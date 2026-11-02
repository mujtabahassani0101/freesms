using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;
using R = CrystalDecisions.ReportAppServer.ReportDefModel;

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
            if (xml.Descendants("object").Any(o => o.Element("Kind")?.Value == "CrossTabObject"))
                ReferenceExporter.Export(report, Path.Combine(directory, "..", "reference"));
        }
    }
    private static XElement ExportReport(ReportDocument report, bool isSubreport = false)
    {
        var xml = new XElement("report");
        var print = new XElement("print");
        if (!isSubreport) Simple(print, report.PrintOptions, "PaperOrientation", "PaperSize", "PaperSource");
        if (!isSubreport) Simple(print, report.PrintOptions.PageMargins, "leftMargin", "rightMargin", "topMargin", "bottomMargin");
        xml.Add(print);
        xml.Add(new XElement("record-selection", report.RecordSelectionFormula));
        var database = new XElement("database");
        foreach (Table table in report.Database.Tables)
        {
            var node = new XElement("table", new XAttribute("name", table.Name));
            foreach (DatabaseFieldDefinition field in table.Fields)
                node.Add(new XElement("field", new XAttribute("name", field.Name), new XAttribute("type", field.ValueType)));
            database.Add(node);
        }
        xml.Add(database);
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
        var running = new XElement("running-totals");
        foreach (RunningTotalFieldDefinition field in report.DataDefinition.RunningTotalFields)
        {
            var total = new XElement("total", new XAttribute("name", field.Name));
            Simple(total, field, "Operation", "OperationParameter", "EvaluationCondition", "EvaluationConditionType", "ResetCondition", "ResetConditionType");
            if (field.SummarizedField != null) total.SetAttributeValue("field", field.SummarizedField.FormulaName);
            if (field.Group != null) total.SetAttributeValue("group", field.Group.ConditionField.FormulaName);
            running.Add(total);
        }
        xml.Add(running);
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
                    using (var child = sub.OpenSubreport(sub.SubreportName)) obj.Add(ExportReport(child, true));
                }
                node.Add(obj);
            }
            sections.Add(node);
        }
        xml.Add(sections);
        // Read the loaded document for a one-time conversion of the user's own
        // templates. Do not change engine licensing, flags or vendor binaries.
        var documentProperty = typeof(ReportDocument).GetProperty("InternalReportClientDocument", BindingFlags.Instance | BindingFlags.NonPublic);
        var ras = (CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument)documentProperty.GetValue(report, null);
        if (!isSubreport)
        {
            var functions = ras.CustomFunctionController.GetCustomFunctions();
            var custom = new XElement("custom-functions");
            for (int i = 0; i < functions.Count; i++)
                custom.Add(new XElement("function", new XAttribute("name", functions[i].Name), functions[i].Text));
            xml.Add(custom);
        }
        var totals = ras.DataDefController.DataDefinition.RunningTotalFields;
        for (int i = 0; i < totals.Count; i++)
        {
            var field = (CrystalDecisions.ReportAppServer.DataDefModel.ISCRRunningTotalField)totals[i];
            var node = running.Elements("total").FirstOrDefault(t => (string)t.Attribute("name") == field.Name);
            if (node == null) continue;
            if (field.ResetCondition is CrystalDecisions.ReportAppServer.DataDefModel.ISCRGroup group)
                node.SetAttributeValue("group", group.ConditionField.FormulaForm);
            else if (field.ResetCondition is CrystalDecisions.ReportAppServer.DataDefModel.ISCRField reset)
                node.SetAttributeValue("reset-field", reset.FormulaForm);
            else if (field.ResetCondition is string resetText && !string.IsNullOrWhiteSpace(resetText))
                node.Add(new XElement("reset-expression", resetText));
        }
        var summaries = new XElement("summaries");
        var summaryFields = ras.DataDefController.DataDefinition.SummaryFields;
        for (int i = 0; i < summaryFields.Count; i++)
        {
            var field = (CrystalDecisions.ReportAppServer.DataDefModel.ISCRSummaryField)summaryFields[i];
            var node = new XElement("summary", new XAttribute("name", field.Name), new XAttribute("formula", field.FormulaForm), new XAttribute("field", field.SummarizedField.FormulaForm), new XAttribute("operation", field.Operation));
            if (field.Group != null) node.SetAttributeValue("group", field.Group.ConditionField.FormulaForm);
            if (field.SecondGroup != null) node.SetAttributeValue("second-group", field.SecondGroup.ConditionField.FormulaForm);
            summaries.Add(node);
        }
        xml.Add(summaries);
        var areas = ras.ReportDefController.ReportDefinition.Areas;
        for (int i = 0; i < areas.Count; i++)
        {
            var area = areas[i];
            for (int j = 0; j < area.Sections.Count; j++)
            {
                var section = area.Sections[j];
                var target = sections.Elements("section").FirstOrDefault(x => (string)x.Attribute("name") == section.Name);
                if (target == null) continue;
                foreach (R.CrSectionAreaFormatConditionFormulaTypeEnum condition in Enum.GetValues(typeof(R.CrSectionAreaFormatConditionFormulaTypeEnum)))
                {
                    string text = section.Format.ConditionFormulas[condition]?.Text;
                    if (!string.IsNullOrWhiteSpace(text)) target.Element("format").Add(new XElement("condition", new XAttribute("name", condition.ToString().Replace("crSectionAreaConditionFormulaType", "")), text));
                }
                for (int k = 0; k < section.ReportObjects.Count; k++)
                {
                    var item = section.ReportObjects[k];
                    var obj = target.Elements("object").FirstOrDefault(x => x.Element("Name")?.Value == item.Name);
                    if (obj == null) continue;
                    foreach (R.CrObjectFormatConditionFormulaTypeEnum condition in Enum.GetValues(typeof(R.CrObjectFormatConditionFormulaTypeEnum)))
                    {
                        string text = item.Format.ConditionFormulas[condition]?.Text;
                        if (!string.IsNullOrWhiteSpace(text)) obj.Element("format").Add(new XElement("condition", new XAttribute("name", condition.ToString().Replace("crObjectFormatConditionFormulaType", "")), text));
                    }
                    if (obj.Element("Kind")?.Value == "PictureObject")
                    {
                        obj.SetAttributeValue("ras-class", item.ClassName);
                        if (item is R.ISCRPictureObject picture)
                        {
                            obj.SetAttributeValue("picture-type", picture.PictureType);
                            obj.SetAttributeValue("original-width", picture.OriginalWidth);
                            obj.SetAttributeValue("original-height", picture.OriginalHeight);
                            obj.SetAttributeValue("x-scaling", picture.XScaling);
                            obj.SetAttributeValue("y-scaling", picture.YScaling);
                            if (picture.PictureData != null)
                                obj.Add(new XElement("picture", Convert.ToBase64String(picture.PictureData.ByteArray)));
                        }
                    }
                    if (item is R.ISCRSubreportObject subreport)
                    {
                        var links = new XElement("links");
                        for (int link = 0; link < subreport.SubreportLinks.Count; link++)
                        {
                            var rule = subreport.SubreportLinks[link];
                            links.Add(new XElement("link", new XAttribute("parent", rule.MainReportFieldName), new XAttribute("child", rule.SubreportFieldName)));
                        }
                        obj.Add(links);
                    }
                    if (item is R.ChartObject chart)
                    {
                        var definition = chart.ChartDefinition;
                        var node = new XElement("chart", new XAttribute("type", definition.ChartType));
                        for (int c = 0; c < definition.ConditionFields.Count; c++)
                            node.Add(new XElement("category", definition.ConditionFields[c].FormulaForm));
                        for (int c = 0; c < definition.DataFields.Count; c++)
                            node.Add(new XElement("series", definition.DataFields[c].FormulaForm));
                        obj.Add(node);
                    }
                }
            }
        }
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
