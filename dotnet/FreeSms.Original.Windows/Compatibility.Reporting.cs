using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

// The recovered controllers still prepare the original tables and parameter values.
// Only the rendering boundary crosses into the native .NET Framework report process.
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

    public sealed class CrystalReportViewer : Panel
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
        public bool ShowExportButton { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowPrintButton { get; set; }
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
                if (value != null) BeginInvoke((Action)Preview);
            }
        }
        private void Preview()
        {
            try { ReportBridge.Show(source, ShowPrintButton, ShowExportButton); }
            catch (Exception error) { MessageBox.Show(FindForm(), error.Message, "گزارش باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { FindForm()?.Close(); }
        }
    }

    internal static class ReportBridge
    {
        internal static void Show(ReportClass report, bool print, bool export)
        {
            var host = Path.Combine(AppContext.BaseDirectory, "report-host", "FreeSms.ReportHost.exe");
            if (!File.Exists(host)) throw new FileNotFoundException("برنامهٔ کمکی گزارش نصب نیست. پوشهٔ report-host باید همراه برنامه باشد.", host);
            var directory = Path.Combine(Path.GetTempPath(), "FreeSMS-report-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(directory);
            try
            {
                var request = new XElement("report", new XAttribute("type", report.GetType().FullName),
                    new XAttribute("print", print), new XAttribute("export", export));
                WriteData(report, directory, "main", request);
                int index = 0;
                foreach (var sub in report.Subreports.Items)
                {
                    var node = new XElement("subreport", new XAttribute("name", sub.Key));
                    WriteData(sub.Value, directory, "sub" + index++, node);
                    request.Add(node);
                }
                foreach (var parameter in report.ParameterFields.Items)
                    foreach (var value in parameter.Value.CurrentValues.Items)
                        request.Add(new XElement("parameter", new XAttribute("key", parameter.Key),
                            new XAttribute("type", Type.GetTypeCode(value?.GetType()).ToString()),
                            Convert.ToString(value, CultureInfo.InvariantCulture) ?? ""));
                var path = Path.Combine(directory, "request.xml");
                new XDocument(request).Save(path);
                var start = new ProcessStartInfo(host) { UseShellExecute = false };
                start.ArgumentList.Add(path);
                using (var process = Process.Start(start))
                {
                    process.WaitForExit();
                    if (process.ExitCode != 0)
                    {
                        var error = Path.Combine(directory, "error.txt");
                        throw new InvalidOperationException(File.Exists(error) ? File.ReadAllText(error) : "موتور گزارش اجرا نشد. راه‌اندازی بخش گزارش و Crystal Runtime را بررسی کنید.");
                    }
                }
            }
            finally { Directory.Delete(directory, true); }
        }

        private static void WriteData(ReportClass report, string directory, string name, XElement node)
        {
            if (report.Data == null) return;
            var file = name + ".xml";
            report.Data.WriteXml(Path.Combine(directory, file), XmlWriteMode.WriteSchema);
            node.Add(new XAttribute("data", file));
            node.Add(new XAttribute("single-table", report.SingleTable));
        }
    }
}
