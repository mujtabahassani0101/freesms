--spRpt_AmarGhaboliClass 101,101,1398
CREATE procedure dbo.spRpt_AmarGhaboliClass 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
as
create table #tmpMark (xclass int,xtest int,typ int,xbook int,avgmark float,countMark int,countAcp int)
insert  into #tmpMark(xclass ,xtest ,typ ,xbook ,avgmark ,countMark,countAcp)
SELECT     tYear_Student.xClass, tMark.Xtest, tMark.typ, tMark.xbook, AVG(tMark.Mark) AS avgMark, COUNT(tMark.id) AS countStd,0
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where  tMark.Mark is not null and    (tMark.Xtest in(select * from SplitNumber(@Exam))) 
and (tYear_Student.xClass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xClass, tMark.Xtest, tMark.typ, tMark.xbook

update #tmpMark set countAcp=tmpAcp.countacp
from 
#tmpMark
 inner join (SELECT     tYear_Student.xClass, tMark.Xtest, tMark.typ, tMark.xbook, COUNT(tMark.id) AS countacp
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE     (tMark.Mark >= 40) and    (tMark.Xtest in(select * from SplitNumber(@Exam)))
and (tYear_Student.xclass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY  tYear_Student.xClass, tMark.Xtest, tMark.typ, tMark.xbook)tmpAcp
 on #tmpMark.xClass=tmpAcp.xClass and #tmpMark.Xtest=tmpAcp.Xtest 
and #tmpMark.typ=tmpAcp.typ and #tmpMark.xbook=tmpAcp.xbook 



insert  into #tmpMark(xclass ,xtest ,typ ,xbook ,avgmark ,countMark,countAcp)
SELECT     tYear_Student.xClass, tMarkDoreh.Xtest, 5,-5, AVG(tMarkDoreh.MarkDoreh) AS avgMark, COUNT(tMarkDoreh.xStudent) AS countStd,0
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where   tMarkDoreh.typ=5 and   (tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)))
and (tYear_Student.xClass in(select * from SplitNumber(@Class)))
AND (tYear_Student.xYear = @xYear)
GROUP BY tYear_Student.xClass, tMarkDoreh.Xtest

update #tmpMark set countAcp=tmpAcp.countacp
from 
#tmpMark
 inner join 
(
select  tacp.xClass,tacp.Xtest,tacp.xbook,tacp.countacp-isnull(tnoacp.countNoAcp,0) as countacp from
	(SELECT     tYear_Student.xClass, tMarkDoreh.Xtest, -5 as xbook, COUNT(tMarkDoreh.xStudent) AS countacp
	FROM         tMarkDoreh INNER JOIN
	                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                             tYear_Student ON tStudent.id = tYear_Student.xStudent
	WHERE  tMarkDoreh.typ=5 and (tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)))
	AND (tYear_Student.xYear = @xYear)
        and (tYear_Student.xclass in(select * from SplitNumber(@Class)))
	GROUP BY tYear_Student.xClass, tMarkDoreh.Xtest)tacp
	left outer join 
	(SELECT     tMark.Xtest, tYear_Student.xClass, COUNT(DISTINCT tMark.xStudent) AS countNoAcp
	FROM         tMark INNER JOIN
	                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                             tYear_Student ON tStudent.id = tYear_Student.xStudent
	WHERE     (tMark.Mark < 40) and (tMark.Xtest in(select * from SplitNumber(@Exam)))
       AND (tYear_Student.xYear = @xYear)
       and (tYear_Student.xclass in(select * from SplitNumber(@Class)))
	GROUP BY tMark.Xtest, tYear_Student.xClass)tnoacp 
	on tacp.xClass=tnoacp.xClass and tacp.Xtest=tnoacp.Xtest

)tmpAcp
 on #tmpMark.xClass=tmpAcp.xClass and #tmpMark.Xtest=tmpAcp.Xtest 
where #tmpMark.typ=5




select #tmpMark.*,tBook.name as Book,tBook.sort , tclass.name as Class,tPaye.name as Paye,tPaye.id as xPaye,
tExam.name as Exam,tTeacher.fNamF+' '+ tTeacher.fNamL as Tch  from #tmpMark left outer  join
tBook on #tmpMark.xbook=tBook.id inner join 
tclass on #tmpMark.xclass=tclass.id  inner join 
tPaye on tclass.xPaye=tPaye.id inner join 
tExam on #tmpMark.xTest=tExam.id left outer  join 
tTch_Cls on #tmpMark.xClass=tTch_Cls.xCls and #tmpMark.xbook=tTch_Cls.xLsn left outer  join 
tTeacher on tTch_Cls.xTch=tTeacher.id
order by #tmpMark.xPaye ,tclass.name,#tmpMark.typ,tBook.sort 
drop table #tmpMark