--13980514
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFWUUI2QUdnQU5BQlVBR3NBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 
UPDATE    tTosif
SET              fromMark = 20
WHERE     (term = 1) AND (lev = 4)
GO
UPDATE    tTosif
SET              tomark = 20
WHERE     (term = 1) AND (lev = 5)
GO
GO
UPDATE    tTosif
SET              fromMark = 50
WHERE     (term = 3) AND (lev = 4)
GO
UPDATE    tTosif
SET              tomark = 50
WHERE     (term = 3) AND (lev = 5)
GO
UPDATE    tTosif
SET              fromMark = 50
WHERE     (term = 0) AND (lev = 4)
GO
UPDATE    tTosif
SET              tomark = 50
WHERE     (term = 0) AND (lev = 5)
GO
update texam set procc=0
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

       update tMarkDoreh set acp=0 where xtest=@Exam and MarkDoreh<20
	

end
else if(@xTerm=3)
begin
	update tMarkDoreh set acp=0 where xtest=@Exam and xstudent in(
	select xstudent as countB from tmark where
	xtest=@Exam and 
	mark <40 group by xstudent
	having count(*)>3)
   
             update tMarkDoreh set acp=0 where xtest=@Exam and MarkDoreh<50
	
      
end
else if(@xTerm=3)
begin
	update tMarkDoreh set acp=2 where xtest=@Exam and MarkDoreh>=50 and xstudent in(
	select xstudent as countB from tmark where
	xtest=@Exam and 
	mark <40 group by xstudent
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