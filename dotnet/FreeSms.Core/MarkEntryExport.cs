namespace FreeSms.Core;

public sealed record MarkEntryExportSheet(int ClassId,string ClassName,IReadOnlyList<Record> Rows);

public sealed class MarkEntryExport(Database database)
{
    public IReadOnlyList<MarkEntryExportSheet> Read(int year,int grade,IReadOnlyCollection<int> allowedGrades,IReadOnlyList<int> classrooms,IReadOnlyList<int> subjects)
    {
        if(year is <1000 or >9999 || !allowedGrades.Contains(grade))throw new ValidationException("سال، پایه یا مجوز دریافت فایل معتبر نیست.");
        if(classrooms.Count==0)throw new ValidationException("هیچ صنفی انتخاب نشده است");
        if(subjects.Count==0)throw new ValidationException("هیچ درسی انتخاب نشده است");
        if(classrooms.Any(id=>id<=0) || subjects.Any(id=>id<=0) || classrooms.Distinct().Count()!=classrooms.Count || subjects.Distinct().Count()!=subjects.Count)
            throw new ValidationException("فهرست صنف یا مضمون معتبر نیست.");
        if(classrooms.Count>1000 || subjects.Count>1000)throw new ValidationException("تعداد انتخاب‌ها بیش از حد مجاز است.");
        return database.Transaction((connection,transaction)=>
        {
            foreach(int subject in subjects)
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook WITH(HOLDLOCK) WHERE id=@p0 AND xPaye=@p1",[subject,grade],connection,transaction))!=1)
                    throw new ValidationException("مضمون انتخاب‌شده با پایه مطابقت ندارد؛ فهرست را تازه کنید.");
            var sheets=new List<MarkEntryExportSheet>();
            foreach(int classroom in classrooms)
            {
                var classes=database.Query("SELECT name FROM tClass WITH(HOLDLOCK) WHERE id=@p0 AND xYear=@p1 AND xPaye=@p2",[classroom,year,grade],connection,transaction);
                if(classes.Count!=1)throw new ValidationException("صنف انتخاب‌شده با سال و پایه مطابقت ندارد؛ فهرست را تازه کنید.");
                // The recovered query emits six columns; the original Mark.xls
                // contributes the seventh, empty mark column for later import.
                var args=new List<object?>{year,classroom,grade};args.AddRange(subjects.Cast<object?>());
                string selected=string.Join(',',Enumerable.Range(3,subjects.Count).Select(i=>"@p"+i));
                var rows=database.Query("SELECT y.sort,s.Code,b.codeDars,s.FName,s.LName,b.Name AS Subject FROM tYear_Student y WITH(HOLDLOCK) JOIN tStudent s WITH(HOLDLOCK) ON s.id=y.xStudent CROSS JOIN tBook b WITH(HOLDLOCK) WHERE y.xYear=@p0 AND y.xClass=@p1 AND y.xPaye=@p2 AND b.xPaye=@p2 AND b.id IN("+selected+") ORDER BY b.sort,b.id,y.sort,s.LName,s.FName",args.ToArray(),connection,transaction);
                if(rows.Count>1_048_575)throw new ValidationException("تعداد ردیف‌ها از ظرفیت فایل اکسل بیشتر است.");
                if(rows.Count!=0)sheets.Add(new(classroom,classes[0].Text("name"),rows));
            }
            return (IReadOnlyList<MarkEntryExportSheet>)sheets;
        });
    }
}
