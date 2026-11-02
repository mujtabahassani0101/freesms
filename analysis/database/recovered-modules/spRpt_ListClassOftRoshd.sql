--spRpt_ListClassOftRoshd 102,'14,15,16',1398
CREATE PROCEDURE dbo.spRpt_ListClassOftRoshd
@Exam varchar(500),
@Class varchar(500)  ,
@xYear int with encryption
AS
declare @NumExam int
declare @Exam1 int

select @NumExam =NumExam from tExam where id=@Exam
set @NumExam=@NumExam-1
select @Exam1=id from tExam where NumExam=@NumExam and xYear=@xYear

create table #stdB (grp int,typ int,xbook int,xStudent bigint,xClass  int,Mark2 float,gcls2 int,test2 nvarchar (50) ,mark1 float ,gcls1 int,test1 nvarchar (50)) 

---------------------------------------------------------------------------------------------------
insert into #stdB(grp,typ,xbook,xStudent,xClass,Mark2,gcls2)

SELECT    1,5,-5, tMarkDoreh.xStudent, tYear_Student.xClass, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
FROM       tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE     (tMarkDoreh.typ = 5) and tMarkDoreh.gClass<6
and  tMarkDoreh.Xtest=@Exam
and tYear_Student.xClass in(select * from SplitNumber(@Class))
AND (tYear_Student.xYear = @xYear)

-----------------------------------------------------------------------------------------------------
insert into #stdB(grp,typ,xbook,xStudent,xClass,Mark2,gcls2)
SELECT    2,5,-5, tMarkDoreh.xStudent, tYear_Student.xClass, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
FROM       tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                           inner join 
                          (SELECT     tYear_Student.xClass, tMarkDoreh.Xtest, tMarkDoreh.typ, MAX(tMarkDoreh.gClass)-4 AS Maxgcls
				FROM         tMarkDoreh INNER JOIN
				                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                                                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
                                WHERE     (tMarkDoreh.typ = 5)and  tMarkDoreh.Xtest=@Exam AND (tYear_Student.xYear = @xYear)
				and tYear_Student.xClass in(select * from SplitNumber(@Class))				
		                 GROUP BY tYear_Student.xClass, tMarkDoreh.Xtest, tMarkDoreh.typ
				) maxgcls ON tMarkDoreh.xtest = maxgcls.xtest AND tYear_Student.xClass = maxgcls.xClass AND 
                  		 tMarkDoreh.gClass >= maxgcls.Maxgcls 
where (tYear_Student.xYear = @xYear)
----------------------------------------------


------------------------------------------------------------
update #stdB set  #stdB.mark1=nobat1.MarkDoreh,#stdB.gcls1=nobat1.gClass from #stdB  INNER JOIN
(SELECT     tMarkDoreh.xStudent, tYear_Student.xClass,tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
FROM       tMarkDoreh INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE     (tMarkDoreh.typ = 5) 
and (tYear_Student.xYear = @xYear)
and  tMarkDoreh.Xtest=@Exam1
and tYear_Student.xClass in(select * from SplitNumber(@Class))
and tMarkDoreh.xStudent in(select distinct xStudent from #stdB)) nobat1
 on #stdB.xStudent=nobat1.xStudent


Create table #tmp (xStudent bigint , xClass int , roshd float,mark2 float ,mark1 float,gcls2 int ,gcls1 int) 
insert into  #tmp
select nobat2.xStudent,nobat1.xClass,nobat2.MarkDoreh - nobat1.MarkDoreh as roshd,nobat2.MarkDoreh,nobat1.MarkDoreh,nobat2.gClass,nobat1.gClass  from
(
	SELECT     tMarkDoreh.xStudent, tYear_Student.xClass, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
	FROM         tMarkDoreh INNER JOIN
	                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                             tYear_Student ON tStudent.id = tYear_Student.xStudent 
	WHERE (tMarkDoreh.typ = 5) 
        and (tYear_Student.xYear = @xYear)
	AND (tMarkDoreh.Xtest = @Exam1)
	AND (tYear_Student.xClass in(select * from SplitNumber(@Class)))
	
)nobat1
inner join 
(
	SELECT     tMarkDoreh.xStudent, tYear_Student.xClass, tMarkDoreh.MarkDoreh, tMarkDoreh.gClass
	FROM         tMarkDoreh INNER JOIN
	                      tStudent ON tMarkDoreh.xStudent = tStudent.id INNER JOIN
                              tYear_Student ON tStudent.id = tYear_Student.xStudent 
	WHERE     (tMarkDoreh.typ = 5) 
        and (tYear_Student.xYear = @xYear)
	AND (tMarkDoreh.Xtest = @Exam)
	AND (tYear_Student.xClass in(select * from SplitNumber(@Class)))
)
nobat2 
on nobat1.xStudent=nobat2.xStudent
--select * from #tmp
--select top 5 * from #tmp where xsch =13003 and XtestTitel=8 order by roshd  
--select top 5 * from #tmp where xsch =13003 and XtestTitel=8 order by roshd desc
DECLARE @xClass int


DECLARE testTitel  CURSOR FOR
select distinct xClass  from #stdB
 OPEN testTitel  
 FETCH NEXT FROM testTitel  INTO
	@xClass
  WHILE @@FETCH_STATUS = 0
  BEGIN

      insert into #stdB(grp,typ,xbook,xStudent,xClass,mark1,Mark2, gcls1,gcls2)
      select top 5  4,5,-5, xStudent,xClass,Mark1,Mark2,gcls1,gcls2 from #tmp where xClass =@xClass and roshd<0 
       order by roshd             
      insert into #stdB(grp,typ,xbook,xStudent,xClass,mark1,Mark2, gcls1,gcls2)
      select top 5 3,5,-5,xStudent,xClass,Mark1,Mark2,gcls1,gcls2 from #tmp where xClass =@xClass and roshd>0 
    order by roshd  desc            

       FETCH NEXT FROM testTitel  INTO
	@xClass
  end
close testTitel
deallocate testTitel

update #stdB set test1=(select name from texam where id=@Exam1)
update #stdB set test2=(select name from texam where id=@Exam)

select #stdB.*  ,  tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.xPaye
FROM      #stdB inner join  
          tStudent  on #stdB.xStudent=tStudent.id INNER JOIN
                 tYear_Student ON tStudent.id = tYear_Student.xStudent 
                INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id 
drop table #tmp
drop table #stdB