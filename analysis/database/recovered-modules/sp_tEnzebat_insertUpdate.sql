

CREATE Procedure dbo.sp_tEnzebat_insertUpdate
@xStudent int,
@Xtest int,
@Enzebat float,
@comment nvarchar(500)  with encryption
as
if not exists(select xStudent from tEnzebat where xStudent=@xStudent and Xtest=@Xtest)
	INSERT INTO tEnzebat
	                      (xStudent, Xtest, Enzebat,comment)
	VALUES      (@xStudent, @Xtest, @Enzebat,@comment)
else 
	UPDATE    tEnzebat
	SET Enzebat=@Enzebat,comment=@comment,xExportRpt=null
	where xStudent=@xStudent and Xtest=@Xtest 

