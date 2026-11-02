alter  PROCEDURE dbo.spRpt_Listfinal   
@Exam varchar(500),  
@Class varchar(500) ,  
@xYear int with encryption  
AS   
  
create table #tmpTable   
(xStudent int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,Acp int,xClass int,countStdClass int)  
  
insert into #tmpTable (xStudent,xClass,xPaye,acp,MarkKoll,Summark,tosifM,level5)  
  
SELECT   tYear_Student.xStudent,tYear_Student.xClass,tYear_Student.XPaye,tYear_Student.acp3,TmpMark.MarkDoreh,TmpMark.Summark,  
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
  
update #tmpTable set   countStdClass= tmpCountStdClass.countStd
from #tmpTable inner join 
(select xClass,count(xStudent) as countStd from #tmpTable
group by xClass)tmpCountStdClass on #tmpTable.xClass=tmpCountStdClass.xClass
  
declare @sch nvarchar(100)  
declare @ost nvarchar(100)  
declare @cty nvarchar(100)  
  
select @sch=sch,@ost=ost,@cty=cty from tParmetr  
  
select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code,   
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,   
#tmpTable.XClass,tClass.Name AS Class,tClass.answerable ,tPaye.Name AS Paye,  tCity.Name AS City, tOstan.Name AS Ostan,  
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
tPaye on #tmpTable.xPaye=tPaye.id  LEFT OUTER JOIN  
                      tCity ON tStudent.xCity = tCity.id   LEFT OUTER JOIN  
                      tOstan ON tCity.xOstan = tOstan.id  
LEFT OUTER JOIN  
 (SELECT     xMaghta, Term1 as countDayTerm1, Term2 as countDayTerm2 ,isnull(Term1,0)+isnull(Term2,0) as countDayTerm3  
  FROM         tYearMaghtaCountDay  
   WHERE     (xYear = @xYear)) tmpcountDay ON tPaye.xMaghta = tmpcountDay.xMaghta     
where tYear_Student.xYear =@xYear               
drop table #tmpTable