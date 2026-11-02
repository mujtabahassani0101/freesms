CREATE  PROCEDURE dbo.spRpt_DabirAvgClassMark
@Exam varchar(500),
@Class varchar(500),
@xYear int  with encryption  
AS 
create table #tmp (xtest int,xTch int,xPaye int,xClass int,xbook int,AvgClass float,maxClass float
,minClass float,AvgPaye float,maxPaye float,minPaye float,Avgkoll float,maxKoll float,minkoll float)

insert into #tmp(xtest,xTch ,xPaye ,xClass ,xbook ,AvgClass,maxClass,minClass)
SELECT    tMark.xtest, tTch_Cls.xTch, tYear_Student.xPaye, tYear_Student.xClass, tMark.xbook, 
AVG(tMark.Mark) AS AvgClass , max(tMark.Mark) AS maxClass, min(tMark.Mark) AS minClass
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tTch_Cls ON tYear_Student.xClass = tTch_Cls.xCls AND tMark.xbook = tTch_Cls.xLsn
WHERE tMark.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
GROUP BY   tMark.xtest,tTch_Cls.xTch, tYear_Student.xPaye, tYear_Student.xClass, tMark.xbook


update #tmp set AvgPaye=tmpPaye.AvgPaye, maxPaye=tmpPaye.maxPaye,minPaye=tmpPaye.minPaye
from #tmp inner join
(SELECT     tMark.xtest,  tTch_Cls.xTch, tYear_Student.xPaye, AVG(tMark.Mark) AS AvgPaye, max(tMark.Mark) AS maxPaye, min(tMark.Mark) AS minPaye
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tTch_Cls ON tYear_Student.xClass = tTch_Cls.xCls AND tMark.xbook = tTch_Cls.xLsn
WHERE tMark.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
GROUP BY   tMark.xtest, tTch_Cls.xTch, tYear_Student.xPaye)tmpPaye on #tmp.xTch=tmpPaye.xTch and  #tmp.xPaye=tmpPaye.xPaye and #tmp.xtest=tmpPaye.xtest


update #tmp set AvgKoll=tmpPaye.AvgKoll, maxKoll=tmpPaye.maxKoll,minKoll=tmpPaye.minKoll
from #tmp inner join
(SELECT     tMark.xtest,  tTch_Cls.xTch, AVG(tMark.Mark) AS AvgKoll, max(tMark.Mark) AS maxKoll, min(tMark.Mark) AS minKoll
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tTch_Cls ON tYear_Student.xClass = tTch_Cls.xCls AND tMark.xbook = tTch_Cls.xLsn
WHERE tMark.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
GROUP BY   tMark.xtest, tTch_Cls.xTch)tmpPaye on #tmp.xTch=tmpPaye.xTch  and #tmp.xtest=tmpPaye.xtest



SELECT     #tmp.*, tTeacher.fNamF + '  ' + tTeacher.fNamL AS tch, tPaye.Name AS Paye, tBook.Name AS Book, tClass.name AS Class,texam.name as Exam
,texam.DateFrom,texam.DateTo
                   
FROM         #tmp INNER JOIN
                      tTeacher ON #tmp.xTch = tTeacher.id INNER JOIN
                      tPaye ON #tmp.xPaye = tPaye.id INNER JOIN
                      tBook ON #tmp.xbook = tBook.id INNER JOIN
                      tClass ON #tmp.xClass = tClass.id INNER JOIN
                      tExam on #tmp.xtest=tExam.id 
order by #tmp.xTch, #tmp.AvgClass desc
drop table tmp