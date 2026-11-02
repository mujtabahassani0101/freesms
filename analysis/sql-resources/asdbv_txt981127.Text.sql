--13981127
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCb0FFNEFWUUI2QUdnQU5RQlVBRzRBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO
CREATE procedure dbo.sp_tYear_Student_Insert
@xYear	int,
@xStudent int,
@xPaye	int	,
@xClass	int,
@xTakhfif smallint,
@Fee1 int,
@transport1 int,
@shaghe	bit,
@hazer	bit,
@mali	bit,
@dakhle	bit,
@uniform	bit,
@komakdarsi	bit,
@ketab	bit,
@transport	bit,
@robotic	bit,
@maghnae	bit with encryption
as 
declare	
@Sumtransport	int,
@SumFee	int

set @Sumtransport=@transport1*9
set @SumFee=@Fee1*9


if not exists(select id from tYear_Student where xStudent=@xStudent and xYear=@xYear)
INSERT INTO [tYear_Student]
           ([xYear]
           ,[xStudent]
           ,[xPaye]
           ,[xClass]
           ,[Status]
           ,[shaghe]
           ,[hazer]
           ,[mali]
           ,[dakhle]
           ,[uniform]
           ,[komakdarsi]
           ,[ketab]
           ,[transport]
           ,[robotic]
           ,[maghnae]
           ,[Sumtransport]
           ,[transport1]
           ,[transport2]
           ,[transport3]
           ,[transport4]
           ,[transport5]
           ,[transport6]
           ,[transport7]
           ,[transport8]
           ,[transport9]
           ,[fee1]
           ,[fee2]
           ,[fee3]
           ,[fee4]
           ,[fee5]
           ,[fee6]
           ,[fee7]
           ,[fee8]
           ,[fee9]
           ,[xTakhfif]
           ,[SumFee])
values
	   (@xYear
           ,@xStudent
           ,@xPaye
           ,@xClass
           ,1
           ,@shaghe
           ,@hazer
           ,@mali
           ,@dakhle
           ,@uniform
           ,@komakdarsi
           ,@ketab
           ,@transport
           ,@robotic
           ,@maghnae
           ,@Sumtransport
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@transport1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@fee1
           ,@xTakhfif
           ,@SumFee)

GO