using System.Diagnostics;
using FreeSms.Core;

internal static class Program
{
    [STAThread]
    private static int Main(string[] args)
    {
        try
        {
            var root = Path.Combine(AppContext.BaseDirectory, "legacy-ui");
            var app = Path.Combine(root, "school_Af.exe");
            if (!File.Exists(app)) throw new FileNotFoundException("پوشهٔ برنامهٔ اصلی همراه این فایل نیست. بسته را کامل استخراج کنید.");
            var start = new ProcessStartInfo(app) { UseShellExecute = false, WorkingDirectory = root };
            foreach (var argument in args) start.ArgumentList.Add(argument);
            if (!args.Contains("--verify-original-forms") && !args.Contains("--preview"))
            {
                var options = DatabaseOptions.Default with { Name = "school_af_kbr" };
                var database = Bootstrapper.OpenAsync(root,
                    string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("FREE_SMS_CONNECTION_STRING")) ? options : null).GetAwaiter().GetResult();
                Migrations.Apply(database, root);
                start.Environment["FREE_SMS_NATIVE_CONNECTION"] = database.ConnectionString;
            }
            using var process = Process.Start(start) ?? throw new InvalidOperationException("برنامه اجرا نشد.");
            process.WaitForExit();
            return process.ExitCode;
        }
        catch (Exception error)
        {
            var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "free-sms", "logs");
            Directory.CreateDirectory(directory);
            File.AppendAllText(Path.Combine(directory, "native-startup-error.txt"), error + Environment.NewLine);
            if (args.Any(argument => argument.StartsWith("--verify-", StringComparison.Ordinal)))
                File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "native-launcher-error.txt"), error.ToString());
            else MessageBox.Show(error.Message, "برنامه باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
    }
}
