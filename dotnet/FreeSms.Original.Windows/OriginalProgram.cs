using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FreeSms.Core;

internal static class OriginalRuntime
{
    public static string ConnectionString;
    public static void Initialize()
    {
        var options = DatabaseOptions.Default with { Name = "school_af_kbr" };
        var database = Bootstrapper.OpenAsync(AppContext.BaseDirectory,
            string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("FREE_SMS_CONNECTION_STRING")) ? options : null).GetAwaiter().GetResult();
        Migrations.Apply(database, AppContext.BaseDirectory);
        ConnectionString = database.ConnectionString;
        KeylessRuntime.Enable();
    }
}

internal static class KeylessRuntime
{
    public static void Enable()
    {
        asdu.o = new string('1', 32);
        asdab.__field_d = "school_af_kbr";
        // These values used to come from the dongle. The numeric school identifier is
        // also interpolated into the original optional export queries.
        asdab.n = "0";
        asdab.q = asdab.n;
        asdab.m = "3";
        asdab.o = "10";
        asdab.p = int.MaxValue;
    }
}

internal static class OriginalProgram
{
    [STAThread]
    public static int Main(string[] args)
    {
        bool checking = args.Contains("--verify-original-forms") || args.Contains("--verify-native-startup");
        try
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            OriginalFonts.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            if (args.Contains("--preview"))
            {
                KeylessRuntime.Enable();
                Application.EnableVisualStyles();
                using (var original = new asdb3())
                using (var image = new System.Drawing.Bitmap(original.Width, original.Height))
                using (var preview = new Form { Text = "پیش‌نمایش فرم اصلی — بدون بانک", ClientSize = original.Size, AutoScroll = true })
                {
                    original.CreateControl();
                    original.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                    preview.Controls.Add(new PictureBox { Image = image, SizeMode = PictureBoxSizeMode.AutoSize });
                    Application.Run(preview);
                }
                return 0;
            }
            if (args.Contains("--verify-original-forms"))
            {
                KeylessRuntime.Enable();
                Application.EnableVisualStyles();
                var catalog = new FormCatalog(AppContext.BaseDirectory);
                var assembly = typeof(OriginalProgram).Assembly;
                using (var log = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "original-forms-verification.txt")))
                {
                    int failures = 0;
                    foreach (var definition in catalog.Forms)
                    {
                      try
                      {
                        log.WriteLine("BEGIN " + definition.S("class"));
                        log.Flush();
                        var type = assembly.GetType(definition.S("class"), true);
                        using (var form = (Form)Activator.CreateInstance(type))
                        {
                            form.CreateControl();
                            using (var image = new System.Drawing.Bitmap(Math.Max(1, form.Width), Math.Max(1, form.Height)))
                                form.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                            log.WriteLine(definition.S("name") + ": constructed and rendered");
                            log.Flush();
                        }
                      }
                      catch (Exception error)
                      {
                          failures++;
                          log.WriteLine("FAILED " + definition.S("class") + ": " + error);
                          log.Flush();
                      }
                    }
                    log.WriteLine(failures == 0 ? "SUCCESS " + catalog.Forms.Count : "FAILED " + failures + " of " + catalog.Forms.Count);
                    if (failures != 0) return 1;
                }
                return 0;
            }
            OriginalRuntime.Initialize();
            if (args.Contains("--verify-native-startup"))
            {
                bool seenLogin = false;
                using (var timer = new Timer { Interval = 3000 })
                {
                    timer.Tick += (sender, eventArgs) =>
                    {
                        timer.Stop();
                        var windows = Application.OpenForms.Cast<Form>().ToArray();
                        seenLogin = windows.Any(form => form is asda3);
                        foreach (var form in windows.Where(form => form is asda3 || form is asdb3))
                            using (var image = new System.Drawing.Bitmap(form.Width, form.Height))
                            {
                                form.DrawToBitmap(image, new System.Drawing.Rectangle(System.Drawing.Point.Empty, image.Size));
                                image.Save(Path.Combine(AppContext.BaseDirectory, "startup-" + form.GetType().Name + ".png"));
                            }
                        foreach (var form in windows.Reverse()) form.Close();
                        Application.Exit();
                    };
                    timer.Start();
                    asdbx.RunOriginal();
                }
                if (!seenLogin) throw new InvalidOperationException("Original login did not open after native database initialization.");
                File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "native-startup-verification.txt"), "SUCCESS: .NET 10 native database and original account login opened. Authentication was not bypassed.");
                return 0;
            }
            asdbx.RunOriginal();
            return 0;
        }
        catch (Exception error)
        {
            var directory = checking ? AppContext.BaseDirectory : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "free-sms", "logs");
            try
            {
                Directory.CreateDirectory(directory);
                File.AppendAllText(Path.Combine(directory, "original-runtime-error.txt"), error.ToString() + Environment.NewLine);
            }
            catch (IOException) { }
            if (!checking) MessageBox.Show(error.Message, "برنامه باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
    }
}
