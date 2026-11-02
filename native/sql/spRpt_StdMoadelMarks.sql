CREATE  PROCEDURE dbo.spRpt_StdMoadelMarks
@Exam varchar(500),
@Class varchar(500) ,
@xYear int  with encryption  
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
(xStudent int,
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
insert into #tmp (xStudent,countTest)
SELECT DISTINCT tStudent.id AS xStudent, 0 AS Expr1
FROM         tStudent INNER JOIN
 		      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent
where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and     (tMarkDoreh.Xtest IN (select * from SplitNumber(@Exam)))


declare Test cursor for
SELECT DISTINCT  tMarkDoreh.Xtest, tExam.Name, tExam.NumExam
FROM         tMarkDoreh INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
		      tYear_Student ON tStudent.id = tYear_Student.xStudent
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
ORDER BY tExam.NumExam
       open Test
fetch next from Test into 
   @xTest,@Test,@NumExam
Set @counter=1
while (@@fetch_status=0)

begin



set @Sql='update  #tmp set xtest'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xTest)+',Test'+convert(varchar(2),@counter)+'=N'''+@Test+''''
exec(@Sql)

set @Sql='update  #tmp set countTest=countTest+1,tmpavgMark=isnull(tmpavgMark,0)+tMarkDoreh.MarkDoreh, Mark'+convert(varchar(2),@counter)+'=tMarkDoreh.MarkDoreh,gSch'+convert(varchar(2),@counter)+'=tMarkDoreh.gPaye,gCls'+convert(varchar(2),@counter)+'=tMarkDoreh.gClass'
+' FROM  tMarkDoreh INNER JOIN #tmp ON tMarkDoreh.xStudent = #tmp.xStudent '
+' WHERE tMarkDoreh.typ=5 and tMarkDoreh.MarkDoreh is not null and tMarkDoreh.xTest = '+convert(varchar(6),@xtest) 
exec(@Sql)
set @counter=@counter+1
set @tmp_xbook=@xbook
fetch next from Test into 
   @xTest,@Test,@NumExam

end

close Test
deallocate Test

--update #tmp set AvgMark=tmpavgMark/countTest
--where countTest>0


update #tmp set AvgMark=tmpAvg.Avgkoll
from   
#tmp   inner join                
(
         SELECT     tmpavgStd.xStudent ,SUM(tmpavgStd.Mark * tBook.vahed) / SUM(tBook.vahed) AS Avgkoll
         from
		(SELECT     tMark.xStudent,tMark.xbook,avg(tMark.Mark) as Mark
		FROM         tMark INNER JOIN
		                      tBook ON tMark.xbook = tBook.id
		WHERE   tMark.typ=1 and  (tMark.Mark IS NOT NULL)  and (tMark.Xtest in(select * from SplitNumber(@Exam)))
		GROUP BY tMark.xStudent,tMark.xbook)tmpavgStd INNER JOIN
                      tBook ON tmpavgStd.xbook = tBook.id
               where tBook.vahed>0
		GROUP BY tmpavgStd.xStudent
) tmpAvg on #tmp.xStudent=tmpAvg.xStudent



select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass,
tClass.Name AS Class ,tPaye.Name AS Paye from  #tmp inner join
tStudent on #tmp.xStudent=tStudent.id INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent inner join
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on tYear_Student.xPaye=tPaye.id 
where (tYear_Student.xYear = @xYear) 
drop table #tmp