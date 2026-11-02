--14001022
 
alter  PROCEDURE [dbo].[spRpt_karnamefinal]     
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
(xStudent int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,Acp int,xClass int,countStdClass int,  
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
    
insert into #tmpTable (xStudent,xPaye,xClass,acp,acp1,MarkKoll,Summark,tosifM,level5,countBookStd)    
    
SELECT   tYear_Student.xStudent,tYear_Student.XPaye,tYear_Student.xClass,tYear_Student.acp3,tYear_Student.acp1,TmpMark.MarkDoreh,TmpMark.Summark,    
dbo.ReturnTosifM5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as TosifM    
,dbo.ReturnLevel5(TmpMark.MarkDoreh,TmpMark.xtest,TmpMark.xStudent) as level5,0    
    
FROM              
  tYear_Student  left outer JOIN    
(select xStudent,xtest,MarkDoreh,Summark from tMarkDoreh where typ=5 and xtest=@Exam   
and xStudent in (select xStudent from tYear_Student where XClass IN (select * from SplitNumber(@Class))  and xYear=@xYear ) )TmpMark    
                       ON tYear_Student.xStudent = TmpMark.xStudent     
    
WHERE     
tYear_Student.XClass IN (select * from SplitNumber(@Class))     
and tYear_Student.shaghe=1  AND (tYear_Student.xYear = @xYear)    
    
    
update #tmpTable set   countStdClass= tmpCountStdClass.countStd  
from #tmpTable inner join   
(select xClass,count(xStudent) as countStd from #tmpTable  
group by xClass)tmpCountStdClass on #tmpTable.xClass=tmpCountStdClass.xClass  
    
    
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
tStudent.bDate,tStudent.bDateM, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,     
 tCity.Name AS City, tOstan.Name AS Ostan,    
tClass.Name AS Class ,tClass.answerable,tPaye.Name AS Paye, tStudentImg.Student_img,    
 tYear_Student.hazer1, tYear_Student.hazer2 as hazer3,isnull( tYear_Student.hazer2,0)-isnull( tYear_Student.hazer1,0) as hazer2,     
tYear_Student.Ghayeb1, tYear_Student.Ghayeb2 as Ghayeb3,isnull( tYear_Student.Ghayeb2,0)-isnull( tYear_Student.Ghayeb1,0) as Ghayeb2,    
 tYear_Student.Mariz1, tYear_Student.Mariz2  as Mariz3, isnull( tYear_Student.Mariz2,0)-isnull( tYear_Student.Mariz1,0) as Mariz2,    
tYear_Student.rokhsat1, tYear_Student.rokhsat2  as rokhsat3, isnull( tYear_Student.rokhsat2,0)-isnull( tYear_Student.rokhsat1,0) as rokhsat2    
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2,     
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2,tClass.Separcheh    
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,    
tmpCommentKoll.Comment as Comment6,tYear_Student.gTerm1,tYear_Student.gTerm3 ,tHazeriAgo.hazer10, tHazeriAgo.hazer11, tHazeriAgo.Ghayeb10, tHazeriAgo.Ghayeb11, tHazeriAgo.Mariz10, tHazeriAgo.Mariz11, tHazeriAgo.rokhsat10,     
                      tHazeriAgo.rokhsat11, tHazeriAgo.CountDay10, tHazeriAgo.CountDay11, tHazeriAgo.xYear10, tHazeriAgo.xYear11,tYear_Student.MarkTerm3_From100    
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
where tYear_Student.xYear=@xYear    
drop table #tmpTable    
    

GO
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFVZ0JrQURBQU1RQkVBRThBU0FCb0FFNEFVUUI2QUdnQU5RQlVBRmdBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO