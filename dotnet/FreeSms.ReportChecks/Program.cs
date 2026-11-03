using System.Data;
using System.Xml.Linq;
using FreeSms.Reports;

int count = 0;
void Check(bool result, string name) { if (!result) throw new Exception(name); count++; Console.WriteLine("PASS " + name); }
var root = Path.GetFullPath(args.FirstOrDefault() ?? ".");
int formulas = 0, reportCount = 0, rebuiltCount = 0, pictures = 0, studentPhotos = 0;
foreach (var path in Directory.GetFiles(Path.Combine(root, "dotnet", "FreeSms.Original.Windows", "portable-layouts"), "*.xml"))
{
    var xml = XDocument.Load(path);
    bool rebuilt = xml.Root!.Attribute("recovered-alias") != null;
    if (rebuilt) rebuiltCount++; else reportCount++;
    foreach (var picture in xml.Descendants("object").Where(o => o.Element("Kind")?.Value == "PictureObject"))
    {
        var payload = Convert.FromBase64String(picture.Element("picture")?.Value ?? throw new Exception("Missing original report image: " + path));
        if (!payload.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })) throw new Exception("Invalid recovered PNG.");
        if (!rebuilt) pictures++;
    }
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
        foreach(var photo in model.Sections.SelectMany(section=>section.Elements("object")).Where(obj=>obj.Element("Kind")?.Value=="BlobFieldObject"))
        {
            if(photo.Element("source")?.Attribute("formula")?.Value.EndsWith(".Student_img}")!=true)throw new Exception("Missing student photo binding: "+path);
            studentPhotos++;
        }
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
Check(pictures == 58, "all 58 original report images are present");
Check(rebuiltCount == 2, "evaluate both original annual-card aliases with disconnected sample data");
Check(reportCount == 98, "evaluate every original report with disconnected sample data: " + reportCount);
Check(studentPhotos==21,"all 21 student-photo placeholders bind the declared database image field");
Check(formulas >= 3000, "parse every original report expression: " + formulas);
foreach (string rebuilt in new[] {"CStdKarnameDorehByChart", "CStdKarnameDorehByChart_byBestStd_OneMark"})
{
    var model = ReportModel.Load(Path.Combine(root,"dotnet","FreeSms.Original.Windows","portable-layouts",rebuilt+".rpt.xml"));
    var fixture = ReportFixtures.Create(model.Xml,2);
    var main = fixture.Data!.Tables[0];
    for (int i=0;i<2;i++)
    {
        main.Rows[i]["xStudent"]=i+1; main.Rows[i]["Book"]="ریاضی";
        main.Rows[i]["Mark"]=i==0?70m:30m; main.Rows[i]["avgClass"]=50m;
    }
    var rows = model.Rows(fixture);
    var chartBand = model.Sections.Single(section=>section.Elements("object").Any(obj=>obj.Element("Name")?.Value=="Graph1"));
    var chart = chartBand.Elements("object").Single(obj=>obj.Element("Name")?.Value=="Graph1").Element("chart")!;
    var scope = model.Scope(fixture,rows[0],rows,model.GroupLevel(chartBand));
    var context = model.Context(fixture,scope[0],scope);
    Check(scope.Length==1 && Equals(model.Evaluate(chart.Elements("series").First().Value,context),70m)
        && Equals(model.Evaluate(chart.Elements("series").Last().Value,context),50m),"rebuilt chart isolates student 70 from peer 30 and preserves class mean 50: "+rebuilt);
    var child = new ReportModel(model.Xml.Descendants("object").Single(obj=>(string?)obj.Attribute("subreport")=="Sub1").Element("report")!);
    var originalAlias=XDocument.Load(Path.Combine(root,"dotnet","FreeSms.Original.Windows","portable-layouts","CR_AF_StdKarnameDorehByChart_term3.rpt.xml")).Root!;
    var savedAlias=XDocument.Load(Path.Combine(root,"dotnet","FreeSms.Original.Windows","portable-layouts",rebuilt+".rpt.xml")).Root!;
    savedAlias.Attribute("recovered-alias")!.Remove();
    Check(XNode.DeepEquals(originalAlias,savedAlias),"catalog alias retains every original section, field, position and formula: "+rebuilt);
    var source = fixture.Subreports["Sub1"]; var table = source.Data!.Tables[0]; table.Clear();
    for(int student=1;student<=2;student++) for(int term=1;term<=3;term++)
    {
        var row=table.NewRow(); foreach(DataColumn column in table.Columns) row[column]=1m;
        row["xStudent"]=student; row["Exam"]="دوره "+term; row["NumExam"]=term;
        row["MarkDoreh"]=student==1?new[]{30m,40m,70m}[term-1]:new[]{10m,20m,30m}[term-1];
        row["AvgClass"]=new[]{20m,30m,50m}[term-1]; table.Rows.Add(row);
    }
    var bound=model.BindSubreport(fixture,source,child,rows[0],rows); var childRows=child.Rows(bound);
    Check(childRows.Length==3 && childRows.All(row=>Convert.ToInt32(row["xStudent"])==1)
        && childRows.Select(row=>Convert.ToDecimal(row["MarkDoreh"])).SequenceEqual(new[]{30m,40m,70m}),"rebuilt progress subreport keeps all three terms and excludes the other student: "+rebuilt);
}

foreach(string name in new[]{"CR_AF_StdKarnameDorehByChart_term1","CR_AF_StdKarnameDorehByChart_term1_land","CR_AF_StdKarnameDorehByChart_term3"})
{
    var original=XDocument.Load(Path.Combine(root,"dotnet","FreeSms.Original.Windows","portable-layouts",name+".rpt.xml")).Root!;
    var sectionsBefore=original.Element("sections")!.Elements("section").Select(section=>new {Name=(string?)section.Attribute("name"),Height=(string?)section.Attribute("height"),Objects=section.Elements("object").Select(obj=>string.Join("|",new[]{"Name","Left","Top","Width","Height"}.Select(key=>obj.Element(key)?.Value))).ToArray()}).ToArray();
    var model=new ReportModel(original);
    Check(sectionsBefore.Select(s=>s.Name+":"+s.Height+":"+string.Join(";",s.Objects)).SequenceEqual(model.Sections.Select(section=>(string?)section.Attribute("name")+":"+(string?)section.Attribute("height")+":"+string.Join(";",section.Elements("object").Select(obj=>string.Join("|",new[]{"Name","Left","Top","Width","Height"}.Select(key=>obj.Element(key)?.Value)))))),"original card sections and object geometry remain unchanged: "+name);
    Check(model.Xml.Attribute("native-first-term-layout")==null && model.Sections.Any(section=>model.Flag(section.Element("area-format"),"EnableNewPageAfter",model.Context(ReportFixtures.Create(model.Xml),null,[]))),"original area page breaks recovered without replacing the card: "+name);
}

var ambiguousPhoto=XElement.Parse("<report><database><table name='one'><field name='Student_img' type='BlobField'/></table><table name='two'><field name='Student_img' type='BlobField'/></table></database><sections><section><object><Name>Studentimg1</Name><Kind>BlobFieldObject</Kind></object></section></sections></report>");
bool rejectedAmbiguousPhoto=false;
try{_ = new ReportModel(ambiguousPhoto);}
catch(InvalidDataException){rejectedAmbiguousPhoto=true;}
Check(rejectedAmbiguousPhoto,"ambiguous student photo metadata cannot silently bind another table");

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
Check(Equals(Eval("{d.comment }"), "نام"), "original field references permit surrounding whitespace");
var selection = new ReportModel(XElement.Parse("<report><formulas><formula name='student '>{d.group }</formula></formulas><record-selection>{@student }={?Pm-@student}</record-selection></report>"));
var selectionData = new DataSet(); selectionData.Tables.Add(data.Copy());
var selectionInput = new ReportInput { Data = selectionData }; selectionInput.Parameters["Pm-@student"] = 2m;
Check(selection.Rows(selectionInput).Length == 1, "subreport selection binds the original linked parent parameter");
var resetModel = new ReportModel(XElement.Parse("<report><running-totals><total name='rows' field='{d.mark}' reset-field='{d.group}'><Operation>Count</Operation></total></running-totals></report>"));
var resetTable = data.Copy(); resetTable.Rows.Add(12m, 1, "بازگشت به گروه اول");
var resetRows = resetTable.Rows.Cast<DataRow>().ToArray();
Check(Equals(resetModel.Evaluate("{#rows}", resetModel.Context(new ReportInput(), resetRows[3], resetRows)), 1), "running total resets when a field changes back to an earlier value");
var spaced = new ReportModel(XElement.Parse("<report><formulas><formula name='caption'>1</formula><formula name='caption '>2</formula></formulas></report>"));
Check(Equals(spaced.Evaluate("{@caption}", spaced.Context(new ReportInput(), null, [])), 1m) && Equals(spaced.Evaluate("{@caption }", spaced.Context(new ReportInput(), null, [])), 2m), "distinct original formula names retain trailing spaces");
foreach (var config in XDocument.Load(Path.Combine(root, "analysis", "report-pivots.xml")).Root!.Elements("report"))
{
    string name = (string)config.Attribute("name")!;
    var model = ReportModel.Load(Path.Combine(root, "dotnet", "FreeSms.Original.Windows", "portable-layouts", name + ".xml"));
    var fixture = new DataSet(); fixture.ReadXml(Path.Combine(root, "validation", "original-report-reference", name + ".input.xml"), XmlReadMode.ReadSchema);
    var input = new ReportInput { Data = fixture };
    foreach (var parameter in model.Xml.Element("parameters")!.Elements("parameter")) input.Parameters[(string)parameter.Attribute("name")!] = "1";
    var rows = model.Rows(input);
    var obj = model.Xml.Descendants("object").First(o => o.Element("Kind")?.Value == "CrossTabObject");
    var section = obj.Parent!;
    var scope = ((string?)section.Attribute("kind"))?.StartsWith("Group") == true ? model.Scope(input, rows[0], rows, model.GroupLevel(section)) : rows;
    var pivot = ReportPivot.Build(obj.Element("pivot")!, model, input, scope);
    decimal? Cell(string row, string column) => pivot.Rows.Single(r => r.Label == row).Values[Array.IndexOf(pivot.Columns, column)];
    bool match = name switch
    {
        "CrAvgClassBooks_1.rpt" => Cell("Book1", "Class1") == 10 && Cell("Book1", "Class2") == 12 && Cell("Book2", "کل") == 16.5m,
        "CrAvgClassBooks_2.rpt" => Cell("Book1 / Class1", "Exam2") == 22 && Cell("Book2 / Class2", "کل") == 28 && pivot.Rows.Single(r => r.Total && r.Label.StartsWith("Book1")).Values.SequenceEqual(new decimal?[] { 11, 24, 17.5m }),
        "CrListBooksRengMark1.rpt" => pivot.Rows.Length == 6 && pivot.Columns.Length == 1 && pivot.Rows.Where(r => r.Total).All(r => r.Values[0] == 2),
        "CrListBooksRengMark2.rpt" => pivot.Rows.Length == 8 && pivot.Columns.Length == 7 && Cell("Book1 / Class1 / Exam2", "د / ") == 1 && Cell("Book2 / Class2 / Exam2", "الف / ") == 1,
        "CrListBooksRengMark_class.rpt" => pivot.Rows.Length == 2 && pivot.Rows.All(r => r.Values.Length == 1 && r.Values[0] == 1),
        "crAmarHozeh.rpt" => Cell("Room1", "Paye1") == 4 && Cell("Room2", "جمع حوزه") == 4 && Cell("جمع پایه", "Paye1") == 8,
        _ => false
    };
    Check(match, "match original engine cross-tab reference: " + name);
}
var numeric = XElement.Parse("<object><number><DecimalPlaces>2</DecimalPlaces><ThousandsSeparator>true</ThousandsSeparator><ThousandSymbol>,</ThousandSymbol><DecimalSymbol>/</DecimalSymbol><NegativeFormat>crNegativeTypeTrailingMinus</NegativeFormat><RoundingFormat>crRoundingTypeRoundToHundredth</RoundingFormat></number></object>");
Check(ReportValue.Format(numeric, -1234.995m) == "1,235/00-", "original report separators, precision and negative format");
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
