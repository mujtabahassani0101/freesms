CREATE procedure dbo.spRpt_AmarGhaboliPaye
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
as
create table #tmpMark (xclass int,xtest int,typ int,xbook int,avgmark float,countMark int,countAcp int)
insert  into #tmpMark(xclass ,xtest ,typ ,xbook ,avgmark ,countMark,countAcp)
SELECT     tYear_Student.xPaye, tMark.Xtest, tMark.typ, tMark.xbook, AVG(tMark.Mark) AS avgMark, COUNT(tMark.id) AS countStd,0
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where  tMark.Mark is not null and    (tMark.Xtest in(select * from SplitNumber(@Exam))) 
and (tYear_Student.xclass in(select * from SplitNumber(@Class))) 
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xPaye, tMark.Xtest, tMark.typ, tMark.xbook

update #tmpMark set countAcp=tmpAcp.countacp
from 
#tmpMark
 inner join (SELECT     tYear_Student.xPaye as xClass, tMark.Xtest, tMark.typ, tMark.xbook, COUNT(tMark.id) AS countacp
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE     (tMark.Mark >= 10) and    (tMark.Xtest in(select * from SplitNumber(@Exam))) 
and  (tYear_Student.xclass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xPaye, tMark.Xtest, tMark.typ, tMark.xbook)tmpAcp
 on #tmpMark.xClass=tmpAcp.xClass and #tmpMark.Xtest=tmpAcp.Xtest 
and #tmpMark.typ=tmpAcp.typ and #tmpMark.xbook=tmpAcp.xbook 



insert  into #tmpMark(xclass ,xtest ,typ ,xbook ,avgmark ,countMark,countAcp)
SELECT     tYear_Student.xPaye, tMarkDoreh.Xtest, 5,-5, AVG(tMarkDoreh.MarkDoreh) AS avgMark, COUNT(tMarkDoreh.xStudent) AS countStd,0
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where   tMarkDoreh.typ=5 and   (tMarkDoreh.Xtest in(select * from SplitNumber(@Exam))) 
and  (tYear_Student.xClass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xPaye,tMarkDoreh.Xtest

update #tmpMark set countAcp=tmpAcp.countacp
from 
#tmpMark
 inner join 
(SELECT     tYear_Student.xPaye as xClass, tMarkDoreh.Xtest, -5 as xbook, COUNT(tMarkDoreh.xStudent) AS countacp
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE  tMarkDoreh.typ=5 and   (tMarkDoreh.MarkDoreh >= 10)  
and   (tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)))
and   (tYear_Student.xClass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xPaye,tMarkDoreh.Xtest)tmpAcp
 on #tmpMark.xClass=tmpAcp.xClass and #tmpMark.Xtest=tmpAcp.Xtest 
where #tmpMark.typ=5

select #tmpMark.*,tBook.name as Book,tBook.sort ,tPaye.name as Paye,tPaye.id as xPaye,
tExam.name as Exam from #tmpMark left outer  join
tBook on #tmpMark.xbook=tBook.id inner join 
tPaye on #tmpMark.xclass=tPaye.id inner join 
tExam on #tmpMark.xTest=tExam.id 
order by #tmpMark.xPaye ,#tmpMark.typ,tBook.sort 
drop table #tmpMark