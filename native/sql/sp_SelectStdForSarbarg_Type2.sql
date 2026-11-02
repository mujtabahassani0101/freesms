alter procedure  dbo.sp_SelectStdForSarbarg_Type2
@type int,
@code varchar(8000),
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int ,
@formType smallint  with encryption  
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

else if(@type=9)
	insert into #tmpId select id from tstudent where id in(select * from SplitNumber(@code))


SELECT   tStudent.code as  [code_motalem], tYear_Student.idx as [choki], tHozeh.Name  as [hoze], tStudent.FName  as [Name], tStudent.LName  as [valad]
, tStudent.FName+ N' - ' + tStudent.LName  as [Name_valad],  
tStudent.PName  as [valadiyat],tYear_Student.sort as [tartib],
tStudent.LastName as [takhalos],tStudent.NumberAsas as [Number_Asas] ,tStudent.Sh_Sh as [Number_Tazkare],tStudent.RegDate as [tarikh_shomoliyat],
tStudent.En_Fname  as [name_English],tStudent.En_LastName  as [takhalos_English],tStudent.En_Lname as  [pedar_English],
MobileFather as [telphon_pedar] ,MobileMother  as [telphon_madar] , tClass.name   as [senf], tPaye.Name   as [Paye],tStudentImg.Student_img   as [Aks]
                  --     ,tmpTch.dabir,(select name from tbook where id=@xBook) as Mazmon
--,@DateExam as TarikhExam,@TimeExam as TimeExam,@CountPageExam as PageExam
,tStudent.bdate as [tarikh_tavalod],dbo.ReturnSen(tStudent.id,@DateExam) as [sen],
case when isnumeric(substring(tStudent.bdate,9,2)) = 1 
            then cast(cast(substring(tStudent.bdate,9,2) as int) as nvarchar)+' ' + dbo.ReturnMoonBdate(tStudent.id)
            else NULL 
end as [Roz_tavalod] 
,case @sort when 1 then  cast (tYear_Student.xpaye+100000 as nvarchar)+ '-' +tClass.name+ '-'+ cast (tYear_Student.sort+100000 as nvarchar) +'-'+tStudent.lname+'-'+tStudent.fname
when 2 then cast (tYear_Student.xhozeh+100000 as nvarchar)+'-'+ cast (tYear_Student.idx+100000 as nvarchar) end as sortid

FROM         tStudent  inner join 
             tYear_Student on tStudent.id=tYear_Student.xStudent INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id left outer JOIN
                      tHozeh ON tYear_Student.xhozeh = tHozeh.id left outer JOIN
                      tStudentImg ON tStudent.id = tStudentImg.xStudent
where tstudent.id in(select id from #tmpId )
and tYear_Student.xYear=@xYear
and tYear_Student.xStudent not in(select * from dbo.ReturnStdForNoPrintSarbarg(@formType,@xYear))
order by sortid
drop table #tmpId