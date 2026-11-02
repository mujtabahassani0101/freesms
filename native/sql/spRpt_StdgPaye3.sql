alter  procedure dbo.spRpt_StdgPaye3
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption  
as
SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName, tYear_Student.xPaye, tMarkDoreh.Xtest, tMarkDoreh.typ, tMarkDoreh.MarkDoreh, tMarkDoreh.gPaye, 
                      tClass.name AS Class
FROM         tStudent INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id
WHERE     (tMarkDoreh.typ = 5) AND (tMarkDoreh.gPaye2 <= 3)--and tStudent.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam))