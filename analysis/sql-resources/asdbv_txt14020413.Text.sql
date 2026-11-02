--14020413
alter procedure dbo.sp_SubrptChapShaghe
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xClass, tBook.id AS xbook, tYear_Student.xStudent, tClass.id, tYear_Student.sort, tStudent.FName, tStudent.LName, tClass.answerable, 
                      tBook.Name as book,isnull( tTeacher.fNamF + ' ' + tTeacher.fNamL,N' ') AS tch, tClass.name as Class,cast(tClass.xYear as nvarchar(4)) as xYear
			, tParmetr.heder1, tParmetr.sch,tStudent.NumberAsas,tStudent.PName
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tBook INNER JOIN
                      tClass ON tBook.xPaye = tClass.xpaye ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN
                      tTch_Cls ON tBook.id = tTch_Cls.xLsn AND tClass.id = tTch_Cls.xCls LEFT OUTER JOIN
                      tTeacher ON tTch_Cls.xTch = tTeacher.id  CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.shaghe = 1) AND (tBook.Vezarat = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO
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

GO
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFVZ0JrQURBQU1RQndBRThBU0FCa0FFOEFVUUI2QUdnQU5BQlVBRmdBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO