CREATE procedure dbo.sp_SubListStdHazer
@Class varchar(500)  ,
@xYear int
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.hazer = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

