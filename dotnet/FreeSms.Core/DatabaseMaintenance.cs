using System.Data;
using Microsoft.Data.SqlClient;

namespace FreeSms.Core;

public enum RestorePhase { ValidatingBackup, CreatingSafetyBackup, ReplacingDatabase, RecoveringSafetyBackup, Complete }
public sealed record RestoreResult(string SafetyBackupPath);

/// <summary>Backs up the configured catalog and validates a restored copy before replacing it.</summary>
public sealed class DatabaseMaintenance(Database database, string? migrationRoot = null)
{
    private string Catalog => new SqlConnectionStringBuilder(database.ConnectionString).InitialCatalog;
    private static string Quote(string identifier) => "[" + identifier.Replace("]", "]]") + "]";
    private static string Literal(string value) => "N'" + value.Replace("'", "''") + "'";
    public bool IsLocalServer() => string.Equals(Convert.ToString(database.Scalar("SELECT SERVERPROPERTY('MachineName')")), Environment.MachineName, StringComparison.OrdinalIgnoreCase);
    private void ValidateCatalog(SqlConnection master)
    {
        int id = Convert.ToInt32(database.Scalar("SELECT DB_ID(@p0)", [Catalog], master));
        if (id <= 4) throw new ValidationException("بانک اطلاعاتی برنامه برای این عملیات مشخص نشده است.");
    }
    private int Execute(SqlConnection connection, string text, params object?[] values)
    {
        using var command = new SqlCommand(text,connection) {CommandTimeout=300};
        for(int i=0;i<values.Length;i++) command.Parameters.AddWithValue("@p"+i,values[i]??DBNull.Value);
        return command.ExecuteNonQuery();
    }
    private DataTable Read(SqlConnection connection,string text,params object?[] values)
    {
        using var command = new SqlCommand(text,connection) {CommandTimeout=300};
        for(int i=0;i<values.Length;i++) command.Parameters.AddWithValue("@p"+i,values[i]??DBNull.Value);
        using var reader = command.ExecuteReader(); var table=new DataTable();table.Load(reader);return table;
    }
    private static string FilePath(string path)
    {
        if (string.IsNullOrWhiteSpace(path)) throw new ValidationException("مسیر فایل را مشخص کنید.");
        return Path.GetFullPath(path.Trim());
    }
    public void Backup(string path)
    {
        path=FilePath(path);
        using var master=database.Open("master"); ValidateCatalog(master);
        if (IsLocalServer()) Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        // Preserve earlier backup sets when the selected media file already exists.
        // Restore chooses the latest complete full set rather than silently reading set1.
        Execute(master,"BACKUP DATABASE "+Quote(Catalog)+" TO DISK=@p0 WITH COPY_ONLY,CHECKSUM,NOINIT",path);
        int position=FullBackupSet(master,path);
        Execute(master,"RESTORE VERIFYONLY FROM DISK=@p0 WITH FILE=@p1",path,position);
    }
    private int FullBackupSet(SqlConnection master,string path)
    {
        var headers=Read(master,"RESTORE HEADERONLY FROM DISK=@p0",path);
        var valid=headers.Rows.Cast<DataRow>().Where(row=>Convert.ToInt32(row["BackupType"])==1
            && row["BackupFinishDate"]!=DBNull.Value
            && (!headers.Columns.Contains("IsDamaged") || row["IsDamaged"]==DBNull.Value || !Convert.ToBoolean(row["IsDamaged"])))
            .OrderByDescending(row=>Convert.ToInt32(row["Position"])).FirstOrDefault();
        if(valid==null)throw new ValidationException("فایل، نسخهٔ پشتیبان کامل و سالم بانک نیست.");
        return Convert.ToInt32(valid["Position"]);
    }
    private sealed record DbFile(string Logical,string Kind,string Physical);
    private List<DbFile> BackupFiles(SqlConnection master,string path,int set)
    {
        var table=Read(master,"RESTORE FILELISTONLY FROM DISK=@p0 WITH FILE=@p1",path,set);
        var files=table.Rows.Cast<DataRow>().Select(row=>new DbFile(Convert.ToString(row["LogicalName"])!,Convert.ToString(row["Type"])!,Convert.ToString(row["PhysicalName"])!)).ToList();
        if(files.Count==0 || files.Any(file=>file.Kind!="D" && file.Kind!="L"))
            throw new ValidationException("ساختار فایل‌های این نسخهٔ پشتیبان پشتیبانی نمی‌شود.");
        return files;
    }
    private void RestoreCopy(SqlConnection master,string name,string path,int set,IReadOnlyList<DbFile> files)
    {
        string moves=string.Join(",",files.Select(file=>"MOVE "+Literal(file.Logical)+" TO "+Literal(file.Physical)));
        Execute(master,"RESTORE DATABASE "+Quote(name)+" FROM DISK=@p0 WITH FILE=@p1,RECOVERY,REPLACE,"+moves,path,set);
    }
    public RestoreResult Restore(string path,IProgress<RestorePhase>? progress=null)
    {
        path=FilePath(path);
        if(!IsLocalServer())throw new ValidationException("بازگردانی باید روی کمپیوتر میزبان بانک انجام شود.");
        if(!File.Exists(path))throw new ValidationException("فایل پشتیبان پیدا نشد.");
        using var master=database.Open("master");ValidateCatalog(master);
        progress?.Report(RestorePhase.ValidatingBackup);
        int set=FullBackupSet(master,path);
        Execute(master,"RESTORE VERIFYONLY FROM DISK=@p0 WITH FILE=@p1",path,set);
        var source=BackupFiles(master,path,set);
        var current=Read(master,"SELECT name,type,physical_name FROM sys.master_files WHERE database_id=DB_ID(@p0) ORDER BY file_id",Catalog)
            .Rows.Cast<DataRow>().Select(row=>new DbFile(Convert.ToString(row["name"])!,Convert.ToInt32(row["type"])==0?"D":"L",Convert.ToString(row["physical_name"])!)).ToList();
        // Only map matching data/log layouts; never restore to paths stored in an unrelated backup.
        if(source.Count!=current.Count || source.GroupBy(f=>f.Kind).Any(group=>current.Count(f=>f.Kind==group.Key)!=group.Count()))
            throw new ValidationException("تعداد و نوع فایل‌های نسخهٔ پشتیبان با بانک فعلی یکسان نیست.");
        var mapped=new List<DbFile>();
        foreach(string kind in new[]{"D","L"})
        {
            var originals=current.Where(f=>f.Kind==kind).ToArray();var backups=source.Where(f=>f.Kind==kind).ToArray();
            for(int i=0;i<backups.Length;i++) mapped.Add(backups[i] with {Physical=originals[i].Physical});
        }
        string nonce=Guid.NewGuid().ToString("N"),stage="FreeSmsRestoreCheck_"+nonce;
        var staged=source.Select((file,i)=>file with {Physical=Path.Combine(Path.GetDirectoryName(current.First(f=>f.Kind==file.Kind).Physical)!,stage+"_"+i+(file.Kind=="L"?".ldf":".mdf"))}).ToArray();
        try
        {
            RestoreCopy(master,stage,path,set,staged);
            var builder=new SqlConnectionStringBuilder(database.ConnectionString){InitialCatalog=stage,Pooling=false};
            var candidate=new Database(builder.ConnectionString);
            using(var connection=candidate.Open())
                foreach(var contract in new[]{("tStudent","Code"),("tYear_Student","xYear"),("tUser","pwd"),("tParmetr","sch"),("tDefYear","xYear"),("tExam","term"),("tVer","ver")})
                    if(candidate.Scalar("SELECT COL_LENGTH(@p0,@p1)",[contract.Item1,contract.Item2],connection)==null)
                        throw new ValidationException("نسخهٔ پشتیبان، ساختار بانک این برنامه را ندارد.");
            Migrations.Apply(candidate,migrationRoot??AppContext.BaseDirectory);
            foreach(string table in new[] {"tBook", "tCardProperties", "tCity", "tClass", "tComnentKarname", "tComnentStd", "tCon", "tDefYear", "tDriver", "tEnzebat", "tExam", "tExportRpt", "tFormColor", "tHazeriAgo", "tHozeh", "tItem", "tItemSabtenamEnable", "tListField", "tMaghta", "tMark", "tMarkAgo", "tMarkDoreh", "tmpStdforPrint", "tmpStdforPrintSarbarg", "tOstan", "tParmetr", "tParmetrBalance", "tPaye", "tPaymentStudent", "tReshteh", "tRpt", "tRptAFLsit", "tRptChart", "tRptDynamic", "tRptLable", "tRptPayment", "tSchool", "tStudent", "tStudentImg", "tTakhfif", "tTch_Cls", "tTeacher", "tTelegramConfig", "tTelegramId", "tTelegramMessage", "tTelegramTypeMessage", "tTosif", "tuser", "tVer", "tYear_Student", "tYearMaghtaCountDay"})
                if(candidate.Scalar("SELECT OBJECT_ID(@p0,N'U')",["dbo."+table])==null)
                    throw new ValidationException("نسخهٔ پشتیبان، جدول لازم برنامه را ندارد: "+table);
        }
        finally
        {
            if(database.Scalar("SELECT DB_ID(@p0)",[stage],master)!=null)
                Execute(master,"ALTER DATABASE "+Quote(stage)+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE "+Quote(stage));
            // SQL drops the staging files; also remove only uniquely named remnants.
            foreach(var file in staged) if(File.Exists(file.Physical)) File.Delete(file.Physical);
        }
        progress?.Report(RestorePhase.CreatingSafetyBackup);
        string safety=Path.Combine(Path.GetDirectoryName(current.First(f=>f.Kind=="D").Physical)!,"FreeSms-before-restore-"+nonce+".bak");
        Backup(safety);
        int safetySet=FullBackupSet(master,safety);
        var safetyFiles=BackupFiles(master,safety,safetySet);
        bool exclusive=false;
        Exception? operationError=null;
        try
        {
            SqlConnection.ClearAllPools();
            Execute(master,"ALTER DATABASE "+Quote(Catalog)+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE");exclusive=true;
            progress?.Report(RestorePhase.ReplacingDatabase);
            RestoreCopy(master,Catalog,path,set,mapped);
        }
        catch(Exception failure)
        {
            operationError=failure;
            if(exclusive)
            {
                try
                {
                    progress?.Report(RestorePhase.RecoveringSafetyBackup);
                    RestoreCopy(master,Catalog,safety,safetySet,safetyFiles);
                }
                catch(Exception recovery) {operationError=new AggregateException("بازگردانی تکمیل نشد. نسخهٔ پیشین بانک در این مسیر محفوظ است: "+safety,failure,recovery);}
            }
        }
        try {if(exclusive) Execute(master,"ALTER DATABASE "+Quote(Catalog)+" SET MULTI_USER");}
        catch(Exception accessError) {operationError=operationError==null?accessError:new AggregateException("بانک به حالت عادی بازنگشت. نسخهٔ پیشین: "+safety,operationError,accessError);}
        finally {SqlConnection.ClearAllPools();}
        if(operationError!=null)System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(operationError).Throw();
        progress?.Report(RestorePhase.Complete);
        return new RestoreResult(safety);
    }
}
