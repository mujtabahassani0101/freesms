using System.Collections.ObjectModel;

namespace FreeSms.Core;

public sealed class YearTransitionEntry
{
    public static IReadOnlyList<string> FlagNames { get; } = Array.AsReadOnly(new[]{"shaghe","hazer","mali","dakhle","uniform","komakdarsi","ketab","transport","robotic","maghnae"});
    public int Student { get; private init; }
    public int Fee { get; private init; }
    public int? Transport { get; private init; }
    public int Discount { get; private init; }
    public int? DiscountCode { get; private init; }
    public IReadOnlyDictionary<string,bool?> Flags { get; private init; } = new ReadOnlyDictionary<string,bool?>(new Dictionary<string,bool?>());
    private YearTransitionEntry() { }
    public static YearTransitionEntry Create(int student,Record row)
    {
        if(student<=0)throw new ValidationException("شاگرد معتبر نیست.");
        var flags=new Dictionary<string,bool?>(StringComparer.OrdinalIgnoreCase);
        foreach(string name in FlagNames)
        {
            object? value=row.Value(name);
            flags[name]=value is null or DBNull?null:value is bool flag?flag:bool.TryParse(Values.Text(value),out bool parsed)?parsed:Values.Number(value,0,1) is int number?number!=0:null;
        }
        return new YearTransitionEntry
        {
            Student=student,Fee=Values.Number(row.Value("Fee1"),0,int.MaxValue/9) ?? throw new ValidationException("مبلغ فیس را وارد کنید"),
            Transport=Values.Number(row.Value("transport1"),0,int.MaxValue/9),
            Discount=Values.Number(row.Value("xTakhfif"),0,short.MaxValue) ?? 0,
            DiscountCode=Values.Number(row.Value("codeTakhfif")),Flags=new ReadOnlyDictionary<string,bool?>(flags)
        };
    }
}

public sealed class YearTransitions(Database database)
{
    public int Transfer(int user,int sourceYear,int sourceGrade,int sourceClass,int targetYear,int targetGrade,int targetClass,IReadOnlyCollection<int> allowedGrades,IReadOnlyList<YearTransitionEntry> entries)
    {
        if(user!=1)throw new ValidationException("فقط کاربر admin اجازهٔ انتقال سال را دارد.");
        if(sourceYear is <1000 or >9999 || targetYear is <1000 or >9999 || sourceYear>=targetYear)
            throw new ValidationException("سال مبدأ باید پیش از سال مقصد باشد.");
        if(sourceClass<=0 || targetClass<=0 || !allowedGrades.Contains(sourceGrade) || !allowedGrades.Contains(targetGrade))
            throw new ValidationException("صنف، پایه یا مجوز انتقال معتبر نیست.");
        if(entries.Count==0)throw new ValidationException("شاگردی انتخاب نشده است");
        if(entries.Select(entry=>entry.Student).Distinct().Count()!=entries.Count)throw new ValidationException("شاگرد در فهرست انتقال تکراری است.");
        return database.Transaction((connection,transaction)=>
        {
            if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tuser WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0",[user],connection,transaction))!=1)
                throw new ValidationException("حساب کاربر معتبر نیست.");
            var target=database.Query("SELECT fee FROM tClass WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xYear=@p1 AND xPaye=@p2",[targetClass,targetYear,targetGrade],connection,transaction);
            if(target.Count!=1)throw new ValidationException("صنف مقصد با سال و پایه مطابقت ندارد.");
            if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tClass WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xYear=@p1 AND xPaye=@p2",[sourceClass,sourceYear,sourceGrade],connection,transaction))!=1)
                throw new ValidationException("صنف مبدأ با سال و پایه مطابقت ندارد.");
            int fee=Values.Number(target[0].Value("fee"),0) ?? throw new ValidationException("فیس صنف مقصد مشخص نشده است.");
            foreach(var entry in entries)
            {
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student y WITH(UPDLOCK,HOLDLOCK) JOIN tStudent s WITH(UPDLOCK,HOLDLOCK) ON s.id=y.xStudent WHERE y.xStudent=@p0 AND y.xYear=@p1 AND y.xPaye=@p2 AND y.xClass=@p3",[entry.Student,sourceYear,sourceGrade,sourceClass],connection,transaction))!=1)
                    throw new ValidationException("فهرست شاگردان مبدأ تغییر کرده است؛ فهرست را تازه کنید.");
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student WITH(UPDLOCK,HOLDLOCK) WHERE xStudent=@p0 AND xYear=@p1",[entry.Student,targetYear],connection,transaction))!=0)
                    throw new ValidationException("شاگرد قبلاً در سال مقصد ثبت‌نام شده است؛ فهرست را تازه کنید.");
                if(entry.Fee!=fee && entry.Discount==0)throw new ValidationException("برای فیس متفاوت از فیس صنف، تخفیف را انتخاب کنید.");
                if(entry.Discount!=0 && Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tTakhfif WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0",[entry.Discount],connection,transaction))!=1)
                    throw new ValidationException("تخفیف انتخاب‌شده موجود نیست.");
                var inputs=new Record
                {
                    ["xYear"]=targetYear,["xStudent"]=entry.Student,["xPaye"]=targetGrade,["xClass"]=targetClass,
                    ["xTakhfif"]=entry.Discount,["codeTakhfif"]=entry.DiscountCode,["Fee1"]=entry.Fee,["transport1"]=entry.Transport
                };
                foreach(string name in YearTransitionEntry.FlagNames)inputs[name]=entry.Flags[name];
                // Preserve the recovered eighteen-parameter procedure, including
                // nine equal monthly amounts, null transport and omitted Sort.
                database.Call("sp_tYear_Student_Insert",inputs,connection,transaction);
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xStudent=@p0 AND xYear=@p1 AND xPaye=@p2 AND xClass=@p3",[entry.Student,targetYear,targetGrade,targetClass],connection,transaction))!=1)
                    throw new ValidationException("انتقال شاگرد در بانک تأیید نشد.");
            }
            return entries.Count;
        });
    }
}
