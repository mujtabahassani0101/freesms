--13980510
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFWUUI2QUdnQU5BQlVBRlVBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 
--spRpt_StdKarnameDoreh2 101,'32,33,34,35',1398
alter  procedure dbo.spRpt_StdKarnameDoreh2
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
SELECT     TOP 5 tMarkDoreh.Xtest
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



select tmpStd.*, tmpMark.CountAb, tmpMark.M1, tmpMark.M2, tmpMark.M3, tmpMark.M4, tmpMark.M5, 
   tmpMark.M6, tmpMark.M7, tmpMark.M8, tmpMark.M9, tmpMark.M10, tmpMark.Mark, tmpMark.Tosif, tmpMark.gClass, tmpMark.gKoll
,tmpCommentKoll.comment as CommentKoll,tmpavgClass.avgClass
 from 
(SELECT  tStudent.id as xStudent, tStudent.Code,tStudent.NumberAsas,tStudent.sh_sh, tStudent.FName, tStudent.LName, tStudent.PName,tStudentImg.Student_img, tYear_Student.xPaye, tYear_Student.xClass, 0 as xReshteh,tParmetr.Foter1 as modir,tParmetr.sch as school, tClass.name as Class,tClass.answerable, 
                      tPaye.Name AS Paye,tBook.id as xBook, tBook.Name AS Book, tBook.vahed, tBook.sort ,
  tYear_Student.xyear,tYear_Student.hazer1, tYear_Student.hazer2, tYear_Student.Ghayeb1, tYear_Student.Ghayeb2, tYear_Student.Mariz1, tYear_Student.Mariz2, tYear_Student.rokhsat1, 
                      tYear_Student.rokhsat2,tMarkDoreh.Summark,tMarkDoreh.MarkDoreh100,dbo.ReturnTosif( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as TosifMark5,dbo.ReturnLevel( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Level5,dbo.ReturnComment( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Comment5,tMarkDoreh.acp, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass AS gClassKoll,
                       tMarkDoreh.gPaye AS gPayeKoll, tMarkDoreh.gKoll AS gSchKoll,#TmpCountClass.CountClass,#TmpCountPaye.CountPaye,tTeacher.fnamf as TchFname,tTeacher.fnaml as tchLname,
 tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, tExam.NumExam,tbook.TimeWeek,
#tmp.test1 ,#tmp.Mark1 ,#tmp.gSch1 ,#tmp.gCls1 ,
#tmp.test2 ,#tmp.Mark2 ,#tmp.gSch2 ,#tmp.gCls2 ,

#tmp.test3 ,#tmp.Mark3 ,#tmp.gSch3 ,#tmp.gCls3 ,
#tmp.test4 ,#tmp.Mark4 ,#tmp.gSch4 ,#tmp.gCls4 ,
#tmp.test5 ,#tmp.Mark5 ,#tmp.gSch5 ,#tmp.gCls5 ,
#tmp.test6 ,#tmp.Mark6 ,#tmp.gSch6 ,#tmp.gCls6 ,
#tmp.test7 ,#tmp.Mark7 ,#tmp.gSch7 ,#tmp.gCls7 ,
#tmp.test8 ,#tmp.Mark8 ,#tmp.gSch8 ,#tmp.gCls8 ,
#tmp.test9 ,#tmp.Mark9 ,#tmp.gSch9 ,#tmp.gCls9 

FROM    
                      tStudent inner join
		      tYear_Student ON tStudent.id=tYear_Student.xStudent  INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xpaye INNER JOIN 
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xstudent
                      INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id   LEFT OUTER JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent  CROSS JOIN  tParmetr

LEFT OUTER JOIN
tTch_Cls on tYear_Student.xClass= tTch_Cls.xCls and tbook.id =tTch_Cls.xLsn LEFT OUTER JOIN tTeacher
 on tTch_Cls.xTch= tTeacher.id 

INNER JOIN
#TmpCountClass on tMarkDoreh.Xtest= #TmpCountClass.Xtest and tYear_Student.xPaye=#TmpCountClass.xPaye    and tYear_Student.xclass=#TmpCountClass.xclass  
INNER JOIN
#TmpCountPaye on tMarkDoreh.Xtest= #TmpCountPaye.Xtest and tYear_Student.xPaye=#TmpCountPaye.xPaye
left outer join #tmp on tStudent.id=#tmp.xStudent 
WHERE     (tMarkDoreh.typ = 5)
and tYear_Student.xYear=@xYear
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.xClass in(select * from SplitNumber(@Class)))tmpStd
left outer join
(
   select tMark.xStudent,tMark.xtest,tMark.xbook,tMark.CountAb, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, 
   tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, tMark.Mark, dbo.ReturnTosif( tMark.Mark,tMark.xtest) as Tosif,dbo.ReturnLevel( tMark.Mark,tMark.xtest) as LevelBook, tMark.gClass, tMark.gKoll
   from tmark inner join tstudent on tmark.xstudent=tstudent.id inner join
   tYear_Student ON tStudent.id=tYear_Student.xStudent
   where  tmark.Xtest in(select * from SplitNumber(@Exam)) 
   and tYear_Student.xYear=@xYear
   and tYear_Student.xClass in(select * from SplitNumber(@Class))
) tmpMark on tmpStd.xstudent=tmpMark.xstudent and tmpStd.xbook=tmpMark.xbook
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
) tmpCommentKoll on tmpStd.xstudent=tmpCommentKoll.xstudent

left outer join
(SELECT     dbo.tMark.Xtest,tMark.xbook, dbo.tYear_Student.xClass, AVG(dbo.tMark.Mark) AS AvgClass
FROM         dbo.tMark INNER JOIN
                      dbo.tStudent ON dbo.tMark.xStudent = dbo.tStudent.id inner join
        tYear_Student ON tStudent.id=tYear_Student.xStudent
WHERE  tMark.Xtest in(select * from SplitNumber(@Exam)) 
 and tYear_Student.xYear=@xYear
 and tYear_Student.xClass in(select * from SplitNumber(@Class))
  and  (dbo.tMark.typ = 1)
GROUP BY dbo.tMark.Xtest,tMark.xbook, dbo.tYear_Student.xClass)
tmpavgClass 
on tmpStd.xClass=tmpavgClass.xClass and tmpMark.Xtest=tmpavgClass.Xtest and tmpMark.xbook=tmpavgClass.xbook


 


drop table #TmpCountClass
drop table #TmpCountPaye
drop table #tmp


GO
--spRpt_StdKarnameDoreh1 101,'32,33,34,35',1398
alter  procedure spRpt_StdKarnameDoreh1
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
SELECT     TOP 5 tMarkDoreh.Xtest
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



SELECT     tMark.xStudent, tStudent.Code,tStudent.NumberAsas,tStudent.sh_sh, tStudent.FName, tStudent.LName, tStudent.PName,tStudentImg.Student_img, tYear_Student.xPaye, tYear_Student.xClass,0 as xReshteh,tParmetr.Foter1 as modir,tParmetr.sch as school, tClass.name as Class,tClass.answerable, 
                       tPaye.Name AS Paye, tBook.Name AS Book, tBook.vahed, tBook.sort , tYear_Student.xyear, tYear_Student.hazer1, tYear_Student.hazer2, tYear_Student.Ghayeb1, tYear_Student.Ghayeb2, tYear_Student.Mariz1, tYear_Student.Mariz2, tYear_Student.rokhsat1, 
                      tYear_Student.rokhsat2,tMarkDoreh.Summark,tMarkDoreh.MarkDoreh100,dbo.ReturnTosif( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as TosifMark5,dbo.ReturnLevel( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Level5,dbo.ReturnComment( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Comment5,tMarkDoreh.acp,
 tMark.CountAb, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, 
                      tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, tMark.Mark, dbo.ReturnTosif( tMark.Mark,tMark.xtest) as Tosif,dbo.ReturnLevel( tMark.Mark,tMark.xtest) as LevelBook, tMark.gClass, tMark.gKoll, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass AS gClassKoll,
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
                      tStudentImg ON tStudent.id = tStudentImg.xStudent CROSS JOIN  tParmetr
                      
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






GO
alter  procedure sp_Procc
@Exam int  with encryption
as
declare @xYear int
select @xYear=xYear from texam where id=@Exam



------------------------------------------------------------
declare @xterm int
select @xterm=term from texam where id=@Exam

if(@xterm=3)
begin
     
declare @ExamTerm1 int
declare @ExamTerm2 int

select @ExamTerm1=id from texam where term=1 and xYear=@xYear
select @ExamTerm2=id from texam where term=2 and xYear=@xYear


	insert  into tmark (xstudent,xbook,xtest,typ)
	select xStudent,xbook ,@Exam,1
	from
	(SELECT     xStudent, xbook
	FROM         tMark
	WHERE     (Xtest IN (@ExamTerm1, @ExamTerm2))
	and cast(xStudent as varchar)+'-'+cast(xbook as varchar) not in(select cast(xStudent as varchar)+'-'+cast(xbook as varchar) as  id from tMark where xtest=@Exam))tmp
	
	
	delete from tmark where xtest =@Exam 
	and cast(xStudent as varchar)+'-'+cast(xbook as varchar) not in (select cast(xStudent as varchar)+'-'+cast(xbook as varchar) as  id from tMark where xtest in(@ExamTerm1,@ExamTerm2))
	
	
	update tmark set m1=  tMark_1.Mark
	FROM         tMark INNER JOIN
	                      tMark tMark_1 ON tMark.xStudent = tMark_1.xStudent AND tMark.typ = tMark_1.typ AND tMark.xbook = tMark_1.xbook
	WHERE     (tMark.Xtest = @Exam) AND (tMark_1.Xtest = @ExamTerm1)
	
	update tmark set m2=  tMark_1.Mark
	FROM         tMark INNER JOIN
	                      tMark tMark_1 ON tMark.xStudent = tMark_1.xStudent AND tMark.typ = tMark_1.typ AND tMark.xbook = tMark_1.xbook
	WHERE     (tMark.Xtest = @Exam) AND (tMark_1.Xtest = @ExamTerm2)
	
	
	update tmark set mark =isnull(m1,0)+isnull(m2,0) 
	where xtest=@Exam
end
------------------------


delete from tmark where  Xtest=@Exam and typ<>1 
update tMark  set gClass=null,gKoll=null,xExportRpt=null where Xtest=@Exam
declare @xbook int
declare @xtest bigint
declare @xClass bigint
declare @xStudent bigint
declare @Mark float
declare @tmp_Mark float
declare @Rotbe int
declare @tmp_Rotbe int

set @Rotbe=1
set @tmp_Rotbe=1


create table #tmp (  Xtest bigint,xClass int,xbook int ,mark float,gClass smallint)
insert into #tmp
	SELECT   distinct tMark.Xtest, tYear_Student.xClass, tMark.xbook, round(tMark.Mark,6),null
                   
		FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                    where tMark.mark is not null and    tMark.Xtest=@Exam  AND (tYear_Student.xYear = @xYear)

 
declare Rbt cursor for
  select distinct xbook,Xtest,xClass from #tmp
       open Rbt
        fetch next from Rbt into 
          @xbook,@xtest,@xClass
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select mark from #tmp where xbook= @xbook and Xtest=@xtest and xClass=@xClass  order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
            @mark
 
           set @Rotbe=1
        while (@@fetch_status = 0)
        begin
	 
	     UPDATE #tmp SET  gClass = @Rotbe WHERE  xClass=@xClass and xbook= @xbook and mark=@mark
	      
	     set @Rotbe=@Rotbe+1

             fetch next from Rbt2 into 
	        @mark
       end
       close Rbt2
       deallocate Rbt2 

        set @Rotbe=1
	    fetch next from Rbt into 
	        @xbook,@xtest,@xClass
       end
       close Rbt
       deallocate Rbt 



update tMark set tMark.gClass=#tmp.gClass
from tMark 
inner join #tmp 
on round(tMark.mark,6)=#tmp.mark 
and  tMark.xbook=#tmp.xbook 
and  tMark.Xtest=#tmp.Xtest

inner join tyear_student
on tMark.xStudent=tyear_student.xStudent and #tmp.xClass=tyear_student.xClass
where tyear_student.xYear=@xYear

delete from #tmp

insert into #tmp
	SELECT   distinct tMark.Xtest, null, tMark.xbook, round(tMark.Mark,6),null
                   
		FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                    where tMark.mark is not null and    tMark.Xtest=@Exam  AND (tYear_Student.xYear = @xYear)




declare Rbt cursor for
  select distinct xbook,Xtest from #tmp
       open Rbt
        fetch next from Rbt into 
          @xbook,@xtest
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select mark from #tmp where xbook= @xbook and Xtest=@xtest order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @mark

              set @Rotbe=1
        while (@@fetch_status = 0)
        begin

	 
	         UPDATE #tmp SET gClass = @Rotbe WHERE  xbook= @xbook and mark=@mark
	         set @Rotbe=@Rotbe+1
	
	

             fetch next from Rbt2 into 
	        @mark
       end
       close Rbt2
       deallocate Rbt2 

       set @Rotbe=1

	    fetch next from Rbt into 
	        @xbook,@xtest
       end
       close Rbt
       deallocate Rbt 




update tMark set tMark.gkoll=#tmp.gClass
from tMark 
inner join #tmp 
on round(tMark.mark,6)=#tmp.mark 
and  tMark.xbook=#tmp.xbook 
and  tMark.Xtest=#tmp.Xtest
inner join tyear_student
on tMark.xStudent=tyear_student.xStudent
where tyear_student.xYear=@xYear


drop table #tmp


GO
alter table tMarkDoreh add gClass2 int,gPaye2 int ,gKoll2 int
GO
alter procedure dbo.sp_CalcMarkDoreh 
@Exam int with encryption
as
declare @xYear int
declare @xTerm int
select @xYear=xYear,@xTerm=term from texam where id=@Exam
delete from tMarkDoreh where Xtest=@Exam and typ<>4
 
declare @zarib100 float
if(@xTerm=0)
 set @zarib100=1
else if(@xTerm=1)
 set @zarib100=2.5
else if(@xTerm=2)
 set @zarib100=1.666666
else if(@xTerm=3)
 set @zarib100=1


INSERT INTO tMarkDoreh
                      (xStudent, Xtest, typ, MarkDoreh,SumMark,MarkDoreh100,acp)
SELECT     tMark.xStudent, tMark.Xtest, 5 AS Expr1, SUM(tMark.Mark * tBook.vahed) / SUM(tBook.vahed) AS Expr2, 
SUM(tMark.Mark), round(SUM(tMark.Mark * tBook.vahed) / SUM(tBook.vahed) *@zarib100,6),1
FROM         tMark INNER JOIN
                      tBook ON tMark.xbook = tBook.id
WHERE     (tMark.Mark IS NOT NULL)  and (tMark.Xtest =@Exam)  
and tBook.vahed>0
GROUP BY tMark.xStudent, tMark.Xtest

if(@xTerm=1)
begin
	update tMarkDoreh set acp=0 where xtest=@Exam and xstudent in(
	select xstudent as countB from tmark where
	xtest=@Exam and 
	mark <16 group by xstudent
	having count(*)>=1)
end
else if(@xTerm=3)
begin
	update tMarkDoreh set acp=0 where xtest=@Exam and xstudent in(
	select xstudent as countB from tmark where
	xtest=@Exam and 
	mark <16 group by xstudent
	having count(*)>3)
end
else if(@xTerm=3)
begin
	update tMarkDoreh set acp=2 where xtest=@Exam and xstudent in(
	select xstudent as countB from tmark where
	xtest=@Exam and 
	mark <16 group by xstudent
	having count(*)<=3)
end



declare @xClass int
declare @xPaye int
declare @xStudent int
declare @Mark float
declare @tmp_Mark float
declare @Rotbe int
declare @tmp_Rotbe int

set @Rotbe=1
set @tmp_Rotbe=1


create table #tmp (  xStudent bigint,xClass int,xPaye int,mark float,gClass smallint,gPaye smallint,gKoll smallint)
insert into #tmp
	SELECT     tMarkDoreh.xStudent, tYear_Student.xClass,tYear_Student.xPaye, tMarkDoreh.MarkDoreh, NULL AS Expr1 , NULL AS Expr2, NULL AS Expr3
                   
		FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
                     
             where tMarkDoreh.Xtest=@Exam and typ=5  AND (tYear_Student.xYear = @xYear)

----------------------------------------------------------------------
declare Rbt cursor for
  select distinct xPaye,xClass from #tmp
       open Rbt
        fetch next from Rbt into 
          @xPaye,@xClass
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select xStudent,mark from #tmp where     xPaye=@xPaye and xClass=@xClass   order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @xStudent,@mark

              set @Rotbe=1
	      set @tmp_Rotbe=1
              set @tmp_Mark=1000
        while (@@fetch_status = 0)
        begin
	   if @tmp_Mark <> @Mark
	      begin
	         UPDATE #tmp SET  gClass = @tmp_Rotbe WHERE xStudent=@xStudent
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmp SET  gClass = @Rotbe WHERE  xStudent=@xStudent 
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 

	    fetch next from Rbt into 
	       @xPaye,@xClass
       end
       close Rbt
       deallocate Rbt 
-----------------------------------------------------

declare Rbt cursor for
  select distinct xPaye from #tmp
       open Rbt
        fetch next from Rbt into 
          @xPaye
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select xStudent,mark from #tmp where  xPaye=@xPaye  order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @xStudent,@mark

              set @Rotbe=1
	      set @tmp_Rotbe=1
              set @tmp_Mark=1000
        while (@@fetch_status = 0)
        begin
	   if @tmp_Mark <> @Mark
	      begin
	         UPDATE #tmp SET  gPaye = @tmp_Rotbe WHERE xStudent=@xStudent
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmp SET  gPaye = @Rotbe  WHERE  xStudent=@xStudent 
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 

	    fetch next from Rbt into 
	      @xPaye
       end
       close Rbt
       deallocate Rbt 
----------------------------------------------------
  declare Rbt2 cursor for
     select xStudent,mark from #tmp order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @xStudent,@mark

              set @Rotbe=1
	      set @tmp_Rotbe=1
              set @tmp_Mark=1000
        while (@@fetch_status = 0)
        begin
	   if @tmp_Mark <> @Mark
	      begin
	         UPDATE #tmp SET  gKoll = @tmp_Rotbe WHERE xStudent=@xStudent 
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmp SET  gKoll = @Rotbe WHERE  xStudent=@xStudent
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 

update tMarkDoreh set tMarkDoreh.gClass2=#tmp.gClass, tMarkDoreh.gPaye2=#tmp.gPaye,tMarkDoreh.gKoll2=#tmp.gKoll
from tMarkDoreh inner join #tmp on tMarkDoreh.xStudent=#tmp.xStudent 
and  tMarkDoreh.Xtest=@Exam and tMarkDoreh.typ=5
drop table #tmp




------aaaaaaaaaaaaaaaaaaaaa--------------------------------


create table #tmp2 ( xClass int,mark float,gClass smallint)
insert into #tmp2
	SELECT  distinct  tYear_Student.xClass,round( tMarkDoreh.MarkDoreh,6), NULL AS Expr1 
                   
		FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
                     
             where tMarkDoreh.Xtest=@Exam and typ=5  AND (tYear_Student.xYear = @xYear)

----------------------------------------------------------------------
declare Rbt cursor for
  select distinct xClass from #tmp2
       open Rbt
        fetch next from Rbt into 
          @xClass
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select mark from #tmp2 where  xClass=@xClass   order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @mark

            set @Rotbe=1
	    
        while (@@fetch_status = 0)
        begin
	   
	      UPDATE #tmp2 SET  gClass = @Rotbe WHERE xClass=@xClass  and mark=@mark
	       set @Rotbe=@Rotbe+1

	

             fetch next from Rbt2 into 
	        @mark

        
       end
       close Rbt2
       deallocate Rbt2 

       set @Rotbe=1

	    fetch next from Rbt into 
	       @xClass
       end
       close Rbt
       deallocate Rbt 

update tMarkDoreh set tMarkDoreh.gClass=#tmp2.gClass
from tMarkDoreh 
inner join #tmp2 
on round(tMarkDoreh.MarkDoreh,6)=#tmp2.mark 
inner join tyear_student
on tMarkDoreh.xStudent=tyear_student.xStudent and #tmp2.xClass=tyear_student.xClass
where tyear_student.xYear=@xYear and tMarkDoreh.xtest=@Exam and tMarkDoreh.typ=5

delete from #tmp2

-----------------------------------------------------

insert into #tmp2
	SELECT  distinct  tYear_Student.xPaye,round( tMarkDoreh.MarkDoreh,6), NULL AS Expr1 
                   
		FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
                     
             where tMarkDoreh.Xtest=@Exam and typ=5  AND (tYear_Student.xYear = @xYear)

----------------------------------------------------------------------
declare Rbt cursor for
  select distinct xClass from #tmp2
       open Rbt
        fetch next from Rbt into 
          @xClass
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select mark from #tmp2 where  xClass=@xClass   order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @mark

            set @Rotbe=1
	    
        while (@@fetch_status = 0)
        begin
	   
	      UPDATE #tmp2 SET  gClass = @Rotbe WHERE xClass=@xClass  and mark=@mark
	       set @Rotbe=@Rotbe+1

	

             fetch next from Rbt2 into 
	        @mark

        
       end
       close Rbt2
       deallocate Rbt2 

       set @Rotbe=1

	    fetch next from Rbt into 
	       @xClass
       end
       close Rbt
       deallocate Rbt 

update tMarkDoreh set tMarkDoreh.gPaye=#tmp2.gClass
from tMarkDoreh 
inner join #tmp2 
on round(tMarkDoreh.MarkDoreh,6)=#tmp2.mark 
inner join tyear_student
on tMarkDoreh.xStudent=tyear_student.xStudent and #tmp2.xClass=tyear_student.xPaye
where tyear_student.xYear=@xYear and tMarkDoreh.xtest=@Exam and tMarkDoreh.typ=5

delete from #tmp2

-----------------------------------------------------

insert into #tmp2
	SELECT  distinct  null,round( tMarkDoreh.MarkDoreh,6), NULL AS Expr1 
                   
		FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
                     
             where tMarkDoreh.Xtest=@Exam and typ=5  AND (tYear_Student.xYear = @xYear)

----------------------------------------------------------------------

        declare Rbt2 cursor for
	select mark from #tmp2  order by mark desc
        open Rbt2
        fetch next from Rbt2 into 
          @mark

            set @Rotbe=1
	    
          while (@@fetch_status = 0)
           begin
	   
	      UPDATE #tmp2 SET  gClass = @Rotbe WHERE  mark=@mark
	       set @Rotbe=@Rotbe+1

	

             fetch next from Rbt2 into 
	        @mark

        
       end
       close Rbt2
       deallocate Rbt2 

   
update tMarkDoreh set tMarkDoreh.gKoll=#tmp2.gClass
from tMarkDoreh 
inner join #tmp2 
on round(tMarkDoreh.MarkDoreh,6)=#tmp2.mark 
inner join tyear_student
on tMarkDoreh.xStudent=tyear_student.xStudent 
where tyear_student.xYear=@xYear and tMarkDoreh.xtest=@Exam and tMarkDoreh.typ=5



drop table #tmp2





GO
alter  procedure dbo.spRpt_StdgClass3
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption  
as
SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName,tYear_Student.xClass, tMarkDoreh.Xtest, tMarkDoreh.typ, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
FROM         tStudent   INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent
WHERE     (tMarkDoreh.typ = 5) AND (tMarkDoreh.gClass2 <= 3)
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear) 
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam))
GO
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



GO


alter table tRpt add showBartar smallint 
GO
update tRpt set showBartar=1,Caption=N'اطلاع نامه چهار و نيم ماهه - عمودي' where id=104
GO
INSERT INTO tRpt
                      (id, Caption, Rpt, sp, subReport, countExam, sp2, type, term, showBartar)
VALUES     (105, N'اطلاع نامه چهار و نيم ماهه - افقي', N'CR_AF_StdKarnameDorehByChart_term1_land', N'spRpt_StdKarnameDoreh2', 
                      N'Sub1,spRpt_StdKarnameDoreh1,Sub2,spRpt_StdgClass3,Sub3,spRpt_StdgPaye3', 1, N'spRpt_StdKarnameDoreh1', 1, 1, 1)
GO
alter table tParmetr add showBartar bit
GO
update tParmetr set showBartar=1
GO
alter procedure updatetParmetr
@heder1 nvarchar(300),
@heder2 nvarchar(300),
@Foter1 nvarchar(300),
@Foter2 nvarchar(300),
@sch nvarchar(300),
@showBartar bit with encryption
as
if not exists(select heder1 from tParmetr)
INSERT INTO tParmetr
                      (heder1, heder2, Foter1, Foter2, sch,showBartar)
          VALUES     (@heder1, @heder2,@Foter1, @Foter2,@sch,@showBartar)
else
update tParmetr set heder1=@heder1,heder2=@heder2,
Foter1=@Foter1,Foter2=@Foter2,sch=@sch ,showBartar=@showBartar,
xExportRpt=null
GO
alter procedure dbo.spRpt_ListStdMoadel1
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption
as
select tmpStd.*, tmpMark.MarkDoreh as Mark, tmpMark.gClass,tmpMark.gPaye,tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest,tYear_Student.sort
                      FROM         tStudent INNER JOIN
                       tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON  tYear_Student.xClass = tClass.id  INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  
where tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear) 
 )tmpStd


inner join
( select tMarkDoreh.xstudent,tMarkDoreh.MarkDoreh, dbo.ReturnTosif( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Tosif,tMarkDoreh.gClass,tMarkDoreh.gPaye, tMarkDoreh.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo
from
  tMarkDoreh INNER JOIN
   tExam ON tMarkDoreh.Xtest = tExam.id 
where tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) and typ=5)tmpMark 
on tmpStd.xstudent=tmpMark.xstudent





GO
alter procedure dbo.spRpt_ListStdMoadel2
@Exam varchar(500),
@Class varchar(500)   ,
@xYear int  with encryption
as
select tmpStd.*, tmpMark.MarkDoreh as Mark, tmpMark.gClass,tmpMark.gPaye,tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest,tYear_Student.sort
                       FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON  tYear_Student.xClass = tClass.id  INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  
where tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear) 
 )tmpStd


left outer join
( select tMarkDoreh.xstudent,tMarkDoreh.MarkDoreh, dbo.ReturnTosif( tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as Tosif,tMarkDoreh.gClass,tMarkDoreh.gPaye, tMarkDoreh.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo
from
  tMarkDoreh INNER JOIN
   tExam ON tMarkDoreh.Xtest = tExam.id 
where tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) and typ=5)tmpMark 
on tmpStd.xstudent=tmpMark.xstudent

GO
update trpt set id=106 where id=1045
GO
update trpt set id=107 where id=1046
GO
update trpt set id=108 where id=1047
GO
update texam set procc=0
GO