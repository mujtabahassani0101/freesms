CREATE procedure  dbo.sp_SelectStdForSarbarg 
@type int,
@code int,
@sort int ,
@xyear int with encryption

as
create table #tmpId(id int)
if(@type=0)
	insert into #tmpId select xstudent from tYear_Student where xYear= @xyear
if(@type=1)
	insert into #tmpId select  xstudent from tYear_Student where xYear= @xyear and xpaye=@code
else if(@type=2)
	insert into #tmpId select  xstudent from tYear_Student where xYear= @xyear and xclass=@code
else if(@type=3)
	insert into #tmpId select  xstudent from tYear_Student where xYear= @xyear and xstudent=@code
else if(@type=4)
	insert into #tmpId select xstudent from tYear_Student where xYear= @xyear  and xhozeh is not null
else if(@type=5)
	insert into #tmpId select xstudent from tYear_Student where xYear= @xyear  and xhozeh=@code


SELECT     tStudent.id AS id,tStudent.code, tYear_Student.idx, tHozeh.Name AS Hozeh, tStudent.FName, tStudent.LName
, tStudent.FName+ N' ' + tStudent.LName as fullname,  
                      tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye,tStudentImg.Student_img as stdimg,
case @sort when 1 then  cast (tYear_Student.xpaye+100000 as nvarchar)+ '-' +tClass.name+ '-'+ cast (tYear_Student.sort+100000 as nvarchar) +'-'+lname+'-'+fname
when 2 then cast (tYear_Student.xhozeh+100000 as nvarchar)+'-'+ cast (tYear_Student.idx+100000 as nvarchar) end as sortid

FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id left outer JOIN
                      tHozeh ON tYear_Student.xhozeh = tHozeh.id left outer JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent
where tstudent.id in(select id from #tmpId )
AND (tYear_Student.xYear = @xYear)
order by sortid

drop table #tmpId
