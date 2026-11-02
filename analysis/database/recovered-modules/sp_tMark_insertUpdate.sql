
CREATE Procedure sp_tMark_insertUpdate
@xStudent int,
@Xtest int,
@xbook int,
@CountAb smallint,
@M1 float,
@M2 float,
@M3 float,
@M4 float,
@M5 float,
@M6 float,
@M7 float,
@M8 float,
@M9 float,
@M10    float,
@Mark float  with encryption

as
if not exists(select id from tmark where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook)
	INSERT INTO tMark
	                      (xStudent, Xtest,typ, xbook,CountAb, M1, M2, M3, M4, M5, M6, M7, M8, M9, M10, Mark)
	VALUES      (@xStudent, @Xtest,1, @xbook,@CountAb, @M1, @M2, @M3, @M4, @M5, @M6, @M7, @M8, @M9, @M10, @Mark)
else 
	UPDATE    tMark
	SET CountAb=@CountAb,    M1 =@M1 , M2 =@M2 , M3 =@M3 , M4 =@M4 , M5 =@M5 ,
	       M6 =@M6 , M7 =@M7 , M8 =@M8 , M9 =@M9 , M10 =@M10 , Mark =@Mark
	where xStudent=@xStudent and Xtest=@Xtest and  xbook=@xbook