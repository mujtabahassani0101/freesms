--13980614
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFZUUJVQUdnQU5BQlVBR3NBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 
CREATE TABLE [dbo].[tCity] (
	[id] [int] NOT NULL ,
	[xOstan] [int] NULL ,
	[Name] [nvarchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tOstan] (
	[id] [int] NOT NULL ,
	[Name] [nvarchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tCity] ADD 
	CONSTRAINT [PK_City] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tOstan] ADD 
	CONSTRAINT [PK_Ostan] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tCity] ADD 
	CONSTRAINT [FK_tCity_tOstan] FOREIGN KEY 
	(
		[xOstan]
	) REFERENCES [dbo].[tOstan] (
		[id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

alter table tstudent add xCity int
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (27, N'dropcity', N'ولسوالي‌ سکونت', 1)
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (28, N'En_Fname', N'نام انگلیسی', 1)
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (29, N'En_Lname', N'نام پدر انگلیسی', 1)
GO
alter table tstudent add En_Fname nvarchar(100),En_Lname nvarchar(100)
GO
alter procedure dbo.sp_tStudent_insertUpdate      
@id int,      
@xYear int,      
@xPaye int ,      
@xClass int ,      
@Code bigint ,      
@FName nvarchar(100),      
@LName nvarchar(100),      
@PName nvarchar(100),      
@Sh_Sh nvarchar(200),      
@bDate nvarchar(10),      
@MobileFather nvarchar(11),      
@MobileMother nvarchar(11),      
@NumberTelegram nvarchar(11),      
@NumberTelegram2 nvarchar(11),      
@Jens smallint,      
@Mazhab smallint,      
@NumberAsas int ,      
@RegDate nvarchar(10),      
@Adress nvarchar (200),      
@ExitDate nvarchar(10),      
@Status smallint,      
      
@shaghe bit,      
@hazer bit,      
@mali bit,      
@dakhle bit,      
@uniform bit,      
@komakdarsi bit,      
@ketab bit,      
@transport bit,      
@robotic bit,      
@maghnae bit,      
    
@Fee1 int,      
@Fee2 int,      
@Fee3 int,      
@Fee4 int,      
@Fee5 int,      
@Fee6 int,      
@Fee7 int,      
@Fee8 int,      
@Fee9 int,      
@SumFee int ,  
@xTakhfif smallint,  
@transport1 int,      
@transport2 int,      
@transport3 int,      
@transport4 int,      
@transport5 int,      
@transport6 int,      
@transport7 int,      
@transport8 int,      
@transport9 int,      
@Sumtransport int,      
@xDriver int,      
  
@xcity int,     
@En_Fname nvarchar (100), 
@En_Lname nvarchar (100),         
@CodeOut int outPut      with encryption
as      
if(@id>0)      
  begin  
        if(@Code is not null)  
          begin     
           if exists(select id from tStudent where id<>@id and Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
          end   
       if(@NumberAsas is not null)  
          begin      
       if exists(select id from tStudent where id<>@id and NumberAsas=@NumberAsas )        
    begin        
      set @CodeOut=-200        
      return        
    end        
          end  
       UPDATE    tStudent      
       SET   Code =@Code, FName =@FName, LName =@LName, PName =@PName, Sh_Sh =@Sh_Sh, bDate=@bDate      
       , MobileFather =@MobileFather, MobileMother =@MobileMother, Jens =@Jens, Mazhab =@Mazhab,      
        NumberAsas =@NumberAsas, RegDate =@RegDate, Adress =@Adress, ExitDate =@ExitDate,       
       NumberTelegram=@NumberTelegram,NumberTelegram2=@NumberTelegram2 ,
       xcity=@xcity ,  En_Fname=@En_Fname, En_Lname=@En_Lname   where id=@id      
            
      UPDATE    tYear_Student      
 SET              xPaye =@xPaye, xClass =@xClass,  Status =@Status, shaghe =@shaghe, hazer =@hazer, mali =@mali,       
                        dakhle =@dakhle, uniform =@uniform, komakdarsi =@komakdarsi, ketab =@ketab,      
                        transport =@transport, robotic =@robotic, maghnae =@maghnae,    
                        Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5,    
    Fee6=@Fee6, Fee7=@Fee7, Fee8=@Fee8, Fee9=@Fee9,SumFee=@SumFee ,xTakhfif=@xTakhfif,    
   transport1=@transport1, transport2=@transport2, transport3=@transport3, transport4=@transport4, transport5=@transport5,    
    transport6=@transport6, transport7=@transport7,transport8=@transport8, transport9=@transport9, Sumtransport=@Sumtransport ,  
   xDriver =@xDriver  
 WHERE     (xYear = @xYear) AND (xStudent = @id)      
      
  end      
else      
  begin      
    if(@Code is not null)  
       begin     
         if exists(select id from tStudent where Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
       end   
    if(@NumberAsas is not null)  
      begin       
        if exists(select id from tStudent where  NumberAsas=@NumberAsas )        
   begin        
     set @CodeOut=-200        
     return        
   end    
      end     
 INSERT INTO tStudent      
                      (Code, FName, LName, PName, Sh_Sh,bDate, MobileFather, MobileMother, NumberTelegram, NumberTelegram2,      
                      Jens, Mazhab, NumberAsas, RegDate, Adress, xcity,  En_Fname, En_Lname)      
 VALUES     (@Code, @FName,@LName,@PName,@Sh_Sh,@bDate,@MobileFather,@MobileMother,@NumberTelegram,@NumberTelegram2,      
                     @Jens,@Mazhab,@NumberAsas,@RegDate,@Adress,@xcity,@En_Fname,@En_Lname)      
       set @id=@@identity      
       set @CodeOut=@id    
       INSERT INTO tYear_Student                            (xYear, xStudent, xPaye, xClass,Status, shaghe, hazer, mali, dakhle, uniform,      
                       komakdarsi, ketab, transport, robotic, maghnae,    
                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,  
                      transport1,transport2,transport3,transport4, transport5,    
                      transport6,transport7,transport8,transport9,Sumtransport,xDriver)      
       VALUES      (@xYear, @id, @xPaye, @xClass,@Status, @shaghe, @hazer, @mali, @dakhle, @uniform,      
                       @komakdarsi, @ketab, @transport, @robotic, @maghnae,    
                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif,   
      @transport1,@transport2,@transport3,@transport4, @transport5,    
                    @transport6,@transport7,@transport8,@transport9,@Sumtransport,@xDriver)      
  end      
      
      
GO
DELETE FROM tRpt
WHERE     (id = 1020)
GO
update tRpt set caption=replace(replace(replace(caption,N'معدل',N'اوسط'),N'کلاس',N'صنف'),N'کارنامه',N'اطلاع نامه')
GO

UPDATE    tRpt
SET              id = 109, term = 1
WHERE     (id = 1019)
GO
alter  PROCEDURE dbo.sp_List_books_RengMark
@Exam varchar(500),
@Class varchar(500) ,
@xYear int with encryption
AS 


CREATE TABLE #tmp (
	[xStudent] [int] NULL ,
	[Xtest] [int] NULL ,
	[typ] [smallint] NULL ,
	[xbook] [int] NULL ,
	[book] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[mark] [float] NULL ,
	[sort] [smallint] NULL ,
        [xPaye] [int] NULL ,
	[xClass] [int] NULL 
)
INSERT INTO #tmp 
                      (xStudent, Xtest, typ, xbook, book, mark, sort,xPaye,xClass) 
SELECT     tMark.xStudent, tMark.Xtest, tMark.typ, tMark.xbook, tBook.Name AS book, ROUND(tMark.Mark, 6) AS mark,
            tBook.sort,tYear_Student.xpaye,tYear_Student.xclass
 FROM    tMark INNER JOIN
                      tBook ON tMark.xbook = tBook.id INNER JOIN
                      tStudent ON tMark.xStudent = tStudent.id INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent 
WHERE   tMark.mark is not null and  (tMark.typ = 1) and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMark.Xtest in(select * from SplitNumber(@Exam)) 

INSERT INTO #tmp 
                      (xStudent, Xtest, typ, xbook, book, mark, sort,xPaye,xClass) 
SELECT     tMarkDoreh.xStudent, tMarkDoreh.Xtest, tMarkDoreh.typ,-5,N'اوسط', ROUND(tMarkDoreh.MarkDoreh, 6) AS mark, 10000,
tYear_Student.xpaye,tYear_Student.xclass
 FROM    tMarkDoreh  INNER JOIN
                      tStudent ON tMarkDoreh.xStudent = tStudent.id  INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent
WHERE   tMarkDoreh.MarkDoreh is not null  and    (tMarkDoreh.typ = 5) 
and tYear_Student.XClass IN (select * from SplitNumber(@Class)) 
AND (tYear_Student.xYear = @xYear)
and tMarkDoreh.Xtest in(select * from SplitNumber(@Exam)) 



SELECT     #tmp.*, tExam.Name AS Exam, tExam.DateFrom AS DateFrom, tExam.DateTo AS DateTo, tExam.NumExam AS NumExam, tPaye.Name AS Paye, 
                      tClass.name AS Class
FROM         #tmp INNER JOIN
                      tExam ON #tmp.Xtest = tExam.id INNER JOIN
                      tPaye ON #tmp.xPaye = tPaye.id INNER JOIN
                      tClass ON #tmp.xClass = tClass.id

drop table #tmp

GO