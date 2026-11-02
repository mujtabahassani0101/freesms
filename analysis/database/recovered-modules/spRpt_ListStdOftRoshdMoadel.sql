--exec spRpt_ListStdOftRoshdMoadel '101,102','15,16'  
CREATE  PROCEDURE spRpt_ListStdOftRoshdMoadel
@Exam varchar(500),  
@Class varchar(500) ,
@xYear int  with encryption  
AS   
declare @xTest int     
declare @xbook int  
declare @Test nvarchar(100)     
declare @tmp_xbook int  
declare @counter int     
declare @Sql nvarchar(500)     
declare @NumExam int     
  
  
  
  
set @tmp_xbook =0  
set @counter=1  
  

create table #tmp   
(xStudent int,  xClass int ,
xtest1 int,test1 nvarchar(100),Mark1 float,gSch1 int,gCls1 int,  
xtest2 int,test2 nvarchar(100),Mark2 float,gSch2 int,gCls2 int,  
countTest smallint,AvgMark float,tmpavgMark float  ,
countStd int,countRosd int,countOft int,count0 int,oftrosd float
)

insert into #tmp (xStudent,xclass,countTest)  
SELECT     tStudent.id AS xStudent,tYear_Student.xclass,0  
FROM         tStudent  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
where  tYear_Student.XClass IN (select * from SplitNumber(@Class))   
AND (tYear_Student.xYear = @xYear) 
 
declare Test cursor for  
SELECT DISTINCT  tMarkDoreh.Xtest, tExam.Name, tExam.NumExam  
FROM         tMarkDoreh INNER JOIN  
                      tExam ON tMarkDoreh.Xtest = tExam.id INNER JOIN  
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
Where  tYear_Student.XClass IN (select * from SplitNumber(@Class))  
AND (tYear_Student.xYear = @xYear) 

and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam))   
ORDER BY tExam.NumExam  
       open Test  
fetch next from Test into   
  @xTest,@Test,@NumExam  
Set @counter=1  
while (@@fetch_status=0)  
  
begin  
  
if( @tmp_xbook <>@xbook)  
   set @counter =1   
  
set @Sql='update  #tmp set xtest'+convert(varchar(2),@counter)+'='+convert(varchar(6),@xTest)+',Test'+convert(varchar(2),@counter)+'=N'''+@Test+''''
exec(@Sql)  
  
set @Sql='update  #tmp set countTest=countTest+1,tmpavgMark=isnull(tmpavgMark,0)+tMarkDoreh.MarkDoreh, Mark'+convert(varchar(2),@counter)+'=tMarkDoreh.MarkDoreh,gSch'+convert(varchar(2),@counter)+'=tMarkDoreh.gPaye,gCls'+convert(varchar(2),@counter)+'=tMarkDoreh.gClass'  
+' FROM  tMarkDoreh INNER JOIN #tmp ON tMarkDoreh.xStudent = #tmp.xStudent '  
+' WHERE tMarkDoreh.MarkDoreh is not null and tMarkDoreh.xTest = '+convert(varchar(6),@xtest)
exec(@Sql)  
set @counter=@counter+1  
set @tmp_xbook=@xbook  
fetch next from Test into   
   @xTest,@Test,@NumExam  
  
end  
  
close Test  
deallocate Test  

update #tmp set oftrosd=Mark2 - Mark1

UPDATE    #tmp
SET              countStd = tblavg.countStd
FROM         #tmp INNER JOIN
                          (SELECT    xClass, COUNT(xStudent) AS countStd
                             FROM         #tmp
                             GROUP BY  xClass) tblavg ON #tmp.xClass = tblavg.xClass

UPDATE    #tmp
SET              countRosd = tblavg.countStd
FROM         #tmp INNER JOIN
                          (SELECT     xClass, COUNT(xStudent) AS countStd
                             FROM         #tmp
                             where oftrosd>0
                             GROUP BY  xClass) tblavg ON #tmp.xClass = tblavg.xClass


UPDATE    #tmp
SET              count0 = tblavg.countStd
FROM         #tmp INNER JOIN
                          (SELECT     xClass, COUNT(xStudent) AS countStd
                             FROM         #tmp
                             where oftrosd=0
                             GROUP BY  xClass) tblavg ON #tmp.xClass = tblavg.xClass


UPDATE    #tmp
SET              countOft = tblavg.countStd
FROM         #tmp INNER JOIN
                          (SELECT     xClass, COUNT(xStudent) AS countStd
                             FROM         #tmp
                             where oftrosd<0
                             GROUP BY xClass) tblavg ON #tmp.xClass = tblavg.xClass 


update #tmp set AvgMark=tmpavgMark/countTest  
where countTest>0  
  
select #tmp.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tYear_Student.XClass,  
tClass.Name AS Class ,tPaye.Name AS Paye from  #tmp inner join  
tStudent on #tmp.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent inner join  
tClass on tYear_Student.xClass=tClass.id inner join  
tPaye on tYear_Student.xPaye=tPaye.id 
where (tYear_Student.xYear = @xYear) 

drop table #tmp