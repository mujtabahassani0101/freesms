--spRpt_StdKarnameDoreh1 101,'32,33,34,35',1398
CREATE  procedure spRpt_StdKarnameDoreh1
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption
as


declare @xTest int   
declare @Test nvarchar(100)   
declare @counter int   
declare @Sql nvarchar(500)   
declare @NumExam int     
set @counter=1

create table #TmpCountClass(Xtest int,xPaye int,xClass int,CountClass int)
insert into #TmpCountClass
SELECT     tMarkDoreh.Xtest, tYear_Student.xPaye, tYear_Student.xClass, COUNT(tMarkDoreh.xStudent) AS CountClass
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id inner join
		      tYear_Student ON tStudent.id=tYear_Student.xStudent
WHERE     (tMarkDoreh.typ = 5) and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.xYear=@xYear
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
GROUP BY  tMarkDoreh.Xtest, tYear_Student.xPaye,tYear_Student.xClass


create table #TmpCountPaye(Xtest int,xPaye int,CountPaye int)
insert into #TmpCountPaye
SELECT     tMarkDoreh.Xtest, tYear_Student.xPaye, COUNT(tMarkDoreh.xStudent) AS CountPaye
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id inner join
		      tYear_Student ON tStudent.id=tYear_Student.xStudent
WHERE     (tMarkDoreh.typ = 5) and tYear_Student.xYear=@xYear
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
GROUP BY  tMarkDoreh.Xtest, tYear_Student.xPaye
create table #tmp 
(xStudent int,
xtest1 int,test1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xtest2 int,test2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xtest3 int,test3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xtest4 int,test4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xtest5 int,test5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xtest6 int,test6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xtest7 int,test7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xtest8 int,test8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xtest9 int,test9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int
)
insert into #tmp (xStudent)
SELECT DISTINCT tMarkDoreh.xStudent
FROM         tMarkDoreh INNER JOIN
tStudent ON tMarkDoreh.xStudent = tStudent.id inner join
tYear_Student ON tStudent.id=tYear_Student.xStudent
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.xYear=@xYear
and tMarkDoreh.typ=5 and tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 

declare Test cursor for
SELECT DISTINCT tMarkDoreh.Xtest, tExam.Name, tExam.NumExam
FROM         tMarkDoreh INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id inner join
tYear_Student ON tStudent.id=tYear_Student.xStudent
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.xYear=@xYear
and tExam.xYear=@xYear
and  tMarkDoreh.xtest not in(select * from SplitNumber(@Exam)) 
and tMarkDoreh.xtest in
(
SELECT     TOP 7 tMarkDoreh.Xtest
FROM         tMarkDoreh INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id inner join
tYear_Student ON tStudent.id=tYear_Student.xStudent
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.xYear=@xYear
and tExam.xYear=@xYear
and  tMarkDoreh.xtest not in(select * from SplitNumber(@Exam)) 
GROUP BY tMarkDoreh.Xtest, tExam.NumExam
ORDER BY tExam.NumExam DESC
)
ORDER BY tExam.NumExam
       open Test
fetch next from Test into 
  @xTest,@Test,@NumExam
Set @counter=1
while (@@fetch_status=0)

begin

set @Sql='update  #tmp set xtest'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xTest)+',Test'+convert(varchar(2),@counter)+'=N'''+@Test+''''
exec(@Sql)

set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tMarkDoreh.MarkDoreh,gSch'+convert(varchar(2),@counter)+'=tMarkDoreh.gPaye,gCls'+convert(varchar(2),@counter)+'=tMarkDoreh.gClass'
+' FROM  tMarkDoreh INNER JOIN #tmp ON tMarkDoreh.xStudent = #tmp.xStudent '
+' WHERE tMarkDoreh.xTest = '+convert(varchar(6),@xtest) 
exec(@Sql)
set @counter=@counter+1

fetch next from Test into 
 @xTest,@Test,@NumExam

end

close Test
deallocate Test



SELECT     tMark.xStudent, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName,tStudentImg.Student_img, tYear_Student.xPaye, tYear_Student.xClass,0 as xReshteh, tClass.name as Class, 
                       tPaye.Name AS Paye, tBook.Name AS Book, tBook.vahed, tBook.sort , tMark.CountAb, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, 
                      tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, tMark.Mark, dbo.ReturnTosif( tMark.Mark) as Tosif, tMark.gClass, tMark.gKoll, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass AS gClassKoll,
                       tMarkDoreh.gPaye AS gPayeKoll, tMarkDoreh.gKoll AS gSchKoll,#TmpCountClass.CountClass,#TmpCountPaye.CountPaye,tTeacher.fnamf as TchFname,tTeacher.fnaml as tchLname, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, tExam.NumExam,tbook.TimeWeek,
tmpCommentKoll.comment as CommentKoll,tmpavgClass.avgClass,
#tmp.test1 ,#tmp.Mark1 ,#tmp.gSch1 ,#tmp.gCls1 ,
#tmp.test2 ,#tmp.Mark2 ,#tmp.gSch2 ,#tmp.gCls2 ,
#tmp.test3 ,#tmp.Mark3 ,#tmp.gSch3 ,#tmp.gCls3 ,
#tmp.test4 ,#tmp.Mark4 ,#tmp.gSch4 ,#tmp.gCls4 ,
#tmp.test5 ,#tmp.Mark5 ,#tmp.gSch5 ,#tmp.gCls5 ,
#tmp.test6 ,#tmp.Mark6 ,#tmp.gSch6 ,#tmp.gCls6 ,
#tmp.test7 ,#tmp.Mark7 ,#tmp.gSch7 ,#tmp.gCls7 ,
#tmp.test8 ,#tmp.Mark8 ,#tmp.gSch8 ,#tmp.gCls8 ,
#tmp.test9 ,#tmp.Mark9 ,#tmp.gSch9 ,#tmp.gCls9 

FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id inner join
		      tYear_Student ON tStudent.id=tYear_Student.xStudent INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tBook ON tMark.xbook = tBook.id INNER JOIN
                      tExam ON tMark.Xtest = tExam.id INNER JOIN 
                      tMarkDoreh ON tMark.Xtest = tMarkDoreh.Xtest AND tMark.xStudent = tMarkDoreh.xStudent  LEFT OUTER JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent 
                      
LEFT OUTER JOIN
tTch_Cls on tYear_Student.xClass= tTch_Cls.xCls and tMark.xbook =tTch_Cls.xLsn LEFT OUTER JOIN tTeacher
 on tTch_Cls.xTch= tTeacher.id 


INNER JOIN
#TmpCountClass on tMark.Xtest= #TmpCountClass.Xtest and tYear_Student.xPaye=#TmpCountClass.xPaye    and tYear_Student.xclass=#TmpCountClass.xclass  
INNER JOIN
#TmpCountPaye on tMark.Xtest= #TmpCountPaye.Xtest and tYear_Student.xPaye=#TmpCountPaye.xPaye
left outer join #tmp on tStudent.id=#tmp.xStudent 
left outer join
(
	SELECT     tComnentKarname.xStudent, tComnentKarname.Xtest, tComnentKarname.Comment
	FROM  tComnentKarname INNER JOIN
	tStudent ON tComnentKarname.xStudent = tStudent.id inner join
        tYear_Student ON tStudent.id=tYear_Student.xStudent
	WHERE (tComnentKarname.typ = 5)  
	and tYear_Student.xYear=@xYear
	AND tYear_Student.XClass IN (SELECT * FROM SplitNumber(@Class))
	AND tComnentKarname.xtest IN (SELECT * FROM SplitNumber(@Exam))
) tmpCommentKoll on tStudent.id=tmpCommentKoll.xstudent
left outer join
(SELECT     dbo.tMark.Xtest,tMark.xbook, dbo.tYear_Student.xClass, AVG(dbo.tMark.Mark) AS AvgClass
FROM         dbo.tMark INNER JOIN
                      dbo.tStudent ON dbo.tMark.xStudent = dbo.tStudent.id inner join
		      tYear_Student ON tStudent.id=tYear_Student.xStudent
WHERE  tMark.Xtest in(select * from SplitNumber(@Exam)) 
 and tYear_Student.xClass in(select * from SplitNumber(@Class))
  and  (dbo.tMark.typ = 1)
GROUP BY dbo.tMark.Xtest,tMark.xbook, dbo.tYear_Student.xClass)
tmpavgClass 
on tYear_Student.xClass=tmpavgClass.xClass and tMark.Xtest=tmpavgClass.Xtest and tMark.xbook=tmpavgClass.xbook
WHERE     (tMarkDoreh.typ = 5)
and tMark.Xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.xClass in(select * from SplitNumber(@Class))
drop table #TmpCountClass
drop table #TmpCountPaye
drop table #tmp