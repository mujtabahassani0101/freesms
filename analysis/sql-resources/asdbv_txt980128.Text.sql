--13980128
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFNEFWUUI2QUdnQU5RQlVBREFBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO

CREATE TABLE [dbo].[tRptAFLsit] (
	[id] [int] NOT NULL ,
	[Caption] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[Rpt] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[sp] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[subReport] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[type] [int] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tRptAFLsit] ADD 
	CONSTRAINT [PK_tRptAFLsit] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (1, N'چاپ شقه', N'CrChapShaghe', N'sp_rptChapShaghe', N'Sub1,sp_SubrptChapShaghe,Sub2,sp_SubrptChapShaghe', 1)
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (2, N'چاپ شقه حاضری', N'CrChapShagheHzeri', N'sp_RptListStd', N'Sub1,sp_SubrptChapShagheHzeri,Sub2,sp_SubrptChapShagheHzeri', 1)
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (3, N'گزارش کل شاگردان صنف', N'CrListStdKoll', N'sp_RptListStd', N'Sub1,sp_SubListStdKoll,Sub2,sp_SubListStdKoll', 1)
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (4, N'گزارش شاگردانی که در شقه می آیند', N'CrListStdshaghe', N'sp_RptListStd', N'Sub1,sp_SubListStdshaghe,Sub2,sp_SubListStdshaghe', 1)
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (5, N'گزارش شاگردانی که در لیست مالی می آیند', N'CrListStdMali', N'sp_RptListStd', N'Sub1,sp_SubListStdMali,Sub2,sp_SubListStdMali', 1)
GO
INSERT [dbo].[tRptAFLsit] ([id], [Caption], [Rpt], [sp], [subReport], [type]) VALUES (6, N'گزارش شاگردانی که حاضرند', N'CrListStdHazer', N'sp_RptListStd', N'Sub1,sp_SubListStdHazer,Sub2,sp_SubListStdHazer', 1)
GO

CREATE procedure dbo.sp_SubListStdshaghe
@Class varchar(500)  ,
@xYear int
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.shaghe = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO

--sp_rptChapShagheHzeri '','32,33,34,35'
CREATE procedure dbo.sp_rptListStd
@Class varchar(500),
@xYear int with encryption
as
create table #tmp(id int identity ,xClass1 int ,xClass2 int)
declare @xclass int
declare @xPaye int
declare @id int
declare @counter int


declare paye cursor for
SELECT  distinct   xpaye
FROM         tClass
WHERE (xYear = @xYear) and id in(select * from SplitNumber(@Class))
and id IN 
         (SELECT xclass  FROM tyear_student 
          WHERE xyear = @xYear  and xclass in(select * from SplitNumber(@Class)))
ORDER BY xpaye
      open paye
fetch next from paye into 
     @xPaye
Set @counter=1
while (@@fetch_status=0)
begin

	declare class cursor for
	SELECT id FROM tclass WHERE (xPaye = @xPaye)
        and id in(select xclass from tYear_Student where xYear=@xYear)  ORDER BY sortRpt 
	      open class
	fetch next from class into 
	     @xclass
	while (@@fetch_status=0)
	begin
          
        if(@counter=1)
          begin
           insert into #tmp(xclass1)values(@xclass)
            set @id=@@identity
            set @counter=2
          end
        else
          begin
             update #tmp set xclass2=@xclass where id=@id
             set @counter=1
          end

	fetch next from class into 
	   @xclass
	end
	close class
	deallocate class


--Set @counter=1
fetch next from paye into 
   @xPaye
end
close paye
deallocate paye

select * from #tmp
drop table #tmp

GO
CREATE procedure dbo.sp_SubListStdKoll
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tParmetr
WHERE  (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO
CREATE procedure dbo.sp_SubListStdHazer
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.hazer = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO
CREATE procedure dbo.sp_SubListStdMali
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                      tPaye ON tYear_Student.xPaye = tPaye.id CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))


GO
--sp_rptChapShaghe '','32,33,34,35'
alter procedure dbo.sp_rptChapShaghe
@Class varchar(500)  ,
@xYear int with encryption
as
create table #tmp(id int identity ,xClass int,xbook1 int ,xbook2 int)
declare @xclass int
declare @xPaye int
declare @xbook int
declare @id int
declare @counter int


declare paye cursor for
SELECT     xpaye,id
FROM         tClass
WHERE (xYear = @xYear) and id in(select * from SplitNumber(@Class))
and id IN 
         (SELECT xclass  FROM tyear_student 
          WHERE xyear = @xYear  and xclass in(select * from SplitNumber(@Class)))
ORDER BY xpaye,sortRpt
      open paye
fetch next from paye into 
     @xPaye,@xclass
Set @counter=1
while (@@fetch_status=0)
begin

	declare book cursor for
	SELECT id FROM tBook WHERE (xPaye = @xPaye) and Vezarat=1 ORDER BY sort
	      open book
	fetch next from book into 
	     @xbook
	while (@@fetch_status=0)
	begin
          
        if(@counter=1)
          begin
           insert into #tmp(xClass,xbook1)values(@xclass,@xbook)
            set @id=@@identity
            set @counter=2
          end
        else
          begin
             update #tmp set xbook2=@xbook where id=@id
             set @counter=1
          end

	fetch next from book into 
	   @xbook
	end
	close book
	deallocate book


Set @counter=1
fetch next from paye into 
   @xPaye,@xclass
end
close paye
deallocate paye

select * from #tmp
drop table #tmp



GO
alter procedure dbo.sp_SubrptChapShaghe
@Class varchar(500)  ,
@xYear int with encryption
as 
SELECT     tYear_Student.xClass, tBook.id AS xbook, tYear_Student.xStudent, tClass.id, tYear_Student.sort, tStudent.FName, tStudent.LName, tClass.answerable, 
                      tBook.Name as book,isnull( tTeacher.fNamF + ' ' + tTeacher.fNamL,N' ') AS tch, tClass.name as Class,cast(tClass.xYear as nvarchar(4)) as xYear
			, tParmetr.heder1, tParmetr.sch
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tBook INNER JOIN
                      tClass ON tBook.xPaye = tClass.xpaye ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN
                      tTch_Cls ON tBook.id = tTch_Cls.xLsn AND tClass.id = tTch_Cls.xCls LEFT OUTER JOIN
                      tTeacher ON tTch_Cls.xTch = tTeacher.id  CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.shaghe = 1) AND (tBook.Vezarat = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))


GO
alter procedure dbo.sp_SubrptChapShagheHzeri
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xClass, tYear_Student.xStudent, tClass.id, tYear_Student.sort, tStudent.FName, tStudent.LName, tClass.answerable, 
                 tClass.name as Class,cast(tClass.xYear as nvarchar(4)) as xYear
			, tParmetr.heder1, tParmetr.sch
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id  CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.shaghe = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO
DELETE FROM tRpt
WHERE     (id IN (51, 52))
GO