// Analysis-only push-data reference export. Does not connect to any database.
using System;
using System.Data;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public class ReportReference
{
    static Type FieldType(string kind) {
        if (kind == "StringField" || kind == "MemoField") return typeof(string);
        if (kind == "BlobField") return typeof(byte[]);
        if (kind == "BooleanField") return typeof(bool);
        if (kind.IndexOf("Date") >= 0 || kind == "TimeField") return typeof(DateTime);
        return typeof(double);
    }
    static object Sample(string field, Type type, int index) {
        if (type == typeof(byte[])) return DBNull.Value;
        if (type == typeof(bool)) return true;
        if (type == typeof(DateTime)) return new DateTime(2026, 11, 2);
        string key = field.ToLower();
        if (type != typeof(string)) {
            if (key == "xpaye" || key == "xclass" || key == "xreshteh") return 1;
            if (key == "code") return 5991001 + index / 12;
            if (key == "xstudent") return index / 12 + 1;
            if (key == "mark" || key == "markdoreh" || key == "markdoreh100") return 70;
            if (key == "avgclass") return 50;
            if (key == "m1") return 30;
            if (key == "m2") return 40;
            if (key == "sort") return index % 12 + 1;
            if (key == "numexam") return 3;
            if (key == "sumMark") return 840;
            return index + 1;
        }
        if (key == "fname") return "احمد " + (index / 12 + 1).ToString();
        if (key == "lname") return "محمود";
        if (key == "pname") return "عبدالله";
        if (key == "book") return "مضمون " + (index % 12 + 1).ToString();
        if (key == "heder1") return "ریاست معارف شهر کابل";
        if (key == "exam") return "سالانه";
        if (key == "sch") return "مکتب آزمایشی";
        if (key == "class") return "هفتم الف";
        if (key == "paye") return "هفتم";
        if (key == "xyear") return "1405";
        if (key.IndexOf("date") >= 0) return "1405/08/11";
        return "";
    }
    static void Bind(ReportDocument document) {
 Console.WriteLine("Binding "+document.Name);
            DataSet set = new DataSet();
            foreach (Table table in document.Database.Tables) {
                DataTable data = new DataTable(table.Name);
                foreach (DatabaseFieldDefinition f in table.Fields) data.Columns.Add(f.Name, FieldType(f.ValueType.ToString()));
                for (int i = 0; i < 24; i++) {
                    DataRow row = data.NewRow();
                    foreach (DataColumn column in data.Columns) row[column] = Sample(column.ColumnName, column.DataType, i);
                    data.Rows.Add(row);
                }
                set.Tables.Add(data);
            }
            Console.WriteLine("Setting datasource");
            document.SetDataSource(set.Tables[0]);
            Console.WriteLine("Setting parameters");
            foreach (ParameterFieldDefinition parameter in document.DataDefinition.ParameterFields) {
                if (document.IsSubreport || parameter.IsLinked() || parameter.Name.StartsWith("Pm-")) continue;
                document.SetParameterValue(parameter.Name, Sample(parameter.Name, FieldType(parameter.ValueType.ToString()), 0));
            }
    }
    public static int Main(string[] args) {
        if (args.Length != 2) return 2;
        using (ReportDocument report = new ReportDocument()) {
            Console.WriteLine("Loading report");
            report.Load(args[0]);
            Console.WriteLine("Report loaded");
            foreach (ReportDocument child in report.Subreports) Bind(child);
            Bind(report);
            Console.WriteLine("Exporting");
            report.ExportToDisk(ExportFormatType.PortableDocFormat, args[1]);
            Console.WriteLine("Exported reference using synthetic in-memory data only.");
        }
        return 0;
    }
}
