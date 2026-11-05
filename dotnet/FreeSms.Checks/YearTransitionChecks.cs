using FreeSms.Core;

internal static class YearTransitionChecks
{
    internal static void Verify(Action<string,Action> check)
    {
        Record Input()=>new(){["Fee1"]="۱۲۳",["transport1"]=DBNull.Value,["xTakhfif"]=0,["codeTakhfif"]=701,["shaghe"]=true,["hazer"]=false,["mali"]=DBNull.Value};
        check("New-year input preserves Persian amounts, null versus zero transport, nullable flags and immutable captured values",()=>
        {
            var input=Input();var first=YearTransitionEntry.Create(1,input);
            input["Fee1"]=0;input["shaghe"]=false;input["transport1"]=0;
            var second=YearTransitionEntry.Create(2,input);
            if(first.Fee!=123 || first.Transport!=null || first.Flags["shaghe"]!=true || first.Flags["hazer"]!=false || first.Flags["mali"]!=null || first.DiscountCode!=701
                || second.Fee!=0 || second.Transport!=0 || second.Flags["shaghe"]!=false)throw new Exception("New-year captured values changed.");
        });
        check("New-year amounts reject negatives, fractions and nine-month overflow before a batch can write",()=>
        {
            var valid=Input();valid["Fee1"]=int.MaxValue/9;valid["transport1"]=int.MaxValue/9;
            var maximum=YearTransitionEntry.Create(1,valid);
            if((long)maximum.Fee*9>int.MaxValue)throw new Exception("Invalid fee boundary.");
            foreach(var bad in new (string,object)[]{("Fee1",-1),("Fee1","1.5"),("Fee1",238609295),("transport1",-1),("transport1","1.5"),("transport1",238609295),("xTakhfif",32768),("hazer",2)})
            {
                var row=Input();row[bad.Item1]=bad.Item2;
                try{YearTransitionEntry.Create(1,row);}catch(ValidationException){continue;}
                throw new Exception("Accepted invalid new-year value: "+bad.Item1);
            }
        });
    }
}
