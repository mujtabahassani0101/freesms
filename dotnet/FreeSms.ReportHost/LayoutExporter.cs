using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;

// One-time migration tool. The generated XML is consumed by the .NET 10 renderer;
// the application distributed to Windows users does not run this exporter.
internal static class LayoutExporter
{
    internal static void ExportAll(string directory)
    {
        Directory.CreateDirectory(directory);
        foreach (var type in typeof(LayoutExporter).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(ReportClass))).OrderBy(t => t.FullName))
        using (var report = (ReportClass)Activator.CreateInstance(type))
        {
            var xml = ExportReport(report);
            xml.SetAttributeValue("type", type.FullName);
            new XDocument(xml).Save(Path.Combine(directory, report.ResourceName + ".xml"));
        }
    }
    private static XElement ExportReport(ReportDocument report)
    {
        var xml = new XElement("report");
        var print = new XElement("print");
        Simple(print, report.PrintOptions, "PaperOrientation", "PaperSize", "PaperSource");
        Simple(print, report.PrintOptions.PageMargins, "leftMargin", "rightMargin", "topMargin", "bottomMargin");
        xml.Add(print);
        var formulas = new XElement("formulas");
        foreach (FormulaFieldDefinition formula in report.DataDefinition.FormulaFields)
            formulas.Add(new XElement("formula", new XAttribute("name", formula.Name), formula.Text));
        xml.Add(formulas);
        var parameters = new XElement("parameters");
        foreach (ParameterFieldDefinition parameter in report.DataDefinition.ParameterFields)
            parameters.Add(new XElement("parameter", new XAttribute("name", parameter.Name), new XAttribute("type", parameter.ValueType)));
        xml.Add(parameters);
        var groups = new XElement("groups");
        foreach (Group group in report.DataDefinition.Groups)
            groups.Add(new XElement("group", new XAttribute("field", group.ConditionField.FormulaName)));
        xml.Add(groups);
        var sorts = new XElement("sorts");
        foreach (SortField sort in report.DataDefinition.SortFields)
            sorts.Add(new XElement("sort", new XAttribute("field", sort.Field.FormulaName), new XAttribute("direction", sort.SortDirection)));
        xml.Add(sorts);
        var sections = new XElement("sections");
        foreach (Section section in report.ReportDefinition.Sections)
        {
            var node = new XElement("section", new XAttribute("name", section.Name), new XAttribute("kind", section.Kind), new XAttribute("height", section.Height));
            var format = new XElement("format");
            Simple(format, section.SectionFormat, "EnableSuppress", "EnableNewPageAfter", "EnableNewPageBefore", "EnableKeepTogether", "EnableUnderlaySection", "EnablePrintAtBottomOfPage", "BackgroundColor");
            node.Add(format);
            foreach (ReportObject item in section.ReportObjects)
            {
                var obj = new XElement("object");
                Simple(obj, item, "Name", "Kind", "Left", "Top", "Width", "Height", "Text", "Color", "LineColor", "LineThickness", "LineStyle", "Font");
                var objectFormat = new XElement("format");
                Simple(objectFormat, item.ObjectFormat, "EnableSuppress", "EnableCanGrow", "HorizontalAlignment", "EnableKeepTogether", "EnableCloseAtPageBreak", "EnableSuppressIfDuplicated");
                obj.Add(objectFormat);
                var border = new XElement("border");
                Simple(border, item.Border, "BackgroundColor", "BorderColor", "LeftLineStyle", "RightLineStyle", "TopLineStyle", "BottomLineStyle");
                obj.Add(border);
                var field = item as FieldObject;
                if (field != null)
                {
                    obj.Add(new XElement("source", new XAttribute("name", field.DataSource.Name), new XAttribute("formula", field.DataSource.FormulaName), new XAttribute("kind", field.DataSource.Kind)));
                    var number = new XElement("number");
                    Simple(number, field.FieldFormat, "NumericFormat", "DateFormat", "BooleanFormat", "CurrencyFormat");
                    obj.Add(number);
                }
                var sub = item as SubreportObject;
                if (sub != null)
                {
                    obj.SetAttributeValue("subreport", sub.SubreportName);
                    using (var child = sub.OpenSubreport(sub.SubreportName)) obj.Add(ExportReport(child));
                }
                node.Add(obj);
            }
            sections.Add(node);
        }
        xml.Add(sections);
        return xml;
    }
    private static void Simple(XElement node, object value, params string[] names)
    {
        foreach (var name in names)
        {
            var type = value.GetType();
            object property = null;
            try { property = type.GetProperty(name)?.GetValue(value, null) ?? type.GetField(name)?.GetValue(value); }
            catch (TargetInvocationException) { continue; }
            if (property == null) continue;
            if (property is Font font)
                node.Add(new XElement(name, new XAttribute("family", font.Name), new XAttribute("size", font.SizeInPoints), new XAttribute("style", (int)font.Style)));
            else if (property is Color color) node.Add(new XElement(name, color.ToArgb()));
            else if (property is string || property.GetType().IsPrimitive || property.GetType().IsEnum || property is decimal)
                node.Add(new XElement(name, property));
        }
    }
}
