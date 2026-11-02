CREATE  PROCEDURE dbo.sp_List_books_RengMark
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 


CREATE TABLE #tmp (
	[xStudent] [int] NULL ,
	[Xtest] [int] NULL ,
	[typ] [smallint] NULL ,
	[xbook] [int] NULL ,
	[book] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[mark] [float] NULL ,
	[sort] [smallint] NULL ,
        [xPaye] [int] NULL ,
	[xClass] [int] NULL 
)
INSERT INTO #tmp 
                      (xStudent, Xtest, typ, xbook, book, mark, sort,xPaye,xClass) 
SELECT     tMark.xStudent, tMark.Xtest, tMark.typ, tMark.xbook, tBook.Name AS book, ROUND(tMark.Mark, 6) AS mark,
            tBook.sort,tYear_Student.xpaye,tYear_Student.xclass
 FROM    tMark INNER JOIN
                      tBook ON tMark.xbook = tBook.id INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE   tMark.mark is not null and  (tMark.typ = 1) and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMark.Xtest in(select * from SplitNumber(@Exam)) 

INSERT INTO #tmp 
                      (xStudent, Xtest, typ, xbook, book, mark, sort,xPaye,xClass) 
SELECT     tMarkDoreh.xStudent, tMarkDoreh.Xtest, tMarkDoreh.typ,-5,N'معدل', ROUND(tMarkDoreh.MarkDoreh, 6) AS mark, 10000,
tYear_Student.xpaye,tYear_Student.xclass
 FROM    tMarkDoreh  INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE   tMarkDoreh.MarkDoreh is not null  and    (tMarkDoreh.typ = 5) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 



SELECT     #tmp.*, tExam.Name AS Exam, tExam.DateFrom AS DateFrom, tExam.DateTo AS DateTo, tExam.NumExam AS NumExam, tPaye.Name AS Paye, 
                      tClass.name AS Class
FROM         #tmp INNER JOIN
                      tExam ON #tmp.Xtest = tExam.id INNER JOIN
                      tPaye ON #tmp.xPaye = tPaye.id INNER JOIN
                      tClass ON #tmp.xClass = tClass.id

drop table #tmp