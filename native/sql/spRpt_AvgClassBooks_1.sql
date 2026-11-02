CREATE procedure spRpt_AvgClassBooks_1 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
as
SELECT  tStudent.id ,tStudent.fname,tStudent.lname, dbo.tExam.Name AS Exam,    dbo.tPaye.Name AS Paye,  dbo.tClass.name AS Class, dbo.tBook.Name AS Book  , dbo.tBook.sort,  dbo.tExam.DateFrom, 
                      dbo.tExam.DateTo,dbo.tMark.Mark
FROM         dbo.tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      dbo.tClass ON dbo.tYear_Student.xClass = dbo.tClass.id INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tExam ON dbo.tMark.Xtest = dbo.tExam.id INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id INNER JOIN
                      dbo.tPaye ON dbo.tYear_Student.xPaye = dbo.tPaye.id
where tMark.Xtest in(select * from SplitNumber(@Exam))
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)
union
SELECT  tStudent.id ,tStudent.fname,tStudent.lname ,dbo.tExam.Name AS Exam,    dbo.tPaye.Name AS Paye,  dbo.tClass.name AS Class, N'معدل' as  Book, 100 as sort,  dbo.tExam.DateFrom, 
                      dbo.tExam.DateTo,dbo.tMarkDoreh.MarkDoreh as Mark
FROM         dbo.tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      dbo.tClass ON dbo.tYear_Student.xClass = dbo.tClass.id INNER JOIN
                      dbo.tMarkDoreh ON dbo.tStudent.id = dbo.tMarkDoreh.xStudent INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id INNER JOIN
                      dbo.tPaye ON dbo.tYear_Student.xPaye = dbo.tPaye.id
where tMarkDoreh.typ=5 and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam))  
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)
order by Exam,Paye,Class,tBook.sort,Book,Mark desc