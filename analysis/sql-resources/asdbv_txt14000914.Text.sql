--14000914
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.tMark
	DROP CONSTRAINT FK_tMark_tExam
GO
ALTER TABLE dbo.tExam SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO

CREATE TABLE [dbo].[tMark14000914](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[xStudent] [int] NOT NULL,
	[Xtest] [int] NOT NULL,
	[typ] [smallint] NOT NULL,
	[xbook] [int] NOT NULL,
	[CountAb] [smallint] NULL,
	[M1] [float] NULL,
	[M2] [float] NULL,
	[M3] [float] NULL,
	[M4] [float] NULL,
	[M5] [float] NULL,
	[M6] [float] NULL,
	[M7] [float] NULL,
	[M8] [float] NULL,
	[M9] [float] NULL,
	[M10] [float] NULL,
	[Mark] [float] NULL,
	[gClass] [smallint] NULL,
	[gKoll] [smallint] NULL,
	[xExportRpt] [int] NULL,

)
GO
insert  into [tMark14000914]
([xStudent]
           ,[Xtest]
           ,[typ]
           ,[xbook]
           ,[CountAb]
           ,[M1]
           ,[M2]
           ,[M3]
           ,[M4]
           ,[M5]
           ,[M6]
           ,[M7]
           ,[M8]
           ,[M9]
           ,[M10]
           ,[Mark]
           ,[gClass]
           ,[gKoll]
           ,[xExportRpt])
select 
[xStudent]
           ,[Xtest]
           ,[typ]
           ,[xbook]
           ,[CountAb]
           ,[M1]
           ,[M2]
           ,[M3]
           ,[M4]
           ,[M5]
           ,[M6]
           ,[M7]
           ,[M8]
           ,[M9]
           ,[M10]
           ,[Mark]
           ,[gClass]
           ,[gKoll]
           ,[xExportRpt] from tmark 

GO
Drop table tmark
GO
CREATE TABLE dbo.tMark
	(
	id int NOT NULL IDENTITY (1, 1),
	xStudent int NOT NULL,
	Xtest int NOT NULL,
	typ smallint NOT NULL,
	xbook int NOT NULL,
	CountAb smallint NULL,
	M1 float(53) NULL,
	M2 float(53) NULL,
	M3 float(53) NULL,
	M4 float(53) NULL,
	M5 float(53) NULL,
	M6 float(53) NULL,
	M7 float(53) NULL,
	M8 float(53) NULL,
	M9 float(53) NULL,
	M10 float(53) NULL,
	Mark float(53) NULL,
	gClass smallint NULL,
	gKoll smallint NULL,
	xExportRpt int NULL
	)  ON [PRIMARY]
GO

GO

INSERT INTO [dbo].[tMark]
           ([xStudent]
           ,[Xtest]
           ,[typ]
           ,[xbook]
           ,[CountAb]
           ,[M1]
           ,[M2]
           ,[M3]
           ,[M4]
           ,[M5]
           ,[M6]
           ,[M7]
           ,[M8]
           ,[M9]
           ,[M10]
           ,[Mark]
           ,[gClass]
           ,[gKoll]
           ,[xExportRpt])
select 
[xStudent]
           ,[Xtest]
           ,[typ]
           ,[xbook]
           ,[CountAb]
           ,[M1]
           ,[M2]
           ,[M3]
           ,[M4]
           ,[M5]
           ,[M6]
           ,[M7]
           ,[M8]
           ,[M9]
           ,[M10]
           ,[Mark]
           ,[gClass]
           ,[gKoll]
           ,[xExportRpt] from [tMark14000914] 
GO

DROP TABLE dbo.tmark14000914
GO
ALTER TABLE dbo.tMark ADD CONSTRAINT
	PK_tMark PRIMARY KEY CLUSTERED 
	(
	xStudent,
	Xtest,
	typ,
	xbook
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.tMark WITH NOCHECK ADD CONSTRAINT
	FK_tMark_tExam FOREIGN KEY
	(
	Xtest
	) REFERENCES dbo.tExam
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
GO
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE UNIQUE NONCLUSTERED INDEX IX_tMark ON dbo.tMark
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.tMark SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
GO
UPDATE [dbo].[tVer]
   SET [ver] =N'VkFCV0FGSUFVZ0JrQURBQU1RQkVBRThBU0FCa0FGQUFWUUI2QUdnQU5BQlVBR3NBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='

GO