alter PROCEDURE spRpt_StdCard 
@Class varchar(500)  ,
@xYear int with encryption
as

SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName,tStudent.PName,tStudent.code,
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear,dbo.tStudentImg.Student_img
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id    INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id left outer JOIN
                      dbo.tStudentImg ON dbo.tStudent.id = dbo.tStudentImg.xStudent CROSS JOIN
                      tParmetr 
WHERE    (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))
and tYear_Student.status<>2