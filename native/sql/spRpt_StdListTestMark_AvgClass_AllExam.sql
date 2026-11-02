alter procedure dbo.spRpt_StdListTestMark_AvgClass_AllExam
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption  
as
select tmpStd.*,tmpavgClass.AvgClass from
(SELECT     dbo.tMarkDoreh.xStudent, dbo.tMarkDoreh.Xtest, dbo.tExam.Name AS Exam,tExam.NumExam, dbo.tMarkDoreh.MarkDoreh, dbo.tYear_Student.xClass
FROM         dbo.tMarkDoreh INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id INNER JOIN
                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id  INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear) and tExam.term not in(1,2)
and  (dbo.tMarkDoreh.typ = 5)) tmpStd
inner join
(SELECT     dbo.tMarkDoreh.Xtest, AVG(dbo.tMarkDoreh.MarkDoreh) AS AvgClass, dbo.tYear_Student.xClass
FROM         dbo.tMarkDoreh INNER JOIN
                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id 
WHERE tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)  and tExam.term not in(1,2)
and  (dbo.tMarkDoreh.typ = 5)
GROUP BY dbo.tMarkDoreh.Xtest, dbo.tYear_Student.xClass)tmpavgClass 
on tmpStd.xClass=tmpavgClass.xClass and tmpStd.Xtest=tmpavgClass.Xtest
order by tmpStd.xStudent,tmpStd.NumExam