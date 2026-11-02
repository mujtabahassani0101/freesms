CREATE Procedure [dbo].idx   
@xYear int,                
@xHozeh int,                
@Start int,
@sort int with encryption
as  
set @Start=@Start-1                            
declare @sql varchar (1000)                
declare @xPaye int                
declare @CountPaye int                
declare @CountClass int                 
declare @CounterClass int                 
declare @CounterNostdClass int                               
Declare @CounterIDx int                
select  @CounterIDx=isnull(max(idx),@Start)+1 from tYear_Student where xYear=@xYear and xHozeh=@xHozeh               
create table #tmpStd (id int IDENTITY (1, 1) NOT NULL,xpaye int ,xstudent bigint,idx int)         
            
                        
                    
        if( @sort =1)
           begin
	        insert into #tmpStd(xstudent,xpaye)                
	        SELECT    tYear_Student.xstudent, tYear_Student.xpaye               
	        FROM         tstudent inner join   tYear_Student  
                    ON  tStudent.id =tYear_Student.xStudent left outer join 
                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent
                    FROM         tMarkDoreh
                    WHERE     (typ = 5) and xtest in(select id from texam where xYear=@xYear)
                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent           
	            WHERE tYear_Student.xYear=@xYear
                    and  tYear_Student.xstudent not in(select xstudent from #tmpStd)             
	            and (tYear_Student.idx IS NULL) and (tYear_Student.xHozeh=@xHozeh)
	           order by tmpMoadel.moadel desc
           end
 	else if( @sort =2)
           begin
	         insert into #tmpStd(xstudent,xpaye)                
	        SELECT    tYear_Student.xstudent, tYear_Student.xpaye               
	        FROM         tstudent inner join   tYear_Student  
                    ON  tStudent.id =tYear_Student.xStudent left outer join 
                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent
                    FROM         tMarkDoreh
                    WHERE     (typ = 5) and xtest in(select id from texam where xYear=@xYear)
                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent           
	            WHERE tYear_Student.xYear=@xYear
                    and  tYear_Student.xstudent not in(select xstudent from #tmpStd)             
	            and (tYear_Student.idx IS NULL) and (tYear_Student.xHozeh=@xHozeh)
	           order by tmpMoadel.moadel 
           end
	else if( @sort =3)
           begin
	        insert into #tmpStd(xstudent,xpaye)                
	        SELECT      tYear_Student.xstudent, tYear_Student.xpaye                 
	        FROM         tstudent inner join   tYear_Student  
                 ON  tStudent.id =tYear_Student.xStudent             
	        WHERE  tYear_Student.xYear=@xYear and  tYear_Student.xstudent not in(select xstudent from #tmpStd)         
	        and (tYear_Student.idx IS NULL) and (tYear_Student.xHozeh=@xHozeh)
	        ORDER BY NEWID()        
           end
	else if( @sort =4)
           begin
	        insert into #tmpStd(xstudent,xpaye)                
	        SELECT      tYear_Student.xstudent, tYear_Student.xpaye                 
	        FROM         tstudent inner join   tYear_Student     
                ON  tStudent.id =tYear_Student.xStudent    
	       WHERE  tYear_Student.xYear=@xYear and  tYear_Student.xstudent not in(select xstudent from #tmpStd)         
	        and (tYear_Student.idx IS NULL) and (tYear_Student.xHozeh=@xHozeh)
	        order by tYear_Student.sort,tStudent.fname , tStudent.lname 
           end             
            

                     
                
                
Declare @CountStd int                
Declare @CounterPaye int                 
Declare @id int                 
set @CounterPaye=1                
create table #tmpPaye(id int IDENTITY (1, 1) NOT NULL,xPaye int)                         
insert into #tmpPaye(xPaye)                
select distinct xPaye from #tmpStd order by xPaye                      
select @CountPaye=count(id) from #tmpPaye                
select @CountStd=count(id) from #tmpStd                     
while (@CountStd>0)                
begin                
                
select @id= min(id) from #tmpStd where xPaye in(select xPaye from #tmpPaye where id=@CounterPaye) and idx is null                
if(@id>0)                
begin                
 update #tmpStd set idx=@CounterIDx where id=@id                
 set @CounterIDx=@CounterIDx+1                
 set @CountStd=@CountStd-1        
end                
set @CounterPaye=@CounterPaye+1                
  if(@CounterPaye>@CountPaye)                
       set @CounterPaye=1                
                
                
                
end                
                
                
update tYear_Student set idx=#tmpStd.idx                
from tYear_Student inner join #tmpStd on tYear_Student.xstudent=#tmpStd.xstudent
WHERE  tYear_Student.xYear=@xYear                 
                
drop table #tmpPaye                
drop table #tmpStd