CREATE procedure dbo.sp_RptListStdTransport
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tStudent.Code, tYear_Student.sort, tStudent.FName, tStudent.LName, 
                      tStudent.PName, tClass.answerable, tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, 
                      tStudent.RegDate, CAST(tClass.xYear AS nvarchar(4)) AS xYear, tDriver.name as  Driver, tDriver.mobil, tYear_Student.xDriver, tDriver.mobil2, 
                      tStudent.MobileFather, tStudent.MobileMother, tStudent.NumberTelegram, tStudent.NumberTelegram2
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id LEFT OUTER JOIN
                      tDriver ON tYear_Student.xDriver = tDriver.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.transport = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))