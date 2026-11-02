--13981008
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCb0FFNEFVUUI2QUdnQU13QlVBREFBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
alter table tYear_Student add gTerm3 int, gTerm1 int
GO
INSERT INTO tRpt
                      (id, Caption, Rpt, sp, countExam, type, sortRpt, term)
VALUES     (116, N'گزارش خلص نتایج', N'CR_AF_ListFinal', N'spRpt_Listfinal', 1, 2, 1, 3)
GO
update tRpt set Caption=N'جدول نتایج صنف اول تا یازدهم' where id=114
GO
--spRpt_karnamefinal 105,'82,83,84',1398

alter  PROCEDURE dbo.spRpt_karnamefinal 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 


declare @ExamTerm1 int
declare @ExamTerm2 int

select @ExamTerm1=id from texam where term=1 and xYear=@xYear
select @ExamTerm2=id from texam where term=2 and xYear=@xYear




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

create table #tmpTable 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gschkoll int,gclsKoll int,gPayeKoll int,Acp int,
xbook1 int,book1 nvarchar(100),M1_1 float,M2_1 float,M3_1 float,
xbook2 int,book2 nvarchar(100),M1_2 float,M2_2 float,M3_2 float,
xbook3 int,book3 nvarchar(100),M1_3 float,M2_3 float,M3_3 float,
xbook4 int,book4 nvarchar(100),M1_4 float,M2_4 float,M3_4 float,
xbook5 int,book5 nvarchar(100),M1_5 float,M2_5 float,M3_5 float,
xbook6 int,book6 nvarchar(100),M1_6 float,M2_6 float,M3_6 float,
xbook7 int,book7 nvarchar(100),M1_7 float,M2_7 float,M3_7 float,
xbook8 int,book8 nvarchar(100),M1_8 float,M2_8 float,M3_8 float,
xbook9 int,book9 nvarchar(100),M1_9 float,M2_9 float,M3_9 float,
xbook10 int,book10 nvarchar(100),M1_10 float,M2_10 int,M3_10 float,
xbook11 int,book11 nvarchar(100),M1_11 float,M2_11 int,M3_11 float,
xbook12 int,book12 nvarchar(100),M1_12 float,M2_12 int,M3_12 float,
xbook13 int,book13 nvarchar(100),M1_13 float,M2_13 int,M3_13 float,
xbook14 int,book14 nvarchar(100),M1_14 float,M2_14 int,M3_14 float,
xbook15 int,book15 nvarchar(100),M1_15 float,M2_15 int,M3_15 float,
xbook16 int,book16 nvarchar(100),M1_16 float,M2_16 int,M3_16 float,
xbook17 int,book17 nvarchar(100),M1_17 float,M2_17 int,M3_17 float,
xbook18 int,book18 nvarchar(100),M1_18 float,M2_18 int,M3_18 float,
xbook19 int,book19 nvarchar(100),M1_19 float,M2_19 int,M3_19 float,
xbook20 int,book20 nvarchar(100),M1_20 float,M2_20 int,M3_20 float,
xbook21 int,book21 nvarchar(100),M1_21 float,M2_21 int,M3_21 float,
MAgo_1 float,
MAgo_2 float,
MAgo_3 float,
MAgo_4 float,
MAgo_5 float,
MAgo_6 float,
MAgo_7 float,
MAgo_8 float,
MAgo_9 float,
MAgo_10 float,
MAgo_11 float,
MAgo_12 float,
MAgo_13 float,
MAgo_14 float,
MAgo_15 float,
MAgo_16 float,
MAgo_17 float,
MAgo_18 float,
MAgo_19 float,
MAgo_20 float,
MAgo_21 float,
MAgo2_1 float,
MAgo2_2 float,
MAgo2_3 float,
MAgo2_4 float,
MAgo2_5 float,
MAgo2_6 float,
MAgo2_7 float,
MAgo2_8 float,
MAgo2_9 float,
MAgo2_10 float,
MAgo2_11 float,
MAgo2_12 float,
MAgo2_13 float,
MAgo2_14 float,
MAgo2_15 float,
MAgo2_16 float,
MAgo2_17 float,
MAgo2_18 float,
MAgo2_19 float,
MAgo2_20 float,
MAgo2_21 float,
MarkKoll1 float,
Summark1 float,
Acp1 int,
gclsKoll1 int,
tosifM_1 nvarchar(10),
level5_1 smallint,
Summark2 float,
MarkKoll2 float,
)

insert into #tmpTable (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gschkoll,gPayeKoll,gclsKoll,acp)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,
tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass,acp
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)

---------------محروم دائم-----------
insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,4
FROM         tYear_Student 
WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتی-----------

insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,3
FROM         tYear_Student 
WHERE  xYear=@xYear and (Status = 1) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتی-----------
update #tmpTable set acp=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass IN (select * from SplitNumber(@Class)))

---------------محروم دائم-----------
update #tmpTable set acp=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass IN (select * from SplitNumber(@Class)))


update #tmpTable set MarkKoll1=tmpMark1.MarkDoreh,Summark1=tmpMark1.Summark,Acp1=tmpMark1.acp,gclsKoll1=tmpMark1.gClass,
tosifM_1=dbo.ReturnTosifM5(tmpMark1.MarkDoreh,@ExamTerm1,tmpMark1.xStudent),
level5_1=dbo.ReturnLevel5(tmpMark1.MarkDoreh,@ExamTerm1,tmpMark1.xStudent)

from #tmpTable inner join 
(
SELECT     xStudent, MarkDoreh, gClass, Summark, acp
FROM         tMarkDoreh
WHERE     (typ = 5) AND (Xtest = @ExamTerm1))tmpMark1 on #tmpTable.xstudent=tmpMark1.xstudent

update #tmpTable set MarkKoll2=tmpMark1.MarkDoreh,Summark2=tmpMark1.Summark
from #tmpTable inner join 
(
SELECT     xStudent, MarkDoreh, gClass, Summark, acp
FROM         tMarkDoreh
WHERE     (typ = 5) AND (Xtest = @ExamTerm2))tmpMark1 on #tmpTable.xstudent=tmpMark1.xstudent



declare Test cursor for
SELECT DISTINCT dbo.tMark.Xtest, dbo.tYear_Student.xPaye, dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)
and tBook.vezarat=1
ORDER BY tMark.Xtest, tYear_Student.xPaye, tBook.sort, tMark.xbook
open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<22)
  begin
	set @Sql=' update  #tmpTable set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	         ' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)

	exec(@Sql)

	set @Sql='update  #tmpTable set m3_'+convert(varchar(2),@counter)+'=tmark.mark'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.Xtest = #tmpTable.xTest  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmpTable.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmpTable set m2_'+convert(varchar(2),@counter)+'=tmark.m2'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.Xtest = #tmpTable.xTest  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmpTable.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)


	set @Sql='update  #tmpTable set m1_'+convert(varchar(2),@counter)+'=tmark.m1'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.Xtest = #tmpTable.xTest  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmpTable.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
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




declare @sch nvarchar(100)
declare @ost nvarchar(100)
declare @cty nvarchar(100)

select @sch=sch,@ost=ost,@cty=cty from tParmetr

select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, 
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName, 
 tCity.Name AS City, tOstan.Name AS Ostan,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,tClass.Name AS Class ,tPaye.Name AS Paye, tStudentImg.Student_img,
 tYear_Student.hazer1, tYear_Student.hazer2 as hazer3,isnull( tYear_Student.hazer2,0)-isnull( tYear_Student.hazer1,0) as hazer2, 
tYear_Student.Ghayeb1, tYear_Student.Ghayeb2 as Ghayeb3,isnull( tYear_Student.Ghayeb2,0)-isnull( tYear_Student.Ghayeb1,0) as Ghayeb2,
 tYear_Student.Mariz1, tYear_Student.Mariz2  as Mariz3, isnull( tYear_Student.Mariz2,0)-isnull( tYear_Student.Mariz1,0) as Mariz2,
tYear_Student.rokhsat1, tYear_Student.rokhsat2  as rokhsat3, isnull( tYear_Student.rokhsat2,0)-isnull( tYear_Student.rokhsat1,0) as rokhsat2
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2, 
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,
tmpCommentKoll.Comment as Comment6,tYear_Student.gTerm1,tYear_Student.gTerm3
 from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmpTable.xPaye=tPaye.id  inner join
tExam on #tmpTable.xTest=tExam.id  LEFT OUTER JOIN
 (SELECT     xMaghta, Term1 as countDayTerm1, Term2 as countDayTerm2 ,isnull(Term1,0)+isnull(Term2,0) as countDayTerm3
  FROM         tYearMaghtaCountDay
   WHERE     (xYear = @xYear)) tmpcountDay ON tPaye.xMaghta = tmpcountDay.xMaghta
 left outer JOIN   
tCity ON tStudent.xCity = tCity.id left outer JOIN 
tOstan ON tCity.xOstan = tOstan.id  LEFT OUTER JOIN
tStudentImg ON tStudent.id = tStudentImg.xStudent
left outer join
(
	SELECT     tComnentKarname.xStudent, tComnentKarname.Xtest, tComnentKarname.Comment
	FROM  tComnentKarname INNER JOIN
	tStudent ON tComnentKarname.xStudent = tStudent.id inner join
        tYear_Student ON tStudent.id=tYear_Student.xStudent
	WHERE (tComnentKarname.typ = 6)  
	and tYear_Student.xYear=@xYear
	AND tYear_Student.XClass IN (SELECT * FROM SplitNumber(@Class))
	AND tComnentKarname.xtest IN (SELECT * FROM SplitNumber(@Exam))
) tmpCommentKoll on tStudent.id=tmpCommentKoll.xstudent  
                  
drop table #tmpTable


GO
--spRpt_Listfinal 105,'82,83,84',1398

create  PROCEDURE dbo.spRpt_Listfinal 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 








create table #tmpTable 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gschkoll int,gclsKoll int,gPayeKoll int,Acp int
)

insert into #tmpTable (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gschkoll,gPayeKoll,gclsKoll,acp)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,
tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass,acp
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)

---------------محروم دائم-----------
insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,4
FROM         tYear_Student 
WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتی-----------

insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,3
FROM         tYear_Student 
WHERE  xYear=@xYear and (Status = 1) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتی-----------
update #tmpTable set acp=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass IN (select * from SplitNumber(@Class)))

---------------محروم دائم-----------
update #tmpTable set acp=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass IN (select * from SplitNumber(@Class)))



declare @sch nvarchar(100)
declare @ost nvarchar(100)
declare @cty nvarchar(100)

select @sch=sch,@ost=ost,@cty=cty from tParmetr

select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, 
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName, 
tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,tClass.Name AS Class ,tPaye.Name AS Paye,
 tYear_Student.hazer2 as hazer3, 
tYear_Student.Ghayeb2 as Ghayeb3,
 tYear_Student.Mariz2  as Mariz3,
 tYear_Student.rokhsat2  as rokhsat3
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2, 
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,
tYear_Student.gTerm1,tYear_Student.gTerm3
 from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmpTable.xPaye=tPaye.id  inner join
tExam on #tmpTable.xTest=tExam.id  LEFT OUTER JOIN
 (SELECT     xMaghta, Term1 as countDayTerm1, Term2 as countDayTerm2 ,isnull(Term1,0)+isnull(Term2,0) as countDayTerm3
  FROM         tYearMaghtaCountDay
   WHERE     (xYear = @xYear)) tmpcountDay ON tPaye.xMaghta = tmpcountDay.xMaghta                  
drop table #tmpTable
GO