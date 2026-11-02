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