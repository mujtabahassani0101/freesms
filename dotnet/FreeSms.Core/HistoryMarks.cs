namespace FreeSms.Core;

public sealed class HistoryMark
{
    public int Book { get; }
    public int? Mark { get; }
    private HistoryMark(int book,int? mark){Book=book;Mark=mark;}
    public static HistoryMark Create(int book,object? value,int minimum=0,int maximum=100)
    {
        if(book<=0 || minimum<0 || maximum<minimum || maximum>100)throw new ValidationException("مضمون یا محدودهٔ نمره معتبر نیست.");
        // The recovered editor is Number0 and its total is an integer sum.
        // Reject fractions instead of rounding them or clearing a pending cell.
        return new(book,Values.Number(value,minimum,maximum));
    }
    public static int Total(IReadOnlyList<HistoryMark> marks)
    {
        long sum=marks.Sum(row=>(long)(row.Mark??0));
        if(sum>int.MaxValue)throw new ValidationException("مجموع نمرات خارج از محدودهٔ مجاز است.");
        return (int)sum;
    }
}

public sealed class HistoryMarks(Database database)
{
    public int Save(int year,int classroom,int student,int historicGrade,IReadOnlyCollection<int> allowedGrades,IReadOnlyList<HistoryMark> marks,int rank)
    {
        if(year is <1000 or >9999 || classroom<=0 || student<=0 || historicGrade is not (10 or 11) || !allowedGrades.Contains(12))
            throw new ValidationException("سال، شاگرد، صنف یا مجوز نمرات گذشته معتبر نیست.");
        if(rank is <0 or >short.MaxValue)throw new ValidationException("رتبه باید عدد صحیح بین ۰ و ۳۲۷۶۷ باشد.");
        if(marks.Count==0 || marks.Select(row=>row.Book).Distinct().Count()!=marks.Count)
            throw new ValidationException("فهرست مضامین خالی یا تکراری است؛ فهرست را تازه کنید.");
        int total=HistoryMark.Total(marks);
        return database.Transaction((connection,transaction)=>
        {
            if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student y WITH(UPDLOCK,HOLDLOCK) JOIN tStudent s WITH(UPDLOCK,HOLDLOCK) ON s.id=y.xStudent JOIN tClass c WITH(UPDLOCK,HOLDLOCK) ON c.id=y.xClass AND c.xYear=y.xYear AND c.xPaye=y.xPaye WHERE y.xYear=@p0 AND y.xClass=@p1 AND y.xStudent=@p2 AND y.xPaye=12",[year,classroom,student],connection,transaction))!=1)
                throw new ValidationException("ثبت‌نام شاگرد یا صنف تغییر کرده است؛ فهرست را تازه کنید.");
            var subjects=database.Query("SELECT id FROM tBook WITH(UPDLOCK,HOLDLOCK) WHERE xPaye=12 AND showOneEntry=1",null,connection,transaction);
            if(!subjects.Select(row=>row.Int("id")).ToHashSet().SetEquals(marks.Select(row=>row.Book)))
                throw new ValidationException("فهرست مضامین تغییر کرده است؛ فهرست را تازه کنید.");
            var aggregates=database.Query("SELECT id FROM tMarkAgo WITH(UPDLOCK,HOLDLOCK) WHERE xStudent=@p0 AND xPaye=@p1 AND typ=5",[student,historicGrade],connection,transaction);
            if(aggregates.Count>1)throw new ValidationException("مجموع نمرات گذشته تکراری است؛ پیش از ذخیره سابقه را اصلاح کنید.");
            foreach(var row in marks)
            {
                var records=database.Query("SELECT id,typ FROM tMarkAgo WITH(UPDLOCK,HOLDLOCK) WHERE xStudent=@p0 AND xPaye=@p1 AND xbook=@p2",[student,historicGrade,row.Book],connection,transaction);
                if(records.Count>1 || records.Any(record=>record.Int("typ")!=1))throw new ValidationException("سابقهٔ مضمون تکراری یا ناسازگار است؛ هیچ نمره‌ای ذخیره نشد.");
                if(row.Mark.HasValue)
                    database.Call("sp_tMarkAgo_insertUpdate",new Record{["xStudent"]=student,["xPaye"]=historicGrade,["xbook"]=row.Book,["Mark"]=row.Mark},connection,transaction);
                else database.Execute("DELETE FROM tMarkAgo WHERE xStudent=@p0 AND xPaye=@p1 AND xbook=@p2 AND typ=1",[student,historicGrade,row.Book],connection,transaction);
            }
            if(total==0)database.Execute("DELETE FROM tMarkAgo WHERE xStudent=@p0 AND xPaye=@p1 AND typ=5",[student,historicGrade],connection,transaction);
            else if(aggregates.Count==0)database.Execute("INSERT INTO tMarkAgo(xStudent,xPaye,typ,xbook,Mark,gClass) VALUES(@p0,@p1,5,-5,@p2,@p3)",[student,historicGrade,total,rank],connection,transaction);
            else database.Execute("UPDATE tMarkAgo SET Mark=@p0,gClass=@p1 WHERE id=@p2",[total,rank,aggregates[0].Int("id")],connection,transaction);
            return total;
        });
    }

    public void SetSubjectOrder(int book,int order,IReadOnlyCollection<int> allowedGrades)
    {
        if(book<=0 || order is <0 or >short.MaxValue || !allowedGrades.Contains(12))throw new ValidationException("ترتیب مضمون باید عدد صحیح بین ۰ و ۳۲۷۶۷ باشد و مجوز پایهٔ دوازدهم لازم است.");
        database.Transaction((connection,transaction)=>
        {
            if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xPaye=12 AND showOneEntry=1",[book],connection,transaction))!=1)
                throw new ValidationException("مضمون تغییر کرده است؛ فهرست را تازه کنید.");
            database.Execute("UPDATE tBook SET SortOneEntry=@p0 WHERE id=@p1",[order,book],connection,transaction);return 0;
        });
    }
}
