--13980124
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFNEFWUUI2QUdnQU5RQlVBR3NBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
ALTER TABLE dbo.tYear_Student ADD
	xTakhfif smallint NULL,SumFee int NULL

GO
CREATE TABLE [dbo].[tTakhfif] (
	[id] [int] NOT NULL IDENTITY (1, 1) ,
	[name] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[comment] [nvarchar] (200) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tTakhfif] ADD 
	CONSTRAINT [PK_tTakhfif] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
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
@Sh_Sh nvarchar(10),    
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
 
@CodeOut int outPut   with encryption  
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
       NumberTelegram=@NumberTelegram,NumberTelegram2=@NumberTelegram2 where id=@id    
          
      UPDATE    tYear_Student    
 SET              xPaye =@xPaye, xClass =@xClass,  Status =@Status, shaghe =@shaghe, hazer =@hazer, mali =@mali,     
                        dakhle =@dakhle, uniform =@uniform, komakdarsi =@komakdarsi, ketab =@ketab,    
                        transport =@transport, robotic =@robotic, maghnae =@maghnae,  
                        Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5,  
    Fee6=@Fee6, Fee7=@Fee7, Fee8=@Fee8, Fee9=@Fee9,SumFee=@SumFee ,xTakhfif=@xTakhfif,  
   transport1=@transport1, transport2=@transport2, transport3=@transport3,  
                        transport4=@transport4, transport5=@transport5,  
    transport6=@transport6, transport7=@transport7,   
                        transport8=@transport8, transport9=@transport9, Sumtransport=@Sumtransport  
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
                      Jens, Mazhab, NumberAsas, RegDate, Adress)    
 VALUES     (@Code, @FName,@LName,@PName,@Sh_Sh,@bDate,@MobileFather,@MobileMother,@NumberTelegram,@NumberTelegram2,    
                     @Jens,@Mazhab,@NumberAsas,@RegDate,@Adress)    
       set @id=@@identity    
       set @CodeOut=@id  
       INSERT INTO tYear_Student    
                      (xYear, xStudent, xPaye, xClass,Status, shaghe, hazer, mali, dakhle, uniform,    
                       komakdarsi, ketab, transport, robotic, maghnae,  
                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,
                      transport1,transport2,transport3,transport4, transport5,  
                      transport6,transport7,transport8,transport9,Sumtransport)    
       VALUES      (@xYear, @id, @xPaye, @xClass,@Status, @shaghe, @hazer, @mali, @dakhle, @uniform,    
                       @komakdarsi, @ketab, @transport, @robotic, @maghnae,  
                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif, 
      @transport1,@transport2,@transport3,@transport4, @transport5,  
                    @transport6,@transport7,@transport8,@transport9,@Sumtransport)    
  end    
    
    
    
  
  


GO
CREATE TABLE [dbo].[tItemSabtenamEnable](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[lable] [nvarchar](50) NULL,
	[Enable] [bit] NULL CONSTRAINT [DF_tItemSabtenamEnable_Enable]  DEFAULT (0))
GO
ALTER TABLE dbo.tItemSabtenamEnable ADD CONSTRAINT
	PK_tItemSabtenamEnable PRIMARY KEY CLUSTERED 
	(
	id
	) ON [PRIMARY]
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (1, N'txtNamP', N'ولدیت', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (2, N'txtNumberTelegram', N'نمبرتلگرام', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (3, N'txtMobileFather', N'تلفن پدر', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (4, N'txtMobileMother', N'تلفن مادر', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (5, N'txtbDate', N'تاریخ تولد', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (6, N'txtSh_sh', N'نمبرتذکره', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (7, N'txtNumberAsas', N'نمبر اساس', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (8, N'dropJens', N'جنیست', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (9, N'dropMazhab', N'دین / مذهب', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (10, N'dropStatus', N'وضعیت', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (11, N'txtRegDate', N'تاریخ شمولیت', 1)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (12, N'txtCode', N'کد متعلم', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (13, N'txtAdress', N'آدرس', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (14, N'checkdakhle', N'داخله', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (15, N'checkuniform', N'یونیفورم', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (16, N'checkkomakdarsi', N'کمک درسی', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (17, N'checkketab', N'کتاب', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (18, N'checktransport', N'ترانسپورت', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (19, N'checkrobotic', N'رباتیک', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (20, N'checkmaghnae', N'مقنعه', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (21, N'checkshaghe', N'شقه', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (22, N'checkhazer', N'حاضر در صنف(رسمی و موقت)', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (23, N'checkmali', N'لیست مالی', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (24, N'comboTakhfif', N'تخفیف', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (25, N'pic', N'عکس شاگرد', 0)
GO
INSERT [dbo].[tItemSabtenamEnable] ([id], [name], [lable], [Enable]) VALUES (26, N'txtExitDate', N'تاریخ خروج', 0)
GO