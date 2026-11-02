
CREATE FUNCTION dbo.ReturnStatusJoinTelegram(@xstudent int, @sentTo int)
RETURNS nvarchar(50) with encryption
AS
BEGIN
	declare @Status nvarchar(50)
	declare @mobil nvarchar(11)
	if(@sentTo=1)
	 select @mobil=MobileFather from tstudent where id=@xstudent
	else if(@sentTo=2)
	 select @mobil=MobileMother from tstudent where id=@xstudent
	if exists( select id from tTelegramId where tTelegramId.Mobile=  cast( @mobil as bigint))
	  set @Status =N'هست'
	return @Status
end

