CREATE Procedure sp_tMarkDoreh_insertUpdateEnzebat
@xStudent int,
@Xtest int,
@Mark float  with encryption
as
if not exists(select xStudent from tMarkDoreh where xStudent=@xStudent and Xtest=@Xtest and  typ=4)
	INSERT INTO tMarkDoreh
	                      (xStudent, Xtest,typ, MarkDoreh)
	VALUES      (@xStudent, @Xtest,4, @Mark)
else 
	UPDATE    tMarkDoreh
	SET MarkDoreh=@Mark,xExportRpt=null
	where xStudent=@xStudent and Xtest=@Xtest and typ=4