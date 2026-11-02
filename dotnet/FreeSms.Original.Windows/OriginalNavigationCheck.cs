using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
    internal static int Worker(string className)
    {
        var builder = new SqlConnectionStringBuilder(Environment.GetEnvironmentVariable(WorkerConnection) ?? "");
        if (!builder.InitialCatalog.StartsWith("free_sms_ui_", StringComparison.Ordinal) || builder.ApplicationName != "FreeSMS.NavigationCheck" || !builder.DataSource.StartsWith(@"np:\\.\pipe\LOCALDB#", StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Navigation probes require their isolated test database.");
        var directory = Path.Combine(AppContext.BaseDirectory, "navigation-checks");
        Directory.CreateDirectory(directory);
        workerLog = Path.Combine(directory, className + ".log");
        File.WriteAllText(workerLog, "BEGIN " + className + Environment.NewLine);
        try
        {
            var catalog = new FormCatalog(AppContext.BaseDirectory);
            if (!catalog.ByClass.ContainsKey(className) || className == "asdb3" || className == "asda3") throw new ArgumentException("Not a navigation destination.");
            OriginalRuntime.ConnectionString = builder.ConnectionString;
            KeylessRuntime.Enable();
            asdab.__field_d = builder.InitialCatalog;
            var database = new Database(builder.ConnectionString);
            asdaj.__field_a = Convert.ToString(database.Scalar("SELECT xYear FROM tDefYear"));
            // Test-only context; connection guard above excludes the user's database.
            asdaj.l = "1"; asdaj.m = "";
            asdaj.n = string.Join(",", database.Query("SELECT id FROM tPaye").Select(row => Convert.ToString(row["id"])));
            File.AppendAllText(workerLog, "CONSTRUCT" + Environment.NewLine);
            using var form = (Form)Activator.CreateInstance(typeof(OriginalProgram).Assembly.GetType(className, true));
            using var timer = new Timer { Interval = 300 };
            timer.Tick += (s, e) =>
            {
                File.AppendAllText(workerLog, "SUCCESS loaded, shown and UI timer responded" + Environment.NewLine);
                Environment.Exit(0); // Do not invoke legacy backup/close confirmation handlers.
            };
            form.Shown += (s, e) => timer.Start();
            File.AppendAllText(workerLog, "SHOW" + Environment.NewLine);
            Application.Run(form);
            File.AppendAllText(workerLog, "FAILED form closed before responsiveness check" + Environment.NewLine);
            return 1;
        }
        catch (Exception error)
        {
            File.AppendAllText(workerLog, "FAILED " + error + Environment.NewLine);
            return 1;
        }
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
            var targets = main.A("controls").Select(control => catalog.Target(main, control)).Where(target => target.HasValue).Select(target => target.Value.S("class"))
                .Where(name => name != "asdb3" && name != "asda3").Distinct().OrderBy(name => name).ToArray();
            int passed = 0;
            foreach (string target in targets)
            {
                var start = new ProcessStartInfo(Environment.ProcessPath) { UseShellExecute = false, CreateNoWindow = true };
                start.ArgumentList.Add("--verify-navigation-form"); start.ArgumentList.Add(target);
                start.Environment[WorkerConnection] = connection.ConnectionString;
                using var process = Process.Start(start);
                bool finished = process.WaitForExit(10000);
                if (!finished) { process.Kill(true); process.WaitForExit(); }
                bool success = finished && process.ExitCode == 0;
                if (success) passed++;
                File.AppendAllText(summary, (success ? "PASS " : finished ? "FAILED " : "TIMEOUT ") + target + " " + catalog.ByClass[target].S("name") + Environment.NewLine);
            }
            File.AppendAllText(summary, "RESULT " + passed + "/" + targets.Length + Environment.NewLine);
            return passed == targets.Length ? 0 : 1;
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
