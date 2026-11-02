alter FUNCTION ReturnMoonBdate(@xStdtunt int)
RETURNS nvarchar(20)  with encryption 
AS
BEGIN
declare @MoonBdate nvarchar(20)

declare @BDate nvarchar(10)
declare @xMoonBDate int


select @BDate=bDate from tstudent where id=@xStdtunt

if len(@BDate)=10
begin

   if isnumeric(substring(@BDate,6,2)) = 0
    return @MoonBdate
	 
   set @xMoonBDate=cast(substring(@BDate,6,2) as int)
   if(@xMoonBDate=1)
     set @MoonBdate=N'حمل'
   else if(@xMoonBDate=2)
     set @MoonBdate=N'ثور'
  else if(@xMoonBDate=3)
     set @MoonBdate=N'جوزا'
  else if(@xMoonBDate=4)
     set @MoonBdate=N'سرطان'
  else if(@xMoonBDate=5)
     set @MoonBdate=N'اسد'
  else if(@xMoonBDate=6)
     set @MoonBdate=N'سنبله'
  else if(@xMoonBDate=7)
     set @MoonBdate=N'ميزان'
  else if(@xMoonBDate=8)
     set @MoonBdate=N'عقرب'
  else if(@xMoonBDate=9)
     set @MoonBdate=N'قوس'
  else if(@xMoonBDate=10)
     set @MoonBdate=N'جدي'
  else if(@xMoonBDate=11)
     set @MoonBdate=N'دلو'
  else if(@xMoonBDate=12)
     set @MoonBdate=N'حوت'


end
else
 set @MoonBdate=null



return  @MoonBdate

end