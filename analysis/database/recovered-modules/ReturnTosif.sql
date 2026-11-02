CREATE FUNCTION ReturnTosif(@Mark float)
RETURNS nvarchar(50)  with encryption
AS
BEGIN
declare @Tosif nvarchar(50)
if @Mark=20 
set @Mark=19.99
SELECT  @Tosif=  tosif
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark)
return  @Tosif

end


