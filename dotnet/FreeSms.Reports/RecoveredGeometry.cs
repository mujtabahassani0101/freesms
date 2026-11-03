using System.Xml.Linq;

namespace FreeSms.Reports;

// Restore omitted RAS properties without rearranging the original report.
internal static class RecoveredGeometry
{
    private static readonly Lazy<XElement> Definitions = new(() =>
    {
        using var stream = typeof(RecoveredGeometry).Assembly.GetManifestResourceStream("FreeSms.Reports.RecoveredGeometry.xml")
            ?? throw new InvalidDataException("Recovered report geometry is missing.");
        return XElement.Load(stream);
    });

    internal static void Apply(XElement report)
    {
        var definition = Definitions.Value.Elements("report").FirstOrDefault(r => (string?)r.Attribute("type") == (string?)report.Attribute("type"));
        if (definition != null) ApplyReport(report, definition);
    }

    private static void ApplyReport(XElement report, XElement definition)
    {
        foreach(var section in report.Element("sections")?.Elements("section") ?? [])
        {
            var flags=definition.Elements("section").Where(s=>(string?)s.Attribute("name")== (string?)section.Attribute("name")).SelectMany(s=>s.Element("area-format")!.Elements()).ToArray();
            if(flags.Length>0)
            {
                section.Element("area-format")?.Remove();
                section.Add(new XElement("area-format",flags.Select(flag=>new XElement(flag))));
            }
        }
        foreach (var obj in report.Element("sections")?.Elements("section").Elements("object") ?? [])
        {
            var recovered = definition.Elements("object").SingleOrDefault(o => (string?)o.Attribute("name") == obj.Element("Name")?.Value);
            if (recovered != null)
                foreach (var property in recovered.Elements())
                {
                    obj.Element(property.Name)?.Remove();
                    obj.Add(new XElement(property));
                }
            if (obj.Element("report") is XElement child)
            {
                var childDefinition = definition.Elements("subreport").SingleOrDefault(s => (string?)s.Attribute("name") == (string?)obj.Attribute("subreport"));
                if (childDefinition != null) ApplyReport(child, childDefinition);
            }
        }
    }
}
