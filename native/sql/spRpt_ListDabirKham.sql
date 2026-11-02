CREATE procedure spRpt_ListDabirKham
@Exam varchar(500),
@Class varchar(500),
@xYear int with encryption
as
SELECT     tStudent.id, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.xPaye, 
                      tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, tExam.id AS Xtest, tYear_Student.sort
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tExam
where tExam.id in(select * from SplitNumber(@Exam))  
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)