CREATE  PROCEDURE spRpt_StdBookMarks
@Exam varchar(500),
@Class varchar(500),
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @Test nvarchar(100)   
declare @tmp_xbook int
declare @counter int   
declare @Sql nvarchar(500)   
declare @NumExam int   




set @tmp_xbook =0
set @counter=1


create table #tmp 
(xStudent int,xBook int ,
xtest1 int,test1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xtest2 int,test2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xtest3 int,test3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xtest4 int,test4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xtest5 int,test5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xtest6 int,test6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xtest7 int,test7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xtest8 int,test8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xtest9 int,test9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int,
countTest smallint,AvgMark float,tmpavgMark float
)
insert into #tmp (xStudent,xbook,countTest)
SELECT     tStudent.id AS xStudent, tBook.id AS xbook,0
FROM         tStudent  INNER JOIN
             tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
             tBook ON tYear_Student.xPaye =tBook.xPaye
where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tBook.id in(SELECT DISTINCT tMark.xbook  FROM tMark  INNER JOIN tStudent 
on tMark.xStudent=tStudent.id INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent
where tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMark.xtest in(select * from SplitNumber(@Exam)) )


declare Test cursor for
SELECT DISTINCT tMark.xbook, tMark.Xtest, tExam.Name, tExam.NumExam
FROM         tMark INNER JOIN
                      tExam ON tMark.Xtest = tExam.id INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
ORDER BY tMark.xbook, tExam.NumExam
       open Test
fetch next from Test into 
   @xbook,@xTest,@Test,@NumExam
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xbook <>@xbook)
   set @counter =1 

set @Sql='update  #tmp set xtest'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xTest)+',Test'+convert(varchar(2),@counter)+'=N'''+@Test+''''+
' WHERE xbook = '+convert(varchar(6),@xbook)
exec(@Sql)

set @Sql='update  #tmp set countTest=countTest+1,tmpavgMark=isnull(tmpavgMark,0)+tmark.mark, Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.xBook = #tmp.xBook '
+' WHERE tmark.mark is not null and tMark.xTest = '+convert(varchar(6),@xtest) +' and #tmp.xBook='+convert(varchar(6),@xbook)
exec(@Sql)
set @counter=@counter+1
set @tmp_xbook=@xbook
fetch next from Test into 
   @xbook,@xTest,@Test,@NumExam

end

close Test
deallocate Test

update #tmp set AvgMark=tmpavgMark/countTest
where countTest>0

select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass,
tClass.Name AS Class ,tPaye.Name AS Paye,tBook.name as book  from  #tmp inner join
tStudent on #tmp.xStudent=tStudent.id INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent inner join
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on tYear_Student.xPaye=tPaye.id  inner join
tBook on #tmp.xBook=tBook.id  
drop table #tmp