

CREATE  procedure dbo.sp_ExportMarkToXls
@Exam varchar(500),
@Class varchar(500) with encryption
as
SELECT     dbo.tStudent.sort AS ردیف, dbo.tExam.Name AS [عنوان دوره], dbo.tClass.name AS کلاس, dbo.tStudent.Code AS [شماره پرونده], dbo.tStudent.FName AS نام, 
                      dbo.tStudent.LName AS [نام خانوادگی], dbo.tBook.codeDars AS [کد درس], dbo.tBook.Name AS [نام درس], round(dbo.tMark.Mark,2) AS [نمره درس], 
                      dbo.tMark.gClass AS [رتبه در کلاس], dbo.tMark.gKoll AS [رتبه در پایه], dbo.tMark.M1 AS نمره1, dbo.tMark.M2 AS نمره2, dbo.tMark.M3 AS نمره3, 
                      dbo.tMark.M4 AS نمره4, dbo.tMark.M5 AS نمره5, dbo.tMark.M6 AS نمره6, dbo.tMark.M7 AS نمره7, dbo.tMark.M8 AS نمره8
FROM         dbo.tMark INNER JOIN
                      dbo.tStudent ON dbo.tMark.xStudent = dbo.tStudent.id INNER JOIN
                      dbo.tPaye ON dbo.tStudent.xPaye = dbo.tPaye.id INNER JOIN
                      dbo.tClass ON dbo.tStudent.xClass = dbo.tClass.id INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id INNER JOIN
                      dbo.tExam ON dbo.tMark.Xtest = dbo.tExam.id
where tStudent.XClass IN (select * from SplitNumber(@Class)) 
and tMark.Xtest in(select * from SplitNumber(@Exam)) 
union
SELECT     dbo.tStudent.sort AS ردیف, dbo.tExam.Name AS [عنوان دوره], dbo.tClass.name AS کلاس, dbo.tStudent.Code AS [شماره پرونده], dbo.tStudent.FName AS نام, 
                      dbo.tStudent.LName AS [نام خانوادگی], 100000 AS [کد درس],'معدل' AS [نام درس],round(dbo.tMarkDoreh.MarkDoreh ,2)AS [نمره درس], 
                      dbo.tMarkDoreh.gClass AS [رتبه در کلاس], dbo.tMarkDoreh.gKoll AS [رتبه در پایه], null AS نمره1, null AS نمره2, null AS نمره3, 
                      null AS نمره4, null AS نمره5, null AS نمره6, null AS نمره7, null AS نمره8
FROM         dbo.tMarkDoreh INNER JOIN
                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id INNER JOIN
                      dbo.tPaye ON dbo.tStudent.xPaye = dbo.tPaye.id INNER JOIN
                      dbo.tClass ON dbo.tStudent.xClass = dbo.tClass.id INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id
where tStudent.XClass IN (select * from SplitNumber(@Class)) 
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) and tMarkDoreh.typ=5

ORDER BY [عنوان دوره],کلاس, ردیف,  [نام خانوادگی],نام, [شماره پرونده],[کد درس]

