using FreeSms.Core;

namespace FreeSms.Windows;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (_, e) => MessageBox.Show(e.Exception.Message, "خطای برنامه");
        try
        {
            var preview = args.Contains("--preview") || args.Contains("--verify-forms");
            var index = Array.IndexOf(args, "--form");
            var name = index >= 0 && index + 1 < args.Length ? args[index + 1] : "frmMain";
            var runtime = new AppRuntime(AppContext.BaseDirectory, preview);
            if (!runtime.Catalog.ByName.ContainsKey(name)) throw new ArgumentException("فرم پیدا نشد: " + name);
            if (args.Contains("--verify-forms"))
            {
                // Windows-only render smoke check, without opening any database.
                foreach (var definition in runtime.Catalog.Forms)
                {
                    using var form = new RecoveredForm(runtime, definition);
                    form.Show(); Application.DoEvents();
                    using var bitmap = new Bitmap(form.Width, form.Height);
                    form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, form.Size));
                    form.Close();
                }
                File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "forms-verification.txt"), $"Rendered {runtime.Catalog.Forms.Count} forms successfully.");
                return;
            }
            Application.Run(new RecoveredForm(runtime, runtime.Catalog.ByName[name]));
        }
        catch (Exception error) { MessageBox.Show(error.Message, "برنامه باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error); Environment.ExitCode = 1; }
    }
}
