alter  PROCEDURE [dbo].[sp_SelectStdForSetAcp]
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
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gclsKoll int,AcpDef int,
xbook1 int,book1 nvarchar(100),
xbook2 int,book2 nvarchar(100),
xbook3 int,book3 nvarchar(100),
xbook4 int,book4 nvarchar(100),
xbook5 int,book5 nvarchar(100),
xbook6 int,book6 nvarchar(100),
xbook7 int,book7 nvarchar(100),
xbook8 int,book8 nvarchar(100),
xbook9 int,book9 nvarchar(100),
xbook10 int,book10 nvarchar(100),
xbook11 int,book11 nvarchar(100),
xbook12 int,book12 nvarchar(100),
xbook13 int,book13 nvarchar(100),
xbook14 int,book14 nvarchar(100),
xbook15 int,book15 nvarchar(100),
xbook16 int,book16 nvarchar(100),
xbook17 int,book17 nvarchar(100),
xbook18 int,book18 nvarchar(100),
xbook19 int,book19 nvarchar(100),
xbook20 int,book20 nvarchar(100),
xbook21 int,book21 nvarchar(100),
Mark1 float,
Mark2 float,
Mark3 float,
Mark4 float,
Mark5 float,
Mark6 float,
Mark7 float,
Mark8 float,
Mark9 float,
Mark10 float,
Mark11 float,
Mark12 float,
Mark13 float,
Mark14 float,
Mark15 float,
Mark16 float,
Mark17 float,
Mark18 float,
Mark19 float,
Mark20 float,
Mark21 float

)

insert into #tmpTable (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gclsKoll,AcpDef)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,tMarkDoreh.gclass,Acp
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass =@xClass
and  tMarkDoreh.xtest=@xTest
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)


if(@xTerm=3)
begin
	---------------محروم دائم-----------
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,4
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------معذرتي-----------
	
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,3
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (Status = 1) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------معذرتي-----------
	update #tmpTable set AcpDef=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass =@xClass)
	
	---------------محروم دائم-----------
	update #tmpTable set AcpDef=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass=@xClass)

end


else if(@xTerm=1)
begin
	---------------محروم -----------
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,4
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------غايب-----------
	
	insert into #tmpTable(xStudent,xtest,xPaye,AcpDef)
	SELECT     xStudent,@xTest, xPaye,5
	FROM         tYear_Student 
	WHERE  xYear=@xYear and (Status = 1) 
	and tYear_Student.shaghe=1
	and  tYear_Student.XClass =@xClass
	and  xStudent not in(select xStudent from #tmpTable)
	
	--------------غايب-----------
	update #tmpTable set AcpDef=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=5 and XClass =@xClass)
	
	---------------محروم دائم-----------
	update #tmpTable set AcpDef=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass=@xClass)

end





declare Test cursor for

SELECT DISTINCT  dbo.tMark.xbook, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent  INNER JOIN
                      dbo.tMark ON dbo.tStudent.id = dbo.tMark.xStudent INNER JOIN
                      dbo.tBook ON dbo.tMark.xbook = dbo.tBook.id AND dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass=@xClass 
and  tMark.xtest=@xtest
AND (tYear_Student.xYear = @xYear)
and tBook.vezarat=1
ORDER BY  tBook.sort, tMark.xbook





open Test
fetch next from Test into 
  @xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if(@counter<22)
  begin
	set @Sql=' update  #tmpTable set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	         ' WHERE Xtest = '+convert(varchar(6),@xtest)
	
	exec(@Sql)

	set @Sql='update  #tmpTable set Mark'+convert(varchar(2),@counter)+'=tmark.mark'
	+' FROM  tMark INNER JOIN #tmpTable ON tMark.xStudent = #tmpTable.xStudent AND tMark.Xtest = #tmpTable.xTest  AND tMark.xBook = #tmpTable.xBook'+convert(varchar(2),@counter)
	+' WHERE #tmpTable.Xtest = '+convert(varchar(6),@xtest)
	exec(@Sql)

	
  End
set @counter=@counter+1

fetch next from Test into 
   @xbook,@book,@sort

end

close Test
deallocate Test


update #tmpTable set markkoll=round(markkoll,2)


select #tmpTable.*,0 as acp ,tYear_Student.id,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, tStudent.NumberAsas,
case @xTerm when 1 then tYear_Student.acp1  when 3 then tYear_Student.acp3 end as acpFinal

from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent 
where tYear_Student.xYear=@xYear
drop table #tmpTable