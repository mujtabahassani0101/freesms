using System;
using System.Data;
using System.IO;
using System.Linq;
using FreeSms.Core;
using Microsoft.Data.SqlClient;

// Preserve original parameters and duplicate error codes, with one transaction for the
// student, enrolment, grade-dependent marks and optional replacement photo.
internal static class OriginalStudentSave
{
    internal static int Save(SqlParameter[] parameters,string photoPath)
    {
        var data=new Record();
        foreach(var parameter in parameters.Skip(1))data[parameter.ParameterName.TrimStart('@')]=parameter.Value is DBNull?null:parameter.Value;
        int id=Convert.ToInt32(data["id"]),year=Convert.ToInt32(data["xYear"]),grade=Convert.ToInt32(data["xpaye"]),classroom=Convert.ToInt32(data["xClass"]);
        foreach(var pair in new[]{("Fee","SumFee"),("transport","Sumtransport")})
        {
            long sum=0;
            for(int index=1;index<=9;index++)
            {
                int? amount=Values.Number(data[pair.Item1+index],0);
                data[pair.Item1+index]=amount;sum+=amount??0;
            }
            if(sum>int.MaxValue)throw new ValidationException("مجموع مبلغ فیس یا ترانسپورت خارج از محدودهٔ مجاز است");
            data[pair.Item2]=(int)sum;
        }
        byte[] photo=null;
        if(!string.IsNullOrEmpty(photoPath))
        {
            photo=File.ReadAllBytes(photoPath);
            if(photo.Length==0 || photo.Length>102400)throw new ValidationException("عکس باید دارای محتوا و حداکثر ۱۰۰ کیلوبایت باشد");
        }
        var database=new Database(OriginalRuntime.ConnectionString);
        int code=database.Transaction((connection,transaction)=>
        {
            if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tClass WHERE id=@p0 AND xYear=@p1 AND xpaye=@p2",new object[]{classroom,year,grade},connection,transaction))!=1)
                throw new ValidationException("صنف با پایه و سال تعلیمی انتخاب‌شده مطابقت ندارد");
            object oldGrade=id>0?database.Scalar("SELECT xPaye FROM tYear_Student WHERE xStudent=@p0 AND xYear=@p1",new object[]{id,year},connection,transaction):null;
            if(id>0 && oldGrade==null)throw new ValidationException("رکورد شاگرد در سال تعلیمی انتخاب‌شده یافت نشد");
            var exams=oldGrade!=null && Convert.ToInt32(oldGrade)!=grade
                ?database.Query("SELECT DISTINCT m.Xtest FROM tMark m JOIN tBook b ON b.id=m.xbook JOIN tExam e ON e.id=m.Xtest WHERE m.xStudent=@p0 AND b.xPaye=@p1 AND e.xYear=@p2",new object[]{id,oldGrade,year},connection,transaction)
                :new System.Collections.Generic.List<Record>();
            object output=database.Call("sp_tStudent_insertUpdate",data,connection,transaction).Output["CodeOut"];
            int result=output==null || output is DBNull?0:Convert.ToInt32(output);
            if(result<0)return result;
            // The recovered procedure assigns CodeOut for inserts/duplicates only.
            int saved=id>0?id:result;
            if(saved<=0)throw new ValidationException("شناسهٔ شاگرد از بانک دریافت نشد");
            foreach(var exam in exams)
            {
                database.Execute("DELETE FROM tMark WHERE xStudent=@p0 AND Xtest=@p1",new object[]{saved,exam["Xtest"]},connection,transaction);
                database.Execute("DELETE FROM tMarkDoreh WHERE xStudent=@p0 AND Xtest=@p1",new object[]{saved,exam["Xtest"]},connection,transaction);
            }
            if(photo!=null)database.Call("sp_tStudentImg_InsertUpdate",new Record{["id"]=saved,["img"]=photo},connection,transaction);
            database.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0",new object[]{year},connection,transaction);
            return saved;
        });
        parameters[0].Value=code;
        return code;
    }
}
