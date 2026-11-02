using System;
using System.Data;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

internal static class Program
{
    [STAThread]
    private static int Main(string[] args)
    {
        string directory = args.Length == 1 && !args[0].StartsWith("--", StringComparison.Ordinal) ? Path.GetDirectoryName(Path.GetFullPath(args[0])) : AppDomain.CurrentDomain.BaseDirectory;
        try
        {
            if (args.Length == 1 && args[0] == "--export-license-context")
            {
                // This is the original trusted build resource, never an input from the user.
                using (var stream = typeof(Program).Assembly.GetManifestResourceStream("FreeSms.ReportHost.exe.licenses"))
                {
                    var context = (object[])new BinaryFormatter().Deserialize(stream);
                    var keys = (Hashtable)context[1];
                    var xml = new XElement("licenses");
                    foreach (DictionaryEntry item in keys)
                        xml.Add(new XElement("license", new XAttribute("type", (string)item.Key), (string)item.Value));
                    new XDocument(xml).Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "original-component-licenses.xml"));
                }
                return 0;
            }
            OriginalFonts.Initialize();
            Application.EnableVisualStyles();
            if (args.Length == 1 && args[0] == "--verify-engine")
            {
                using (var viewer = new CrystalReportViewer()) viewer.CreateControl();
                var types = typeof(Program).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(ReportClass))).OrderBy(t => t.FullName).ToArray();
                using (var log = new StreamWriter(Path.Combine(directory, "report-engine-verification.txt")))
                {
                    foreach (var type in types)
                    using (var report = (ReportClass)Activator.CreateInstance(type))
                    {
                        // Forces the native Crystal runtime to load each original embedded template.
                        log.WriteLine(type.FullName + ": " + report.ReportDefinition.Sections.Count + " sections");
                        log.Flush();
                    }
                    log.WriteLine("SUCCESS " + types.Length);
                }
                return 0;
            }
            if (args.Length != 1) throw new ArgumentException("Expected a report request.");
            var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
            XElement request;
            using (var reader = XmlReader.Create(args[0], settings)) request = XDocument.Load(reader).Root;
            var typeName = (string)request.Attribute("type");
            var typeInfo = typeof(Program).Assembly.GetType(typeName, true);
            if (!typeInfo.IsSubclassOf(typeof(ReportClass))) throw new InvalidDataException("Unknown report type.");
            using (var report = (ReportClass)Activator.CreateInstance(typeInfo))
            {
                ApplyData(report, request, directory);
                foreach (var sub in request.Elements("subreport")) ApplyData(report.Subreports[(string)sub.Attribute("name")], sub, directory);
                foreach (var item in request.Elements("parameter"))
                {
                    var key = (string)item.Attribute("key");
                    var code = (TypeCode)Enum.Parse(typeof(TypeCode), (string)item.Attribute("type"));
                    var value = Convert.ChangeType(item.Value, code, CultureInfo.InvariantCulture);
                    var field = key.StartsWith("index:", StringComparison.Ordinal) ? report.ParameterFields[int.Parse(key.Substring(6), CultureInfo.InvariantCulture)] : report.ParameterFields[key.Substring(5)];
                    field.CurrentValues.AddValue(value);
                }
                using (var form = new Form { Text = "گزارش", WindowState = FormWindowState.Maximized })
                using (var viewer = new CrystalReportViewer { Dock = DockStyle.Fill, DisplayGroupTree = false,
                    ShowPrintButton = (bool)request.Attribute("print"), ShowExportButton = (bool)request.Attribute("export"),
                    ShowRefreshButton = false, ReportSource = report })
                {
                    form.Controls.Add(viewer);
                    Application.Run(form);
                }
            }
            return 0;
        }
        catch (Exception error)
        {
            File.WriteAllText(Path.Combine(directory, "error.txt"), error.ToString());
            return 1;
        }
    }

    private static void ApplyData(ReportDocument report, XElement item, string directory)
    {
        var name = (string)item.Attribute("data");
        if (name == null) return;
        if (Path.GetFileName(name) != name) throw new InvalidDataException("Invalid table file.");
        using (var data = new DataSet())
        using (var reader = XmlReader.Create(Path.Combine(directory, name), new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null }))
        {
            data.ReadXml(reader, XmlReadMode.ReadSchema);
            if ((bool?)item.Attribute("single-table") == true) report.SetDataSource(data.Tables[0]);
            else report.SetDataSource(data);
        }
    }
}
