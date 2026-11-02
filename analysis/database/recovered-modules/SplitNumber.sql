--select * from fnSplit('1,22,333,444,,5555,666')
CREATE FUNCTION dbo.SplitNumber
(
	@RowData varchar(8000) 
	
)  
RETURNS @RtnValue table 
(
	Data bigint
)   with encryption
AS  
BEGIN 
        Declare @SplitOn nvarchar(5)
        set @SplitOn=N','
	Declare @Cnt int
	Set @Cnt = 1

	While (Charindex(@SplitOn,@RowData)>0)
	Begin
		Insert Into @RtnValue (data)
		Select 
			Data = ltrim(rtrim(Substring(@RowData,1,Charindex(@SplitOn,@RowData)-1)))

		Set @RowData = Substring(@RowData,Charindex(@SplitOn,@RowData)+1,len(@RowData))
		Set @Cnt = @Cnt + 1
	End
	
	Insert Into @RtnValue (data)
	Select Data = ltrim(rtrim(@RowData))

	Return
END








