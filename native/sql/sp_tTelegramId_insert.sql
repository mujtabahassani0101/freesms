CREATE Procedure dbo.sp_tTelegramId_insert
@telegranID nvarchar(20),
@Mobile bigint,
@code int output,
@IsInStd int output,
@StdName  nvarchar(500) output with encryption
as
set @IsInStd=2
if not exists(select id from tTelegramId where Mobile=@Mobile)
	begin
		INSERT INTO tTelegramId
		                      (Mobile, telegranID)
		VALUES      (@Mobile, @telegranID)
	        set @code=1
	end
else
	begin
               update tTelegramId set telegranID=@telegranID where Mobile=@Mobile
	  set @code=2
	end

declare @NameStd nvarchar(500)
set @NameStd=''
declare @Name nvarchar(100)
declare @countStd int
select @countStd =count(*) from tstudent where   cast( MobileFather as bigint)=@Mobile
if @countStd>0
    begin
	set @IsInStd=1
               DECLARE std CURSOR FOR
			SELECT N'پدر '+fname+ ' '+lname FROM tstudent where  cast( MobileFather as bigint)=@Mobile
		OPEN STD
		FETCH NEXT FROM STD INTO
			@Name
		WHILE @@FETCH_STATUS = 0
			BEGIN
		  
                                if (@NameStd<>'')
                                 set  @NameStd=@NameStd+ N' و '
                               
			         set  @NameStd=@NameStd+@Name
		             	FETCH NEXT FROM std INTO
				@Name
			END
		CLOSE STD
		DEALLOCATE STD
               
    end

select @countStd =count(*) from tstudent where   cast( MobileMother as bigint)=@Mobile
if @countStd>0
    begin
	set @IsInStd=1
               DECLARE std CURSOR FOR
			SELECT N'مادر '+fname+ ' '+lname FROM tstudent where  cast( MobileMother as bigint)=@Mobile
		OPEN STD
		FETCH NEXT FROM STD INTO
			@Name
		WHILE @@FETCH_STATUS = 0
			BEGIN
		  
                                if (@NameStd<>'')
                                 set  @NameStd=@NameStd+ N' و '
                               
			         set  @NameStd=@NameStd+@Name
		             	FETCH NEXT FROM std INTO
				@Name
			END
		CLOSE STD
		DEALLOCATE STD
               
    end

   set @StdName=@NameStd