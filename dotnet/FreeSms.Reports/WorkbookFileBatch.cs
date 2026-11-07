using System.Security.Cryptography;

namespace FreeSms.Reports;

public sealed record WorkbookFile(string Path,string? PreviousHash,Action<string> Write);

public static class WorkbookFileBatch
{
    public static string? Fingerprint(string path)
    {
        if(!File.Exists(path))return null;
        using var stream=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read);
        return Convert.ToHexString(SHA256.HashData(stream));
    }
    public static void Save(IReadOnlyList<WorkbookFile> files)
    {
        if(files.Select(f=>System.IO.Path.GetFullPath(f.Path)).Distinct(StringComparer.OrdinalIgnoreCase).Count()!=files.Count)
            throw new IOException("دو فایل خروجی نام یکسان دارند.");
        var staged=new List<(WorkbookFile File,string Temp,string Backup)>();
        var replaced=new List<(WorkbookFile File,string Backup)>();
        var installed=new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        try
        {
            foreach(var file in files)
            {
                string suffix=".freesms-"+Guid.NewGuid().ToString("N");string temp=file.Path+suffix+".tmp",backup=file.Path+suffix+".bak";
                staged.Add((file,temp,backup));file.Write(temp);
            }
            foreach(var item in staged)
            {
                if(Fingerprint(item.File.Path)!=item.File.PreviousHash)throw new IOException("فایل خروجی پس از انتخاب تغییر کرده است؛ دوباره تلاش کنید.");
                string outputHash=Fingerprint(item.Temp) ?? throw new IOException("فایل آماده‌شده موجود نیست.");
                if(item.File.PreviousHash!=null)File.Move(item.File.Path,item.Backup);
                replaced.Add((item.File,item.Backup));
                File.Move(item.Temp,item.File.Path); // Never silently overwrite a concurrently created file.
                installed.Add(item.File.Path,outputHash);
            }
        }
        catch(Exception original)
        {
            var failures=new List<Exception>{original};
            foreach(var item in replaced.AsEnumerable().Reverse())
                try
                {
                    // Only destinations reached by this batch are restored.
                    if(installed.TryGetValue(item.File.Path,out string? expected))
                    {
                        if(Fingerprint(item.File.Path)!=expected)throw new IOException("فایل پس از ساخت تغییر کرده است و حذف نشد: "+item.File.Path);
                        File.Delete(item.File.Path);
                    }
                    if(File.Exists(item.Backup))File.Move(item.Backup,item.File.Path);
                }
                catch(Exception recovery) when(recovery is IOException or UnauthorizedAccessException)
                {failures.Add(new IOException("نسخهٔ قبلی در مسیر زیر نگهداری شد: "+item.Backup,recovery));}
            if(failures.Count>1)throw new AggregateException("ذخیره و بازگرداندن فایل‌ها با خطا روبه‌رو شد.",failures);
            throw;
        }
        finally
        {
            foreach(var item in staged)
                try{if(File.Exists(item.Temp))File.Delete(item.Temp);}
                catch(Exception cleanup) when(cleanup is IOException or UnauthorizedAccessException){ }
        }
        // A failed cleanup must not turn a committed, valid workbook into a
        // reported failed export. A remaining backup is safe to retain.
        foreach(var item in replaced)
            try{if(File.Exists(item.Backup))File.Delete(item.Backup);}
            catch(Exception cleanup) when(cleanup is IOException or UnauthorizedAccessException){ }
    }
}
