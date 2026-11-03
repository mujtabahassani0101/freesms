using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

// The recovered controllers still prepare the original tables and parameter values.
// Display, pagination and printing now run in the same .NET 10 Windows process.
namespace FreeSms.Reporting
{
    public class ReportClass
    {
        public virtual string ResourceName { get; set; }
        internal DataSet Data;
        internal bool SingleTable;
        public SubreportCollection Subreports { get; } = new SubreportCollection();
        public ParameterCollection ParameterFields { get; } = new ParameterCollection();
        public void SetDataSource(DataTable table)
        {
            Data = new DataSet();
            Data.Tables.Add(table.Copy());
            SingleTable = true;
        }
        public void SetDataSource(DataSet data) { Data = data.Copy(); SingleTable = false; }
    }

    public sealed class SubreportCollection
    {
        internal readonly Dictionary<string, ReportClass> Items = new Dictionary<string, ReportClass>();
        public ReportClass this[string name]
        {
            get
            {
                if (!Items.TryGetValue(name, out var report)) Items.Add(name, report = new ReportClass());
                return report;
            }
        }
    }

    public sealed class ParameterCollection
    {
        internal readonly Dictionary<string, Parameter> Items = new Dictionary<string, Parameter>();
        public Parameter this[int index] => Get("index:" + index.ToString(CultureInfo.InvariantCulture));
        public Parameter this[string name] => Get("name:" + name);
        private Parameter Get(string key)
        {
            if (!Items.TryGetValue(key, out var parameter)) Items.Add(key, parameter = new Parameter());
            return parameter;
        }
    }

    public sealed class Parameter
    {
        public ParameterValues CurrentValues { get; } = new ParameterValues();
    }

    public sealed class ParameterValues
    {
        internal readonly List<object> Items = new List<object>();
        public void AddValue(object value) { Items.Add(value); }
    }

    public sealed class CrystalReportViewer : FreeSms.NativeControls.PortableReportViewer
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ActiveViewIndex { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DisplayGroupTree { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectionFormula { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ViewTimeSelectionFormula { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowExportButton { get => ShowExport; set => ShowExport = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowPrintButton { get => ShowPrint; set => ShowPrint = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowRefreshButton { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowGroupTreeButton { get; set; }
        private ReportClass source;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ReportClass ReportSource
        {
            get => source;
            set
            {
                source = value;
                if (value != null) BeginInvoke((Action)(() =>
                {
                    try
                    {
                        string name = value.ResourceName;
                        if (Path.GetFileName(name) != name) throw new InvalidDataException("Invalid report template name.");
                        var model = FreeSms.Reports.ReportModel.Load(Path.Combine(AppContext.BaseDirectory, "portable-layouts", name + ".xml"));
                        Open(model, ToInput(value, model.Xml));
                    }
                    catch (Exception error) { MessageBox.Show(FindForm(), error.Message, "گزارش باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }));
            }
        }
        private static FreeSms.Reports.ReportInput ToInput(ReportClass report, XElement template)
        {
            var input = new FreeSms.Reports.ReportInput { Data = report.Data };
            var names = template.Element("parameters")?.Elements("parameter").Select(x => (string)x.Attribute("name")).ToArray() ?? Array.Empty<string>();
            foreach (var parameter in report.ParameterFields.Items)
            {
                string key = parameter.Key;
                if (key.StartsWith("index:", StringComparison.Ordinal))
                {
                    int index = int.Parse(key.Substring(6), CultureInfo.InvariantCulture);
                    if (index < 0 || index >= names.Length) throw new InvalidDataException("Unknown report parameter index: " + index);
                    key = names[index];
                }
                else key = key.Substring(5);
                input.Parameters[key] = parameter.Value.CurrentValues.Items.LastOrDefault();
            }
            foreach (var child in report.Subreports.Items)
            {
                var node = template.Descendants("object").FirstOrDefault(x => (string)x.Attribute("subreport") == child.Key)?.Element("report");
                if (node == null) throw new InvalidDataException("Unknown subreport: " + child.Key);
                input.Subreports[child.Key] = ToInput(child.Value, node);
            }
            if(template.Attribute("recovered-alias")!=null)
            {
                // The legacy absent templates used parameter5 for a different
                // display option. The intact annual card uses it for rankings.
                // Only enable that original band when its configured SQL data exists.
                input.Parameters["showBartar"]=input.Subreports.ContainsKey("Sub2") && input.Subreports.ContainsKey("Sub3") ? "1" : "0";
            }
            return input;
        }
    }
}
