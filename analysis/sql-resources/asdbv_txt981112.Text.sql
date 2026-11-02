--13981112
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCb0FFNEFWUUI2QUdnQU5BQlVBRmNBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
alter table tYear_Student add acp3 smallint, acp1 smallint
GO
alter FUNCTION dbo.ReturnTosifM5(@Mark float,@xExam int,@xStudent int)
RETURNS nvarchar(10) with encryption
AS
BEGIN
declare @term smallint
declare @xYear smallint
select @term=term,@xYear=xYear from tExam where id=@xExam

declare @Tosif nvarchar(10)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

 if (@term=1 or @term=3)
   begin
	  declare @acp smallint
            if @term=1 
	      select @acp =acp1 from tYear_Student where xStudent=@xStudent and xYear=@xYear
            else if @term=3 
	      select @acp =acp3 from tYear_Student where xStudent=@xStudent and xYear=@xYear


	  if(@acp=1)
           SELECT  @Tosif=  tosifm
	    FROM         tTosif
	    WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
	  else if (@acp=0 or @acp=2)
          
            SELECT  @Tosif=  tosifm
	    FROM         tTosif
	    WHERE     lev=5 and term=@term

         else set @Tosif=''
 
  end
 
else
   begin
	SELECT  @Tosif=  tosifm
	FROM         tTosif
	WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
   end
return  @Tosif

end

GO
--sp_SelectStdForSetAcp 1,63,1398

create  PROCEDURE dbo.sp_SelectStdForSetAcp
@xTerm int,
@xClass int ,
@xYear int with encryption
AS 


declare @xTest int
select  @xTest=id from tExam where term=@xTerm and xYear=@xYear
declare @xbook int
declare @book nvarchar(100)   
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   
set @counter=1

create table #tmpTable 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gclsKoll int,AcpDef int,
xbook1 int,book1 nvarchar(100),
xbook2 int,book2 nvarchar(100),
xbook3 int,book3 nvarchar(100),
xbook4 int,book4 nvarchar(100),
xbook5 int,book5 nvarchar(100),
xbook6 int,book6 nvarchar(100),
xbook7 int,book7 nvarchar(100),
xbook8 int,book8 nvarchar(100),
xbook9 int,book9 nvarchar(100),
xbook10 int,book10 nvarchar(100),
xbook11 int,book11 nvarchar(100),
xbook12 int,book12 nvarchar(100),
xbook13 int,book13 nvarchar(100),
xbook14 int,book14 nvarchar(100),
xbook15 int,book15 nvarchar(100),
xbook16 int,book16 nvarchar(100),
xbook17 int,book17 nvarchar(100),
xbook18 int,book18 nvarchar(100),
xbook19 int,book19 nvarchar(100),
xbook20 int,book20 nvarchar(100),
xbook21 int,book21 nvarchar(100),
Mark1 float,
Mark2 float,
Mark3 float,
Mark4 float,
Mark5 float,
Mark6 float,
Mark7 float,
Mark8 float,
Mark9 float,
Mark10 float,
Mark11 float,
Mark12 float,
Mark13 float,
Mark14 float,
Mark15 float,
Mark16 float,
Mark17 float,
Mark18 float,
Mark19 float,
Mark20 float,
Mark21 float

)

insert into #tmpTable (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gclsKoll,AcpDef)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,tMarkDoreh.gclass,Acp
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass =@xClass
and  tMarkDoreh.xtest=@xTest
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)


if(@xTerm=3)
begin
	---------------محروم دائم-----------
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,4
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------معذرتي-----------
	
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,3
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (Status = 1) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------معذرتي-----------
	update #tmpTable set AcpDef=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass =@xClass)
	
	---------------محروم دائم-----------
	update #tmpTable set AcpDef=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass=@xClass)

end


else if(@xTerm=1)
begin
	---------------محروم -----------
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,4
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------غايب-----------
	
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,5
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (Status = 1) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------غايب-----------
	update #tmpTable set AcpDef=5 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass =@xClass)
	
	---------------محروم دائم-----------
	update #tmpTable set AcpDef=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass=@xClass)

end





declare Test cursor for

SELECT DISTINCT  dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass=@xClass 
and  tMark.xtest=@xtest
AND (tYear_Student.xYear = @xYear)
and tBook.vezarat=1
ORDER BY  tBook.sort, tMark.xbook





open Test
fetch next from Test into 
  @xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if(@counter<22)
  begin
	set @Sql=' update  #tmpTable set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	         ' WHERE Xtest = '+convert(varchar(6),@xtest)
	
	exec(@Sql)

	set @Sql='update  #tmpTable set Mark'+convert(varchar(2),@counter)+'=tmark.mark'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.Xtest = #tmpTable.xTest  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmpTable.Xtest = '+convert(varchar(6),@xtest)
	exec(@Sql)

	
  End
set @counter=@counter+1

fetch next from Test into 
   @xbook,@book,@sort

end

close Test
deallocate Test


update #tmpTable set markkoll=round(markkoll,2)


select #tmpTable.*,0 as acp ,tYear_Student.id,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, tStudent.NumberAsas,
case @xTerm when 1 then tYear_Student.acp1  when 3 then tYear_Student.acp3 end as acpFinal

from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent 
drop table #tmpTable

GO
--sp_SelectStdForSetGTerm 3,63,1398

create  PROCEDURE dbo.sp_SelectStdForSetGTerm
@xTerm int,
@xClass int ,
@xYear int with encryption
AS 


declare @xTest int
select  @xTest=id from tExam where term=@xTerm and xYear=@xYear
declare @xbook int
declare @book nvarchar(100)   
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   
set @counter=1

create table #tmpTable 
(xStudent int,xPaye int,MarkKoll float,Summark float,gclsKoll int,AcpFinal int,gterm int)

insert into #tmpTable (xStudent,xPaye,AcpFinal,gterm,MarkKoll,Summark)
SELECT   tYear_Student.xStudent,tYear_Student.XPaye,
case @xTerm when 1 then tYear_Student.Acp1 when 3 then  tYear_Student.Acp3 else 0 end as Acp,
case @xTerm when 1 then tYear_Student.gTerm1 when 3 then  tYear_Student.gTerm3 else 0 end as gterm,
tmmMark.MarkDoreh,tmmMark.Summark
FROM         tYear_Student 
left outer JOIN
	(select xStudent,MarkDoreh,Summark from tMarkDoreh where typ=5 and xtest=@xTest
	 and xStudent in (select xStudent from tYear_Student where XClass =@xClass and xYear=@xYear ) )tmmMark
                       ON tYear_Student.xStudent = tmmMark.xStudent 
where					     
tYear_Student.XClass =@xClass
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)



declare @xStudent bigint
declare @Mark float
declare @tmp_Mark float
declare @Rotbe int
declare @tmp_Rotbe int

set @Rotbe=1
set @tmp_Rotbe=1



        declare Rbt2 cursor for
	select xStudent,MarkKoll from #tmpTable where AcpFinal=1   order by MarkKoll desc
        open Rbt2
        fetch next from Rbt2 into 
          @xStudent,@mark

              set @Rotbe=1
	      set @tmp_Rotbe=1
              set @tmp_Mark=10000
        while (@@fetch_status = 0)
        begin
	   if @tmp_Mark <> @Mark
	      begin
	         UPDATE #tmpTable SET  gclsKoll = @tmp_Rotbe WHERE xStudent=@xStudent
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmpTable SET  gclsKoll = @Rotbe WHERE  xStudent=@xStudent
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 





update #tmpTable set markkoll=round(markkoll,2)

select #tmpTable.*,0 as acp ,tYear_Student.id,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, tStudent.NumberAsas,
case #tmpTable.AcpFinal when 1 then -1 else #tmpTable.AcpFinal end as acpSort
from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent 
drop table #tmpTable

GO
--spRpt_Listfinal 105,'82,83,84',1398

alter  PROCEDURE dbo.spRpt_Listfinal 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 

create table #tmpTable 
(xStudent int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,Acp int)

insert into #tmpTable (xStudent,xPaye,acp,MarkKoll,Summark,tosifM,level5)

SELECT   tYear_Student.xStudent,tYear_Student.XPaye,tYear_Student.acp3,TmpMark.MarkDoreh,TmpMark.Summark,
dbo.ReturnTosifM5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as TosifM
,dbo.ReturnLevel5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as level5

FROM          
                      tYear_Student  left outer JOIN
(select xStudent,xtest,MarkDoreh,Summark from tMarkDoreh where typ=5 and xtest=@Exam
and xStudent in (select xStudent from tYear_Student where XClass IN (select * from SplitNumber(@Class))  and xYear=@xYear ) )TmpMark
                       ON tYear_Student.xStudent = TmpMark.xStudent 

WHERE 
tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)



declare @sch nvarchar(100)
declare @ost nvarchar(100)
declare @cty nvarchar(100)

select @sch=sch,@ost=ost,@cty=cty from tParmetr

select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, 
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName, 
tYear_Student.XClass,tClass.Name AS Class ,tPaye.Name AS Paye,
 tYear_Student.hazer2 as hazer3, 
tYear_Student.Ghayeb2 as Ghayeb3,
 tYear_Student.Mariz2  as Mariz3,
 tYear_Student.rokhsat2  as rokhsat3
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2, 
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2,tClass.Separcheh
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,
tYear_Student.gTerm1,tYear_Student.gTerm3
 from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmpTable.xPaye=tPaye.id LEFT OUTER JOIN
 (SELECT     xMaghta, Term1 as countDayTerm1, Term2 as countDayTerm2 ,isnull(Term1,0)+isnull(Term2,0) as countDayTerm3
  FROM         tYearMaghtaCountDay
   WHERE     (xYear = @xYear)) tmpcountDay ON tPaye.xMaghta = tmpcountDay.xMaghta                  
drop table #tmpTable




GO

--spRpt_karnamefinal 105,'38',1398

ALTER  PROCEDURE [dbo].[spRpt_karnamefinal] 
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
(xStudent int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,Acp int,
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
MAgo10_1 float,
MAgo10_2 float,
MAgo10_3 float,
MAgo10_4 float,
MAgo10_5 float,
MAgo10_6 float,
MAgo10_7 float,
MAgo10_8 float,
MAgo10_9 float,
MAgo10_10 float,
MAgo10_11 float,
MAgo10_12 float,
MAgo10_13 float,
MAgo10_14 float,
MAgo10_15 float,
MAgo10_16 float,
MAgo10_17 float,
MAgo10_18 float,
MAgo10_19 float,
MAgo10_20 float,
MAgo10_21 float,
MAgo11_1 float,
MAgo11_2 float,
MAgo11_3 float,
MAgo11_4 float,
MAgo11_5 float,
MAgo11_6 float,
MAgo11_7 float,
MAgo11_8 float,
MAgo11_9 float,
MAgo11_10 float,
MAgo11_11 float,
MAgo11_12 float,
MAgo11_13 float,
MAgo11_14 float,
MAgo11_15 float,
MAgo11_16 float,
MAgo11_17 float,
MAgo11_18 float,
MAgo11_19 float,
MAgo11_20 float,
MAgo11_21 float,
MarkKoll1 float,
Summark1 float,
Acp1 int,
gclsKoll1 int,
tosifM_1 nvarchar(10),
level5_1 smallint,
Summark2 float,
MarkKoll2 float,


Summark10 float,
Summark11 float,


gClass10 float,
gClass11 float,
SumMarkFinal float,
countBookStd int
)

insert into #tmpTable (xStudent,xPaye,acp,acp1,MarkKoll,Summark,tosifM,level5,countBookStd)
SELECT   tYear_Student.xStudent,tYear_Student.XPaye,tYear_Student.acp3,tYear_Student.acp1,TmpMark.MarkDoreh,TmpMark.Summark,
dbo.ReturnTosifM5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as TosifM
,dbo.ReturnLevel5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as level5,0

FROM          
                      tYear_Student  left outer JOIN
(select xStudent,xtest,MarkDoreh,Summark from tMarkDoreh where typ=5 and xtest=@Exam
and xStudent in (select xStudent from tYear_Student where XClass IN (select * from SplitNumber(@Class))  and xYear=@xYear ) )TmpMark
                       ON tYear_Student.xStudent = TmpMark.xStudent 

WHERE 
tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)




update #tmpTable set MarkKoll1=tmpMark1.MarkDoreh,Summark1=tmpMark1.Summark,gclsKoll1=tmpMark1.gClass,
tosifM_1=dbo.ReturnTosifM5(tmpMark1.MarkDoreh,@ExamTerm1,tmpMark1.xStudent),
level5_1=dbo.ReturnLevel5(tmpMark1.MarkDoreh,@ExamTerm1,tmpMark1.xStudent)

from #tmpTable inner join 
(
SELECT     xStudent, MarkDoreh, gClass, Summark
FROM         tMarkDoreh
WHERE     (typ = 5) AND (Xtest = @ExamTerm1))tmpMark1 on #tmpTable.xstudent=tmpMark1.xstudent

update #tmpTable set MarkKoll2=tmpMark1.MarkDoreh,Summark2=tmpMark1.Summark
from #tmpTable inner join 
(
SELECT     xStudent, MarkDoreh, gClass, Summark
FROM         tMarkDoreh
WHERE     (typ = 5) AND (Xtest = @ExamTerm2))tmpMark1 on #tmpTable.xstudent=tmpMark1.xstudent



update #tmpTable set Summark10=tMarkAgo.mark,gClass10=tMarkAgo.gClass
FROM  tMarkAgo INNER JOIN #tmpTable ON tMarkAgo.xStudent = #tmpTable.xStudent 
where tMarkAgo.xpaye = 10 and tMarkAgo.typ=5


update #tmpTable set Summark11=tMarkAgo.mark,gClass11=tMarkAgo.gClass
FROM  tMarkAgo INNER JOIN #tmpTable ON tMarkAgo.xStudent = #tmpTable.xStudent 
where tMarkAgo.xpaye = 11 and tMarkAgo.typ=5





declare Test cursor for
/*
SELECT DISTINCT @Exam, dbo.tYear_Student.xPaye, dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMark.xtest in(select * from SplitNumber(@Exam)) 
AND (tYear_Student.xYear = @xYear)
and tBook.vezarat=1
ORDER BY tMark.Xtest, tYear_Student.xPaye, tBook.sort, tMark.xbook
*/

SELECT DISTINCT @Exam, tYear_Student.xPaye, tBook.id, tBook.Name, tBook.sort
FROM         tYear_Student INNER JOIN
                      tBook ON tYear_Student.xPaye = tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
 and tBook.vezarat=1 and tBook.id in(select distinct xbook from tmark where xtest=@Exam) 
or 
 tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
 and tBook.vezarat=1   
      and tBook.id in(select distinct xbook from tMarkAgo where xstudent 
        in(select xstudent from tYear_Student where XClass in (select * from SplitNumber(@Class))))
ORDER BY  tYear_Student.xPaye, tBook.sort, tBook.id




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
	         ' WHERE xPaye = '+convert(varchar(6),@xPaye)

	exec(@Sql)


	set @Sql='update  #tmpTable set MAgo10_'+convert(varchar(2),@counter)+'=tMarkAgo.mark,countBookStd=countBookStd+1'
	+' FROM  tMarkAgo INNER JOIN #tmpTable ON tMarkAgo.xStudent = #tmpTable.xStudent AND tMarkAgo.xpaye = 10 AND tMarkAgo.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	exec(@Sql)

	set @Sql='update  #tmpTable set MAgo11_'+convert(varchar(2),@counter)+'=tMarkAgo.mark,countBookStd=countBookStd+1'
	+' FROM  tMarkAgo INNER JOIN #tmpTable ON tMarkAgo.xStudent = #tmpTable.xStudent AND tMarkAgo.xpaye = 11 AND tMarkAgo.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	exec(@Sql)



	set @Sql='update  #tmpTable set m3_'+convert(varchar(2),@counter)+'=tmark.mark,countBookStd=countBookStd+1'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE tMark.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmpTable set m2_'+convert(varchar(2),@counter)+'=tmark.m2'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE tMark.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)


	set @Sql='update  #tmpTable set m1_'+convert(varchar(2),@counter)+'=tmark.m1'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE tMark.Xtest = '+convert(varchar(6),@xtest)+' AND #tmpTable.xPaye = '+convert(varchar(6),@xPaye)
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



update #tmpTable set SumMarkFinal=(isnull(sumMark,0)+isnull(summark10,0)+isnull(summark11,0))/countBookStd
where countBookStd>0


declare @sch nvarchar(100)
declare @ost nvarchar(100)
declare @cty nvarchar(100)

select @sch=sch,@ost=ost,@cty=cty from tParmetr

select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, 
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName, 
 tCity.Name AS City, tOstan.Name AS Ostan,tYear_Student.XClass, 
tClass.Name AS Class ,tPaye.Name AS Paye, tStudentImg.Student_img,
 tYear_Student.hazer1, tYear_Student.hazer2 as hazer3,isnull( tYear_Student.hazer2,0)-isnull( tYear_Student.hazer1,0) as hazer2, 
tYear_Student.Ghayeb1, tYear_Student.Ghayeb2 as Ghayeb3,isnull( tYear_Student.Ghayeb2,0)-isnull( tYear_Student.Ghayeb1,0) as Ghayeb2,
 tYear_Student.Mariz1, tYear_Student.Mariz2  as Mariz3, isnull( tYear_Student.Mariz2,0)-isnull( tYear_Student.Mariz1,0) as Mariz2,
tYear_Student.rokhsat1, tYear_Student.rokhsat2  as rokhsat3, isnull( tYear_Student.rokhsat2,0)-isnull( tYear_Student.rokhsat1,0) as rokhsat2
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2, 
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2,tClass.Separcheh
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,
tmpCommentKoll.Comment as Comment6,tYear_Student.gTerm1,tYear_Student.gTerm3 ,tHazeriAgo.hazer10, tHazeriAgo.hazer11, tHazeriAgo.Ghayeb10, tHazeriAgo.Ghayeb11, tHazeriAgo.Mariz10, tHazeriAgo.Mariz11, tHazeriAgo.rokhsat10, 
                      tHazeriAgo.rokhsat11, tHazeriAgo.CountDay10, tHazeriAgo.CountDay11, tHazeriAgo.xYear10, tHazeriAgo.xYear11
 from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmpTable.xPaye=tPaye.id LEFT OUTER JOIN
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
left outer join
tHazeriAgo on tStudent.id=tHazeriAgo.xStudent

drop table #tmpTable


GO