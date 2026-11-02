--990902
update tRptLable set Caption=N'شماره چوکي با نام' where id=1
GO
update tRptLable set Caption=N'شماره چوکي بدون نام' where id=2
GO
update tRptLable set Caption=N'ليست رهنما دانش آموزان هر صنف براي مشاهده شماره چوکي و حوزه امتحاني ' where id=7
GO
update tRptLable set Caption=N'ليست رهنما دانش آموزان هر پايه براي مشاهده شماره چوکي و حوزه امتحاني' where id=8
GO
update tRptChart  set Caption=REPLACE(Caption, N'کلاس', N'صنف')
GO
update tRptChart  set Caption=N'نمودار عملکرد استاد در هر درس و صنف' where id=1011
GO


alter table tYear_Student add ShowSarbarg1 bit,ShowSarbarg2 bit,
ShowSarbarg3 bit,ShowSarbarg4 bit,ShowSarbarg6 bit,ShowSarbarg7 bit
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg1 DEFAULT 1 FOR ShowSarbarg1
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg2 DEFAULT 1 FOR ShowSarbarg2
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg3 DEFAULT 1 FOR ShowSarbarg3
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg4 DEFAULT 1 FOR ShowSarbarg4
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg6 DEFAULT 1 FOR ShowSarbarg6
GO
ALTER TABLE dbo.tYear_Student ADD CONSTRAINT
	DF_tYear_Student_ShowSarbarg7 DEFAULT 1 FOR ShowSarbarg7
GO
update tYear_Student set ShowSarbarg1=1,ShowSarbarg2=1
,ShowSarbarg3=1,ShowSarbarg4=1,ShowSarbarg6=1,ShowSarbarg7=1 where ShowSarbarg1 is null and Status=1
GO
update tYear_Student set ShowSarbarg1=0,ShowSarbarg2=0
,ShowSarbarg3=0,ShowSarbarg4=0,ShowSarbarg6=0,ShowSarbarg7=0 where ShowSarbarg1 is null and Status<>1
GO
alter FUNCTION ReturnMoonBdate(@xStdtunt int)
RETURNS nvarchar(20)  with encryption 
AS
BEGIN
declare @MoonBdate nvarchar(20)

declare @BDate nvarchar(10)
declare @xMoonBDate int


select @BDate=bDate from tstudent where id=@xStdtunt

if len(@BDate)=10
begin

   if isnumeric(substring(@BDate,6,2)) = 0
    return @MoonBdate
	 
   set @xMoonBDate=cast(substring(@BDate,6,2) as int)
   if(@xMoonBDate=1)
     set @MoonBdate=N'حمل'
   else if(@xMoonBDate=2)
     set @MoonBdate=N'ثور'
  else if(@xMoonBDate=3)
     set @MoonBdate=N'جوزا'
  else if(@xMoonBDate=4)
     set @MoonBdate=N'سرطان'
  else if(@xMoonBDate=5)
     set @MoonBdate=N'اسد'
  else if(@xMoonBDate=6)
     set @MoonBdate=N'سنبله'
  else if(@xMoonBDate=7)
     set @MoonBdate=N'ميزان'
  else if(@xMoonBDate=8)
     set @MoonBdate=N'عقرب'
  else if(@xMoonBDate=9)
     set @MoonBdate=N'قوس'
  else if(@xMoonBDate=10)
     set @MoonBdate=N'جدي'
  else if(@xMoonBDate=11)
     set @MoonBdate=N'دلي'
  else if(@xMoonBDate=12)
     set @MoonBdate=N'حوت'


end
else
 set @MoonBdate=null



return  @MoonBdate

end

GO


alter FUNCTION ReturnSen(@xStdtunt int,@DateForPrint nvarchar(10))
RETURNS Int  with encryption 
AS
BEGIN
declare @Sen int

declare @BDate nvarchar(10)
declare @xYearBDate int
declare @xYearDateForPrint int
declare @xMoonBDate int
declare @xMoonDateForPrint int

select @BDate=bDate from tstudent where id=@xStdtunt

if len(@BDate)=10
begin

  if isnumeric(substring(@BDate,1,4)) = 0
    return null
   if isnumeric(substring(@BDate,6,2)) = 0
    return null

  set @xYearBDate=cast(substring(@BDate,1,4) as int)
  set @xYearDateForPrint=cast(substring(@DateForPrint,1,4) as int)
  set @xMoonBDate=cast(substring(@BDate,6,2) as int)
  set @xMoonDateForPrint=cast(substring(@DateForPrint,6,2) as int)
  
if(@xMoonDateForPrint=12 and @xMoonBDate=1)
 set @xYearDateForPrint=@xYearDateForPrint+1

 set @Sen=@xYearDateForPrint-@xYearBDate
   

end
else
 set @Sen=null



return  @Sen

end


GO
create FUNCTION [dbo].[ReturnStdForNoPrintSarbarg](@formType smallint,@xYear int)  
RETURNS @RtnValue table 
(
	Data bigint
)
with encryption 
 AS  
BEGIN 
 if(@formType=1 or @formType=5)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg1=0
 else if(@formType=2)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg2=0
 else if(@formType=3)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg3=0
 else if(@formType=4)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg4=0
 else if(@formType=6)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg6=0
 else if(@formType=7)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg7=0
	
 Return
END

GO
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


GO

alter procedure  dbo.sp_SelectStdForSarbarg_Test_Type2
@type int,
@code int,
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10) ,
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int,
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


SELECT  top 8  tStudent.code as  [code_motalem], tYear_Student.idx as [choki], tHozeh.Name  as [hoze], tStudent.FName  as [Name], tStudent.LName  as [valad]
, tStudent.FName+ N' ' + tStudent.LName  as [Name_valad],  
                      tStudent.PName  as [valadiyat],tYear_Student.sort as [tartib],
tStudent.LastName as [takhalos],tStudent.NumberAsas as [Number_Asas] ,tStudent.Sh_Sh as [Number_Tazkare],tStudent.RegDate as [tarikh_shomoliyat],
tStudent.En_Fname  as [name_English],tStudent.En_LastName  as [takhalos_English],tStudent.En_Lname as  [pedar_English]
,MobileFather as [telphon_pedar] ,MobileMother  as [telphon_madar] , tClass.name   as [senf], tPaye.Name   as [Paye],tStudentImg.Student_img   as [Aks]
                  --     ,tmpTch.dabir,(select name from tbook where id=@xBook) as Mazmon
--,@DateExam as TarikhExam,@TimeExam as TimeExam,@CountPageExam as PageExam
,tStudent.bdate as [tarikh_tavalod],dbo.ReturnSen(tStudent.id,@DateExam) as [sen],case when isnumeric(substring(tStudent.bdate,9,2)) = 1 
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
order by tYear_Student.xpaye,tClass.name,tYear_Student.sort,tStudent.lname,tStudent.fname
drop table #tmpId
GO


alter procedure  dbo.sp_SelectStdForSarbarg_Type1
@type int,
@code  varchar(8000),
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10) ,
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

SELECT    tStudent.code as  [code_motalem], tYear_Student.idx as [choki], tHozeh.Name  as [hoze], tStudent.FName  as [Name], tStudent.LName  as [valad]
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
			WHERE     (tTch_Cls.xLsn = @xBook) and tTch_Cls.xCls in(select id from tclass where xYear=@xYear ))tmpTch on tYear_Student.xClass =tmpTch.xCls
where tstudent.id in(select id from #tmpId )
and tYear_Student.xYear=@xYear
and tYear_Student.xStudent not in(select * from dbo.ReturnStdForNoPrintSarbarg(@formType,@xYear))
order by sortid
drop table #tmpId



GO


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


GO
UPDATE    tVer
                         SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQlVBRThBU0FCa0FGQUFWUUI2QUdnQU13QlVBRmNBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO