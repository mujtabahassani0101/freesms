using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

// Offline comparison evidence only; never referenced by the .NET 10 application.
internal static class ReferenceExporter
{
    internal static void Export(ReportClass report, string directory)
    {
        Directory.CreateDirectory(directory);
        string name = report.ResourceName;
        var result = new XElement("reference", new XAttribute("report", name));
        try
        {
            var data = new DataSet();
            foreach (Table source in report.Database.Tables)
            {
                var table = data.Tables.Add(source.Name);
                foreach (DatabaseFieldDefinition field in source.Fields)
                {
                    string kind = field.ValueType.ToString();
                    var type = kind == "StringField" ? typeof(string) : kind == "BooleanField" ? typeof(bool) : kind.Contains("Date") || kind.Contains("Time") ? typeof(DateTime) : kind.Contains("Blob") ? typeof(byte[]) : typeof(decimal);
                    table.Columns.Add(field.Name, type);
                }
                for (int index = 0; index < 8; index++)
                {
                    var row = table.NewRow();
                    foreach (DataColumn column in table.Columns)
                    {
                        if (column.DataType == typeof(string))
                        {
                            string field = column.ColumnName.ToLowerInvariant();
                            row[column] = field == "exam" ? "Exam" + (index / 4 + 1) : field == "book" ? "Book" + (index / 2 % 2 + 1) : field == "class" ? "Class" + (index % 2 + 1) : field == "hozeh" ? "Room" + (index % 2 + 1) : field == "paye" ? "Paye1" : "1";
                        }
                        else if (column.DataType == typeof(bool)) row[column] = true;
                        else if (column.DataType == typeof(DateTime)) row[column] = new DateTime(2026, 11, 2);
                        else if (column.DataType == typeof(byte[])) row[column] = DBNull.Value;
                        else
                        {
                            string field = column.ColumnName.ToLowerInvariant();
                            row[column] = field == "mark" ? new decimal[] { 10, 12, 15, 18, 22, 26, 32, 38 }[index] : field == "xstudent" || field == "id" ? index + 1 : field == "xclass" || field == "xhozeh" ? index % 2 + 1 : field == "xbook" ? index / 2 % 2 + 1 : field == "numexam" ? index / 4 + 1 : 1;
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            data.WriteXml(Path.Combine(directory, name + ".input.xml"), XmlWriteMode.WriteSchema);
            report.SetDataSource(data);
            foreach (ParameterFieldDefinition parameter in report.DataDefinition.ParameterFields)
                report.SetParameterValue(parameter.Name, parameter.ValueType == FieldValueType.StringField ? (object)"1" : 1);
            report.ExportToDisk(ExportFormatType.HTML40, Path.Combine(directory, name + ".html"));
            result.SetAttributeValue("status", "exported");
        }
        catch (Exception error) { result.SetAttributeValue("status", "failed"); result.Add(new XElement("error", error.ToString())); }
        new XDocument(result).Save(Path.Combine(directory, name + ".result.xml"));
    }
}
