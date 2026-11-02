alter procedure dbo.sp_SubrptChapShagheHzeri
@Class varchar(500)  ,
@xYear int  with encryption
as
SELECT     tYear_Student.xClass, tYear_Student.xStudent, tClass.id, tYear_Student.sort, tStudent.FName, tStudent.LName, tClass.answerable, 
                 tClass.name as Class,cast(tClass.xYear as nvarchar(4)) as xYear
			, tParmetr.heder1, tParmetr.sch,tStudent.NumberAsas,tStudent.PName
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id  CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.shaghe = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))