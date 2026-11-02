--13980404
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFVUUI2QUdnQU13QlVBR3NBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 

CREATE procedure dbo.sp_RptListStdTransport
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tStudent.Code, tYear_Student.sort, tStudent.FName, tStudent.LName, 
                      tStudent.PName, tClass.answerable, tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, 
                      tStudent.RegDate, CAST(tClass.xYear AS nvarchar(4)) AS xYear, tDriver.name as  Driver, tDriver.mobil, tYear_Student.xDriver, tDriver.mobil2, 
                      tStudent.MobileFather, tStudent.MobileMother, tStudent.NumberTelegram, tStudent.NumberTelegram2
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id LEFT OUTER JOIN
                      tDriver ON tYear_Student.xDriver = tDriver.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.transport = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))



GO
ALTER TABLE dbo.tExam ADD
	term smallint NULL
GO
ALTER TABLE dbo.tExam ADD CONSTRAINT
	DF_tExam_term DEFAULT 0 FOR term
GO
update texam set term=0 where term is null
GO
Declare @id int
select @id= isnull(max(id),100)+1 from texam
if not Exists(select id from texam where xyear=1398 and term=1)
INSERT INTO tExam
                      (id, xYear, NumExam, Name, term)
VALUES     (@id, 1398, - 10, N'چهار و نيم ماهه', 1)
GO
Declare @id int
select @id= isnull(max(id),100)+1 from texam
if not Exists(select id from texam where xyear=1398 and term=2)
INSERT INTO tExam
                      (id, xYear, NumExam, Name, term)
VALUES     (@id, 1398, - 9, N'نيمسال دوم', 2)
GO
Declare @id int
select @id= isnull(max(id),100)+1 from texam
if not Exists(select id from texam where xyear=1398 and term=3)
INSERT INTO tExam
                      (id, xYear, NumExam, Name, term)
VALUES     (@id, 1398, - 8, N'سالانه', 3)
GO
--sp_Procc 101
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


create table #tmp (  xStudent bigint, Xtest bigint,xClass int,xbook int ,mark float,gClass smallint,gKoll smallint)
insert into #tmp
	SELECT     tMark.xStudent, tMark.Xtest, tYear_Student.xClass, tMark.xbook, tMark.Mark, NULL AS Expr1 , NULL AS Expr2
                   
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
	select xStudent,mark from #tmp where xbook= @xbook and Xtest=@xtest and xClass=@xClass  order by mark desc
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
	         UPDATE #tmp SET  gClass = @tmp_Rotbe WHERE xStudent=@xStudent and xbook= @xbook
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmp SET  gClass = @Rotbe WHERE  xStudent=@xStudent and xbook= @xbook
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 

	    fetch next from Rbt into 
	        @xbook,@xtest,@xClass
       end
       close Rbt
       deallocate Rbt 


declare Rbt cursor for
  select distinct xbook,Xtest from #tmp
       open Rbt
        fetch next from Rbt into 
          @xbook,@xtest
  while (@@fetch_status = 0)
    begin
        declare Rbt2 cursor for
	select xStudent,mark from #tmp where xbook= @xbook and Xtest=@xtest order by mark desc
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
	         UPDATE #tmp SET  gKoll = @tmp_Rotbe WHERE xStudent=@xStudent and xbook= @xbook
	         set @Rotbe=@tmp_Rotbe
	      end
	   else
	      begin
	        UPDATE #tmp SET  gKoll = @Rotbe WHERE  xStudent=@xStudent and xbook= @xbook
	      end
	
	
	     set @tmp_Rotbe=@tmp_Rotbe+1
              set @tmp_Mark = @Mark
	

             fetch next from Rbt2 into 
	        @xStudent,@mark
       end
       close Rbt2
       deallocate Rbt2 

	    fetch next from Rbt into 
	        @xbook,@xtest
       end
       close Rbt
       deallocate Rbt 




update tMark set tMark.gClass=#tmp.gClass,tMark.gKoll=#tmp.gKoll
from tMark inner join #tmp on tMark.xStudent=#tmp.xStudent and  tMark.xbook=#tmp.xbook 
and  tMark.Xtest=#tmp.Xtest
drop table #tmp
GO
alter procedure dbo.spRpt_StdListTestMark_AvgClass_AllExam
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int  with encryption  
as
select tmpStd.*,tmpavgClass.AvgClass from
(SELECT     dbo.tMarkDoreh.xStudent, dbo.tMarkDoreh.Xtest, dbo.tExam.Name AS Exam,tExam.NumExam, dbo.tMarkDoreh.MarkDoreh, dbo.tYear_Student.xClass
FROM         dbo.tMarkDoreh INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id INNER JOIN
                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id  INNER JOIN
  tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear) and tExam.term not in(1,2)
and  (dbo.tMarkDoreh.typ = 5)) tmpStd
inner join
(SELECT     dbo.tMarkDoreh.Xtest, AVG(dbo.tMarkDoreh.MarkDoreh) AS AvgClass, dbo.tYear_Student.xClass
FROM         dbo.tMarkDoreh INNER JOIN
                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      dbo.tExam ON dbo.tMarkDoreh.Xtest = dbo.tExam.id 
WHERE tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)  and tExam.term not in(1,2)
and  (dbo.tMarkDoreh.typ = 5)
GROUP BY dbo.tMarkDoreh.Xtest, dbo.tYear_Student.xClass)tmpavgClass 
on tmpStd.xClass=tmpavgClass.xClass and tmpStd.Xtest=tmpavgClass.Xtest
order by tmpStd.xStudent,tmpStd.NumExam



GO
create PROCEDURE spRpt_StdCard 
@Class varchar(500)  ,
@xYear int with encryption  
as

SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName,tStudent.PName,tStudent.code,
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear,dbo.tStudentImg.Student_img
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id    INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id left outer JOIN
                      dbo.tStudentImg ON dbo.tStudent.id = dbo.tStudentImg.xStudent CROSS JOIN
                      tParmetr 
WHERE    (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))
GO
INSERT INTO tRptAFLsit
                      (id, Caption, Rpt, sp, type)
VALUES     (7, N'گزارش شاگردان داراي ترانسپورت هر صنف', N'CrListStdTransport', N'sp_RptListStdTransport', 1)
GO
INSERT INTO tRptAFLsit
                      (id, Caption, Rpt, sp, type)
VALUES     (8, N'گزارش شاگردان مربوط به هر راننده', N'CrListStdTransportDriver', N'sp_RptListStdTransport', 1)
GO
INSERT INTO tRptAFLsit
                      (id, Caption, Rpt, sp, type)
VALUES     (9, N'کارت امتحان', N'CrStdCard', N'spRpt_StdCard', 1)
GO
CREATE Procedure dbo.sp_tMark_insertUpdate_FromXls_Af  
@xuser int,  
@code varchar(14),  
@codedars int,  
@Xtest int,  
@xYear int, 
@Mark float,  
@err nvarchar(100) output  with encryption
as  
declare @xStudent int  
declare @xPaye int  
declare @xbook int  
set @xbook=0  
set @xStudent=0  
select @xStudent=tstudent.id,@xPaye=tyear_student.xpaye from tstudent inner join tyear_student
on  tstudent.id=tyear_student.xstudent where tStudent.code=@code  and tyear_student.xYear=@xYear
if(@xStudent<=0)  
begin  
set @err=N'کد متعلم در سيستم وجود ندارد'  
return  
end  
select @xbook=id  from tbook where codedars=@codedars and xpaye=@xPaye  
if(@xbook<=0)  
begin  
set @err=N'کد درس '+cast(@codedars as varchar)+' در سيستم وجود ندارد'  
return  
end  
  
if (@Mark=-1000)  
 DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)  
else if not exists(select id from tmark where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook)  
 INSERT INTO tMark  
                       (xStudent, Xtest,typ, xbook, M1, Mark)  
 VALUES      (@xStudent, @Xtest,1, @xbook, @Mark, @Mark)  
else   
 UPDATE    tMark  
 SET   M1 =@Mark , Mark =@Mark  
 where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook  

GO