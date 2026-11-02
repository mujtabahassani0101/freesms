using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeSms.Core;

internal static class OriginalDatabaseMaintenance
{
    private static DatabaseMaintenance Service => new DatabaseMaintenance(new Database(OriginalRuntime.ConnectionString));
    internal static bool IsLocalServer() => Service.IsLocalServer();
    internal static int Backup(string path) {Service.Backup(path);return -1;}
    internal static string NewBackupPath(string prefix="backup")
    {
        string directory=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"free-sms","backups");
        Directory.CreateDirectory(directory);
        return Path.Combine(directory,prefix+"_"+DateTime.Now.ToString("yyyyMMdd_HHmmss")+"_"+Guid.NewGuid().ToString("N").Substring(0,8)+".bak");
    }
    internal static int BackupNamed(string prefix) => Backup(NewBackupPath(prefix));
    private static void Log(Exception error)
    {
        try
        {
            string directory=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"free-sms","logs");Directory.CreateDirectory(directory);
            File.AppendAllText(Path.Combine(directory,"database-maintenance.log"),DateTimeOffset.Now.ToString("O")+Environment.NewLine+error+Environment.NewLine);
        }
        catch(IOException){}catch(UnauthorizedAccessException){}
    }
    internal static async Task<bool> BackupAsync(Form owner,string path)
    {
        owner.Enabled=false;owner.UseWaitCursor=true;
        Exception failure=null;
        try{await Task.Run(()=>Service.Backup(path));}
        catch(Exception error){failure=error;Log(error);}
        finally{if(!owner.IsDisposed){owner.Enabled=true;owner.UseWaitCursor=false;}}
        if(owner.IsDisposed)return false;
        if(failure!=null){MessageBox.Show(owner,"تهیهٔ نسخهٔ پشتیبان انجام نشد:\n"+failure.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);return false;}
        MessageBox.Show(owner,"تهيه نسخه پشتيبان با موفقیت انجام شد","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        return true;
    }
    internal static async Task<bool> RestoreAsync(Form owner,string path)
    {
        owner.Enabled=false;owner.UseWaitCursor=true;Exception failure=null;
        try{await Task.Run(()=>Service.Restore(path));}
        catch(Exception error){failure=error;Log(error);}
        finally{if(!owner.IsDisposed){owner.Enabled=true;owner.UseWaitCursor=false;}}
        if(owner.IsDisposed)return false;
        if(failure!=null){MessageBox.Show(owner,"بازگردانی انجام نشد:\n"+failure.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);return false;}
        MessageBox.Show(owner,"بازگردانی نسخهٔ پشتیبان انجام شد. برنامه را دوباره اجرا کنید.","FreeSMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
        return true;
    }
}
