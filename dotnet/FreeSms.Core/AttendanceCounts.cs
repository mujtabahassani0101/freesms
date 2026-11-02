namespace FreeSms.Core;

public readonly record struct AttendanceCounts(int Present,int Absent,int Sick,int Leave)
{
    public static AttendanceCounts Parse(int days,object? present,object? absent,object? sick,object? leave)
    {
        if(days<=0)throw new ValidationException("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");
        var counts=new AttendanceCounts(Values.Number(present,0,days)??0,Values.Number(absent,0,days)??0,Values.Number(sick,0,days)??0,Values.Number(leave,0,days)??0);
        if((long)counts.Present+counts.Absent+counts.Sick+counts.Leave>days)
            throw new ValidationException("مجموع روزهای حاضر، غیرحاضر، مریض و رخصت از روزهای تعلیمی بیشتر است");
        return counts;
    }
    public static AttendanceCounts FromAbsences(int days,object? absent,object? sick,object? leave)
    {
        var counts=Parse(days,0,absent,sick,leave);
        return counts with{Present=days-counts.Absent-counts.Sick-counts.Leave};
    }
}
