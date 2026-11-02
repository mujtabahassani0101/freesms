alter procedure  dbo.sp_SelectStdForSarbarg_Test_Type1
@type int,
@code int,
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int ,
@formType smallint with encryption  
as
create table #tmpId(id int)
if(@type=0)
	insert into #tmpId select tstudent.id from tstudent  inner join 
        tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.Status=1 and tYear_Student.xYear=@xYear
if(@type=1)
	insert into #tmpId select tstudent.id from tstudent  inner join 
        tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.Status=1 and tYear_Student.xYear=@xYear and tYear_Student.xpaye=@code
else if(@type=2)
	insert into #tmpId select tstudent.id from tstudent  inner join 
        tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.Status=1 and tYear_Student.xYear=@xYear and tYear_Student.xclass=@code
else if(@type=3)
	insert into #tmpId select id from tstudent where id=@code
else if(@type=4)
	insert into #tmpId select tstudent.id from tstudent  inner join 
        tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.Status=1 and tYear_Student.xYear=@xYear and tYear_Student.xhozeh is not null
else if(@type=5)
	insert into #tmpId select tstudent.id from tstudent  inner join 
        tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.Status=1 and tYear_Student.xYear=@xYear and tYear_Student.xhozeh=@code


SELECT  top 2  tStudent.code as  [code_motalem], tYear_Student.idx as [choki], tHozeh.Name  as [hoze], tStudent.FName  as [Name], tStudent.LName  as [valad]
, tStudent.FName+ N' ' + tStudent.LName  as [Name_valad],tYear_Student.sort as [tartib],  
                      tStudent.PName  as [valadiyat],
tStudent.LastName as [takhalos],tStudent.NumberAsas as [Number_Asas] ,tStudent.Sh_Sh as [Number_Tazkare],tStudent.bDate as [tarikh_tavalod],
tStudent.En_Fname  as [name_English],tStudent.En_LastName  as [takhalos_English],tStudent.En_Lname as  [pedar_English],
 tClass.name   as [senf], tPaye.Name   as [Paye],tStudentImg.Student_img   as [Aks],
                       tmpTch.dabir as [Teacher],(select name from tbook where id=@xBook) as Mazmon
,@DateExam as TarikhExam,@TimeExam as TimeExam,@StartExam as StartExam,@CountPageExam as PageExam,@CountQusExam as QusExam
,case @sort when 1 then  cast (tYear_Student.xpaye+100000 as nvarchar)+ '-' +tClass.name+ '-'+ cast (tYear_Student.sort+100000 as nvarchar) +'-'+tStudent.lname+'-'+tStudent.fname
when 2 then cast (tYear_Student.xhozeh+100000 as nvarchar)+'-'+ cast (tYear_Student.idx+100000 as nvarchar) end as sortid,tStudent.id as xStudent

FROM         tStudent  inner join 
             tYear_Student on tStudent.id=tYear_Student.xStudent INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id left outer JOIN
                      tHozeh ON tYear_Student.xhozeh = tHozeh.id left outer JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent left outer JOIN
                       (SELECT     tTch_Cls.xCls,  tTeacher.fNamF + ' ' + tTeacher.fNamL AS dabir
			FROM         tTch_Cls INNER JOIN
                     	 tTeacher ON tTch_Cls.xTch = tTeacher.id
			WHERE     (tTch_Cls.xLsn = @xBook) and tTch_Cls.xCls in(select id from tclass where xYear=@xYear ))tmpTch
                          on tYear_Student.xClass =tmpTch.xCls
where tstudent.id in(select id from #tmpId )
and tYear_Student.xYear=@xYear
and tYear_Student.xStudent not in(select * from dbo.ReturnStdForNoPrintSarbarg(@formType,@xYear))
order by tYear_Student.xpaye,tClass.name,tYear_Student.sort,tStudent.lname
drop table #tmpId