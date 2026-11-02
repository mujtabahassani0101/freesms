
CREATE FUNCTION dbo.CountA
(
	@xStudent int,@xtest int ,@xbook int
)  
RETURNS Int with encryption 
AS  
BEGIN 
declare  @A int
set @A=0
declare  @M1 int
declare  @M2 int
declare  @M3 int
declare  @M4 int
declare  @M5 int

select @M1=M1, @M2=M2, @M3=M3, @M4=M4, @M5=M5 from tmark where xtest= @xtest and xStudent=@xStudent and xbook=@xbook
if(@M1=-1)
 set @A=@A+1
if(@M2=-1)
 set @A=@A+1
if(@M3=-1)
 set @A=@A+1
if(@M4=-1)
 set @A=@A+1
if(@M5=-1)
 set @A=@A+1

Return @A
END


