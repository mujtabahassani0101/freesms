CREATE  PROCEDURE dbo.spRpt_ListDabirKhamByTchName
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 

SELECT     tYear_Student.sort, tStudent.id AS xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tYear_Student.xPaye, tYear_Student.xClass, tBook.id AS xbook, 
                      tBook.Name AS Book, tTch_Cls.xTch, tTeacher.fNamF + '  ' + tTeacher.fNamL AS tch, tPaye.Name AS Paye, tClass.name AS Class, 
                      tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, tExam.id AS Xtest
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xPaye INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN
                      tTch_Cls ON tYear_Student.xClass = tTch_Cls.xCls AND tBook.id = tTch_Cls.xLsn LEFT OUTER JOIN
                      tTeacher ON tTch_Cls.xTch = tTeacher.id CROSS JOIN
                      tExam
where  tYear_Student.xClass IN (select * from SplitNumber(@Class)) 
and tExam.id in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)