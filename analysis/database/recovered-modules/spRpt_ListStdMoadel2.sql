CREATE procedure dbo.spRpt_ListStdMoadel2
@Exam varchar(500),
@Class varchar(500)   ,
@xYear int  with encryption
as
select tmpStd.*, tmpMark.MarkDoreh as Mark, tmpMark.gClass,tmpMark.gPaye,tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest,tYear_Student.sort
                       FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON  tYear_Student.xClass = tClass.id  INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  
where tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear) 
 )tmpStd


left outer join
( select tMarkDoreh.xstudent,tMarkDoreh.MarkDoreh, dbo.ReturnTosif( tMarkDoreh.MarkDoreh) as Tosif,tMarkDoreh.gClass,tMarkDoreh.gPaye, tMarkDoreh.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo
from
  tMarkDoreh INNER JOIN
   tExam ON tMarkDoreh.Xtest = tExam.id 
where tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) and typ=5)tmpMark 
on tmpStd.xstudent=tmpMark.xstudent