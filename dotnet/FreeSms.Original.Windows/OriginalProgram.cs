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
        var database = Bootstrapper.OpenAsync(AppContext.BaseDirectory, options).GetAwaiter().GetResult();
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
        asdab.n = "FreeSMS";
        asdab.m = "3";
        asdab.o = "10";
    }
}

internal static class OriginalProgram
{
    [STAThread]
    public static int Main(string[] args)
    {
        bool checking = args.Contains("--verify-original-forms");
        try
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            if (checking)
            {
                KeylessRuntime.Enable();
                Application.EnableVisualStyles();
                var catalog = new FormCatalog(AppContext.BaseDirectory);
                var assembly = typeof(OriginalProgram).Assembly;
                using (var log = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "original-forms-verification.txt")))
                {
                    foreach (var definition in catalog.Forms)
                    {
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
                    log.WriteLine("SUCCESS " + catalog.Forms.Count);
                }
                return 0;
            }
            OriginalRuntime.Initialize();
            asdbx.RunOriginal();
            return 0;
        }
        catch (Exception error)
        {
            File.AppendAllText(Path.Combine(AppContext.BaseDirectory, "original-runtime-error.txt"), error.ToString() + Environment.NewLine);
            if (!checking) MessageBox.Show(error.Message, "برنامه باز نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 1;
        }
    }
}
