--13980813
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FGQUFVUUI2QUdnQU5BQlVBRmdBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 

update tRptAFLsit set id=id+2 where id>2
GO
INSERT INTO tRptAFLsit
                      (id, Caption, Rpt, sp, subReport, type)
VALUES     (3, N'چاپ شقه سالانه', N'CrChapShaghe2', N'sp_rptChapShaghe', N'Sub1,sp_SubrptChapShaghe,Sub2,sp_SubrptChapShaghe', 1)
GO
INSERT INTO tRptAFLsit
                      (id, Caption, Rpt, sp, subReport, type)
VALUES     (4, N'چاپ شقه حاضری سالانه', N'CrChapShagheHzeri2', N'sp_RptListStd', N'Sub1,sp_SubrptChapShagheHzeri,Sub2,sp_SubrptChapShagheHzeri', 1)
GO
update tRptAFLsit set Caption=N'چاپ شقه چهار ونیم ماه' where id=1
GO
update tRptAFLsit set Caption=N'چاپ شقه حاضری چهار و نیم ماهه' where id=2
GO

--sp_rptChapShagheHzeri '','32,33,34,35'
alter procedure dbo.sp_rptListStd
@Class varchar(500),
@xYear int with encryption
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
	SELECT id FROM tclass WHERE (xPaye = @xPaye) and id in(select * from SplitNumber(@Class))
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

GO