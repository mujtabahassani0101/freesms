using FreeSms.Core;

internal static class HistoryMarksChecks
{
    internal static void Verify(Action<string,Action> check)
    {
        check("History marks retain recovered integer sum, Persian digits and distinct blank versus zero values",()=>
        {
            var rows=new[]{HistoryMark.Create(1,"۲۵"),HistoryMark.Create(2,"٣٠"),HistoryMark.Create(3,0),HistoryMark.Create(4,DBNull.Value)};
            if(HistoryMark.Total(rows)!=55 || rows[2].Mark!=0 || rows[3].Mark!=null || HistoryMark.Total(new[]{HistoryMark.Create(1,100),HistoryMark.Create(2,100)})!=200)
                throw new Exception("History marks were averaged, rounded or lost blank/zero semantics.");
        });
        check("History marks reject fractions, overflow, nonfinite, malformed and out-of-range values without rounding",()=>
        {
            foreach(object value in new object[]{"25.5","۲۵٫۵",-1,101,"NaN","Infinity","2147483648","invalid"})
            {try{HistoryMark.Create(1,value);}catch(ValidationException){continue;}throw new Exception("Accepted invalid history mark: "+value);}
            try{HistoryMark.Create(0,10);}catch(ValidationException){return;}throw new Exception("Accepted invalid history subject.");
        });
    }
}
