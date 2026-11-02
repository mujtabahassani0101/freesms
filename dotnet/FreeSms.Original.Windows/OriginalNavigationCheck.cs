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
            var control = definition.A("controls").Single(item => item.S("variable") == route);
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
            asdaj.__field_a = Convert.ToString(database.Scalar("SELECT xYear FROM tDefYear"));
            // Test-only context; connection guard above excludes the user's database.
            asdaj.l = "1"; asdaj.m = "";
            asdaj.n = string.Join(",", database.Query("SELECT id FROM tPaye").Select(row => Convert.ToString(row["id"])));
            File.AppendAllText(workerLog, "CONSTRUCT" + Environment.NewLine);
            using var main = new asdb3(); // Do not show the main form or invoke its login Load handler.
            using var timer = new Timer { Interval = 300 };
            bool started = false;
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
                if (windows.Any(form => form.GetType().Name == className))
                {
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
    [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
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
    internal static int Run()
    {
        string suffix = Guid.NewGuid().ToString("N");
        string instance = "FreeSmsUiCheck_" + suffix;
        var options = new DatabaseOptions(Path.Combine(Path.GetTempPath(), instance), instance, "free_sms_ui_" + suffix);
        string directory = Path.Combine(AppContext.BaseDirectory, "navigation-checks");
        Directory.CreateDirectory(directory);
        string summary = Path.Combine(directory, "summary.log");
        File.WriteAllText(summary, "Isolated native form Load/Shown responsiveness checks" + Environment.NewLine);
        try
        {
            var database = Bootstrapper.OpenAsync(AppContext.BaseDirectory, options).GetAwaiter().GetResult();
            Migrations.Apply(database, AppContext.BaseDirectory);
            var connection = new SqlConnectionStringBuilder(database.ConnectionString) { ApplicationName = "FreeSMS.NavigationCheck" };
            var catalog = new FormCatalog(AppContext.BaseDirectory);
            var main = catalog.ByName["frmMain"];
            var targets = main.A("controls").Where(control => catalog.Target(main, control) is var target && target.HasValue && target.Value.S("class") != "asdb3" && target.Value.S("class") != "asda3")
                .GroupBy(control => control.S("click")).Select(group => group.First()).OrderBy(control => control.S("name")).ToArray();
            int passed = 0, interaction = 0;
            foreach (var control in targets)
            {
                string route = control.S("variable");
                var target = catalog.Target(main, control).Value;
                var start = new ProcessStartInfo(Environment.ProcessPath) { UseShellExecute = false, CreateNoWindow = true };
                start.ArgumentList.Add("--verify-navigation-form"); start.ArgumentList.Add(route);
                start.Environment[WorkerConnection] = connection.ConnectionString;
                using var process = Process.Start(start);
                bool finished = process.WaitForExit(10000);
                if (!finished) { process.Kill(true); process.WaitForExit(); }
                bool success = finished && process.ExitCode == 0;
                bool waiting = finished && process.ExitCode == 2;
                if (success) passed++;
                if (waiting) interaction++;
                File.AppendAllText(summary, (success ? "PASS " : waiting ? "INTERACTION " : finished ? "FAILED " : "TIMEOUT ") + route + " " + control.S("name") + " -> " + target.S("name") + Environment.NewLine);
            }
            File.AppendAllText(summary, "RESULT loaded=" + passed + ", interaction=" + interaction + ", total=" + targets.Length + Environment.NewLine);
            return passed + interaction == targets.Length ? 0 : 1;
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
