CREATE procedure dbo.sp_tYearMaghtaCountDay_insertUpdate
@id int,
@xYear int,
@xMaghta int,
@Term1 int ,
@Term2 int  with encryption
as
if(@id>0)
  begin 
     
       UPDATE    tYearMaghtaCountDay
       SET         Term1 =@Term1, Term2 =@Term2 where id=@id
  end
else
  begin
      
     INSERT INTO tYearMaghtaCountDay
                      (xYear, xMaghta,Term1, Term2)
     VALUES     (@xYear, @xMaghta, @Term1, @Term2)
  end