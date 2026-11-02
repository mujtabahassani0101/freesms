CREATE procedure dbo.spRpt_AvgClassBooksTch
@Exam varchar(500),
@Class varchar(500),
@xYear int with encryption
as

SELECT     tExam.Name AS Exam, tBook.xPaye, tPaye.Name AS Paye, tClass.name AS Class, tBook.Name AS Book, tBook.sort, tmpmark.avgMark, tTeacher.fNamF, 
                      tTeacher.fNamL, tTch_Cls.xTch, tExam.NumExam, tmpAvg.avgMark AS avgPaye
FROM         (SELECT     tMark.Xtest, tYear_Student.xPaye, tYear_Student.xClass, tMark.xbook, AVG(tMark.Mark) AS avgMark
                        FROM         tStudent INNER JOIN
                                     tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                                     tMark ON tStudent.id = tMark.xStudent
                        WHERE     (tMark.typ = 1)and tMark.Xtest in(select * from SplitNumber(@Exam))
                        and tYear_Student.xClass in(select * from SplitNumber(@Class))
                        AND (tYear_Student.xYear = @xYear)
                        GROUP BY tMark.Xtest, tYear_Student.xPaye, tYear_Student.xClass, tMark.xbook) tmpmark INNER JOIN
                          (SELECT     tMark.Xtest, tYear_Student.xPaye, tMark.xbook, AVG(tMark.Mark) AS avgMark
                             FROM         tStudent INNER JOIN
                                          tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                                          tMark ON tStudent.id = tMark.xStudent
                             WHERE     (tMark.typ = 1) and tMark.Xtest in(select * from SplitNumber(@Exam)) 
                             GROUP BY tMark.Xtest, tYear_Student.xPaye, tMark.xbook) tmpAvg ON tmpmark.xbook = tmpAvg.xbook AND tmpmark.xPaye = tmpAvg.xPaye AND 
                      tmpmark.Xtest = tmpAvg.Xtest INNER JOIN
                      tBook ON tmpmark.xbook = tBook.id INNER JOIN
                      tPaye ON tBook.xPaye = tPaye.id INNER JOIN
                      tClass ON tmpmark.xClass = tClass.id INNER JOIN
                      tExam ON tmpmark.Xtest = tExam.id LEFT OUTER JOIN
                      tTch_Cls ON tClass.id = tTch_Cls.xCls AND tmpmark.xbook = tTch_Cls.xLsn LEFT OUTER JOIN
                      tTeacher ON tTch_Cls.xTch = tTeacher.id
ORDER BY tTch_Cls.xTch, tBook.Name, tPaye.Name, tClass.name, tExam.NumExam