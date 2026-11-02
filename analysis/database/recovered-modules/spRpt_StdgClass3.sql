CREATE  procedure dbo.spRpt_StdgClass3
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption  
as
SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName,tYear_Student.xClass, tMarkDoreh.Xtest, tMarkDoreh.typ, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
FROM         tStudent   INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent
WHERE     (tMarkDoreh.typ = 5) AND (tMarkDoreh.gClass <= 3)
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam))