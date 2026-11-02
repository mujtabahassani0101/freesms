using System;
using System.IO;
using System.Windows.Forms;
using FreeSms.Core;

internal static class OriginalFeatureGuard
{
    // Some menu entries were carried over from another database edition. Do not
    // fabricate tables/procedures or let their Load handlers fail on an Afghan DB.
    internal static bool RequireSchema(Form owner, string feature, params string[] objects)
    {
        var database = new Database(OriginalRuntime.ConnectionString);
        foreach (string name in objects)
        {
            if (database.Scalar("SELECT OBJECT_ID(@p0)", new object[] { name }) != null) continue;
            try
            {
                string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "free-sms", "logs");
                Directory.CreateDirectory(directory);
                File.AppendAllText(Path.Combine(directory, "schema-compatibility.txt"), DateTimeOffset.Now.ToString("O") + " " + feature + ": missing " + name + Environment.NewLine);
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
            MessageBox.Show(owner, "بانک فعلی، اطلاعات و ساختار لازم برای بخش «" + feature + "» را ندارد. برای استفاده از این بخش، بانک کامل و سازگار همان نسخهٔ برنامه لازم است.", "بخش با بانک فعلی سازگار نیست", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        return true;
    }
}
