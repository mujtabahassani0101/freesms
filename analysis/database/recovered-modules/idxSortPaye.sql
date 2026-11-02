CREATE Procedure [dbo].idxSortPaye 
@xYear int,   
@xHozeh int,                
@Start int,
@sort int with encryption
as  
set @Start=@Start-1                            
declare @sql varchar (1000)                
declare @CountPaye int                
declare @CountClass int                 
declare @CounterClass int                 
declare @CounterNostdClass int                               
              
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
            



                     
                
Declare @CounterIDx int                
select  @CounterIDx=isnull(max(idx),@Start)+1 from tYear_Student where xyear=@xYear and xHozeh=@xHozeh                            
Declare @id int                 

DECLARE TESTSTD CURSOR FOR
	SELECT ID from #tmpStd where  idx is null  order by xpaye,id  
OPEN TESTSTD
FETCH NEXT FROM TESTSTD INTO
	@ID
WHILE @@FETCH_STATUS = 0
BEGIN                  
   update #tmpStd set idx=@CounterIDx where id=@id                
   set @CounterIDx=@CounterIDx+1 
    FETCH NEXT FROM TESTSTD INTO
		@ID                     
END
CLOSE TESTSTD
DEALLOCATE TESTSTD            
                

update tYear_Student set idx=#tmpStd.idx                
from tYear_Student inner join #tmpStd on tYear_Student.xstudent=#tmpStd.xstudent
WHERE  tYear_Student.xYear=@xYear                 
                
              
drop table #tmpStd