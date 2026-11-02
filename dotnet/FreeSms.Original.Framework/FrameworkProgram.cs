global using ReportClass = CrystalDecisions.CrystalReports.Engine.ReportClass;
global using CrystalReportViewer = CrystalDecisions.Windows.Forms.CrystalReportViewer;

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FreeSms.Reporting { internal static class OriginalEngine { } }

internal static class OriginalRuntime
{
    public static string ConnectionString => Environment.GetEnvironmentVariable("FREE_SMS_NATIVE_CONNECTION") ?? "";
}

internal static class KeylessRuntime
{
    public static void Enable()
    {
        asdu.o = new string('1', 32);
        asdab.__field_d = "school_af_kbr";
        asdab.n = "0";
        asdab.q = asdab.n;
        asdab.m = "3";
        asdab.o = "10";
        asdab.p = int.MaxValue;
    }
}

internal static class StreamCompatibility
{
    public static void ReadExactly(this Stream stream, byte[] buffer, int offset, int count)
    {
        while (count > 0)
        {
            int read = stream.Read(buffer, offset, count);
            if (read == 0) throw new EndOfStreamException();
            offset += read;
            count -= read;
        }
    }
}

internal static class FrameworkProgram
{
    [STAThread]
    public static int Main(string[] args)
    {
        bool checking = args.Contains("--verify-original-forms") || args.Contains("--verify-native-startup");
        try
        {
            OriginalFonts.Initialize();
            KeylessRuntime.Enable();
            if (args.Contains("--verify-original-forms"))
            {
                Application.EnableVisualStyles();
                int failures = 0;
                var forms = typeof(FrameworkProgram).Assembly.GetTypes()
                    .Where(type => type.IsSubclassOf(typeof(Form)) && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
                    .OrderBy(type => type.Name).ToArray();
                using (var log = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "original-forms-verification.txt")))
                {
                    foreach (var type in forms)
                    {
                        log.WriteLine("BEGIN " + type.Name); log.Flush();
                        try
                        {
                            using (var form = (Form)Activator.CreateInstance(type))
                            {
                                form.CreateControl();
                                using (var image = new System.Drawing.Bitmap(Math.Max(1, form.Width), Math.Max(1, form.Height)))
                                    form.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                                log.WriteLine(type.Name + ": constructed and rendered");
                            }
                        }
                        catch (Exception error) { failures++; log.WriteLine("FAILED " + type.Name + ": " + error); }
                        log.Flush();
                    }
                    log.WriteLine(failures == 0 ? "SUCCESS " + forms.Length : "FAILED " + failures + " of " + forms.Length);
                }
                return failures == 0 ? 0 : 1;
            }
            if (string.IsNullOrWhiteSpace(OriginalRuntime.ConnectionString)) throw new InvalidOperationException("برنامه را از FreeSMS.exe اجرا کنید تا بانک بومی آماده شود.");
            if (args.Contains("--verify-native-startup"))
            {
                Application.EnableVisualStyles();
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
                bool seenLogin = false;
                using (var timer = new Timer { Interval = 3000 })
                {
                    timer.Tick += (sender, eventArgs) =>
                    {
                        timer.Stop();
                        var windows = Application.OpenForms.Cast<Form>().ToArray();
                        seenLogin = windows.Any(form => form is asda3);
                        foreach (var form in windows.Where(form => form is asda3 || form is asdb3))
                        {
                            using (var image = new System.Drawing.Bitmap(form.Width, form.Height))
                            {
                                form.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                                image.Save(Path.Combine(AppContext.BaseDirectory, "startup-" + form.GetType().Name + ".png"));
                            }
                        }
                        foreach (var form in windows.Reverse()) form.Close();
                        Application.Exit();
                    };
                    timer.Start();
                    asdbx.RunOriginal();
                }
                if (!seenLogin) throw new InvalidOperationException("Original login did not open after native database initialization.");
                File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "native-startup-verification.txt"), "SUCCESS: native database initialized and the original account login opened. No user authentication was bypassed.");
                return 0;
            }
            asdbx.RunOriginal();
            return 0;
        }
        catch (Exception error)
        {
            File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "original-runtime-error.txt"), error.ToString());
            if (!checking) MessageBox.Show(error.Message, "برنامه باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
    }
}
