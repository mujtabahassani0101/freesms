--13990102
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQlVBRThBU0FCa0FFNEFWUUI2QUdnQU13QlVBRmNBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
alter  PROCEDURE dbo.spRpt_Liststd_books1
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @book nvarchar(100)   
declare @xPaye int 
declare @tmp_xTest int
declare @tmp_xPaye int 
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   




set @tmp_xTest =0
set @tmp_xPaye =0
set @counter=1


create table #tmp 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gschkoll int,gclsKoll int,gPayeKoll int,
xbook1 int,book1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xbook2 int,book2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xbook3 int,book3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xbook4 int,book4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xbook5 int,book5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xbook6 int,book6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xbook7 int,book7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xbook8 int,book8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xbook9 int,book9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int,
xbook10 int,book10 nvarchar(100),Mark10 float,gSch10 int,gCls10 int,
xbook11 int,book11 nvarchar(100),Mark11 float,gSch11 int,gCls11 int,
xbook12 int,book12 nvarchar(100),Mark12 float,gSch12 int,gCls12 int,
xbook13 int,book13 nvarchar(100),Mark13 float,gSch13 int,gCls13 int,
xbook14 int,book14 nvarchar(100),Mark14 float,gSch14 int,gCls14 int,
xbook15 int,book15 nvarchar(100),Mark15 float,gSch15 int,gCls15 int,
xbook16 int,book16 nvarchar(100),Mark16 float,gSch16 int,gCls16 int,
xbook17 int,book17 nvarchar(100),Mark17 float,gSch17 int,gCls17 int,
xbook18 int,book18 nvarchar(100),Mark18 float,gSch18 int,gCls18 int,
xbook19 int,book19 nvarchar(100),Mark19 float,gSch19 int,gCls19 int,
xbook20 int,book20 nvarchar(100),Mark20 float,gSch20 int,gCls20 int,
xbook21 int,book21 nvarchar(100),Mark21 float,gSch21 int,gCls21 int

)
insert into #tmp (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gschkoll,gPayeKoll,gclsKoll)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,
tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)

declare Test cursor for
SELECT DISTINCT dbo.tMark.Xtest, dbo.tYear_Student.xPaye, dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)

ORDER BY tMark.Xtest, tYear_Student.xPaye, tBook.sort, tMark.xbook
open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<22)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)	exec(@Sql)

	set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest  AND tMark.xBook = #tmp.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmp.Xtest = '+convert(varchar(6),@xtest)+' AND #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)
  End
set @counter=@counter+1
set @tmp_xTest=@xTest
set @tmp_xPaye=@xPaye

fetch next from Test into 
   @xTest,@xPaye,@xbook,@book,@sort

end

close Test
deallocate Test


select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp  inner join
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
where tYear_Student.xYear =@xYear       
drop table #tmp

GO

alter  PROCEDURE spRpt_Liststd_books2
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @book nvarchar(100)   
declare @xPaye int 
declare @tmp_xTest int
declare @tmp_xPaye int 
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   




set @tmp_xTest =0
set @tmp_xPaye =0
set @counter=1


create table #tmp 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,
gschkoll int,gclsKoll int,gPayeKoll int,
xbook1 int,book1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xbook2 int,book2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xbook3 int,book3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xbook4 int,book4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xbook5 int,book5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xbook6 int,book6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xbook7 int,book7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xbook8 int,book8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xbook9 int,book9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int,
xbook10 int,book10 nvarchar(100),Mark10 float,gSch10 int,gCls10 int,
xbook11 int,book11 nvarchar(100),Mark11 float,gSch11 int,gCls11 int,
xbook12 int,book12 nvarchar(100),Mark12 float,gSch12 int,gCls12 int,
xbook13 int,book13 nvarchar(100),Mark13 float,gSch13 int,gCls13 int,
xbook14 int,book14 nvarchar(100),Mark14 float,gSch14 int,gCls14 int,
xbook15 int,book15 nvarchar(100),Mark15 float,gSch15 int,gCls15 int,
xbook16 int,book16 nvarchar(100),Mark16 float,gSch16 int,gCls16 int,
xbook17 int,book17 nvarchar(100),Mark17 float,gSch17 int,gCls17 int,
xbook18 int,book18 nvarchar(100),Mark18 float,gSch18 int,gCls18 int,
xbook19 int,book19 nvarchar(100),Mark19 float,gSch19 int,gCls19 int,
xbook20 int,book20 nvarchar(100),Mark20 float,gSch20 int,gCls20 int,
xbook21 int,book21 nvarchar(100),Mark21 float,gSch21 int,gCls21 int
)
insert into #tmp (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gschkoll,gPayeKoll,gclsKoll)
SELECT   tStudent.id,@Exam,tYear_Student.XPaye,tmptMarkDoreh.MarkDoreh,tmptMarkDoreh.Summark,
   dbo.ReturnTosifM5(tmptMarkDoreh.MarkDoreh,tmptMarkDoreh.xtest,tmptMarkDoreh.xStudent) as TosifM,
dbo.ReturnLevel5(tmptMarkDoreh.MarkDoreh,tmptMarkDoreh.xtest,tmptMarkDoreh.xStudent) as level5,tmptMarkDoreh.gKoll,tmptMarkDoreh.gPaye,tmptMarkDoreh.gclass
FROM         tStudent  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent left outer JOIN
                     (select * from tMarkDoreh where xtest =@Exam and tMarkDoreh.typ = 5 ) tmptMarkDoreh ON tStudent.id = tmptMarkDoreh.xStudent  
WHERE tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)


declare Test cursor for
SELECT DISTINCT @Exam, dbo.tYear_Student.xPaye, dbo.tBook.id, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent INNER JOIN 
               tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
              tBook on  dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)

ORDER BY  tYear_Student.xPaye, tBook.sort, tBook.id
       open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<22)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest  AND tMark.xBook = #tmp.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmp.Xtest = '+convert(varchar(6),@xtest)+' AND #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)
  End
set @counter=@counter+1
set @tmp_xTest=@xTest
set @tmp_xPaye=@xPaye

fetch next from Test into 
   @xTest,@xPaye,@xbook,@book,@sort

end

close Test
deallocate Test

select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp  inner join
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
where tYear_Student.xYear =@xYear       
drop table #tmp
GO
update trpt set caption=N'اطلاع نامه استاد' where id=1039
GO
update trpt set caption=N'اوسط مکتسبه دانش آموزان در طول دوره هاي ارزيابي-به تفکيک پايه ' where id=1049
GO
update trpt set caption=N'ليست دانش آموزان مشروطي'  ,term=3 where id=1050

GO
update trpt set caption=N'ليست اوسط دانش آموزان تا 4 رقم اعشار به تفکيک پايه'  where id=107
GO
update trpt set caption=N'ليست اوسط دانش آموزان تا 4 رقم اعشار  در کل مکتب'  where id=108
GO
alter table tstudent add xCityNow int
GO
alter table tYear_Student add codeTakhfif int
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (33, N'dropcityNow', N'سکونت فعلي', 0)
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (34, N'txtcodeTakhfif', N'کد تخفيف', 0)
GO
update tItemSabtenamEnable set lable=N'ولسوالي‌ سکونت اصلي'  where id=27
GO
alter procedure dbo.sp_tStudent_insertUpdate        
@id int,        
@xYear int,        
@xPaye int ,        
@xClass int ,        
@Code bigint ,        
@FName nvarchar(100),        
@LName nvarchar(100),        
@PName nvarchar(100),        
@Sh_Sh nvarchar(200),        
@bDate nvarchar(10),        
@MobileFather nvarchar(11),        
@MobileMother nvarchar(11),        
@NumberTelegram nvarchar(11),        
@NumberTelegram2 nvarchar(11),        
@Jens smallint,        
@Mazhab smallint,        
@NumberAsas int ,        
@RegDate nvarchar(10),        
@Adress nvarchar (200),        
@ExitDate nvarchar(10),        
@Status smallint,        
        
@shaghe bit,        
@hazer bit,        
@mali bit,        
@dakhle bit,        
@uniform bit,        
@komakdarsi bit,        
@ketab bit,        
@transport bit,        
@robotic bit,        
@maghnae bit,        
      
@Fee1 int,        
@Fee2 int,        
@Fee3 int,        
@Fee4 int,        
@Fee5 int,        
@Fee6 int,        
@Fee7 int,        
@Fee8 int,        
@Fee9 int,        
@SumFee int ,    
@xTakhfif smallint,    
@transport1 int,        
@transport2 int,        
@transport3 int,        
@transport4 int,        
@transport5 int,        
@transport6 int,        
@transport7 int,        
@transport8 int,        
@transport9 int,        
@Sumtransport int,        
@xDriver int,        
    
@xcity int,       
@En_Fname nvarchar (100),   
@En_Lname nvarchar (100),    
@LastName nvarchar(100),  
@En_LastName nvarchar(100) ,        
  
@MarkTerm3_From100 bit,    
@xCityNow int,
@codeTakhfif int  ,
@CodeOut int outPut    with encryption  
as        
if(@id>0)        
  begin    
        if(@Code is not null)    
          begin       
           if exists(select id from tStudent where id<>@id and Code=@Code)          
    begin          
      set @CodeOut=-100          
      return          
    end     
          end     
       if(@NumberAsas is not null)    
          begin        
       if exists(select id from tStudent where id<>@id and NumberAsas=@NumberAsas )          
    begin          
      set @CodeOut=-200          
      return          
    end          
          end    
       UPDATE    tStudent        
       SET   Code =@Code, FName =@FName, LName =@LName, PName =@PName, Sh_Sh =@Sh_Sh, bDate=@bDate        
       , MobileFather =@MobileFather, MobileMother =@MobileMother, Jens =@Jens, Mazhab =@Mazhab,        
        NumberAsas =@NumberAsas, RegDate =@RegDate, Adress =@Adress, ExitDate =@ExitDate,         
       NumberTelegram=@NumberTelegram,NumberTelegram2=@NumberTelegram2 ,  
       xcity=@xcity ,  En_Fname=@En_Fname, En_Lname=@En_Lname ,En_LastName=@En_LastName ,LastName=@LastName,
	xCityNow=@xCityNow where id=@id        
              
      UPDATE    tYear_Student        
 SET              xPaye =@xPaye, xClass =@xClass,  Status =@Status, shaghe =@shaghe, hazer =@hazer, mali =@mali,         
                        dakhle =@dakhle, uniform =@uniform, komakdarsi =@komakdarsi, ketab =@ketab,        
                        transport =@transport, robotic =@robotic, maghnae =@maghnae, MarkTerm3_From100=@MarkTerm3_From100   ,  
                        Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5,      
    Fee6=@Fee6, Fee7=@Fee7, Fee8=@Fee8, Fee9=@Fee9,SumFee=@SumFee ,xTakhfif=@xTakhfif,      
   transport1=@transport1, transport2=@transport2, transport3=@transport3, transport4=@transport4, transport5=@transport5,      
    transport6=@transport6, transport7=@transport7,transport8=@transport8, transport9=@transport9, Sumtransport=@Sumtransport ,    
   xDriver =@xDriver,codeTakhfif=@codeTakhfif
 WHERE     (xYear = @xYear) AND (xStudent = @id)        
        
  end        
else        
  begin        
    if(@Code is not null)    
       begin       
         if exists(select id from tStudent where Code=@Code)          
    begin          
      set @CodeOut=-100          
      return          
    end     
       end     
    if(@NumberAsas is not null)    
      begin         
        if exists(select id from tStudent where  NumberAsas=@NumberAsas )          
   begin          
     set @CodeOut=-200          
   return          
   end      
      end       
 INSERT INTO tStudent        
                      (Code, FName, LName, PName, Sh_Sh,bDate, MobileFather, MobileMother, NumberTelegram, NumberTelegram2,        
                      Jens, Mazhab, NumberAsas, RegDate, Adress, xcity,  En_Fname, En_Lname,En_LastName,LastName,xCityNow)        
 VALUES     (@Code, @FName,@LName,@PName,@Sh_Sh,@bDate,@MobileFather,@MobileMother,@NumberTelegram,@NumberTelegram2,        
                     @Jens,@Mazhab,@NumberAsas,@RegDate,@Adress,@xcity,@En_Fname,@En_Lname,@En_LastName,@LastName,@xCityNow)        
       set @id=@@identity        
       set @CodeOut=@id      
       INSERT INTO tYear_Student (xYear, xStudent, xPaye, xClass,Status, shaghe, hazer, mali, dakhle, uniform,        
                       komakdarsi, ketab, transport, robotic, maghnae,MarkTerm3_From100,      
                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,    
                      transport1,transport2,transport3,transport4, transport5,      
                      transport6,transport7,transport8,transport9,Sumtransport,xDriver,codeTakhfif)        
       VALUES      (@xYear, @id, @xPaye, @xClass,@Status, @shaghe, @hazer, @mali, @dakhle, @uniform,        
                       @komakdarsi, @ketab, @transport, @robotic, @maghnae, @MarkTerm3_From100,     
                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif,     
      @transport1,@transport2,@transport3,@transport4, @transport5,      
                    @transport6,@transport7,@transport8,@transport9,@Sumtransport,@xDriver,@codeTakhfif)        
  end        
  
GO