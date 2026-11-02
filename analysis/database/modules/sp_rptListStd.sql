--sp_rptChapShagheHzeri '','32,33,34,35'
CREATE procedure dbo.sp_rptListStd
@Class varchar(500),
@xYear int
as
create table #tmp(id int identity ,xClass1 int ,xClass2 int)
declare @xclass int
declare @xPaye int
declare @id int
declare @counter int


declare paye cursor for
SELECT  distinct   xpaye
FROM         tClass
WHERE (xYear = @xYear) and id in(select * from SplitNumber(@Class))
and id IN 
         (SELECT xclass  FROM tyear_student 
          WHERE xyear = @xYear  and xclass in(select * from SplitNumber(@Class)))
ORDER BY xpaye
      open paye
fetch next from paye into 
     @xPaye
Set @counter=1
while (@@fetch_status=0)
begin

	declare class cursor for
	SELECT id FROM tclass WHERE (xPaye = @xPaye)
        and id in(select xclass from tYear_Student where xYear=@xYear)  ORDER BY sortRpt 
	      open class
	fetch next from class into 
	     @xclass
	while (@@fetch_status=0)
	begin
          
        if(@counter=1)
          begin
           insert into #tmp(xclass1)values(@xclass)
            set @id=@@identity
            set @counter=2
          end
        else
          begin
             update #tmp set xclass2=@xclass where id=@id
             set @counter=1
          end

	fetch next from class into 
	   @xclass
	end
	close class
	deallocate class


--Set @counter=1
fetch next from paye into 
   @xPaye
end
close paye
deallocate paye

select * from #tmp
drop table #tmp





