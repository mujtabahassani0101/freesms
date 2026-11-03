using System.Globalization;

namespace FreeSms.Core;

// The recovered individual-entry handler averages populated components, except
// term 3, whose displayed M1 is stored as M2 and replaces the total when present.
public sealed class IndividualMark
{
    public int Book { get; }
    public short? Absences { get; }
    public IReadOnlyList<double?> Components { get; }
    public double? Total { get; }
    public int Term { get; }
    private IndividualMark(int book, short? absences, double?[] components, double? total, int term)
    { Book=book; Absences=absences; Components=Array.AsReadOnly(components); Total=total; Term=term; }

    public static double? Number(object? value, int minimum, int maximum)
    {
        if(minimum<0 || maximum<minimum || maximum>short.MaxValue)
            throw new ValidationException("محدودهٔ نمره معتبر نیست.");
        string text=Values.Text(value);
        if(text.Length==0 || value is DBNull)return null;
        const string digits="۰۱۲۳۴۵۶۷۸۹٠١٢٣٤٥٦٧٨٩";
        text=string.Concat(text.Select(c=>digits.IndexOf(c) is var i && i>=0?(char)('0'+i%10):c)).Replace('٫','.');
        if(!double.TryParse(text,NumberStyles.AllowLeadingSign|NumberStyles.AllowDecimalPoint,CultureInfo.InvariantCulture,out double number) || !double.IsFinite(number))
            throw new ValidationException("نمرهٔ عددی معتبر وارد کنید.");
        if(number<minimum || number>maximum)throw new ValidationException("نمره وارد شده خارج از محدوده است");
        return number;
    }

    public static IndividualMark Create(int book, object? absences, IReadOnlyList<object?> values, int minimum, int maximum, int term)
    {
        if(book<=0 || values.Count!=10 || term is <0 or >3)throw new ValidationException("اطلاعات مضمون یا دوره معتبر نیست.");
        var components=values.Select(value=>Number(value,minimum,maximum)).ToArray();
        var count=Values.Number(absences is DBNull?null:absences,0,short.MaxValue);
        int populated=components.Count(value=>value.HasValue);
        double? total=populated==0?null:components.Sum(value=>value??0)/(term==3?1:populated);
        if(term==3)
        {
            if(components[0] is double entered)total=entered;
            components[1]=components[0];components[0]=null;
        }
        return new(book,count is null?null:(short)count,components,total,term);
    }
}

public sealed class IndividualMarks(Database database)
{
    public void Save(int year,int student,int grade,int classroom,int exam,IReadOnlyList<IndividualMark> entries)
    {
        if(entries.Count==0)return;
        if(entries.Select(entry=>entry.Book).Distinct().Count()!=entries.Count)
            throw new ValidationException("مضمون تکراری در فهرست نمره وجود دارد.");
        database.Transaction((connection,transaction)=>
        {
            // Validate the captured selection under the same transaction as all
            // writes, including deletes and invalidation of calculated results.
            int enrolled=Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tYear_Student WITH(UPDLOCK,HOLDLOCK) WHERE xYear=@p0 AND xStudent=@p1 AND xPaye=@p2 AND xClass=@p3",[year,student,grade,classroom],connection,transaction));
            var term=database.Scalar("SELECT term FROM tExam WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xYear=@p1",[exam,year],connection,transaction);
            if(enrolled!=1 || term is null || entries.Any(entry=>entry.Term!=Convert.ToInt32(term)))
                throw new ValidationException("شاگرد، صنف یا دوره با سال انتخاب‌شده مطابقت ندارد.");
            foreach(var entry in entries)
            {
                if(Convert.ToInt32(database.Scalar("SELECT COUNT(*) FROM tBook WITH(UPDLOCK,HOLDLOCK) WHERE id=@p0 AND xPaye=@p1 AND showOneEntry=1",[entry.Book,grade],connection,transaction))!=1)
                    throw new ValidationException("مضمون با پایهٔ انتخاب‌شده مطابقت ندارد.");
                if(entry.Total is null && entry.Absences is null)
                    database.Execute("DELETE FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",[student,exam,entry.Book],connection,transaction);
                else
                {
                    var values=new Record{["xStudent"]=student,["Xtest"]=exam,["xbook"]=entry.Book,["CountAb"]=entry.Absences,["Mark"]=entry.Total};
                    for(int i=0;i<10;i++)values["M"+(i+1)]=entry.Components[i];
                    database.Call("sp_tMark_insertUpdate",values,connection,transaction);
                }
            }
            database.Execute("UPDATE tExam SET procc=0 WHERE id=@p0",[exam],connection,transaction);
            if(Convert.ToInt32(term) is 1 or 2)
                database.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0 AND term=3",[year],connection,transaction);
            return 0;
        });
    }
}
