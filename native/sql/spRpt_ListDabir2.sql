alter procedure dbo.spRpt_ListDabir2
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption
as
select tmpStd.*, tmpMark.M1, tmpMark.M2, tmpMark.M3, tmpMark.M4, tmpMark.M5, tmpMark.M6, tmpMark.M7, tmpMark.M8, tmpMark.M9, tmpMark.M10, 
                      tmpMark.Mark, tmpMark.gClass, tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif,tmpMark.TosifM,tmpMark.LevelBook
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tBook.Name AS Book, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest, tbook.id as xbook,tYear_Student.sort
                      FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON   tYear_Student.xClass =tClass.id    INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xPaye
where tBook.id in(select distinct xbook from tMark where Xtest in(select * from SplitNumber(@Exam)) )

and tYear_Student.xClass in(select distinct tYear_Student.xClass  from tMark inner join 
tStudent on tMark.xstudent=tStudent.id INNER JOIN  tYear_Student ON tStudent.id = tYear_Student.xStudent 
where tMark.Xtest in(select * from SplitNumber(@Exam)) AND (tYear_Student.xYear = @xYear) 
and tYear_Student.xClass in(select * from SplitNumber(@Class)) )
)tmpStd


left outer JOIN
( select tMark.xstudent,tMark.xbook, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, 
                      tMark.Mark, tMark.gClass, tMark.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo,
                      dbo.ReturnTosif( tMark.Mark,tMark.xtest) as Tosif, dbo.ReturnTosifM( tMark.Mark,tMark.xtest) as TosifM,
                      dbo.ReturnLevel( tMark.Mark,tMark.xtest) as LevelBook
from
  tMark  INNER JOIN
   tExam ON tMark.Xtest = tExam.id 
where tMark.Xtest in(select * from SplitNumber(@Exam)))tmpMark 
on tmpStd.xstudent=tmpMark.xstudent and tmpStd.xbook=tmpMark.xbook