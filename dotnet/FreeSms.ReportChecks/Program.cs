using System.Data;
using System.Xml.Linq;
using FreeSms.Reports;

int count = 0;
void Check(bool result, string name) { if (!result) throw new Exception(name); count++; Console.WriteLine("PASS " + name); }
var root = Path.GetFullPath(args.FirstOrDefault() ?? ".");
int formulas = 0, reportCount = 0;
foreach (var path in Directory.GetFiles(Path.Combine(root, "dotnet", "FreeSms.Original.Windows", "portable-layouts"), "*.xml"))
{
    reportCount++;
    var xml = XDocument.Load(path);
    var fixture = ReportFixtures.Create(xml.Root!);
    void EvaluateReport(XElement template, ReportInput input)
    {
        var model = new ReportModel(template);
        var rows = model.Rows(input);
        foreach (var row in rows)
        {
            var context = model.Context(input, row, rows);
            foreach (var formula in model.Formulas.Values) formula.Evaluate(context);
            foreach (var condition in template.Descendants("condition").Where(c => c.Ancestors("report").First() == template)) model.Evaluate(condition.Value, context);
            foreach (var field in template.Descendants("source").Where(c => c.Ancestors("report").First() == template)) model.Evaluate((string)field.Attribute("formula")!, context);
            foreach (var series in template.Descendants("series").Where(c => c.Ancestors("report").First() == template)) model.Evaluate(series.Value, context);
        }
        foreach (var child in input.Subreports) EvaluateReport(template.Descendants("object").First(o => (string?)o.Attribute("subreport") == child.Key).Element("report")!, child.Value);
    }
    try { EvaluateReport(xml.Root!, fixture); }
    catch (Exception error) { throw new Exception(Path.GetFileName(path) + ": " + error.Message, error); }
    foreach (var report in xml.Descendants("report"))
    {
        var model = new ReportModel(report);
        foreach (var function in report.Element("custom-functions")?.Elements("function") ?? [])
        {
            var ctx = model.Context(new ReportInput(), null, []);
            var expected = function.Value.Contains("Case -1") ? "خیلی خوب" : "الف";
            Check(Equals(model.Evaluate("tosif(" + (function.Value.Contains("Case -1") ? "-1" : "1") + ")", ctx), expected), "original descriptive grade " + Path.GetFileName(path));
        }
    }
    foreach (var formula in xml.Descendants("formula")) { Formula.Parse(formula.Value); formulas++; }
    foreach (var condition in xml.Descendants("condition")) Formula.Parse(condition.Value);
    foreach (var source in xml.Descendants("source")) Formula.Parse((string?)source.Attribute("formula") ?? "");
}
Check(reportCount == 98, "evaluate every original report with disconnected sample data: " + reportCount);
Check(formulas >= 3000, "parse every original report expression: " + formulas);
var data = new DataTable(); data.Columns.Add("mark", typeof(decimal)); data.Columns.Add("group", typeof(int)); data.Columns.Add("comment", typeof(string));
data.Rows.Add(19.995m, 1, "نام"); data.Rows.Add(15m, 1, DBNull.Value); data.Rows.Add(-1m, 2, "");
var contexts = data.Rows.Cast<DataRow>().Select(row => new FormulaContext { Row = row, Rows = data.Rows.Cast<DataRow>().ToArray() }).ToArray();
object? Eval(string formula, int row = 0) => Formula.Parse(formula).Evaluate(contexts[row]);
Check(Equals(Eval("if {d.mark}<20 and {d.mark}>=19.99 then '19.99' else 'other'"), "19.99"), "original 19.99 boundary");
Check(Equals(Eval("if {d.mark}<20 and {d.mark}>=19.99 then '19.99' else 'other'", 1), "other"), "conditional fallback");
Check(Equals(Eval("if true then 'ok' else 1/0"), "ok"), "conditional evaluates selected branch only");
Check(Equals(Eval("ToText(-1)"), "1.00-"), "Crystal default negative number format");
Check(Equals(Eval("replace(replace(totext({d.mark}), '.00', ''), '.', '/')", 1), "15"), "original mark text conversion");
Check(Equals(Eval("Average({d.mark}, {d.group})"), 17.4975m), "group average excludes other groups");
Check(Equals(Eval("sum({d.mark})"), 33.995m), "report total");
Check(Equals(Eval("isnull({d.comment})", 1), true), "database null detection");
Check(Equals(Eval("'الف' + ' ' + {d.comment}"), "الف نام"), "Persian text concatenation");
Check(Equals(Eval("mid('1405/08/11', 6, 2)"), "08"), "one-based date substring");
Check(Equals(Eval("if false then 'الف' else if {d.mark}>0 then 'ب' else 'پ'"), "ب"), "nested conditions");
string workbook = Path.Combine(Path.GetTempPath(), "FreeSms-report-" + Guid.NewGuid().ToString("N") + ".xlsx");
try
{
    var exportData = new DataSet(); exportData.Tables.Add(data.Copy());
    var exportInput = new ReportInput { Data = exportData };
    ReportWorkbook.Save(workbook, new ReportModel(XElement.Parse("<report type='نمرات'/>")), exportInput);
    using var archive = System.IO.Compression.ZipFile.OpenRead(workbook);
    XNamespace ns = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
    using var stream = archive.GetEntry("xl/worksheets/sheet1.xml")!.Open();
    var sheet = XDocument.Load(stream);
    Check(sheet.Descendants(ns + "row").Count() == 4 && sheet.Descendants(ns + "v").Any(v => v.Value == "19.995"), "Excel export preserves every record and decimal value");
    Check(sheet.Descendants(ns + "t").Any(t => t.Value == "نام") && !sheet.Descendants(ns + "f").Any(), "Excel export preserves Persian text without generated formulas");
}
finally { File.Delete(workbook); }
Console.WriteLine("SUCCESS " + count);
