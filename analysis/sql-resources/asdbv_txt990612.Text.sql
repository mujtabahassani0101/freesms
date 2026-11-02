--13990612
CREATE TABLE [dbo].[tComnentStd] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[xStudent] [int] NULL ,
	[xYear] [int] NULL ,
	[dayOfWeek] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[subject] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[Comment] [nvarchar] (1000) COLLATE Arabic_CI_AS NULL ,
	[DateInsert] [nvarchar] (10) COLLATE Arabic_CI_AS NULL ,
	[TimeInsert] [nvarchar] (10) COLLATE Arabic_CI_AS NULL ,
	[DateUpdate] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[xUserInsert] [int] NULL ,
	[xUserUpdate] [int] NULL ,
	[deleteDate] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[xUserDelete] [int] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tComnentStd] ADD 
	CONSTRAINT [PK_tComnentStd] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO
create FUNCTION ReturnMoonBdate(@xStdtunt int)
RETURNS nvarchar(20)  with encryption 
AS
BEGIN
declare @MoonBdate nvarchar(20)

declare @BDate nvarchar(10)
declare @xMoonBDate int


select @BDate=bDate from tstudent where id=@xStdtunt

if len(@BDate)=10
begin
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
     set @MoonBdate=N'میزان'
  else if(@xMoonBDate=8)
     set @MoonBdate=N'عقرب'
  else if(@xMoonBDate=9)
     set @MoonBdate=N'قوس'
  else if(@xMoonBDate=10)
     set @MoonBdate=N'جدی'
  else if(@xMoonBDate=11)
     set @MoonBdate=N'دلی'
  else if(@xMoonBDate=12)
     set @MoonBdate=N'حوت'


end
else
 set @MoonBdate=null



return  @MoonBdate

end
GO
CREATE FUNCTION ReturnSen(@xStdtunt int,@DateForPrint nvarchar(10))
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

CREATE Procedure dbo.sp_tComnentStd_insertUpdate
@id int,
@xYear int,
@xStudent int,
@dayOfWeek nvarchar(20),
@subject nvarchar(200),
@comment nvarchar(1000),
@Date nvarchar(10),
@Time nvarchar(10),
@xUser int with encryption
as
if(@id=0)
  begin 

		   INSERT INTO tComnentStd
		                      (xYear, xStudent, DateInsert,TimeInsert,dayOfWeek, subject, comment, xUserInsert)
				VALUES (@xYear, @xStudent, @Date,@Time, @dayOfWeek, @subject, @comment, @xUser)
                 end
  else
  begin
                
			UPDATE    tComnentStd SET  subject =@subject, comment =@comment ,
		        DateUpdate =@Date+'-'+@Time, xUserUpdate =@xUser    where id=@id
                
         
  end

GO
CREATE procedure  dbo.sp_SelectStdForSarbarg_Test_Type1
@type int,
@code int,
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int  with encryption  
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
order by tYear_Student.xpaye,tClass.name,tYear_Student.sort,tStudent.lname
drop table #tmpId
GO


CREATE procedure  dbo.sp_SelectStdForSarbarg_Test_Type2
@type int,
@code int,
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10) ,
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int  with encryption  
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
tStudent.LastName as [takhalos],tStudent.NumberAsas as [Number_Asas] ,tStudent.Sh_Sh as [Number_Tazkare],tStudent.bDate as [tarikh_tavalod],
tStudent.En_Fname  as [name_English],tStudent.En_LastName  as [takhalos_English],tStudent.En_Lname as  [pedar_English]
,MobileFather as [telphon_pedar] ,MobileMother  as [telphon_madar] , tClass.name   as [senf], tPaye.Name   as [Paye],tStudentImg.Student_img   as [Aks]
                  --     ,tmpTch.dabir,(select name from tbook where id=@xBook) as Mazmon
--,@DateExam as TarikhExam,@TimeExam as TimeExam,@CountPageExam as PageExam
,tStudent.bdate as [tarikh_tavalod],dbo.ReturnSen(tStudent.id,@DateExam) as [sen],cast(cast(substring(tStudent.bdate,9,2) as int) as nvarchar)+' ' + dbo.ReturnMoonBdate(tStudent.id) as [Roz_tavalod] 
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
order by tYear_Student.xpaye,tClass.name,tYear_Student.sort,tStudent.lname,tStudent.fname
drop table #tmpId



GO


CREATE procedure  dbo.sp_SelectStdForSarbarg_Type1
@type int,
@code  varchar(8000),
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10) ,
@StartExam nvarchar(15),
@xYear int  with encryption  
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
order by sortid
drop table #tmpId

GO
CREATE procedure  dbo.sp_SelectStdForSarbarg_Type2
@type int,
@code varchar(8000),
@sort int,
@xBook int,
@DateExam nvarchar(10),
@TimeExam nvarchar(50),
@CountPageExam nvarchar(10),
@CountQusExam nvarchar(10),
@StartExam nvarchar(15),
@xYear int  with encryption  
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
tStudent.LastName as [takhalos],tStudent.NumberAsas as [Number_Asas] ,tStudent.Sh_Sh as [Number_Tazkare],tStudent.bDate as [tarikh_tavalod],
tStudent.En_Fname  as [name_English],tStudent.En_LastName  as [takhalos_English],tStudent.En_Lname as  [pedar_English],
MobileFather as [telphon_pedar] ,MobileMother  as [telphon_madar] , tClass.name   as [senf], tPaye.Name   as [Paye],tStudentImg.Student_img   as [Aks]
                  --     ,tmpTch.dabir,(select name from tbook where id=@xBook) as Mazmon
--,@DateExam as TarikhExam,@TimeExam as TimeExam,@CountPageExam as PageExam
,tStudent.bdate as [tarikh_tavalod],dbo.ReturnSen(tStudent.id,@DateExam) as [sen],cast(cast(substring(tStudent.bdate,9,2) as int) as nvarchar)+' ' + dbo.ReturnMoonBdate(tStudent.id) as [Roz_tavalod] 
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
order by sortid
drop table #tmpId




GO


CREATE TABLE [dbo].[tmpStdforPrintSarbarg] (
	[id] [int] NOT NULL ,
	[xUser] [int] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tmpStdforPrintSarbarg] ADD 
	CONSTRAINT [PK_tmpStdforPrintSarbarg] PRIMARY KEY  CLUSTERED 
	(
		[id],
		[xUser]
	)  ON [PRIMARY] 
GO


CREATE TABLE [dbo].[tRptDynamic] (
	[id] [int] NOT NULL ,
	[Caption] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[Rpt] [image] NULL ,
	[sys] [bit] NULL ,
	[type] [smallint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tRptDynamic] ADD 
	CONSTRAINT [PK_tRptDynamic] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQlVBRThBU0FCa0FFOEFZUUJVQUdnQU5BQlVBRmNBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='

GO