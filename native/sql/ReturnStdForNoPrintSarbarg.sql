create FUNCTION [dbo].[ReturnStdForNoPrintSarbarg](@formType smallint,@xYear int)  
RETURNS @RtnValue table 
(
	Data bigint
)
with encryption 
 AS  
BEGIN 
 if(@formType=1 or @formType=5)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg1=0
 else if(@formType=2)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg2=0
 else if(@formType=3)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg3=0
 else if(@formType=4)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg4=0
 else if(@formType=6)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg6=0
 else if(@formType=7)
   Insert Into @RtnValue (data) select xstudent from tYear_Student where xYear=@xYear and ShowSarbarg7=0
	
 Return
END