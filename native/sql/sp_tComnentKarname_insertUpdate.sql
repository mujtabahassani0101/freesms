CREATE Procedure dbo.sp_tComnentKarname_insertUpdate
@xStudent int,
@Xtest int,
@typ int,
@xbook int,
@comment nvarchar(500) with encryption
as
if not exists(select id from tComnentKarname where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook and typ=@typ)
	INSERT INTO tComnentKarname
	                      (xStudent, Xtest,typ, xbook,comment)
	VALUES      (@xStudent, @Xtest,@typ, @xbook,@comment)
else 
	UPDATE    tComnentKarname
	SET  comment=@comment
	where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook and typ=@typ