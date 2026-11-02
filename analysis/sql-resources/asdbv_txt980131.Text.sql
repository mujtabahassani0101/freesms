--13980131
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFNEFWUUI2QUdnQU5nQlVBRllBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO

CREATE TABLE [dbo].[tPaymentStudent] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[xYear] [int] NULL ,
	[xStudent] [int] NULL ,
	[PaynemtDate] [nvarchar] (10) COLLATE Arabic_CI_AS NULL ,
	[dayOfWeek] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[NamberBel] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[Fee] [int] NULL ,
	[Transport] [int] NULL ,
	[racing] [int] NULL ,
	[Celebration] [int] NULL ,
	[Exam] [int] NULL ,
	[uniform] [int] NULL ,
	[maghnae] [int] NULL ,
	[ketab] [int] NULL ,
	[komakdarsi] [int] NULL ,
	[dakhle] [int] NULL ,
	[other] [int] NULL ,
	[comment] [nvarchar] (500) COLLATE Arabic_CI_AS NULL ,
	[DateInsert] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[DateUpdate] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[xUserInsert] [int] NULL ,
	[xUserUpdate] [int] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tPaymentStudent] ADD 
	CONSTRAINT [PK_tPaymentStudent] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

CREATE Procedure dbo.sp_tPaymentStudent_insertUpdate
@id int,
@xYear int,
@xStudent int,
@PaynemtDate nvarchar(10),
@dayOfWeek nvarchar(20),
@NamberBel nvarchar(50),
@Fee int,
@Transport int,
@racing int,
@Celebration int,
@Exam int,
@uniform int,
@maghnae int,
@ketab int,
@komakdarsi int,
@dakhle int,
@other int,
@comment nvarchar(500),
@Date nvarchar(20),
@xUser int,
@code int output with encryption
as
declare @sumPay int
declare @FeeStd int
select @FeeStd= SumFee from tYear_Student where xStudent=@xStudent and xYear=@xYear
if(@id=0)
  begin 
        if exists(select id from tPaymentStudent where xStudent=@xStudent and xYear=@xYear and PaynemtDate=@PaynemtDate)
          begin
            set @code=-100
            return
          end
       
       
        else
           begin
             
               select @sumPay=isnull(Sum(fee),0) from tPaymentStudent where xStudent=@xStudent and xYear=@xYear
               set @sumPay=isnull(@sumPay,0)+isnull(@Fee,0)
               if(@sumPay>@FeeStd)
                 begin
                   set @code=-200
                   return
                 end
               else 
                 begin
		   INSERT INTO tPaymentStudent
		                      (xYear, xStudent, PaynemtDate,dayOfWeek, NamberBel, Fee, Transport, racing, Celebration,
                                        Exam, uniform, maghnae, ketab, komakdarsi, dakhle, other, comment, DateInsert, xUserInsert)
				VALUES (@xYear, @xStudent, @PaynemtDate, @dayOfWeek, @NamberBel, @Fee, @Transport, @racing, @Celebration,
		                        @Exam, @uniform, @maghnae, @ketab, @komakdarsi, @dakhle, @other, @comment, @Date, @xUser)
                   set @code=@@identity
                 end
           end
  end
else
  begin
  if exists(select id from tPaymentStudent where id<>@id and xStudent=@xStudent and xYear=@xYear and PaynemtDate=@PaynemtDate)
          begin
            set @code=-100
            return
          end
        else
           begin
               select @sumPay = isnull(Sum(fee),0) from tPaymentStudent where xStudent=@xStudent and xYear=@xYear and id<>@id
               set @sumPay = isnull(@sumPay,0)+isnull(@Fee,0)
               if(@sumPay>@FeeStd)
                 begin
                   set @code=-200
                   return
                 end
               else 
                 begin
			UPDATE    tPaymentStudent SET  PaynemtDate =@PaynemtDate , dayOfWeek =@dayOfWeek , NamberBel =@NamberBel , 
			Fee =@Fee , Transport =@Transport , racing =@racing ,Celebration =@Celebration , Exam =@Exam , uniform =@uniform , 
			maghnae =@maghnae , ketab =@ketab , komakdarsi =@komakdarsi , dakhle =@dakhle , other =@other , comment =@comment ,
		        DateUpdate =@Date , xUserUpdate =@xUser    where id=@id
	                set @code=@id
                 end
          end
  end


GO