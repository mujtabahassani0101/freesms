namespace FreeSms.Core;

public sealed record BulkMark(int Student, IndividualMark Mark);

// The recovered bulk form edits one subject for a selected grade/class.
// Its calculation and annual M2 convention are shared with individual entry.
public sealed class BulkMarks(Database database)
{
    public void Save(int year,int grade,int classroom,int exam,int book,IReadOnlyList<BulkMark> entries)
    {
        if(entries.Count==0)return;
        if(entries.Any(entry=>entry.Student<=0 || entry.Mark is null || entry.Mark.Book!=book)
            || entries.Select(entry=>entry.Student).Distinct().Count()!=entries.Count)
            throw new ValidationException("فهرست شاگردان یا مضمون معتبر نیست.");
        database.Transaction((connection,transaction)=>
        {
            var term=database.Scalar("SELECT term FROM tExam WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xYear=@p1",[exam,year],connection,transaction);
            if(term is null || entries.Any(entry=>entry.Mark.Term!=Convert.ToInt32(term))
                || Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xPaye=@p1",[book,grade],connection,transaction))!=1)
                throw new ValidationException("مضمون یا دوره با سال و پایهٔ انتخاب‌شده مطابقت ندارد.");
            foreach(var entry in entries)
            {
                int eligible=Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student WITH(UPDLOCK,HOLDLOCK) WHERE xYear=@p0 AND xStudent=@p1 AND xPaye=@p2 AND (@p3=0 OR xClass=@p3) AND Status IN(1,4) AND (@p4 NOT IN(1,2,3) OR MarkTerm3_From100=CASE WHEN @p4=3 THEN 1 ELSE 0 END)",[year,entry.Student,grade,classroom,term],connection,transaction));
                if(eligible!=1)throw new ValidationException("فهرست شاگردان تغییر کرده است؛ صفحه را دوباره باز کنید.");
                var mark=entry.Mark;
                if(mark.Total is null && mark.Absences is null)
                    database.Execute("DELETE FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",[entry.Student,exam,book],connection,transaction);
                else
                {
                    var values=new Record{["xStudent"]=entry.Student,["Xtest"]=exam,["xbook"]=book,["CountAb"]=mark.Absences,["Mark"]=mark.Total};
                    for(int i=0;i<10;i++)values["M"+(i+1)]=mark.Components[i];
                    database.Call("sp_tMark_insertUpdate",values,connection,transaction);
                }
            }
            database.Execute("UPDATE tExam SET procc=0 WHERE id=@p0",[exam],connection,transaction);
            if(Convert.ToInt32(term) is 1 or 2)
                database.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0 AND term=3",[year],connection,transaction);
            return 0;
        });
    }

    public void SaveOrder(int year,int grade,int classroom,int student,object? value)
    {
        int? order=Values.Number(value,0,short.MaxValue);
        if(order is null)throw new ValidationException("شمارهٔ ترتیب را وارد کنید.");
        database.Transaction((connection,transaction)=>
        {
            int count=Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student WITH(UPDLOCK,HOLDLOCK) WHERE xYear=@p0 AND xPaye=@p1 AND (@p2=0 OR xClass=@p2) AND xStudent=@p3",[year,grade,classroom,student],connection,transaction));
            if(count!=1)throw new ValidationException("ثبت‌نام شاگرد با سال و صنف انتخاب‌شده مطابقت ندارد.");
            database.Execute("UPDATE tYear_Student SET sort=@p0 WHERE xYear=@p1 AND xPaye=@p2 AND xStudent=@p3",[order,year,grade,student],connection,transaction);
            return 0;
        });
    }
}
