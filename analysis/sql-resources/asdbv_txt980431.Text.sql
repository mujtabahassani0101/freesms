--13980431
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFVUUI2QUdnQU5nQlVBRllBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 
alter table tTosif add tosifM nvarchar(10),term smallint,lev smallint,comment nvarchar(1000)
GO
ALTER TABLE dbo.tTosif ADD CONSTRAINT
	PK_tTosif PRIMARY KEY CLUSTERED 
	(
	id
	) ON [PRIMARY]
GO
delete from tTosif
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm,  term,lev,comment)
VALUES     (15, 0, 16, N'نياز به تلاش بيشتر',N'ه', 1,5,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما قابل قبول نيست؛ اما فرصت داريد در نيمه‌ي دوم سال تعليمي، با تلاش و پشتکار بيشتر به نتيجه‌ي مطلوب رسيده و براي ارتقا صنف در پايان سال، امتياز قابل قبول داشته باشيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (14, 16, 24, N'پذيرفته شده',N'د', 1,4,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما در حد کاميابي است، اما پيشنهاد مي شود که مشکل درسي خود را به کمک والدين و مدير صنف، شناسايي نموده و براي حل آن اقدام موثر نماييد تا به نتيجه‌ي مطلوب برسيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (13, 24, 30, N'خوب',N'ج', 1,3,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما (خوب) است و زحمات تان قابل قدر؛ ولي رسيدن به قله‌هاي بلند موفقيت نياز به تلاش بيشتر دارد که با همت بلند خود مي‌توانيد در گروه بسيار خوب و عالي قرار گيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (12, 30, 36, N'بسيار خوب',N'ب', 1,2,N'دانش‌آموز عزيز! اداره مکتب و استادان کسب مقام (بسيار خوب) را خدمت شما و خانواده محترم تان تبريک عرض مي‌کنند و انتظار دارند که در امتحان بعدي بتوانيد در گروه دانش‌آموزان عالي قرار بگيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (11, 36, 40, N'عالي',N'الف', 1,1,N'دانش‌آموز عزيز! اداره مکتب و استادان، کسب مقام (عالي) را خدمت شما و خانواده محترم تان تبريک عرض مي نمايند و تلاشهاي شما را قابل تحسين مي دانند. براي شما آرزوي موفقيت‌هاي مزيد داريم.')
GO

INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm,  term,lev,comment)
VALUES     (35, 0, 40, N'تلاش بيشتر',N'ه', 3,5,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما قابل قبول نيست؛ چون اوسط نمرات کمتر از نصف مجموعه مي‌باشد، پس به اطلاع رسانيده مي‌شود که جهت يادگيري بهتر، همين صنف را در سال آينده تکرار بخوانيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (34, 40, 60, N'پذيرفته شده',N'د', 3,4,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما در حد کاميابي است؛ پيشنهاد مي شود که مشکل درسي خود را به کمک والدين و مدير صنف، شناسايي نموده و براي حل آن اقدام موثر نماييد تا به نتيجه‌ي مطلوب برسيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (33, 60, 75, N'خوب',N'ج', 3,3,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما (خوب) است و زحمات تان قابل قدر؛ ولي رسيدن به قله‌هاي بلند موفقيت نياز به تلاش بيشتر دارد که با همت بلند خود مي‌توانيد در گروه بسيار خوب و عالي قرار گيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (32, 75, 90, N'بسيار خوب',N'ب', 3,2,N'دانش‌آموز عزيز! اداره مکتب و استادان کسب مقام (بسيار خوب) را خدمت شما و خانواده محترم تان تبريک عرض مي‌کنند و ما باور داريم که در سال بعدي شما مي‌توانيد در گروه دانش‌آموزان عالي قرار بگيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (31, 90, 100, N'عالي',N'الف', 3,1,N'دانش‌آموز عزيز! اداره مکتب و استادان، کسب مقام (عالي) را خدمت شما و خانواده محترم تان تبريک عرض مي نمايند و تلاشهاي شما را قابل تحسين مي دانند. درخشش شما در معارف، شايسته تقدير است.')
GO

INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm,  term,lev,comment)
VALUES     (5, 0, 40, N'تلاش بيشتر',N'ه', 0,5,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما قابل قبول نيست؛ چون اوسط نمرات کمتر از نصف مجموعه مي‌باشد، پيشنهاد مي شود که مشکل درسي خود را به کمک والدين و مدير صنف، شناسايي نموده و براي حل آن اقدام موثر نماييد تا به نتيجه‌ي مطلوب برسيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (4, 40, 60, N'پذيرفته شده',N'د', 0,4,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما در حد کاميابي است؛ پيشنهاد مي شود که مشکل درسي خود را به کمک والدين و مدير صنف، شناسايي نموده و براي حل آن اقدام موثر نماييد تا به نتيجه‌ي مطلوب برسيد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (3, 60, 75, N'خوب',N'ج', 0,3,N'دانش‌آموز عزيز! نتيجه‌ي امتحان شما (خوب) است و زحمات تان قابل قدر؛ ولي رسيدن به قله‌هاي بلند موفقيت نياز به تلاش بيشتر دارد که با همت بلند خود مي‌توانيد در گروه بسيار خوب و عالي قرار گيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (2, 75, 90, N'بسيار خوب',N'ب', 0,2,N'دانش‌آموز عزيز! اداره مکتب و استادان کسب مقام (بسيار خوب) را خدمت شما و خانواده محترم تان تبريک عرض مي‌کنند و ما باور داريم که در سال بعدي شما مي‌توانيد در گروه دانش‌آموزان عالي قرار بگيريد.')
GO
INSERT INTO tTosif
                      (id, fromMark, toMark, tosif,tosifm, term,lev,comment)
VALUES     (1, 90, 100, N'عالي',N'الف', 0,1,N'دانش‌آموز عزيز! اداره مکتب و استادان، کسب مقام (عالي) را خدمت شما و خانواده محترم تان تبريک عرض مي نمايند و تلاشهاي شما را قابل تحسين مي دانند. درخشش شما در معارف، شايسته تقدير است.')
GO
alter table tMarkDoreh  add MarkDoreh100 float ,Summark float, acp smallint
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

update tMarkDoreh set tMarkDoreh.gClass=#tmp.gClass, tMarkDoreh.gPaye=#tmp.gPaye,tMarkDoreh.gKoll=#tmp.gKoll
from tMarkDoreh inner join #tmp on tMarkDoreh.xStudent=#tmp.xStudent 
and  tMarkDoreh.Xtest=@Exam and tMarkDoreh.typ=5
drop table #tmp



GO
alter FUNCTION dbo.ReturnTosif(@Mark float,@xExam int)
RETURNS nvarchar(50) with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @Tosif nvarchar(50)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @Tosif=  tosif
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @Tosif
end

GO
create FUNCTION dbo.ReturnComment(@Mark float,@xExam int)
RETURNS nvarchar(1000) with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @comment nvarchar(1000)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @comment=  comment
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @comment
end

GO
CREATE FUNCTION dbo.ReturnLevel(@Mark float,@xExam int)
RETURNS smallint with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @Lev smallint
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @Lev=  lev
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @Lev
end


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
(SELECT  tStudent.id as xStudent, tStudent.Code,tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName,tStudentImg.Student_img, tYear_Student.xPaye, tYear_Student.xClass, 0 as xReshteh, tClass.name as Class,tClass.answerable, 
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
                      tStudentImg ON tStudent.id = tStudentImg.xStudent 

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



SELECT     tMark.xStudent, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName,tStudentImg.Student_img, tYear_Student.xPaye, tYear_Student.xClass,0 as xReshteh, tClass.name as Class,tClass.answerable, 
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



GO
alter table trpt add term smallint
GO
GO
delete from trpt where id in(4,5,6,17,18,9,10,11,13,43,35)
GO
update trpt  set id=id+1000 where id<100
GO
INSERT INTO tRpt
                      (id, Caption, Rpt, sp, subReport, countExam, sp2, type, term)
VALUES     (104, N'کارنامه چهار و نيم ماهه', N'CR_AF_StdKarnameDorehByChart_term1', N'spRpt_StdKarnameDoreh2', 
                      N'Sub1,spRpt_StdListTestMark_AvgClass_AllExam,Sub2,spRpt_StdgClass3,Sub3,spRpt_StdgPaye3', 1, N'spRpt_StdKarnameDoreh1', 1, 1)

GO
update trpt  set id=101,caption=N'لیست خام جهت ورود نمرات'
where id=1036
GO
update trpt  set id=102,caption=N'لیست نمرات'
where id=1034
GO
update trpt  set id=103,caption=N'لیست نمرات هر مضمون'
where id=1002
GO
alter procedure dbo.spRpt_ListDabir1
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int with encryption
as
select tmpStd.*, tmpMark.M1, tmpMark.M2, tmpMark.M3, tmpMark.M4, tmpMark.M5, tmpMark.M6, tmpMark.M7, tmpMark.M8, tmpMark.M9, tmpMark.M10, 
                      tmpMark.Mark, tmpMark.gClass, tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tBook.Name AS Book, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest, tbook.id as xbook,tYear_Student.sort
                      FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON   tYear_Student.xClass =tClass.id    INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xPaye
where tBook.id in(select distinct xbook from tMark where Xtest in(select * from SplitNumber(@Exam)) )

and tYear_Student.xClass in(select distinct tYear_Student.xClass  from tMark inner join 
tStudent on tMark.xstudent=tStudent.id INNER JOIN  tYear_Student ON tStudent.id = tYear_Student.xStudent 
where tMark.Xtest in(select * from SplitNumber(@Exam)) AND (tYear_Student.xYear = @xYear))
)tmpStd


left outer JOIN
( select tMark.xstudent,tMark.xbook, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, 
                      tMark.Mark, tMark.gClass, tMark.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, dbo.ReturnTosif( tMark.Mark,tMark.xtest) as Tosif
from
  tMark  INNER JOIN
   tExam ON tMark.Xtest = tExam.id 
where tMark.Xtest in(select * from SplitNumber(@Exam)))tmpMark 
on tmpStd.xstudent=tmpMark.xstudent and tmpStd.xbook=tmpMark.xbook



GO
alter procedure spRpt_ListDabir2
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
as
select tmpStd.*, tmpMark.M1, tmpMark.M2, tmpMark.M3, tmpMark.M4, tmpMark.M5, tmpMark.M6, tmpMark.M7, tmpMark.M8, tmpMark.M9, tmpMark.M10, 
                      tmpMark.Mark, tmpMark.gClass, tmpMark.gKoll,tmpMark.Exam, tmpMark.DateFrom, tmpMark.DateTo,tmpMark.Tosif
from
(SELECT     tStudent.id as xStudent, tStudent.FName, tStudent.LName, tStudent.PName, tBook.Name AS Book, tClass.name AS Class, tPaye.Name AS Paye, 
                      tYear_Student.xPaye, @Exam as Xtest, tbook.id as xbook,tYear_Student.sort
                      FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON  tYear_Student.xClass = tClass.id  INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id  INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xPaye
 where tYear_Student.xClass in(select * from SplitNumber(@Class)) )tmpStd


left outer JOIN
( select tMark.xstudent,tMark.xbook, tMark.M1, tMark.M2, tMark.M3, tMark.M4, tMark.M5, tMark.M6, tMark.M7, tMark.M8, tMark.M9, tMark.M10, 
                      tMark.Mark, tMark.gClass, tMark.gKoll, tExam.Name AS Exam, tExam.DateFrom, tExam.DateTo, dbo.ReturnTosif( tMark.Mark,tmark.xtest) as Tosif
from
  tMark  INNER JOIN
   tExam ON tMark.Xtest = tExam.id 
where tMark.Xtest in(select * from SplitNumber(@Exam)))tmpMark 
on tmpStd.xstudent=tmpMark.xstudent and tmpStd.xbook=tmpMark.xbook





GO
update texam set name=N'سالانه' where term=2
GO
update texam set name=N'جمع نمرات' where term=3
GO
alter procedure dbo.sp_RptSumPaymentkoll
@Class varchar(500)  ,
@xYear int with encryption
as
select tmpkoll.*,  tParmetr.sch,cast(@xYear as varchar(4)) as xYear ,1 as xclass  from
(select sum(SumFee) as SumFee,
sum(Sumtransport) as SumTransport,
sum(Pay_Fee) as Pay_Fee,
sum(Pay_Transport) as Pay_Transport,
sum(fee1) as fee1,
sum(fee2) as fee2,
sum(fee3) as fee3,
sum(fee4) as fee4,
sum(fee5) as fee5,
sum(fee6) as fee6,
sum(fee7) as fee7,
sum(fee8) as fee8,
sum(fee9) as fee9,
sum(Pay_fee1) as Pay_fee1,
sum(Pay_fee2) as Pay_fee2,
sum(Pay_fee3) as Pay_fee3,
sum(Pay_fee4) as Pay_fee4,
sum(Pay_fee5) as Pay_fee5,
sum(Pay_fee6) as Pay_fee6,
sum(Pay_fee7) as Pay_fee7,
sum(Pay_fee8) as Pay_fee8,
sum(Pay_fee9) as Pay_fee9,
sum(transport1) as transport1,
sum(transport2) as transport2,
sum(transport3) as transport3,
sum(transport4) as transport4,
sum(transport5) as transport5,
sum(transport6) as transport6,
sum(transport7) as transport7,
sum(transport8) as transport8,
sum(transport9) as transport9,
sum(Pay_transport1) as Pay_transport1,
sum(Pay_transport2) as Pay_transport2,
sum(Pay_transport3) as Pay_transport3,
sum(Pay_transport4) as Pay_transport4,
sum(Pay_transport5) as Pay_transport5,
sum(Pay_transport6) as Pay_transport6,
sum(Pay_transport7) as Pay_transport7,
sum(Pay_transport8) as Pay_transport8,
sum(Pay_transport9) as Pay_transport9

from
(SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent,
 tYear_Student.Sumtransport, tYear_Student.SumFee, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, tYear_Student.transport4, tYear_Student.transport5, 
                      tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, tYear_Student.transport9, tYear_Student.fee1, 
                      tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, tYear_Student.fee7, tYear_Student.fee8,tYear_Student.fee9,
                      isnull(tmpMali.Pay_Fee,0 ) as Pay_Fee,  isnull(tmpMali.Pay_Transport,0) as Pay_Transport ,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0) then fee1 
                           else isnull(tmpMali.Pay_Fee,0 ) end  as Pay_fee1,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0) then fee2 
                           when isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0)<0 then 0 
                           else isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0) end  as Pay_fee2,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0) then fee3 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)) end  as Pay_fee3,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0) then fee4 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)) end  as Pay_fee4,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)   then fee5
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)) end  as Pay_fee5,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0) then fee6   
                           when  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)) end  as Pay_fee6,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)   then fee7
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)) end  as Pay_fee7,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                            +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0) then fee8 
                          when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0))<0 then 0
                          else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)) end  as Pay_fee8,
                       case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                             +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)+isnull(tYear_Student.fee9,0)  then fee9
                            when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) end  as Pay_fee9,

		       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0) then transport1 
                           else isnull(tmpMali.Pay_transport,0 ) end  as Pay_transport1,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0) then transport2 
                           when isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0)<0 then 0 
                           else isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0) end  as Pay_transport2,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0) then transport3 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)) end  as Pay_transport3,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0) then transport4 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)) end  as Pay_transport4,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)   then transport5
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)) end  as Pay_transport5,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0) then transport6   
                           when  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)) end  as Pay_transport6,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)   then transport7
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)) end  as Pay_transport7,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                            +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0) then transport8 
                          when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0))<0 then 0
                          else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)) end  as Pay_transport8,
                       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                             +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)+isnull(tYear_Student.transport9,0)  then transport9
                            when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) end  as Pay_transport9

                    
FROM      tYear_Student   left outer join
                      
	                 (SELECT     xStudent, SUM(Fee) AS Pay_Fee, SUM(Transport) AS Pay_Transport FROM  tPaymentStudent
			  WHERE     (xYear = @xYear) and xStudent in(select xstudent from tYear_Student where mali=1 and  xYear = @xYear )
			  GROUP BY xStudent)tmpMali on tYear_Student.xStudent=tmpMali.xStudent
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class)))tmpPay
)tmpkoll CROSS JOIN
tParmetr


GO
update tRptPayment set Caption=N'گزارش کلي وضعيت فيس و ترانسپورت(مجموع صنف هاي انتخاب شده)' where id=6
GO
update tRptPayment set Caption=N'گزارش وضعيت فيس و ترانسپورت بر اساس صنف' where id=5
GO
CREATE FUNCTION dbo.ReturnTosifM(@Mark float,@xExam int)
RETURNS nvarchar(10) with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @Tosif nvarchar(10)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @Tosif=  tosifm
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @Tosif

end

GO
alter  PROCEDURE spRpt_Liststd_books2
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @book nvarchar(100)   
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
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),
gschkoll int,gclsKoll int,gPayeKoll int,
xbook1 int,book1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xbook2 int,book2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xbook3 int,book3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xbook4 int,book4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xbook5 int,book5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xbook6 int,book6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xbook7 int,book7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xbook8 int,book8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xbook9 int,book9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int,
xbook10 int,book10 nvarchar(100),Mark10 float,gSch10 int,gCls10 int,
xbook11 int,book11 nvarchar(100),Mark11 float,gSch11 int,gCls11 int,
xbook12 int,book12 nvarchar(100),Mark12 float,gSch12 int,gCls12 int,
xbook13 int,book13 nvarchar(100),Mark13 float,gSch13 int,gCls13 int,
xbook14 int,book14 nvarchar(100),Mark14 float,gSch14 int,gCls14 int,
xbook15 int,book15 nvarchar(100),Mark15 float,gSch15 int,gCls15 int,
xbook16 int,book16 nvarchar(100),Mark16 float,gSch16 int,gCls16 int,
xbook17 int,book17 nvarchar(100),Mark17 float,gSch17 int,gCls17 int,
xbook18 int,book18 nvarchar(100),Mark18 float,gSch18 int,gCls18 int
)
insert into #tmp (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,gschkoll,gPayeKoll,gclsKoll)
SELECT   tStudent.id,@Exam,tYear_Student.XPaye,tmptMarkDoreh.MarkDoreh,tmptMarkDoreh.Summark,
   dbo.ReturnTosifM(tmptMarkDoreh.MarkDoreh,tmptMarkDoreh.xtest) as TosifM,tmptMarkDoreh.gKoll,tmptMarkDoreh.gPaye,tmptMarkDoreh.gclass
FROM         tStudent  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent left outer JOIN
                     (select * from tMarkDoreh where xtest =@Exam and tMarkDoreh.typ = 5 ) tmptMarkDoreh ON tStudent.id = tmptMarkDoreh.xStudent  
WHERE tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)


declare Test cursor for
SELECT DISTINCT @Exam, dbo.tYear_Student.xPaye, dbo.tBook.id, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent INNER JOIN 
               tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
              tBook on  dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)

ORDER BY  tYear_Student.xPaye, tBook.sort, tBook.id
       open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<19)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest  AND tMark.xBook = #tmp.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmp.Xtest = '+convert(varchar(6),@xtest)+' AND #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)
  End
set @counter=@counter+1
set @tmp_xTest=@xTest
set @tmp_xPaye=@xPaye

fetch next from Test into 
   @xTest,@xPaye,@xbook,@book,@sort

end

close Test
deallocate Test


select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp  inner join
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
drop table #tmp

GO
alter  PROCEDURE dbo.spRpt_Liststd_books1
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @book nvarchar(100)   
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
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),gschkoll int,gclsKoll int,gPayeKoll int,
xbook1 int,book1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,
xbook2 int,book2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,
xbook3 int,book3 nvarchar(100),Mark3 float,gSch3 int,gCls3 int,
xbook4 int,book4 nvarchar(100),Mark4 float,gSch4 int,gCls4 int,
xbook5 int,book5 nvarchar(100),Mark5 float,gSch5 int,gCls5 int,
xbook6 int,book6 nvarchar(100),Mark6 float,gSch6 int,gCls6 int,
xbook7 int,book7 nvarchar(100),Mark7 float,gSch7 int,gCls7 int,
xbook8 int,book8 nvarchar(100),Mark8 float,gSch8 int,gCls8 int,
xbook9 int,book9 nvarchar(100),Mark9 float,gSch9 int,gCls9 int,
xbook10 int,book10 nvarchar(100),Mark10 float,gSch10 int,gCls10 int,
xbook11 int,book11 nvarchar(100),Mark11 float,gSch11 int,gCls11 int,
xbook12 int,book12 nvarchar(100),Mark12 float,gSch12 int,gCls12 int,
xbook13 int,book13 nvarchar(100),Mark13 float,gSch13 int,gCls13 int,
xbook14 int,book14 nvarchar(100),Mark14 float,gSch14 int,gCls14 int,
xbook15 int,book15 nvarchar(100),Mark15 float,gSch15 int,gCls15 int,
xbook16 int,book16 nvarchar(100),Mark16 float,gSch16 int,gCls16 int,
xbook17 int,book17 nvarchar(100),Mark17 float,gSch17 int,gCls17 int,
xbook18 int,book18 nvarchar(100),Mark18 float,gSch18 int,gCls18 int
)
insert into #tmp (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,gschkoll,gPayeKoll,gclsKoll)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest) as TosifM,tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)

declare Test cursor for
SELECT DISTINCT dbo.tMark.Xtest, dbo.tYear_Student.xPaye, dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)

ORDER BY tMark.Xtest, tYear_Student.xPaye, tBook.sort, tMark.xbook
open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<19)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set Mark'+convert(varchar(2),@counter)+'=tmark.mark,gSch'+convert(varchar(2),@counter)+'=tmark.gKoll,gCls'+convert(varchar(2),@counter)+'=tmark.gClass'
	+' FROM  tMark INNER JOIN #tmp ON tMark.xStudent = #tmp.xStudent AND tMark.Xtest = #tmp.xTest  AND tMark.xBook = #tmp.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmp.Xtest = '+convert(varchar(6),@xtest)+' AND #tmp.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)
  End
set @counter=@counter+1
set @tmp_xTest=@xTest
set @tmp_xPaye=@xPaye

fetch next from Test into 
   @xTest,@xPaye,@xbook,@book,@sort

end

close Test
deallocate Test


select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp  inner join
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
drop table #tmp
GO