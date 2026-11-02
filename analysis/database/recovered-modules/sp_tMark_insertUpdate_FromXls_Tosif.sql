
create Procedure dbo.sp_tMark_insertUpdate_FromXls_Tosif 
@xuser int,  
@code varchar(14),  
@codedars int,  
@Xtest int,
@Mark float,  
@comment nvarchar(500),
@err nvarchar(100) output  with encryption
as  
  
declare @xStudent int  
declare @xPaye int  
declare @xbook int  
set @xbook=0  
set @xStudent=0  
select @xStudent=id,@xPaye=xpaye from tstudent where code=@code  
if(@xStudent<=0)  
begin  
set @err=N'شماره پرونده در سيستم وجود ندارد'  
return  
end  
select @xbook=id  from tbook where codedars=@codedars and xpaye=@xPaye  
if(@xbook<=0)  
begin  
set @err=N'کد درس '+cast(@codedars as varchar)+' در سيستم وجود ندارد'  
return  
end  

if (@comment <>'')
  begin
	if not exists(select id from tComnentKarname where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook and typ=1)
		INSERT INTO tComnentKarname
		                      (xStudent, Xtest,typ, xbook,comment)
		VALUES      (@xStudent, @Xtest,1, @xbook,@comment)
	else 
		UPDATE    tComnentKarname
		SET  comment=@comment
		where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook and typ=1
  end  
else
   DELETE FROM tComnentKarname WHERE (xStudent = @xStudent) And typ=1 AND (Xtest = @Xtest) AND (xbook = @xbook)
               
  
if (@Mark=-1000)  
 DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)  
 else if not exists(select id from tmark where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook)  
 INSERT INTO tMark  
                       (xStudent, Xtest,typ, xbook, M1, Mark)  
 VALUES       (@xStudent, @Xtest,1, @xbook, -@Mark, -@Mark)  
 else   
 UPDATE    tMark  
 SET M1 =-@Mark ,Mark =-@Mark  
 where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook  
  

  
  


