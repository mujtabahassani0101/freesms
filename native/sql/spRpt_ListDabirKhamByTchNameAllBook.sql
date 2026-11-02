CREATE  PROCEDURE spRpt_ListDabirKhamByTchNameAllBook
@Exam varchar(500),
@Class varchar(500),
@xYear int with encryption
AS 
declare @xTest int   
declare @xbook int
declare @book nvarchar(100)   
declare @xPaye int 
declare @xClass int 
declare @tmp_xTest int
declare @tmp_xPaye int 
declare @counter int   
declare @Sql nvarchar(500)   
declare @sort int   




set @tmp_xTest =0
set @tmp_xPaye =0
set @counter=1


create table #tmp 
(xStudent int,xTest int,xPaye int,xClass int,
xbook1 int,book1 nvarchar(100),tch1 nvarchar(100),
xbook2 int,book2 nvarchar(100),tch2 nvarchar(100),
xbook3 int,book3 nvarchar(100),tch3 nvarchar(100),
xbook4 int,book4 nvarchar(100),tch4 nvarchar(100),
xbook5 int,book5 nvarchar(100),tch5 nvarchar(100),
xbook6 int,book6 nvarchar(100),tch6 nvarchar(100),
xbook7 int,book7 nvarchar(100),tch7 nvarchar(100),
xbook8 int,book8 nvarchar(100),tch8 nvarchar(100),
xbook9 int,book9 nvarchar(100),tch9 nvarchar(100),
xbook10 int,book10 nvarchar(100),tch10 nvarchar(100),
xbook11 int,book11 nvarchar(100),tch11 nvarchar(100),
xbook12 int,book12 nvarchar(100),tch12 nvarchar(100),
xbook13 int,book13 nvarchar(100),tch13 nvarchar(100),
xbook14 int,book14 nvarchar(100),tch14 nvarchar(100),
xbook15 int,book15 nvarchar(100),tch15 nvarchar(100),
xbook16 int,book16 nvarchar(100),tch16 nvarchar(100),
xbook17 int,book17 nvarchar(100),tch17 nvarchar(100),
xbook18 int,book18 nvarchar(100),tch18 nvarchar(100)
)

insert into #tmp (xStudent,xtest,xPaye,xClass)
SELECT   tStudent.id,@Exam,tYear_Student.XPaye,tYear_Student.xClass
FROM         tStudent  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)



declare Test cursor for
SELECT DISTINCT @Exam, dbo.tYear_Student.xPaye,dbo.tBook.id, dbo.tBook.Name, dbo.tBook.sort
FROM         dbo.tStudent INNER JOIN
             tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
              tBook on  dbo.tYear_Student.xPaye = dbo.tBook.xPaye
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
ORDER BY  tYear_Student.xPaye, tBook.sort, tBook.id
       open Test
fetch next from Test into 
    @xTest,@xPaye,@xbook,@book,@sort
Set @counter=1
while (@@fetch_status=0)

begin

if( @tmp_xTest <>@xTest or @tmp_xPaye <>@xPaye)
   set @counter =1 

if(@counter<19)
  begin
	set @Sql='update  #tmp set xBook'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xbook)+',book'+convert(varchar(2),@counter)+'=N'''+@book+''''+
	' WHERE Xtest = '+convert(varchar(6),@xtest)+' AND xPaye = '+convert(varchar(6),@xPaye)
	exec(@Sql)

	set @Sql='update  #tmp set tch'+convert(varchar(2),@counter)+'= tTeacher.fNamF+'' ''+tTeacher.fNamL
		FROM         tTch_Cls INNER JOIN
                      tTeacher ON tTch_Cls.xTch = tTeacher.id INNER JOIN
                      #tmp ON tTch_Cls.xCls = #tmp.xClass
		  WHERE  (tTch_Cls.xLsn = '+convert(varchar(6),@xbook)+')'
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


select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,
tClass.Name AS Class ,tPaye.Name AS Paye  from  #tmp inner join
tStudent on #tmp.xStudent=tStudent.id INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent inner join
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmp.xPaye=tPaye.id  inner join
tExam on #tmp.xTest=tExam.id
where  (tYear_Student.xYear = @xYear)


drop table #tmp