CREATE  PROCEDURE dbo.spRpt_Liststd_booksAlarm
@Exam varchar(500),
@Class varchar(500) ,
@xYear int  with encryption 
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
(xStudent int,xTest int,xPaye int,MarkKoll float,gschkoll int,gclsKoll int,gPayeKoll int,
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
xbook18 int,book18 nvarchar(100),Mark18 float,gSch18 int,gCls18 int
)
insert into #tmp (xStudent,xtest,xPaye,MarkKoll,gschkoll,gPayeKoll,gclsKoll)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass
FROM         tStudent INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent  
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
and tStudent.id in(select xstudent from tmark where mark<40 and typ=1 and xtest in(select * from SplitNumber(@Exam)))


declare Test cursor for
SELECT DISTINCT tMark.Xtest, tYear_Student.xPaye, tMark.xbook, tBook.Name, tBook.sort
FROM         tStudent  INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMark ON tStudent.id = tMark.xStudent INNER JOIN
                      tBook ON tMark.xbook = tBook.id AND tYear_Student.xPaye = tBook.xPaye
WHERE     (tMark.Mark < 40)
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
ORDER BY tMark.Xtest, tYear_Student.xPaye, tBook.sort, tMark.xbook
open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<19)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest  AND tMark.xBook = #tmp.xBook'+convert(varchar(2),@counter)
	+' WHERE tMark.mark<40 and #tmp.Xtest = '+convert(varchar(6),@xtest)+' AND #tmp.xPaye = '+convert(varchar(6),@xPaye)
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
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp inner join
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent inner join
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
where (tYear_Student.xYear = @xYear) 

drop table #tmp