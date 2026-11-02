--13980922
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FGQUFWUUI2QUdnQU5RQlVBRmNBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
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

--------------معذرتي-----------

insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,3
FROM         tYear_Student 
WHERE  xYear=@xYear and (Status = 1) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتي-----------
update #tmpTable set acp=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass IN (select * from SplitNumber(@Class)))


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


-----------------معذرتي-------------

update #tmpTable set acp=3 where Summark2 is null and acp<>4

-------------------------

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
tmpCommentKoll.Comment as Comment6
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
ALTER TABLE dbo.tYear_Student ADD
	MarkTerm3_From100 bit 
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_MarkTerm3_From100 DEFAULT 0 FOR MarkTerm3_From100
GO
Update tYear_Student set MarkTerm3_From100=0 where MarkTerm3_From100 is null
GO
alter procedure sp_Procc 
@Exam int with encryption
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

    delete from tmark where xtest=@Exam and xstudent not in( select xstudent from tYear_Student  where xYear=@xYear and MarkTerm3_From100=1)
	insert  into tmark (xstudent,xbook,xtest,typ)
	select distinct xStudent,xbook ,@Exam,1
	FROM         tMark
	WHERE     (Xtest IN (@ExamTerm1, @ExamTerm2))
        and xstudent not in(select xstudent from tmark where  xtest=@Exam)

	
	update tmark set m1=  tMark_1.Mark
	FROM         tMark INNER JOIN
	                      tMark tMark_1 ON tMark.xStudent = tMark_1.xStudent AND tMark.typ = tMark_1.typ AND tMark.xbook = tMark_1.xbook
	WHERE     (tMark.Xtest = @Exam) AND (tMark_1.Xtest = @ExamTerm1)
	and tMark.xstudent not in( select xstudent from tYear_Student  where xYear=@xYear and MarkTerm3_From100=1)

	update tmark set m2=  tMark_1.Mark
	FROM         tMark INNER JOIN
	                      tMark tMark_1 ON tMark.xStudent = tMark_1.xStudent AND tMark.typ = tMark_1.typ AND tMark.xbook = tMark_1.xbook
	WHERE     (tMark.Xtest = @Exam) AND (tMark_1.Xtest = @ExamTerm2)
	and tMark.xstudent not in( select xstudent from tYear_Student  where xYear=@xYear and MarkTerm3_From100=1)
	
	update tmark set mark =isnull(m1,0)+isnull(m2,0) 
	where xtest=@Exam
         and xstudent not in( select xstudent from tYear_Student  where xYear=@xYear and MarkTerm3_From100=1)
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

INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (32, N'checkMarkTerm3_From100', N'ورود نمره سالانه از 100', 0)
GO
alter procedure dbo.sp_tStudent_insertUpdate      
@id int,      
@xYear int,      
@xPaye int ,      
@xClass int ,      
@Code bigint ,      
@FName nvarchar(100),      
@LName nvarchar(100),      
@PName nvarchar(100),      
@Sh_Sh nvarchar(200),      
@bDate nvarchar(10),      
@MobileFather nvarchar(11),      
@MobileMother nvarchar(11),      
@NumberTelegram nvarchar(11),      
@NumberTelegram2 nvarchar(11),      
@Jens smallint,      
@Mazhab smallint,      
@NumberAsas int ,      
@RegDate nvarchar(10),      
@Adress nvarchar (200),      
@ExitDate nvarchar(10),      
@Status smallint,      
      
@shaghe bit,      
@hazer bit,      
@mali bit,      
@dakhle bit,      
@uniform bit,      
@komakdarsi bit,      
@ketab bit,      
@transport bit,      
@robotic bit,      
@maghnae bit,      
    
@Fee1 int,      
@Fee2 int,      
@Fee3 int,      
@Fee4 int,      
@Fee5 int,      
@Fee6 int,      
@Fee7 int,      
@Fee8 int,      
@Fee9 int,      
@SumFee int ,  
@xTakhfif smallint,  
@transport1 int,      
@transport2 int,      
@transport3 int,      
@transport4 int,      
@transport5 int,      
@transport6 int,      
@transport7 int,      
@transport8 int,      
@transport9 int,      
@Sumtransport int,      
@xDriver int,      
  
@xcity int,     
@En_Fname nvarchar (100), 
@En_Lname nvarchar (100),  
@LastName nvarchar(100),
@En_LastName nvarchar(100) ,      

@MarkTerm3_From100 bit,  

@CodeOut int outPut   with encryption
as      
if(@id>0)      
  begin  
        if(@Code is not null)  
          begin     
           if exists(select id from tStudent where id<>@id and Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
          end   
       if(@NumberAsas is not null)  
          begin      
       if exists(select id from tStudent where id<>@id and NumberAsas=@NumberAsas )        
    begin        
      set @CodeOut=-200        
      return        
    end        
          end  
       UPDATE    tStudent      
       SET   Code =@Code, FName =@FName, LName =@LName, PName =@PName, Sh_Sh =@Sh_Sh, bDate=@bDate      
       , MobileFather =@MobileFather, MobileMother =@MobileMother, Jens =@Jens, Mazhab =@Mazhab,      
        NumberAsas =@NumberAsas, RegDate =@RegDate, Adress =@Adress, ExitDate =@ExitDate,       
       NumberTelegram=@NumberTelegram,NumberTelegram2=@NumberTelegram2 ,
       xcity=@xcity ,  En_Fname=@En_Fname, En_Lname=@En_Lname ,En_LastName=@En_LastName ,LastName=@LastName where id=@id      
            
      UPDATE    tYear_Student      
 SET              xPaye =@xPaye, xClass =@xClass,  Status =@Status, shaghe =@shaghe, hazer =@hazer, mali =@mali,       
                        dakhle =@dakhle, uniform =@uniform, komakdarsi =@komakdarsi, ketab =@ketab,      
                        transport =@transport, robotic =@robotic, maghnae =@maghnae, MarkTerm3_From100=@MarkTerm3_From100   ,
                        Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5,    
    Fee6=@Fee6, Fee7=@Fee7, Fee8=@Fee8, Fee9=@Fee9,SumFee=@SumFee ,xTakhfif=@xTakhfif,    
   transport1=@transport1, transport2=@transport2, transport3=@transport3, transport4=@transport4, transport5=@transport5,    
    transport6=@transport6, transport7=@transport7,transport8=@transport8, transport9=@transport9, Sumtransport=@Sumtransport ,  
   xDriver =@xDriver  
 WHERE     (xYear = @xYear) AND (xStudent = @id)      
      
  end      
else      
  begin      
    if(@Code is not null)  
       begin     
         if exists(select id from tStudent where Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
       end   
    if(@NumberAsas is not null)  
      begin       
        if exists(select id from tStudent where  NumberAsas=@NumberAsas )        
   begin        
     set @CodeOut=-200        
     return        
   end    
      end     
 INSERT INTO tStudent      
                      (Code, FName, LName, PName, Sh_Sh,bDate, MobileFather, MobileMother, NumberTelegram, NumberTelegram2,      
                      Jens, Mazhab, NumberAsas, RegDate, Adress, xcity,  En_Fname, En_Lname,En_LastName,LastName)      
 VALUES     (@Code, @FName,@LName,@PName,@Sh_Sh,@bDate,@MobileFather,@MobileMother,@NumberTelegram,@NumberTelegram2,      
                     @Jens,@Mazhab,@NumberAsas,@RegDate,@Adress,@xcity,@En_Fname,@En_Lname,@En_LastName,@LastName)      
       set @id=@@identity      
       set @CodeOut=@id    
       INSERT INTO tYear_Student (xYear, xStudent, xPaye, xClass,Status, shaghe, hazer, mali, dakhle, uniform,      
                       komakdarsi, ketab, transport, robotic, maghnae,MarkTerm3_From100,    
                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,  
                      transport1,transport2,transport3,transport4, transport5,    
                      transport6,transport7,transport8,transport9,Sumtransport,xDriver)      
       VALUES      (@xYear, @id, @xPaye, @xClass,@Status, @shaghe, @hazer, @mali, @dakhle, @uniform,      
                       @komakdarsi, @ketab, @transport, @robotic, @maghnae, @MarkTerm3_From100,   
                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif,   
      @transport1,@transport2,@transport3,@transport4, @transport5,    
                    @transport6,@transport7,@transport8,@transport9,@Sumtransport,@xDriver)      
  end      
      
     
GO