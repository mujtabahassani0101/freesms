alter  PROCEDURE dbo.sp_SelectStdForSetGTerm
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
where tYear_Student.xYear=@xYear
drop table #tmpTable