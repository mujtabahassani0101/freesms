CREATE procedure spRpt_AvgClassBooks_2 --102,'6,7,8,9'
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
as
SELECT     tExam.Name AS Exam, tPaye.Name AS Paye, tClass.name AS Class, tBook.Name AS Book, tBook.sort, tExam.DateFrom, tExam.DateTo, 
                      AVG(tMark.Mark) AS mark
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tMark ON tStudent.id = tMark.xStudent INNER JOIN
                      tExam ON tMark.Xtest = tExam.id INNER JOIN
                      tBook ON tMark.xbook = tBook.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id

where tMark.Xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)
GROUP BY tExam.Name, tPaye.Name, tClass.name, tBook.Name, tBook.sort, tExam.DateFrom, tExam.DateTo
union
SELECT     tExam.Name AS Exam, tPaye.Name AS Paye, tClass.name AS Class, N'معدل' AS Book, 100 AS sort, tExam.DateFrom, tExam.DateTo, 
                      AVG(tMarkDoreh.MarkDoreh) AS mark
FROM       tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id
where tMarkDoreh.typ=5 and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)
GROUP BY tExam.Name, tPaye.Name, tClass.name, tExam.DateFrom, tExam.DateTo
order by Exam,Paye,Class,Mark desc