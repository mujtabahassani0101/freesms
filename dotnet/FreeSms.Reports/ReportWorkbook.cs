using System.Data;
using System.Globalization;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace FreeSms.Reports;

// A data workbook uses typed cells and inline strings. It does not require Excel,
// COM automation or a legacy report engine, and never converts text to formulas.
public static class ReportWorkbook
{
    private const string Main = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
    private const string Relations = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
    private const string PackageRelations = "http://schemas.openxmlformats.org/package/2006/relationships";
    private const string ContentTypes = "http://schemas.openxmlformats.org/package/2006/content-types";
    private sealed record Sheet(string Name, DataColumn[] Columns, DataRow[] Rows);
    public static void Save(string path, ReportModel model, ReportInput input)
    {
        var sheets = new List<Sheet>();
        var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        void Add(ReportModel report, IReadOnlyList<ReportInput> contexts, string label)
        {
            var source = contexts.FirstOrDefault();
            var table = source?.Data?.Tables.Cast<DataTable>().FirstOrDefault();
            if (table != null)
            {
                string name = Regex.Replace(label, @"[\[\]:*?/\\]", "_").Trim('\'');
                if (name.Length == 0) name = "Report";
                name = name[..Math.Min(31, name.Length)];
                string unique = name;
                for (int suffix = 2; !names.Add(unique); suffix++) unique = name[..Math.Min(26, name.Length)] + "-" + suffix;
                sheets.Add(new Sheet(unique, table.Columns.Cast<DataColumn>().Where(c => c.DataType != typeof(byte[])).ToArray(), contexts.SelectMany(report.Rows).Distinct().ToArray()));
            }
            foreach (var child in source?.Subreports ?? new Dictionary<string, ReportInput>())
            {
                var node = report.Xml.Descendants("object").First(o => (string?)o.Attribute("subreport") == child.Key).Element("report")!;
                var childModel = new ReportModel(node);
                var bound = new List<ReportInput>();
                var seen = new HashSet<string>(StringComparer.Ordinal);
                foreach (var parent in contexts)
                {
                    var records = report.Rows(parent);
                    foreach (var record in records)
                    {
                        var item = report.BindSubreport(parent, parent.Subreports[child.Key], childModel, record, records);
                        string key = System.Text.Json.JsonSerializer.Serialize(item.Parameters.OrderBy(p => p.Key));
                        if (seen.Add(key)) bound.Add(item);
                    }
                }
                Add(childModel, bound, child.Key);
            }
        }
        Add(model, new[] { input }, model.Name.Split('.').Last());
        if (sheets.Count == 0) throw new InvalidDataException("The report has no data to export.");
        using var archive = ZipFile.Open(path, ZipArchiveMode.Create);
        void Xml(string name, XDocument xml)
        {
            using var stream = archive.CreateEntry(name, CompressionLevel.Optimal).Open();
            using var writer = XmlWriter.Create(stream, new XmlWriterSettings { Encoding = new UTF8Encoding(false), CheckCharacters = true });
            xml.Save(writer);
        }
        XNamespace ns = Main, rel = Relations, package = PackageRelations, types = ContentTypes;
        var content = new XElement(types + "Types",
            new XElement(types + "Default", new XAttribute("Extension", "rels"), new XAttribute("ContentType", "application/vnd.openxmlformats-package.relationships+xml")),
            new XElement(types + "Default", new XAttribute("Extension", "xml"), new XAttribute("ContentType", "application/xml")),
            new XElement(types + "Override", new XAttribute("PartName", "/xl/workbook.xml"), new XAttribute("ContentType", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml")));
        var workbook = new XElement(ns + "workbook", new XAttribute(XNamespace.Xmlns + "r", rel.NamespaceName), new XElement(ns + "sheets"));
        var relationships = new XElement(package + "Relationships");
        for (int index = 0; index < sheets.Count; index++)
        {
            var sheet = sheets[index];
            int id = index + 1;
            content.Add(new XElement(types + "Override", new XAttribute("PartName", $"/xl/worksheets/sheet{id}.xml"), new XAttribute("ContentType", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml")));
            workbook.Element(ns + "sheets")!.Add(new XElement(ns + "sheet", new XAttribute("name", sheet.Name), new XAttribute("sheetId", id), new XAttribute(rel + "id", "rId" + id)));
            relationships.Add(new XElement(package + "Relationship", new XAttribute("Id", "rId" + id), new XAttribute("Type", Relations + "/worksheet"), new XAttribute("Target", $"worksheets/sheet{id}.xml")));
            using var stream = archive.CreateEntry($"xl/worksheets/sheet{id}.xml", CompressionLevel.Optimal).Open();
            using var writer = XmlWriter.Create(stream, new XmlWriterSettings { Encoding = new UTF8Encoding(false) });
            writer.WriteStartElement("worksheet", Main);
            writer.WriteStartElement("sheetViews"); writer.WriteStartElement("sheetView"); writer.WriteAttributeString("workbookViewId", "0"); writer.WriteAttributeString("rightToLeft", "1");
            writer.WriteStartElement("pane"); writer.WriteAttributeString("ySplit", "1"); writer.WriteAttributeString("topLeftCell", "A2"); writer.WriteAttributeString("state", "frozen"); writer.WriteEndElement(); writer.WriteEndElement(); writer.WriteEndElement();
            writer.WriteStartElement("cols");
            for (int column = 0; column < sheet.Columns.Length; column++)
            {
                writer.WriteStartElement("col"); writer.WriteAttributeString("min", (column + 1).ToString(CultureInfo.InvariantCulture)); writer.WriteAttributeString("max", (column + 1).ToString(CultureInfo.InvariantCulture)); writer.WriteAttributeString("width", "20"); writer.WriteAttributeString("customWidth", "1"); writer.WriteEndElement();
            }
            writer.WriteEndElement(); writer.WriteStartElement("sheetData");
            void Row(int number, IEnumerable<object?> values)
            {
                writer.WriteStartElement("row"); writer.WriteAttributeString("r", number.ToString(CultureInfo.InvariantCulture));
                int column = 0;
                foreach (var value in values)
                {
                    writer.WriteStartElement("c"); writer.WriteAttributeString("r", ColumnName(column++) + number.ToString(CultureInfo.InvariantCulture));
                    if (value is bool flag) { writer.WriteAttributeString("t", "b"); writer.WriteElementString("v", flag ? "1" : "0"); }
                    else if (value is byte or sbyte or short or ushort or int or uint or long or ulong or decimal or float or double)
                    { writer.WriteAttributeString("t", "n"); writer.WriteElementString("v", Convert.ToString(value, CultureInfo.InvariantCulture)); }
                    else
                    {
                        string text = value == null || value == DBNull.Value ? "" : value is byte[] bytes ? Convert.ToBase64String(bytes) : value is DateTime date ? date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : Formula.Text(value);
                        writer.WriteAttributeString("t", "inlineStr"); writer.WriteStartElement("is"); writer.WriteStartElement("t"); writer.WriteAttributeString("xml", "space", XNamespace.Xml.NamespaceName, "preserve"); writer.WriteString(text); writer.WriteEndElement(); writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            Row(1, sheet.Columns.Select(c => (object?)c.Caption));
            for (int row = 0; row < sheet.Rows.Length; row++) Row(row + 2, sheet.Columns.Select(c => sheet.Rows[row][c]));
            writer.WriteEndElement(); writer.WriteEndElement();
        }
        Xml("[Content_Types].xml", new XDocument(content));
        Xml("_rels/.rels", new XDocument(new XElement(package + "Relationships", new XElement(package + "Relationship", new XAttribute("Id", "rId1"), new XAttribute("Type", Relations + "/officeDocument"), new XAttribute("Target", "xl/workbook.xml")))));
        Xml("xl/workbook.xml", new XDocument(workbook));
        Xml("xl/_rels/workbook.xml.rels", new XDocument(relationships));
    }
    private static string ColumnName(int index)
    {
        string result = "";
        do { result = (char)('A' + index % 26) + result; index = index / 26 - 1; } while (index >= 0);
        return result;
    }
}
