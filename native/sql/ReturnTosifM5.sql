alter FUNCTION dbo.ReturnTosifM5(@Mark float,@xExam int,@xStudent int)
RETURNS nvarchar(10) with encryption
AS
BEGIN
declare @term smallint
declare @xYear smallint
select @term=term,@xYear=xYear from tExam where id=@xExam

declare @Tosif nvarchar(10)
if @Mark=40 and @term=1 
  set @Mark=39.9999
else if @Mark=100 and @term=3 
  set @Mark=99.9999
else if @Mark=100 and @term=0 
  set @Mark=99.9999

 if (@term=1 or @term=3)
   begin
	  declare @acp smallint
            if @term=1 
	      select @acp =acp1 from tYear_Student where xStudent=@xStudent and xYear=@xYear
            else if @term=3 
	      select @acp =acp3 from tYear_Student where xStudent=@xStudent and xYear=@xYear


	  if(@acp=1)
           SELECT  @Tosif=  tosifm
	    FROM         tTosif
	    WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
	  else if (@acp=0 or @acp=2)
          
            SELECT  @Tosif=  tosifm
	    FROM         tTosif
	    WHERE     lev=5 and term=@term

         else set @Tosif=''
 
  end
 
else
   begin
	SELECT  @Tosif=  tosifm
	FROM         tTosif
	WHERE     (fromMark <= @Mark) AND (toMark > @Mark) and term=@term
   end
return  @Tosif

end