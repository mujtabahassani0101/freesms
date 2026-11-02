alter FUNCTION ReturnSen(@xStdtunt int,@DateForPrint nvarchar(10))
RETURNS Int  with encryption 
AS
BEGIN
declare @Sen int

declare @BDate nvarchar(10)
declare @xYearBDate int
declare @xYearDateForPrint int
declare @xMoonBDate int
declare @xMoonDateForPrint int

select @BDate=bDate from tstudent where id=@xStdtunt

if len(@BDate)=10
begin

  if isnumeric(substring(@BDate,1,4)) = 0
    return null
   if isnumeric(substring(@BDate,6,2)) = 0
    return null

  set @xYearBDate=cast(substring(@BDate,1,4) as int)
  set @xYearDateForPrint=cast(substring(@DateForPrint,1,4) as int)
  set @xMoonBDate=cast(substring(@BDate,6,2) as int)
  set @xMoonDateForPrint=cast(substring(@DateForPrint,6,2) as int)
  
if(@xMoonDateForPrint=12 and @xMoonBDate=1)
 set @xYearDateForPrint=@xYearDateForPrint+1

 set @Sen=@xYearDateForPrint-@xYearBDate
   

end
else
 set @Sen=null



return  @Sen

end