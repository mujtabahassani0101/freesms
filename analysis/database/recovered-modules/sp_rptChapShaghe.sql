
--sp_rptChapShaghe '','32,33,34,35'
CREATE procedure dbo.sp_rptChapShaghe
@Class varchar(500)  ,
@xYear int with encryption
as
create table #tmp(id int identity ,xClass int,xbook1 int ,xbook2 int)
declare @xclass int
declare @xPaye int
declare @xbook int
declare @id int
declare @counter int


declare paye cursor for
SELECT     xpaye,id
FROM         tClass
WHERE (xYear = @xYear) and id in(select * from SplitNumber(@Class))
and id IN 
         (SELECT xclass  FROM tyear_student 
          WHERE xyear = @xYear  and xclass in(select * from SplitNumber(@Class)))
ORDER BY xpaye,sortRpt
      open paye
fetch next from paye into 
     @xPaye,@xclass
Set @counter=1
while (@@fetch_status=0)
begin

	declare book cursor for
	SELECT id FROM tBook WHERE (xPaye = @xPaye) and Vezarat=1 ORDER BY sort
	      open book
	fetch next from book into 
	     @xbook
	while (@@fetch_status=0)
	begin
          
        if(@counter=1)
          begin
           insert into #tmp(xClass,xbook1)values(@xclass,@xbook)
            set @id=@@identity
            set @counter=2
          end
        else
          begin
             update #tmp set xbook2=@xbook where id=@id
             set @counter=1
          end

	fetch next from book into 
	   @xbook
	end
	close book
	deallocate book


Set @counter=1
fetch next from paye into 
   @xPaye,@xclass
end
close paye
deallocate paye

select * from #tmp
drop table #tmp



