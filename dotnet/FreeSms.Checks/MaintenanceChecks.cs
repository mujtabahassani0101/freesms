using FreeSms.Core;
using Microsoft.Data.SqlClient;

internal static class MaintenanceChecks
{
    private sealed class InlineProgress(Action<RestorePhase> action):IProgress<RestorePhase> {public void Report(RestorePhase value)=>action(value);}
    internal static void Run(Database db,string root,string directory,Action<string,Action> check)
    {
        static void Require(bool condition,string message) {if(!condition)throw new Exception(message);}
        var maintenance=new DatabaseMaintenance(db,root);
        string folder=Path.Combine(directory,"نسخه ' آزمایشی");Directory.CreateDirectory(folder);
        string backup=Path.Combine(folder,"snapshot ' فارسی.bak");
        db.Execute("CREATE TABLE native_backup_fixture(id int PRIMARY KEY,value nvarchar(100),amount decimal(18,4),photo varbinary(max))");
        db.Execute("INSERT INTO native_backup_fixture VALUES(1,@p0,123.4567,@p1)",["نسخه ' نخست",new byte[]{1,2,3,4}]);
        check("Backup uses configured catalog and quoted Persian path; latest complete appended set restores exact values",()=>
        {
            maintenance.Backup(backup);
            db.Execute("UPDATE native_backup_fixture SET value=@p0,amount=987.6543",["نسخه ' دوم"]);
            maintenance.Backup(backup);
            db.Execute("UPDATE native_backup_fixture SET value=N'پس از پشتیبان',amount=0");
            var restored=maintenance.Restore(backup);
            var row=db.Query("SELECT * FROM native_backup_fixture WHERE id=1").Single();
            Require(row.Text("value")=="نسخه ' دوم" && Convert.ToDecimal(row["amount"])==987.6543m,"Restore selected the wrong backup set or lost exact decimal/text values.");
            Require(((byte[])row["photo"]!).SequenceEqual(new byte[]{1,2,3,4}),"Restore lost binary content.");
            Require(File.Exists(restored.SafetyBackupPath),"Pre-restore safety backup was not retained.");
            Require(Convert.ToString(db.Scalar("SELECT user_access_desc FROM sys.databases WHERE name=DB_NAME()"))=="MULTI_USER","Restore left database access restricted.");
        });
        check("Malformed backup is rejected before modifying live records",()=>
        {
            string bad=Path.Combine(folder,"invalid.bak");File.WriteAllText(bad,"This is not a SQL backup.");
            bool rejected=false;
            try{maintenance.Restore(bad);}catch(SqlException error) when(error.Errors.Cast<SqlError>().Any(e=>e.Number is 3241 or 3013)){rejected=true;}
            Require(rejected && db.Query("SELECT value FROM native_backup_fixture WHERE id=1").Single().Text("value")=="نسخه ' دوم","Bad backup was accepted or altered current data.");
        });
        check("Failure opening input after preflight restores the safety copy and normal access",()=>
        {
            db.Execute("UPDATE native_backup_fixture SET value=N'پیش از خطای ورودی'");
            string moved=backup+".moved";bool recovered=false,rejected=false;
            var progress=new InlineProgress(phase=>
            {
                if(phase==RestorePhase.ReplacingDatabase)File.Move(backup,moved);
                if(phase==RestorePhase.RecoveringSafetyBackup)recovered=true;
            });
            try{maintenance.Restore(backup,progress);}catch(SqlException error) when(error.Errors.Cast<SqlError>().Any(e=>e.Number==3201)){rejected=true;}
            finally{if(File.Exists(moved))File.Move(moved,backup);}
            Require(rejected && recovered,"Restore failure did not attempt safety-copy recovery.");
            Require(db.Query("SELECT value FROM native_backup_fixture WHERE id=1").Single().Text("value")=="پیش از خطای ورودی","Recovery lost the pre-restore value.");
            Require(Convert.ToString(db.Scalar("SELECT user_access_desc FROM sys.databases WHERE name=DB_NAME()"))=="MULTI_USER","Recovery left the bank restricted.");
        });
        check("Structurally incompatible SQL backup is rejected by staged validation",()=>
        {
            string wrong="FreeSmsWrongBackup_"+Guid.NewGuid().ToString("N");
            string literal(string value)=>"N'"+value.Replace("'","''")+"'";
            using var master=db.Open("master");
            db.Execute("CREATE DATABASE ["+wrong+"] ON PRIMARY (NAME=N'wrong_data',FILENAME="+literal(Path.Combine(directory,wrong+".mdf"))+") LOG ON (NAME=N'wrong_log',FILENAME="+literal(Path.Combine(directory,wrong+".ldf"))+")",connection:master);
            try
            {
                var connection=new SqlConnectionStringBuilder(db.ConnectionString){InitialCatalog=wrong};
                string path=Path.Combine(folder,"wrong-schema.bak");new DatabaseMaintenance(new Database(connection.ConnectionString),root).Backup(path);
                bool rejected=false;try{maintenance.Restore(path);}catch(ValidationException){rejected=true;}
                Require(rejected && db.Query("SELECT value FROM native_backup_fixture WHERE id=1").Single().Text("value")=="پیش از خطای ورودی","Incompatible backup replaced valid data.");
            }
            finally{SqlConnection.ClearAllPools();db.Execute("ALTER DATABASE ["+wrong+"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;DROP DATABASE ["+wrong+"]",connection:master);}
        });
        db.Execute("DROP TABLE native_backup_fixture");
    }
}
