using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace FreeSms.Reports;

public sealed class ReportInput
{
    public DataSet? Data { get; init; }
    public Dictionary<string, object?> Parameters { get; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, ReportInput> Subreports { get; } = new(StringComparer.OrdinalIgnoreCase);
}

public sealed class ReportModel
{
    public XElement Xml { get; }
    private readonly Dictionary<string, Func<object?[], object?>> functions = new(StringComparer.OrdinalIgnoreCase);
    private readonly System.Collections.Concurrent.ConcurrentDictionary<string, Formula> expressions = new(StringComparer.Ordinal);
    public string Name => (string?)Xml.Attribute("type") ?? "Report";
    public Dictionary<string, Formula> Formulas { get; }
    public string[] Groups { get; }
    public XElement[] Sections { get; }
    public ReportModel(XElement xml)
    {
        FirstTermCardLayouts.Apply(xml);
        Xml = xml;
        Formulas = (xml.Element("formulas")?.Elements("formula") ?? []).ToDictionary(x => (string)x.Attribute("name")!, x => Formula.Parse(x.Value), StringComparer.OrdinalIgnoreCase);
        Groups = (xml.Element("groups")?.Elements("group") ?? []).Select(x => (string)x.Attribute("field")!).ToArray();
        Sections = xml.Element("sections")?.Elements("section").ToArray() ?? [];
        // The recovered exporter omitted BlobFieldObject.DataSource. These known
        // student-photo controls have exactly one declared Student_img blob column.
        // Repair the in-memory model; preserve the recovered XML files unchanged.
        foreach(var image in Sections.SelectMany(section=>section.Elements("object"))
            .Where(obj=>obj.Element("Kind")?.Value=="BlobFieldObject" && obj.Element("Name")?.Value=="Studentimg1" && obj.Element("source")==null))
        {
            var fields=xml.Element("database")?.Elements("table").SelectMany(table=>table.Elements("field")
                .Where(field=>(string?)field.Attribute("name")=="Student_img" && (string?)field.Attribute("type")=="BlobField")
                .Select(field=>(string?)table.Attribute("name"))).ToArray()??[];
            if(fields.Length!=1 || string.IsNullOrEmpty(fields[0]))throw new InvalidDataException("Student photo binding requires one declared Student_img blob field.");
            image.Add(new XElement("source",new XAttribute("name","Student_img"),new XAttribute("formula","{"+fields[0]+".Student_img}"),new XAttribute("kind","DatabaseField")));
        }
        foreach (var scope in xml.Ancestors("report").Reverse().Append(xml))
            foreach (var function in scope.Element("custom-functions")?.Elements("function") ?? [])
                functions[(string)function.Attribute("name")!] = CompileFunction(function.Value);
    }
    // The original templates use a small VB Select Case lookup for descriptive
    // marks. Compile only that declaration shape into immutable lookup data.
    private static Func<object?[], object?> CompileFunction(string source)
    {
        var match = Regex.Match(source, @"\A\s*Function\s+(\w+)\s*\(\s*(\w+)\s+As\s+Number\s*\)\s+As\s+String\s+Dim\s+(\w+)\s+As\s+String\s+\3\s*=\s*""""\s+Select\s+Case\s+\2\s+(.*?)\s+End\s+Select\s+\1\s*=\s*Trim\(\3\)\s+End\s+Function\s*\z", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        if (!match.Success) throw new InvalidDataException("Unsupported custom report function declaration.");
        var cases = new Dictionary<decimal, string>();
        string body = match.Groups[4].Value;
        var entries = Regex.Matches(body, @"\s*Case\s+(-?\d+)\s+" + Regex.Escape(match.Groups[3].Value) + @"\s*=\s*""([^""]*)""\s*", RegexOptions.IgnoreCase);
        if (entries.Count == 0 || string.Concat(entries.Select(x => x.Value)).Trim() != body.Trim()) throw new InvalidDataException("Unsupported custom report lookup body.");
        foreach (Match entry in entries) cases.Add(decimal.Parse(entry.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture), entry.Groups[2].Value.Trim());
        return values => values.Length == 1 ? cases.GetValueOrDefault(Convert.ToDecimal(values[0], System.Globalization.CultureInfo.InvariantCulture), "") : throw new InvalidDataException("Invalid custom report function arguments.");
    }
    public static ReportModel Load(string path)
    {
        using var reader = XmlReader.Create(path, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null });
        return new ReportModel(XDocument.Load(reader).Root ?? throw new InvalidDataException("Empty report layout."));
    }
    public object? Evaluate(string text, FormulaContext context) => expressions.GetOrAdd(text, Formula.Parse).Evaluate(context);
    public bool Flag(XElement? format, string name, FormulaContext context)
    {
        if (name == "EnableSuppress" && format?.Element("area-suppress") is XElement area && Flag(area, name, context)) return true;
        string? condition = format?.Elements("condition").FirstOrDefault(x => (string?)x.Attribute("name") == name)?.Value;
        return condition != null ? Formula.Boolean(Evaluate(condition, context)) : bool.TryParse(format?.Element(name)?.Value, out var value) && value;
    }
    public FormulaContext Context(ReportInput input, DataRow? row, IReadOnlyList<DataRow> rows, int page = 1, int pages = 1)
    {
        FormulaContext? context = null;
        context = new FormulaContext
        {
            Row = row, Rows = rows, Formulas = Formulas, Parameters = input.Parameters, Functions = functions,
            RowFactory = record => Context(input, record, rows, page, pages),
            Special = name =>
            {
                if (name.Equals("white", StringComparison.OrdinalIgnoreCase)) return -1;
                if (name.Equals("pagenumber", StringComparison.OrdinalIgnoreCase)) return page;
                if (name.Equals("pagenofm", StringComparison.OrdinalIgnoreCase)) return page + " / " + pages;
                if (name.Equals("recordnumber", StringComparison.OrdinalIgnoreCase)) return row == null ? 0 : rows.ToList().IndexOf(row) + 1;
                if (name.Equals("onlastrecord", StringComparison.OrdinalIgnoreCase)) return row != null && rows.LastOrDefault() == row;
                if (name.StartsWith('#'))
                {
                    var total = Xml.Element("running-totals")?.Elements("total").FirstOrDefault(t => ((string?)t.Attribute("name"))?.TrimStart('#').Equals(name[1..], StringComparison.OrdinalIgnoreCase) == true);
                    if (total == null) throw new InvalidDataException("Missing report running total: " + name);
                    var records = rows.Take(row == null ? 0 : rows.ToList().IndexOf(row) + 1);
                    var group = (string?)total.Attribute("group");
                    var resetField = (string?)total.Attribute("reset-field");
                    if (group != null || resetField != null)
                    {
                        var fields = group == null ? new[] { resetField! } : Groups.Take(Array.FindIndex(Groups, g => g.Equals(group, StringComparison.OrdinalIgnoreCase)) + 1).DefaultIfEmpty(group).ToArray();
                        var keys = fields.Select(field => Evaluate(field, context!)).ToArray();
                        var prefix = records.ToArray();
                        int start = Array.FindLastIndex(prefix, r => fields.Where((field, i) => !Equals(Evaluate(field, Context(input, r, rows)), keys[i])).Any()) + 1;
                        records = prefix.Skip(start);
                    }
                    var condition = total.Element("EvaluationCondition")?.Value;
                    if (!string.IsNullOrWhiteSpace(condition)) records = records.Where(r => Formula.Boolean(Evaluate(condition, Context(input, r, rows))));
                    var values = records.ToArray();
                    var field = (string?)total.Attribute("field");
                    string operation = total.Element("Operation")?.Value ?? "Count";
                    var entries = field == null ? values.Select(_ => (object?)1).ToArray() : values.Select(r => Evaluate(field, Context(input, r, rows))).Where(v => v != null).ToArray();
                    if (operation.Contains("Count", StringComparison.OrdinalIgnoreCase) || field == null) return entries.Length;
                    var numbers = entries.Select(value => Convert.ToDecimal(value, System.Globalization.CultureInfo.InvariantCulture)).ToArray();
                    return operation.Contains("Average", StringComparison.OrdinalIgnoreCase) ? numbers.Length == 0 ? 0 : numbers.Average() : numbers.Sum();
                }
                throw new InvalidDataException("Unsupported report special value: " + name);
            }
        };
        return context;
    }
    public ReportInput BindSubreport(ReportInput parent, ReportInput source, ReportModel child, DataRow? row, IReadOnlyList<DataRow> rows)
    {
        var result = new ReportInput { Data = source.Data };
        foreach (var parameter in parent.Parameters) result.Parameters[parameter.Key] = parameter.Value;
        foreach (var parameter in source.Parameters) result.Parameters[parameter.Key] = parameter.Value;
        foreach (var nested in source.Subreports) result.Subreports[nested.Key] = nested.Value;
        var context = Context(parent, row, rows);
        foreach (var parameter in child.Xml.Element("parameters")?.Elements("parameter") ?? [])
        {
            string key = (string)parameter.Attribute("name")!;
            if (key.StartsWith("Pm-", StringComparison.Ordinal)) result.Parameters[key] = Evaluate("{" + key[3..] + "}", context);
        }
        return result;
    }
    public DataRow[] Rows(ReportInput input)
    {
        var table = input.Data?.Tables.Cast<DataTable>().FirstOrDefault();
        var rows = table?.Rows.Cast<DataRow>().ToArray() ?? [];
        string selection = Xml.Element("record-selection")?.Value ?? "";
        if (!string.IsNullOrWhiteSpace(selection)) rows = rows.Where(row => Formula.Boolean(Evaluate(selection, Context(input, row, rows)))).ToArray();
        IOrderedEnumerable<DataRow>? sorted = null;
        foreach (var sort in Xml.Element("sorts")?.Elements("sort") ?? [])
        {
            string expression = (string)sort.Attribute("field")!;
            bool descending = ((string?)sort.Attribute("direction"))?.Contains("Descending", StringComparison.OrdinalIgnoreCase) == true;
            object? Key(DataRow row) => Evaluate(expression, Context(input, row, rows));
            sorted = sorted == null ? descending ? rows.OrderByDescending(Key, ValueComparer.Instance) : rows.OrderBy(Key, ValueComparer.Instance) : descending ? sorted.ThenByDescending(Key, ValueComparer.Instance) : sorted.ThenBy(Key, ValueComparer.Instance);
        }
        return sorted?.ToArray() ?? rows;
    }
    public int GroupLevel(XElement section)
    {
        if ((int?)section.Attribute("group-level") is int level) return Math.Clamp(level, 0, Math.Max(0, Groups.Length - 1));
        string name = (string?)section.Attribute("name") ?? "";
        var number = Regex.Match(name, @"(\d+)");
        return number.Success ? Math.Clamp(int.Parse(number.Value) - 1, 0, Math.Max(0, Groups.Length - 1)) : 0;
    }
    public DataRow[] Scope(ReportInput input, DataRow? row, DataRow[] rows, int level)
    {
        if (row == null || Groups.Length == 0) return rows;
        return rows.Where(r => Enumerable.Range(0, Math.Min(Groups.Length, level + 1)).All(i => Equals(Evaluate(Groups[i], Context(input, row, rows)), Evaluate(Groups[i], Context(input, r, rows))))).ToArray();
    }
    private sealed class ValueComparer : IComparer<object?>
    {
        internal static readonly ValueComparer Instance = new();
        public int Compare(object? a, object? b) => a == null ? b == null ? 0 : -1 : b == null ? 1 : a is string || b is string ? string.Compare(Formula.Text(a), Formula.Text(b), StringComparison.Ordinal) : ((IComparable)a).CompareTo(b);
    }
}
