using System.Globalization;

namespace FreeSms.Core;

public sealed class WorkbookStudentEntry
{
    public long Code { get; private init; }
    public int Grade { get; private init; }
    public string ClassName { get; private init; } = "";
    public string FirstName { get; private init; } = "";
    public string Family { get; private init; } = "";
    public string Father { get; private init; } = "";
    public string MobileFather { get; private init; } = "";
    public string MobileMother { get; private init; } = "";
    public int Gender { get; private init; }
    public int? NumberAsas { get; private init; }
    public int? Sort { get; private init; }
    public int BaseFee { get; private init; }
    public int Total { get; private init; }
    public int Discount { get; private init; }
    public IReadOnlyList<int> Fees { get; private init; } = Array.Empty<int>();
    public int Payment { get; private init; }
    public int Entrance { get; private init; }
    public int Exam { get; private init; }
    public int Uniform { get; private init; }
    private WorkbookStudentEntry() { }

    public static WorkbookStudentEntry Create(Record row, int discount)
    {
        int Required(string name) => Values.Number(row.Value(name), 0) ?? throw new ValidationException("فیلد «"+name+"» خالی است.");
        string Text(string name, int limit)
        {
            string value=Values.Text(row.Value(name));
            if(value.Length>limit)throw new ValidationException("فیلد «"+name+"» بیش از حد طولانی است.");
            return value;
        }
        int grade=Values.Number(row.Value("paye"),0,12) ?? throw new ValidationException("پایهٔ تحصیلی خالی است.");
        string classroom=Text("class",4000);
        if(classroom.Length==0)throw new ValidationException("عنوان صنف خالی است.");
        int baseFee=Required("mainfees"),monthly=Required("stdfees"),total=Required("stdfeeskoll");
        bool full=total==9L*baseFee;
        if(!full && discount<=0)throw new ValidationException("برای فیس متفاوت از فیس اصلی، تخفیف را انتخاب کنید.");
        if(discount>short.MaxValue)throw new ValidationException("تخفیف معتبر نیست.");
        int[] fees=new int[9];
        if(full)Array.Fill(fees,baseFee);
        else
        {
            int remaining=total;
            for(int i=0;i<8;i++){fees[i]=Math.Min(remaining,monthly);remaining-=fees[i];}
            fees[8]=remaining;
        }
        return new WorkbookStudentEntry
        {
            Code=Values.LongNumber(row.Value("code"),1) ?? throw new ValidationException("کد متعلم خالی است."),
            Grade=grade==0?100:grade,ClassName=classroom,
            FirstName=Text("name",100),Family=Text("family",100),Father=Text("father",100),
            MobileFather=Text("mobilefather",11),MobileMother=Text("mobilemother",11),
            Gender=Values.Number(row.Value("jens"),0,1) ?? -1,
            NumberAsas=Values.Number(row.Value("numberasas"),0),Sort=Values.Number(row.Value("sort"),0),
            BaseFee=baseFee,Total=total,Discount=full?0:discount,Fees=Array.AsReadOnly(fees),
            Payment=Values.Number(row.Value("payment"),0) ?? 0,Entrance=Values.Number(row.Value("dakhele"),0) ?? 0,
            Exam=Values.Number(row.Value("exam"),0) ?? 0,Uniform=Values.Number(row.Value("uniform"),0) ?? 0
        };
    }
}

public sealed record WorkbookPaymentDate(string Text, string Weekday)
{
    public static WorkbookPaymentDate Parse(string text)
    {
        string[] parts=Values.Text(text).Split('/');
        try
        {
            if(parts.Length!=3 || parts[0].Length!=4 || parts[1].Length!=2 || parts[2].Length!=2)throw new ArgumentException();
            int year=Values.Number(parts[0],1000,9999) ?? 0,month=Values.Number(parts[1],1,12) ?? 0,day=Values.Number(parts[2],1,31) ?? 0;
            var calendar=new PersianCalendar();var date=calendar.ToDateTime(year,month,day,0,0,0,0);
            if(calendar.GetYear(date)!=year || calendar.GetMonth(date)!=month || calendar.GetDayOfMonth(date)!=day)throw new ArgumentException();
            string weekday=date.DayOfWeek switch{DayOfWeek.Saturday=>"شنبه",DayOfWeek.Sunday=>"یکشنبه",DayOfWeek.Monday=>"دوشنبه",DayOfWeek.Tuesday=>"سه شنبه",DayOfWeek.Wednesday=>"چهارشنبه",DayOfWeek.Thursday=>"پنج شنبه",_=>"جمعه"};
            return new(FormattableString.Invariant($"{year:0000}/{month:00}/{day:00}"),weekday);
        }
        catch(Exception error) when(error is ArgumentException or ValidationException or OverflowException)
        {throw new ValidationException("تاریخ پرداخت اشتباه است");}
    }
}

public sealed class WorkbookStudents(Database database)
{
    public int Save(int year,int user,IReadOnlyCollection<int> allowedGrades,string paymentDate,string insertedAt,IReadOnlyList<WorkbookStudentEntry> entries)
    {
        if(year is <1000 or >9999 || user<=0 || allowedGrades.Count==0)throw new ValidationException("سال یا مجوز ثبت شاگردان معتبر نیست.");
        var date=WorkbookPaymentDate.Parse(paymentDate);
        if(insertedAt.Length>20)throw new ValidationException("زمان ثبت معتبر نیست.");
        if(entries.Select(e=>e.Code).Distinct().Count()!=entries.Count)throw new ValidationException("کد متعلم در فایل تکراری است.");
        var numbers=entries.Where(e=>e.NumberAsas.HasValue).Select(e=>e.NumberAsas).ToArray();
        if(numbers.Distinct().Count()!=numbers.Length)throw new ValidationException("نمبر اساس در فایل تکراری است.");
        if(entries.Count==0)return 0;
        var grades=allowedGrades.ToHashSet();
        return database.Transaction((connection,transaction)=>
        {
            int classLimit=Convert.ToInt32(database.Scalar("SELECT COL_LENGTH('dbo.tClass','name')/2",null,connection,transaction));
            foreach(var entry in entries)
            {
                if(!grades.Contains(entry.Grade))throw new ValidationException("مجوز ثبت شاگردان این پایه را ندارید: "+entry.Grade);
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tPaye WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0",[entry.Grade],connection,transaction))!=1)
                    throw new ValidationException("پایهٔ تحصیلی در بانک موجود نیست.");
                if(entry.ClassName.Length>classLimit)throw new ValidationException("عنوان صنف بیش از حد طولانی است.");
                if(entry.Discount!=0 && Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tTakhfif WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0",[entry.Discount],connection,transaction))!=1)
                    throw new ValidationException("تخفیف انتخاب‌شده موجود نیست.");
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tStudent WITH(UPDLOCK,HOLDLOCK) WHERE Code=@p0",[entry.Code],connection,transaction))!=0)
                    throw new ValidationException("کد متعلم تکراری است.");
                if(entry.NumberAsas.HasValue && Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tStudent WITH(UPDLOCK,HOLDLOCK) WHERE NumberAsas=@p0",[entry.NumberAsas],connection,transaction))!=0)
                    throw new ValidationException("نمبر اساس تکراری است.");
                var classes=database.Query("SELECT id FROM tClass WITH(UPDLOCK,HOLDLOCK) WHERE xYear=@p0 AND xPaye=@p1 AND name=@p2",[year,entry.Grade,entry.ClassName],connection,transaction);
                if(classes.Count>1)throw new ValidationException("عنوان صنف در همین سال و پایه تکراری است.");
                int classroom=classes.Count==1?classes[0].Int("id"):Convert.ToInt32(database.Scalar("INSERT INTO tClass(xYear,name,xPaye,fee) OUTPUT INSERTED.id VALUES(@p0,@p1,@p2,@p3)",[year,entry.ClassName,entry.Grade,entry.BaseFee],connection,transaction));
                var inputs=new Record
                {
                    ["xYear"]=year,["xPaye"]=entry.Grade,["xClass"]=classroom,["Code"]=entry.Code,
                    ["FName"]=entry.FirstName,["LName"]=entry.Family,["PName"]=entry.Father,["MobileFather"]=entry.MobileFather,["MobileMother"]=entry.MobileMother,
                    ["Jens"]=entry.Gender,["NumberAsas"]=entry.NumberAsas,["Sort"]=entry.Sort,["RegDate"]=year.ToString(CultureInfo.InvariantCulture)+"/01/01",
                    ["SumFee"]=entry.Total,["xTakhfif"]=entry.Discount
                };
                for(int i=0;i<9;i++)inputs["Fee"+(i+1)]=entry.Fees[i];
                int student=database.Call("sp_tStudent_insert_FromXls",inputs,connection,transaction).Output.Int("CodeOut");
                if(student==-100)throw new ValidationException("کد متعلم تکراری است.");
                if(student==-200)throw new ValidationException("نمبر اساس تکراری است.");
                if(student<=0 || Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id WHERE s.id=@p0 AND s.Code=@p1 AND y.xYear=@p2 AND y.xPaye=@p3 AND y.xClass=@p4",[student,entry.Code,year,entry.Grade,classroom],connection,transaction))!=1)
                    throw new ValidationException("ثبت شاگرد در بانک تأیید نشد؛ هیچ ردیفی ذخیره نشد.");
                if(entry.Payment!=0 || entry.Entrance!=0 || entry.Exam!=0 || entry.Uniform!=0)
                    database.Call("sp_tPaymentStudent_insertFromXls",new Record
                    {
                        ["xYear"]=year,["xStudent"]=student,["PaynemtDate"]=date.Text,["dayOfWeek"]=date.Weekday,
                        ["Fee"]=entry.Payment,["Exam"]=entry.Exam,["uniform"]=entry.Uniform,["dakhle"]=entry.Entrance,["Date"]=insertedAt,["xUser"]=user
                    },connection,transaction);
            }
            return entries.Count;
        });
    }
}
