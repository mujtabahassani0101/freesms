CREATE  PROCEDURE dbo.spRpt_ListTestBookStd 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 
create table #tmp(Xtest int,xStudent int,typ int,xbook int,mark float)
insert into #tmp(  Xtest, xStudent, typ, xbook, Mark)
SELECT     Xtest, xStudent, typ, xbook, Mark
FROM         tMark
WHERE     (typ = 1)
and xStudent in( select tStudent.id from tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                       where  (tYear_Student.xYear = @xYear) AND
                        tYear_Student.XClass IN (select * from SplitNumber(@Class)) )
and  xtest in(select * from SplitNumber(@Exam)) 

insert into #tmp(  Xtest, xStudent, typ, xbook, Mark)
SELECT     Xtest, xStudent, typ, -5, MarkDoreh
FROM         tMarkDoreh
WHERE     (typ = 5)
and xStudent in( select tStudent.id from tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                       where  (tYear_Student.xYear = @xYear) AND
                        tYear_Student.XClass IN (select * from SplitNumber(@Class)) )
and  xtest in(select * from SplitNumber(@Exam)) 



SELECT     #tmp.Xtest, #tmp.xStudent, #tmp.xbook, #tmp.typ, #tmp.Mark, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Code,  tPaye.Name as Paye, 
                      tClass.name AS Class,tYear_Student.xPaye,tYear_Student.xClass, tBook.Name AS Book, tBook.sort, tExam.Name AS Exam, tExam.NumExam,tStudentImg.Student_img
FROM         #tmp INNER JOIN
                      tStudent ON #tmp.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tExam ON #tmp.Xtest = tExam.id LEFT OUTER JOIN
                      tBook ON #tmp.xbook = tBook.id LEFT OUTER JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent 
     where (tYear_Student.xYear = @xYear)