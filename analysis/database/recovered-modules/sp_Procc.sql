--sp_Procc 101
CREATE procedure sp_Procc
@Exam int  with encryption
as
declare @xYear int
select @xYear=xYear from texam where id=@Exam

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