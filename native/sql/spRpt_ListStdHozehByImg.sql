CREATE procedure dbo.spRpt_ListStdHozehByImg with encryption
as
SELECT     tStudent.id AS xStudent, tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xhozeh, tYear_Student.idx, tHozeh.Name AS Hozeh, tStudent.FName, tStudent.LName, 
                      tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, tHozeh.Capacity AS CapacityHozeh, tStudentImg.Student_img
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tHozeh ON tYear_Student.xhozeh = tHozeh.id LEFT OUTER JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent
WHERE     (tYear_Student.idx IS NOT NULL) and tYear_Student.xyear in(select xyear from tDefYear)