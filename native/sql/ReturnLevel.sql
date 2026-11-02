CREATE FUNCTION dbo.ReturnLevel(@Mark float,@xExam int)
RETURNS smallint with encryption
AS
BEGIN
declare @term smallint
select @term=term from tExam where id=@xExam
declare @Lev smallint
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

SELECT  @Lev=  lev
FROM         tTosif
WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
return  @Lev
end