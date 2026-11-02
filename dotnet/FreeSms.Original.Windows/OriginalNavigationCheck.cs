using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FreeSms.Core;
using Microsoft.Data.SqlClient;

// Opens recovered menu destinations against an isolated seed database, in separate
// processes: a blocked Load handler cannot block the remaining probes or the user DB.
internal static class OriginalNavigationCheck
{
    private const string WorkerConnection = "FREE_SMS_NAVIGATION_TEST_CONNECTION";
    private static string workerLog;
    internal static void TraceCommand(string sql)
    {
        if (workerLog == null) return;
        File.AppendAllText(workerLog, "SQL " + Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(sql ?? ""))) + Environment.NewLine + Environment.StackTrace + Environment.NewLine);
    }
    internal static int Worker(string route)
    {
        int workflowMarker = route.IndexOf("_workflow_", StringComparison.Ordinal);
        string workflow = workflowMarker < 0 ? null : route.Substring(workflowMarker + 10);
        int marker = route.IndexOf("_report_", StringComparison.Ordinal);
        string reportId = marker < 0 ? null : route.Substring(marker + 8);
        string routeVariable = workflowMarker >= 0 ? route.Substring(0, workflowMarker) : marker < 0 ? route : route.Substring(0, marker);
        var builder = new SqlConnectionStringBuilder(Environment.GetEnvironmentVariable(WorkerConnection) ?? "");
        if (!builder.InitialCatalog.StartsWith("free_sms_ui_", StringComparison.Ordinal) || builder.ApplicationName != "FreeSMS.NavigationCheck" || !builder.DataSource.StartsWith(@"np:\\.\pipe\LOCALDB#", StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Navigation probes require their isolated test database.");
        var directory = Path.Combine(AppContext.BaseDirectory, "navigation-checks");
        Directory.CreateDirectory(directory);
        workerLog = Path.Combine(directory, route + ".log");
        File.WriteAllText(workerLog, "BEGIN " + route + Environment.NewLine);
        try
        {
            var catalog = new FormCatalog(AppContext.BaseDirectory);
            var definition = catalog.ByName["frmMain"];
            var control = definition.A("controls").Single(item => item.S("variable") == routeVariable);
            var target = catalog.Target(definition, control) ?? throw new ArgumentException("Not a navigation route.");
            string className = target.S("class");
            if (className == "asdb3" || className == "asda3") throw new ArgumentException("Not a navigation destination.");
            File.AppendAllText(workerLog, control.S("name") + " -> " + target.S("name") + Environment.NewLine);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, exception) =>
            {
                File.AppendAllText(workerLog, "FAILED " + exception.Exception + Environment.NewLine);
                Environment.Exit(1);
            };
            OriginalRuntime.ConnectionString = builder.ConnectionString;
            KeylessRuntime.Enable();
            asdab.__field_d = builder.InitialCatalog;
            var database = new Database(builder.ConnectionString);
            if (workflow == "student-delete") OriginalWorkflowChecks.PrepareReportFixture(database);
            asdaj.__field_a = Convert.ToString(database.Scalar("SELECT xYear FROM tDefYear"));
            // Test-only context; connection guard above excludes the user's database.
            asdaj.l = "1"; asdaj.m = "";
            asdaj.n = string.Join(",", database.Query("SELECT id FROM tPaye").Select(row => Convert.ToString(row["id"])));
            File.AppendAllText(workerLog, "CONSTRUCT" + Environment.NewLine);
            using var main = new asdb3(); // Do not show the main form or invoke its login Load handler.
            using var timer = new Timer { Interval = 300 };
            bool started = false, previewClicked = false, workflowRunning = false;
            timer.Tick += (sender, e) =>
            {
                if (!started)
                {
                    started = true;
                    File.AppendAllText(workerLog, "CLICK " + control.S("click") + Environment.NewLine);
                    var handler = typeof(asdb3).GetMethod(control.S("click").TrimStart('@'), BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(object), typeof(EventArgs) }, null);
                    handler.Invoke(main, new object[] { main, EventArgs.Empty });
                    return;
                }
                var windows = Application.OpenForms.Cast<Form>().Where(form => form.Visible).ToArray();
                if (workflow != null)
                {
                    if (workflowRunning) return;
                    var form = windows.FirstOrDefault(item => item.GetType().Name == className);
                    if (form == null)
                    {
                        if (HasNativeDialog()) { File.AppendAllText(workerLog, "FAILED workflow blocked before opening: " + NativeDialogText() + Environment.NewLine); Environment.Exit(1); }
                        return;
                    }
                    workflowRunning = true;
                    OriginalWorkflowChecks.Run(workflow, form, database, message => File.AppendAllText(workerLog, message + Environment.NewLine));
                    File.AppendAllText(workerLog, "SUCCESS original workflow actions and persisted effects" + Environment.NewLine);
                    Environment.Exit(0);
                }
                if (reportId != null)
                {
                    var selector = windows.FirstOrDefault(form => form.GetType().Name == className);
                    if (!previewClicked && selector != null)
                    {
                        previewClicked = true;
                        PrepareReportPreview(selector, reportId);
                        File.AppendAllText(workerLog, "CLICK actual report preview button, report=" + reportId + Environment.NewLine);
                        Field<Janus.Windows.EditControls.UIButton>(selector, "m_c").PerformClick();
                        return;
                    }
                    var viewers = windows.SelectMany(Descendants).OfType<FreeSms.NativeControls.PortableReportViewer>().ToArray();
                    if (viewers.Any(viewer => viewer.ReportPageCount > 0))
                    {
                        var viewer = viewers.First(viewer => viewer.ReportPageCount > 0);
                        using var image = new System.Drawing.Bitmap(viewer.Width, viewer.Height);
                        viewer.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                        image.Save(Path.Combine(directory, route + ".png"));
                        OriginalWorkflowChecks.AssertReportFixture(viewer, database);
                        File.AppendAllText(workerLog, "PASS actual report input contains the fixture student's persisted identity and name" + Environment.NewLine);
                        File.AppendAllText(workerLog, "SUCCESS actual report controller and preview; pages=" + viewer.ReportPageCount + Environment.NewLine);
                        Environment.Exit(0);
                    }
                    if (HasNativeDialog())
                    {
                        File.AppendAllText(workerLog, "FAILED unexpected modal during report preview: " + NativeDialogText() + Environment.NewLine);
                        Environment.Exit(1);
                    }
                    return;
                }
                if (windows.Any(form => form.GetType().Name == className))
                {
                    if (HasNativeDialog())
                    {
                        string message = NativeDialogText();
                        bool expected = className == "asdj" && message.Split(new[] { " | " },StringSplitOptions.None).Contains("هنوز درسی تعریف نشده است")
                            && Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook b JOIN tPaye p ON p.id=b.xPaye")) == 0;
                        expected |= className == "asdp" && message.Split(new[] { " | " },StringSplitOptions.None).Contains("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید")
                            && Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYearMaghtaCountDay WHERE xYear=@p0",new object[] {asdaj.__field_a})) == 0;
                        File.AppendAllText(workerLog, (expected ? "EXPECTED_VALIDATION missing fixture configuration: " : "FAILED destination blocked by unexpected native dialog: ") + message + Environment.NewLine);
                        Environment.Exit(expected ? 2 : 1);
                    }
                    File.AppendAllText(workerLog, "SUCCESS loaded, shown and UI timer responded" + Environment.NewLine);
                    Environment.Exit(0);
                }
                if (windows.Any(form => form.Modal) || HasNativeDialog())
                {
                    File.AppendAllText(workerLog, "INTERACTION responsive modal selection/message; awaiting user input" + Environment.NewLine);
                    Environment.Exit(2);
                }
            };
            timer.Start();
            Application.Run(new ApplicationContext());
            File.AppendAllText(workerLog, "FAILED form closed before responsiveness check" + Environment.NewLine);
            return 1;
        }
        catch (Exception error)
        {
            File.AppendAllText(workerLog, "FAILED " + error + Environment.NewLine);
            return 1;
        }
    }
    private delegate bool WindowCallback(IntPtr window, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool EnumThreadWindows(uint thread, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool IsWindowVisible(IntPtr window);
    [DllImport("user32.dll", CharSet = CharSet.Unicode)] private static extern int GetClassName(IntPtr window, StringBuilder name, int size);
    [DllImport("user32.dll", CharSet = CharSet.Unicode)] private static extern int GetWindowText(IntPtr window, StringBuilder text, int size);
    [DllImport("user32.dll")] private static extern bool EnumChildWindows(IntPtr window, WindowCallback callback, IntPtr parameter);
    [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
    private static string NativeDialogText()
    {
        var texts = new System.Collections.Generic.List<string>();
        EnumThreadWindows(GetCurrentThreadId(), (window, parameter) =>
        {
            var name = new StringBuilder(128); GetClassName(window,name,name.Capacity);
            if (!IsWindowVisible(window) || name.ToString() != "#32770") return true;
            var title = new StringBuilder(2048); GetWindowText(window,title,title.Capacity); texts.Add(title.ToString());
            EnumChildWindows(window,(child,unused) => { var text = new StringBuilder(2048); GetWindowText(child,text,text.Capacity); if (text.Length > 0) texts.Add(text.ToString()); return true; },IntPtr.Zero);
            return true;
        },IntPtr.Zero);
        return string.Join(" | ",texts);
    }
    private static bool HasNativeDialog()
    {
        bool found = false;
        EnumThreadWindows(GetCurrentThreadId(), (window, parameter) =>
        {
            var name = new StringBuilder(128);
            GetClassName(window, name, name.Capacity);
            found |= IsWindowVisible(window) && name.ToString() == "#32770";
            return !found;
        }, IntPtr.Zero);
        return found;
    }
    private static T Field<T>(Form form, string name) => (T)form.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(form);
    private static System.Collections.Generic.IEnumerable<Control> Descendants(Control parent)
    {
        foreach (Control child in parent.Controls)
        {
            yield return child;
            foreach (var nested in Descendants(child)) yield return nested;
        }
    }
    private static void PrepareReportPreview(Form selector, string reportId)
    {
        var reports = Field<Janus.Windows.GridEX.GridEX>(selector, "m_b");
        int selected = -1;
        for (int i = 0; i < reports.RowCount; i++)
            if (Convert.ToString(reports.GetRow(i).Cells["id"].Value) == reportId) { selected = i; break; }
        if (selected < 0) throw new InvalidOperationException("Required report not available: " + reportId);
        reports.Row = selected;
        var classes = Field<Janus.Windows.GridEX.GridEX>(selector, "m_e");
        if (classes.RowCount == 0) throw new InvalidOperationException("Report fixture has no classes.");
        for (int i = 0; i < classes.RowCount; i++) classes.GetRow(i).Cells["Selector"].Value = i == 0;
        var exams = Field<Janus.Windows.GridEX.GridEX>(selector, "m_f");
        string term = Convert.ToString(reports.GetRow(selected).Cells["term"].Value);
        int count = Convert.ToInt32(reports.GetRow(selected).Cells["countExam"].Value);
        int chosen = 0;
        for (int i = 0; i < exams.RowCount; i++)
        {
            bool pick = chosen < Math.Max(1, count) && (term.Length == 0 || term == Convert.ToString(exams.GetRow(i).Cells["term"].Value));
            exams.GetRow(i).Cells["Selector"].Value = pick;
            if (pick) chosen++;
        }
        if (chosen == 0) throw new InvalidOperationException("Report fixture has no compatible exam.");
        File.AppendAllText(workerLog, "PREPARED classes=1 exams=" + chosen + " term=" + term + Environment.NewLine);
    }
    private static bool CheckReportCatalog(Database database, string directory)
    {
        string path = Path.Combine(directory, "report-catalog.log");
        int failures = 0, count = 0;
        using var log = new StreamWriter(path);
        var entries = database.Query("SELECT * FROM tRpt ORDER BY id");
        File.WriteAllText(Path.Combine(directory,"report-catalog-spec.json"),System.Text.Json.JsonSerializer.Serialize(entries,new System.Text.Json.JsonSerializerOptions {WriteIndented=true}));
        foreach (var row in entries)
        {
            count++;
            string id = Convert.ToString(row["id"]), name = Convert.ToString(row["Rpt"]);
            log.WriteLine("CATALOG report=" + id + " tosifi=" + Convert.ToString(row["tosifi"]) + " caption=" + Convert.ToString(row["Caption"]));
            var report = asdd.a(name);
            if (report == null || !File.Exists(Path.Combine(AppContext.BaseDirectory, "portable-layouts", report.ResourceName + ".xml")))
            { failures++; log.WriteLine("FAILED report=" + id + " missing factory/template: " + name); }
            else log.WriteLine("PASS report=" + id + " original factory and migrated template: " + name);
            var procedures = new System.Collections.Generic.List<string>();
            foreach (string column in new[] { "sp", "sp2" })
                if (!string.IsNullOrWhiteSpace(Convert.ToString(row[column]))) procedures.Add(Convert.ToString(row[column]));
            string children = Convert.ToString(row["subReport"]);
            if (children.Length > 0) log.WriteLine("SUBREPORT report=" + id + " bindings=" + children);
            if (children.Length > 0)
            {
                var parts = children.Split(',');
                if (parts.Length % 2 != 0) { failures++; log.WriteLine("FAILED report=" + id + " malformed subreport pairs"); }
                for (int i=1; i<parts.Length; i+=2) procedures.Add(parts[i]);
            }
            foreach (string procedure in procedures.Distinct())
            {
                bool exists = database.Scalar("SELECT OBJECT_ID(@p0,'P')", new object[] {procedure}) != null;
                if (!exists) failures++;
                log.WriteLine((exists ? "PASS " : "FAILED ") + "report=" + id + " procedure=" + procedure);
            }
        }
        log.WriteLine("RESULT reports=" + count + " failures=" + failures + "; dependency checks only, not execution proof");
        return count > 0 && failures == 0;
    }
    internal static int Run(bool reportActions = false, bool businessActions = false)
    {
        string suffix = Guid.NewGuid().ToString("N");
        string instance = "FreeSmsUiCheck_" + suffix;
        var options = new DatabaseOptions(Path.Combine(Path.GetTempPath(), instance), instance, "free_sms_ui_" + suffix);
        string directory = Path.Combine(AppContext.BaseDirectory, "navigation-checks");
        Directory.CreateDirectory(directory);
        string summary = Path.Combine(directory, businessActions ? "business-actions-summary.log" : reportActions ? "report-actions-summary.log" : "summary.log");
        File.WriteAllText(summary, (businessActions ? "Original school/discount workflow actions and persisted effects" : reportActions ? "Original report preview action and generated pages" : "Isolated native form Load/Shown responsiveness checks") + Environment.NewLine);
        try
        {
            var database = Bootstrapper.OpenAsync(AppContext.BaseDirectory, options).GetAwaiter().GetResult();
            Migrations.Apply(database, AppContext.BaseDirectory);
            var connection = new SqlConnectionStringBuilder(database.ConnectionString) { ApplicationName = "FreeSMS.NavigationCheck" };
            if (reportActions) OriginalWorkflowChecks.PrepareReportFixture(database);
            bool reportCatalogValid = !reportActions || CheckReportCatalog(database, directory);
            var catalog = new FormCatalog(AppContext.BaseDirectory);
            var main = catalog.ByName["frmMain"];
            var targets = main.A("controls").Where(control => catalog.Target(main, control) is var target && target.HasValue && target.Value.S("class") != "asdb3" && target.Value.S("class") != "asda3")
                .GroupBy(control => control.S("click")).Select(group => group.First()).OrderBy(control => control.S("name")).ToArray();
            if (reportActions) targets = targets.Where(control => catalog.Target(main, control).Value.S("class") == "asda0").ToArray();
            if (businessActions) targets = targets.Where(control => new[] { "asdh", "asdac", "asdm" }.Contains(catalog.Target(main, control).Value.S("class"))).ToArray();
            if (businessActions && targets.Select(control => catalog.Target(main,control).Value.S("class")).Distinct().Count() != 3)
                throw new InvalidOperationException("School, discount and student deletion workflow routes are required.");
            if (targets.Length == 0) throw new InvalidOperationException("No verification routes were discovered.");
            int passed = 0, interaction = 0;
            foreach (var control in targets)
            {
                string route = control.S("variable") + (businessActions ? "_workflow_" + (catalog.Target(main, control).Value.S("class") == "asdh" ? "discount" : catalog.Target(main, control).Value.S("class") == "asdm" ? "student-delete" : "school") : reportActions ? "_report_101" : "");
                var target = catalog.Target(main, control).Value;
                var start = new ProcessStartInfo(Environment.ProcessPath) { UseShellExecute = false, CreateNoWindow = true };
                start.ArgumentList.Add("--verify-navigation-form"); start.ArgumentList.Add(route);
                start.Environment[WorkerConnection] = connection.ConnectionString;
                using var process = Process.Start(start);
                bool finished = process.WaitForExit(reportActions || businessActions ? 60000 : 10000);
                if (!finished) { process.Kill(true); process.WaitForExit(); }
                bool success = finished && process.ExitCode == 0;
                bool waiting = finished && process.ExitCode == 2;
                if (success) passed++;
                if (waiting) interaction++;
                File.AppendAllText(summary, (success ? "PASS " : waiting ? "INTERACTION " : finished ? "FAILED " : "TIMEOUT ") + route + " " + control.S("name") + " -> " + target.S("name") + Environment.NewLine);
            }
            File.AppendAllText(summary, "RESULT loaded=" + passed + ", interaction=" + interaction + ", total=" + targets.Length + Environment.NewLine);
            return reportCatalogValid && passed + interaction == targets.Length ? 0 : 1;
        }
        finally
        {
            SqlConnection.ClearAllPools();
            var utility = Bootstrapper.FindLocalDbUtility();
            if (utility != null)
            {
                Bootstrapper.RunLocalDbAsync(utility, default, "stop", instance, "-k").GetAwaiter().GetResult();
                Bootstrapper.RunLocalDbAsync(utility, default, "delete", instance).GetAwaiter().GetResult();
            }
            try { if (Directory.Exists(options.DataDirectory)) Directory.Delete(options.DataDirectory, true); }
            catch (IOException) { }
        }
    }
}
