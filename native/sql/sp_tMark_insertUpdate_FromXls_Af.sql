CREATE Procedure dbo.sp_tMark_insertUpdate_FromXls_Af  
@xuser int,  
@code varchar(14),  
@codedars int,  
@Xtest int,  
@xYear int, 
@Mark float,  
@err nvarchar(100) output  with encryption
as  
declare @xStudent int  
declare @xPaye int  
declare @xbook int  
set @xbook=0  
set @xStudent=0  
select @xStudent=tstudent.id,@xPaye=tyear_student.xpaye from tstudent inner join tyear_student
on  tstudent.id=tyear_student.xstudent where tStudent.code=@code  and tyear_student.xYear=@xYear
if(@xStudent<=0)  
begin  
set @err=N'کد متعلم در سيستم وجود ندارد'  
return  
end  
select @xbook=id  from tbook where codedars=@codedars and xpaye=@xPaye  
if(@xbook<=0)  
begin  
set @err=N'کد درس '+cast(@codedars as varchar)+' در سيستم وجود ندارد'  
return  
end  
  
if (@Mark=-1000)  
 DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)  
else if not exists(select id from tmark where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook)  
 INSERT INTO tMark  
                       (xStudent, Xtest,typ, xbook, M1, Mark)  
 VALUES      (@xStudent, @Xtest,1, @xbook, @Mark, @Mark)  
else   
 UPDATE    tMark  
 SET   M1 =@Mark , Mark =@Mark  
 where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook