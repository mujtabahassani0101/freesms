CREATE FUNCTION dbo.ReturnTosifM(@Mark float,@xExam int)
RETURNS nvarchar(10) with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @Tosif nvarchar(10)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @Tosif=  tosifm
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @Tosif

end