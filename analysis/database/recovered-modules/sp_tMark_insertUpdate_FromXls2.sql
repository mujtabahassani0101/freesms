

CREATE Procedure dbo.sp_tMark_insertUpdate_FromXls2  
@xuser int,  
@code varchar(14),  
@xbook int,  
@Xtest int,  
@CountAb smallint,  
@M1 float,  
@M2 float,  
@M3 float,  
@M4 float,  
@M5 float,  
@M6 float,  
@M7 float,  
@M8 float,  
@Mark float,  
@err nvarchar(100) output  with encryption
as  
  
declare @xStudent int  
declare @xPaye int  
declare @xPayeBook int  
set @xStudent=0  
select @xStudent=id,@xPaye=xpaye from tstudent where code=@code  
if(@xStudent<=0)  
begin  
set @err=N'شماره پرونده در سیستم وجود ندارد'  
return  
end  
select @xPayeBook=xPaye  from tbook where id=@xbook
if(@xPayeBook<>@xPaye)  
begin  
set @err=N'این دانش آموز در پایه ی انتخاب شده نیست'  
return  
end  
  
  
  
  
if (@Mark=-1000)  
 DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)  
else if not exists(select id from tmark where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook)  
 INSERT INTO tMark  
                       (xStudent, Xtest,typ, xbook,CountAb, M1, M2, M3, M4, M5, M6, M7, M8, Mark)  
 VALUES      (@xStudent, @Xtest,1, @xbook,@CountAb, @M1, @M2, @M3, @M4, @M5, @M6, @M7, @M8, @Mark)  
else   
 UPDATE    tMark  
 SET CountAb=@CountAb,    M1 =@M1 , M2 =@M2 , M3 =@M3 , M4 =@M4 , M5 =@M5 ,  
        M6 =@M6 , M7 =@M7 , M8 =@M8 , Mark =@Mark  
 where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook
