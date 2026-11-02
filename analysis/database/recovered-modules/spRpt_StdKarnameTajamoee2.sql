--spRpt_StdKarnameTajamoee2 '101,102,103','13,14,15',1397
CREATE  PROCEDURE spRpt_StdKarnameTajamoee2
@Exam varchar(500),
@Class varchar(500) ,
@xYear int  with encryption
AS 

declare @lastExam int
declare @NumExam int
select @NumExam =max(NumExam) from texam where id in(select * from SplitNumber(@Exam)) 
select @lastExam=id from texam where NumExam=@NumExam

create table #TmpCountClass(xPaye int,xClass int,CountClass int)
insert into #TmpCountClass
SELECT    tYear_Student.xPaye, tYear_Student.xClass, COUNT(distinct tMarkDoreh.xStudent) AS CountClass
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE     (tMarkDoreh.typ = 5) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
GROUP BY  tYear_Student.xPaye,tYear_Student.xClass


create table #TmpCountPaye(xPaye int,CountPaye int)
insert into #TmpCountPaye
SELECT     tYear_Student.xPaye, COUNT(distinct tMarkDoreh.xStudent) AS CountPaye
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE     (tMarkDoreh.typ = 5)
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)
GROUP BY   tYear_Student.xPaye





declare @xTest int   
declare @xbook int
declare @Test nvarchar(100)   
declare @xPaye int 
declare @tmp_xTest int
declare @tmp_xPaye int 
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   


set @tmp_xTest =0
set @tmp_xPaye =0
set @counter=1


create table #tmp 
(xStudent int,xbook int,xPaye int, xClass int,countTest int,avgMark float,
xtest1 int,Test1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xTest2 int,Test2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xTest3 int,Test3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xTest4 int,Test4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xTest5 int,Test5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xTest6 int,Test6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xTest7 int,Test7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xTest8 int,Test8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xTest9 int,Test9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int
)
insert into #tmp (xStudent,xbook,xPaye,xClass,countTest)
SELECT DISTINCT tMark.xStudent, tMark.xbook, tYear_Student.xPaye, tYear_Student.xClass,0
FROM         tMark INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
insert into #tmp (xStudent,xbook,xPaye,xClass,countTest)
SELECT DISTINCT tMarkDoreh.xStudent, -5, tYear_Student.xPaye, tYear_Student.xClass,0
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 


declare Test cursor for
SELECT DISTINCT tYear_Student.xPaye, tMarkDoreh.Xtest, tExam.Name AS test, tExam.NumExam
FROM         tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tExam ON tMarkDoreh.Xtest = tExam.id
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
ORDER BY tYear_Student.xPaye, tExam.NumExam

open Test
fetch next from Test into 
  @xPaye,@xTest,@test,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<19)
  begin
	set @Sql='update  #tmp set xTest'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xtest)+',test'+convert(varchar(2),@counter)+'=N'''+@test+''''+
	' WHERE xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set countTest=countTest+1, Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest'+convert(varchar(2),@counter)+'  AND tMark.xBook = #tmp.xBook'
	+' WHERE tMark.mark is not null and #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

       set @Sql='update  #tmp set countTest=countTest+1, Mark'+convert(varchar(2),@counter)+'=tMarkDoreh.MarkDoreh,gSch'+convert(varchar(2),@counter)+'=tMarkDoreh.gPaye,gCls'+convert(varchar(2),@counter)+'=tMarkDoreh.gClass'
	+' FROM  tMarkDoreh INNER JOIN #tmp ON tMarkDoreh.xStudent = #tmp.xStudent AND tMarkDoreh.Xtest = #tmp.xTest'+convert(varchar(2),@counter)+'  AND #tmp.xBook=-5'
	+' WHERE #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)


  End
set @counter=@counter+1
set @tmp_xPaye=@xPaye

fetch next from Test into 
     @xPaye,@xTest,@test,@sort

end

close Test
deallocate Test



update #tmp set AvgMark=
(isnull(Mark1,0)+isnull(Mark2,0)+isnull(Mark3,0)+isnull(Mark4,0)+isnull(Mark5,0)+
 isnull(Mark6,0)+isnull(Mark7,0)+isnull(Mark8,0)+isnull(Mark9,0))/countTest
where xbook>0 and countTest>0


update #tmp set AvgMark=tmpAvg.Avgkoll
from   
#tmp   inner join                
(SELECT     #tmp.xStudent,  SUM(#tmp.AvgMark * tBook.vahed) / SUM(tBook.vahed) AS Avgkoll
FROM         #tmp INNER JOIN
                      tBook ON #tmp.xbook = tBook.id
WHERE     (#tmp.AvgMark IS NOT NULL)  and #tmp.xbook>0
GROUP BY #tmp.xStudent) tmpAvg on #tmp.xStudent=tmpAvg.xStudent
where #tmp.xbook=-5


select tmpStd.*,tbook.name as book,tbook.vahed,tbook.timeWeek,tbook.sort,#tmp.countTest ,#tmp.avgMark ,
#tmp.xtest1 ,#tmp.Test1,Mark1 ,gSch1 ,#tmp.gCls1 ,
#tmp.xTest2 ,#tmp.Test2,Mark2 ,gSch2 ,#tmp.gCls2 ,
#tmp.xTest3 ,#tmp.Test3,Mark3 ,gSch3 ,#tmp.gCls3 ,
#tmp.xTest4 ,#tmp.Test4,Mark4 ,gSch4 ,#tmp.gCls4 ,
#tmp.xTest5 ,#tmp.Test5,Mark5 ,gSch5 ,#tmp.gCls5 ,
#tmp.xTest6 ,#tmp.Test6,Mark6 ,gSch6 ,#tmp.gCls6 ,
#tmp.xTest7 ,#tmp.Test7,Mark7 ,gSch7 ,#tmp.gCls7 ,
#tmp.xTest8 ,#tmp.Test8,Mark8 ,gSch8 ,#tmp.gCls8 ,
#tmp.xTest9 ,#tmp.Test9,Mark9 ,gSch9 ,#tmp.gCls9 ,#tmp.xstudent,#tmp.xPaye,#tmp.xClass,#tmp.xbook ,
tmpCommentKoll.comment as CommentKoll,tmpCommentbook.comment as Commentbook,tTeacher.fnamf as TchFname,tTeacher.fnaml as tchLname
from  #tmp inner join
(
	select tStudent.id ,tStudent.FName,tStudent.LName,tStudent.PName, 
	tClass.Name AS Class ,tPaye.Name AS Paye ,tStudentImg.Student_img,#TmpCountClass.CountClass,#TmpCountPaye.CountPaye,
	(SELECT      '   از   ' + CAST(MIN(DateFrom) AS VARCHAR) +'   تا   '+ CAST(MAX(DateTo) AS VARCHAR) AS DateTo
	FROM         tExam
	WHERE  id in (select * from SplitNumber(@Exam))) AS TimeDored
	from
	tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  inner join
	tClass on tYear_Student.xClass=tClass.id inner join
	tPaye on tYear_Student.xPaye=tPaye.id 
	 LEFT OUTER JOIN
	tStudentImg ON tStudent.id = tStudentImg.xStudent 
	INNER JOIN
	#TmpCountClass on  tYear_Student.xPaye=#TmpCountClass.xPaye    and tYear_Student.xclass=#TmpCountClass.xclass  
	INNER JOIN
	#TmpCountPaye on  tYear_Student.xPaye=#TmpCountPaye.xPaye 
	where tYear_Student.XClass IN (select * from SplitNumber(@Class))
        AND (tYear_Student.xYear = @xYear)
	and tStudent.id in(select xstudent from tMarkDoreh where Xtest in(select * from SplitNumber(@Exam))) 
)
tmpStd 

on #tmp.xstudent= tmpStd.id 
left outer join tbook
on #tmp.xbook=tbook.id

left outer join
(
	SELECT     tComnentKarname.xStudent, tComnentKarname.Xtest, tComnentKarname.Comment
	FROM  tComnentKarname INNER JOIN
	tStudent ON tComnentKarname.xStudent = tStudent.id  INNER JOIN
        tYear_Student ON tStudent.id = tYear_Student.xStudent
	WHERE (tComnentKarname.typ = 5) 
	AND tYear_Student.XClass IN (SELECT * FROM SplitNumber(@Class))
	AND (tYear_Student.xYear = @xYear)
	AND tComnentKarname.xtest =@lastExam
) tmpCommentKoll on #tmp.xstudent=tmpCommentKoll.xstudent
left outer join
(
	SELECT     tComnentKarname.xStudent, tComnentKarname.Xtest,tComnentKarname.xbook, tComnentKarname.Comment
	FROM  tComnentKarname INNER JOIN
	tStudent ON tComnentKarname.xStudent = tStudent.id INNER JOIN
        tYear_Student ON tStudent.id = tYear_Student.xStudent
	WHERE (tComnentKarname.typ = 1) 
	AND tYear_Student.XClass IN (SELECT * FROM SplitNumber(@Class))
	AND (tYear_Student.xYear = @xYear)
	AND tComnentKarname.xtest =@lastExam
) tmpCommentbook on #tmp.xstudent=tmpCommentbook.xstudent and #tmp.xbook=tmpCommentbook.xbook
LEFT OUTER JOIN
tTch_Cls on #tmp.xClass= tTch_Cls.xCls and #tmp.xbook =tTch_Cls.xLsn LEFT OUTER JOIN tTeacher
 on tTch_Cls.xTch= tTeacher.id 

drop table #TmpCountClass
drop table #TmpCountPaye
drop table #tmp