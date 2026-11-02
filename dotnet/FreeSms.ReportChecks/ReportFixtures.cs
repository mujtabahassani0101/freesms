using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using FreeSms.Reports;

internal static class ReportFixtures
{
    internal static ReportInput Create(XElement template, int count = 3)
    {
        var table = new DataTable("fixture");
        var expressions = template.Descendants().Where(x => x.Name == "formula" || x.Name == "condition" || x.Name == "category" || x.Name == "series").Select(x => x.Value)
            .Concat(template.Descendants("source").Select(x => (string?)x.Attribute("formula") ?? ""))
            .Concat(template.Descendants("group").Select(x => (string?)x.Attribute("field") ?? ""))
            .Concat(template.Descendants("sort").Select(x => (string?)x.Attribute("field") ?? ""));
        foreach (var field in expressions.SelectMany(s => Regex.Matches(s, @"\{([^@?#}][^}]*)\}").Select(m => m.Groups[1].Value.Split('.').Last())).Distinct(StringComparer.OrdinalIgnoreCase))
            if (!table.Columns.Contains(field)) table.Columns.Add(field, typeof(object));
        for (int index = 0; index < count; index++)
        {
            var row = table.NewRow();
            foreach (DataColumn column in table.Columns) row[column] = 1m;
            table.Rows.Add(row);
        }
        var data = new DataSet(); data.Tables.Add(table);
        var input = new ReportInput { Data = data };
        foreach (var parameter in template.Element("parameters")?.Elements("parameter") ?? [])
            input.Parameters[(string)parameter.Attribute("name")!] = ((string?)parameter.Attribute("type")) == "StringField" ? "1" : 1m;
        foreach (var obj in template.Element("sections")?.Descendants("object").Where(o => o.Parent?.Parent?.Parent == template && o.Attribute("subreport") != null) ?? [])
            input.Subreports[(string)obj.Attribute("subreport")!] = Create(obj.Element("report")!, count);
        return input;
    }
}
