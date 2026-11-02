CREATE FUNCTION dbo.ReturnLevel5(@Mark float,@xExam int,@xStudent int)
RETURNS smallint  with encryption
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

 if (@term=1 or @term=3)
   begin
	  declare @acp smallint
	  select @acp =acp from tMarkDoreh where xStudent=@xStudent and xtest=@xExam
	  if(@acp=1)
	   SELECT  @Lev=  lev
	  FROM         tTosif
	  WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
	 
	  else 
	   set @Lev=5
  end
 
else
   begin
	  SELECT  @Lev=  lev
	  FROM         tTosif
	  WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
   end


return  @Lev
end