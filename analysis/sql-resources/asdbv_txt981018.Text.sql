--13981018
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCb0FFNEFVUUI2QUdnQU5BQlVBREFBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
CREATE TABLE [dbo].[tMarkAgo] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[xStudent] [int] NULL ,
	[xPaye] [int] NULL ,
	[typ] [smallint] NULL ,
	[xbook] [int] NULL ,
	[Mark] [float] NULL ,
	[gClass] [smallint] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tMarkAgo] ADD 
	CONSTRAINT [PK_tMarkAgo] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO
create Procedure dbo.sp_tMarkAgo_insertUpdate
@xStudent int,
@xPaye int,
@xbook int,
@Mark float with encryption

as
if not exists(select id from tMarkAgo where xStudent=@xStudent and xPaye=@xPaye and  xbook=@xbook)
	INSERT INTO tMarkAgo
	                      (xStudent, xPaye,typ, xbook, Mark)
	VALUES      (@xStudent, @xPaye,1, @xbook, @Mark)
else 
	UPDATE    tMarkAgo
	SET  Mark =@Mark
	where xStudent=@xStudent and xPaye=@xPaye and  xbook=@xbook
GO
alter table tclass add Separcheh smallint
GO
--spRpt_Listfinal 105,'82,83,84',1398

alter  PROCEDURE dbo.spRpt_Listfinal 
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 


create table #tmpTable 
(xStudent int,xTest int,xPaye int,MarkKoll float,Summark float,tosifM nvarchar(10),level5 smallint,gschkoll int,gclsKoll int,gPayeKoll int,Acp int
)

insert into #tmpTable (xStudent,xtest,xPaye,MarkKoll,Summark,tosifM,level5,gschkoll,gPayeKoll,gclsKoll,acp)
SELECT  distinct   tMarkDoreh.xStudent,tMarkDoreh.Xtest,tYear_Student.XPaye,tMarkDoreh.MarkDoreh,
tMarkDoreh.Summark,dbo.ReturnTosifM5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as TosifM
,dbo.ReturnLevel5(tMarkDoreh.MarkDoreh,tMarkDoreh.xtest,tMarkDoreh.xStudent) as level5,
tMarkDoreh.gKoll,tMarkDoreh.gPaye,tMarkDoreh.gclass,acp
FROM         tStudent INNER JOIN
                      tMarkDoreh ON tStudent.id = tMarkDoreh.xStudent   INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE  (tMarkDoreh.typ = 5) 
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  tMarkDoreh.xtest in(select * from SplitNumber(@Exam)) 
and tYear_Student.shaghe=1
AND (tYear_Student.xYear = @xYear)

---------------محروم دائم-----------
insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,4
FROM         tYear_Student 
WHERE  xYear=@xYear and (tYear_Student.Status = 2) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتي-----------

insert into #tmpTable(xStudent,xtest,xPaye,acp)
SELECT     xStudent,@Exam, xPaye,3
FROM         tYear_Student 
WHERE  xYear=@xYear and (Status = 1) 
and tYear_Student.shaghe=1
and  tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
and  xStudent not in(select xStudent from #tmpTable)

--------------معذرتي-----------
update #tmpTable set acp=3 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=4 and XClass IN (select * from SplitNumber(@Class)))

---------------محروم دائم-----------
update #tmpTable set acp=4 where xStudent in(select xStudent from tYear_Student where xYear=@xYear and Status=2 and XClass IN (select * from SplitNumber(@Class)))



declare @sch nvarchar(100)
declare @ost nvarchar(100)
declare @cty nvarchar(100)

select @sch=sch,@ost=ost,@cty=cty from tParmetr

select #tmpTable.*,tYear_Student.sort,tStudent.FName,tStudent.LName,tStudent.PName,tStudent.Code, 
tStudent.bDate, tStudent.Sh_Sh, tStudent.NumberAsas, tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName, 
tYear_Student.XClass, 
tExam.Name AS Exam,tExam.DateFrom,tExam.DateTo,tClass.Name AS Class ,tPaye.Name AS Paye,
 tYear_Student.hazer2 as hazer3, 
tYear_Student.Ghayeb2 as Ghayeb3,
 tYear_Student.Mariz2  as Mariz3,
 tYear_Student.rokhsat2  as rokhsat3
,   tClass.countDakhele1, tClass.countDakhele2, tClass.countExam1, tClass.countExam2, tClass.countAcp1, tClass.countAcp2, tClass.countNoAcp1, tClass.countNoAcp2, 
                      tClass.countMashrot1, tClass.countMashrot2, tClass.countMazerati1, tClass.countMazerati2, tClass.countAbsent1, tClass.countAbsent2,tClass.Separcheh
,tmpcountDay.countDayTerm1,tmpcountDay.countDayTerm2,tmpcountDay.countDayTerm3,@sch as School,@ost as SchOst,@cty as SchCty ,cast(@xYear as nvarchar) as xYear ,
tYear_Student.gTerm1,tYear_Student.gTerm3
 from  #tmpTable  inner join
tStudent on #tmpTable.xStudent=tStudent.id  INNER JOIN
tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
tClass on tYear_Student.xClass=tClass.id inner join
tPaye on #tmpTable.xPaye=tPaye.id  inner join
tExam on #tmpTable.xTest=tExam.id  LEFT OUTER JOIN
 (SELECT     xMaghta, Term1 as countDayTerm1, Term2 as countDayTerm2 ,isnull(Term1,0)+isnull(Term2,0) as countDayTerm3
  FROM         tYearMaghtaCountDay
   WHERE     (xYear = @xYear)) tmpcountDay ON tPaye.xMaghta = tmpcountDay.xMaghta                  
drop table #tmpTable



GO
update trpt set caption=N'جدول نتايج صنف اول تا نهم' where id=114
GO
INSERT INTO tRpt
                      (id, Caption, Rpt, sp, countExam, type, term)
VALUES     (115, N'جدول نتايج صنف دهم و يازدهم', N'CR_AF_StdKarnameFinal_10_11', N'spRpt_karnamefinal', 1, 2, 3)
GO