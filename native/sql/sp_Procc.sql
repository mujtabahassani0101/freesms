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