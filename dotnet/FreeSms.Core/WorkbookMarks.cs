using System.Globalization;

namespace FreeSms.Core;

public sealed class WorkbookMarkEntry
{
    public long Code { get; }
    public int CourseCode { get; }
    public double? Mark { get; }
    private WorkbookMarkEntry(long code, int courseCode, double? mark) { Code=code; CourseCode=courseCode; Mark=mark; }
    public static WorkbookMarkEntry Create(object? code, object? courseCode, object? mark, int minimum, int maximum)
    {
        // The recovered import procedure accepts varchar(14), not the student's
        // full BigInt width. Reject overflow explicitly instead of truncating it.
        long parsedCode=Values.LongNumber(code,1,99_999_999_999_999L) ?? throw new ValidationException("کد متعلم خالی است.");
        int parsedCourse=Values.Number(courseCode,1) ?? throw new ValidationException("کد مضمون خالی است.");
        return new(parsedCode,parsedCourse,IndividualMark.Number(mark,minimum,maximum));
    }
}

public sealed class WorkbookMarks(Database database)
{
    public int Save(int year, int exam, int user, IReadOnlyCollection<int> allowedGrades, IReadOnlyList<WorkbookMarkEntry> entries)
    {
        if(year is <1000 or >9999 || exam<=0 || user<=0 || allowedGrades.Count==0)
            throw new ValidationException("سال، دوره یا مجوز ورود نمرات معتبر نیست.");
        if(entries.Select(entry=>(entry.Code,entry.CourseCode)).Distinct().Count()!=entries.Count)
            throw new ValidationException("کد متعلم و مضمون در فایل تکرار شده است؛ ردیف‌های تکراری را اصلاح کنید.");
        var pending=entries.Where(entry=>entry.Mark.HasValue).ToArray();
        if(pending.Length==0)return 0; // The recovered import skips blank marks; they are not a delete command.
        var grades=allowedGrades.ToHashSet();
        return database.Transaction((connection,transaction)=>
        {
            object? term=database.Scalar("SELECT term FROM tExam WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xYear=@p1",[exam,year],connection,transaction);
            if(term is null || Convert.ToInt32(term) is <0 or >2)
                throw new ValidationException("دورهٔ انتخاب‌شده با سال ورود نمرات مطابقت ندارد.");
            foreach(var entry in pending)
            {
                var enrollments=database.Query("SELECT y.xPaye FROM tYear_Student y WITH(UPDLOCK,HOLDLOCK) JOIN tStudent s WITH(UPDLOCK,HOLDLOCK) ON s.id=y.xStudent WHERE y.xYear=@p0 AND s.Code=@p1",[year,entry.Code],connection,transaction);
                if(enrollments.Count!=1)throw new ValidationException("کد متعلم در سال انتخاب‌شده ثبت‌نام معتبر ندارد: "+entry.Code);
                int grade=enrollments[0].Int("xPaye");
                if(!grades.Contains(grade))throw new ValidationException("مجوز ورود نمرات پایهٔ این متعلم را ندارید: "+entry.Code);
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook WITH(UPDLOCK,HOLDLOCK) WHERE CodeDars=@p0 AND xPaye=@p1",[entry.CourseCode,grade],connection,transaction))!=1)
                    throw new ValidationException("کد مضمون با پایهٔ متعلم مطابقت ندارد: "+entry.CourseCode);
                var result=database.Call("sp_tMark_insertUpdate_FromXls_Af",new Record
                {
                    ["xuser"]=user,["code"]=entry.Code.ToString(CultureInfo.InvariantCulture),["codedars"]=entry.CourseCode,["Xtest"]=exam,["xYear"]=year,["Mark"]=entry.Mark
                },connection,transaction);
                string error=result.Output.Text("err");
                if(error.Length!=0)throw new ValidationException(error);
            }
            database.Execute("UPDATE tExam SET procc=0 WHERE id=@p0",[exam],connection,transaction);
            if(Convert.ToInt32(term) is 1 or 2)
                database.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0 AND term=3",[year],connection,transaction);
            return pending.Length;
        });
    }
}
