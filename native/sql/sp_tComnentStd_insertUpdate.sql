CREATE Procedure dbo.sp_tComnentStd_insertUpdate
@id int,
@xYear int,
@xStudent int,
@dayOfWeek nvarchar(20),
@subject nvarchar(200),
@comment nvarchar(1000),
@Date nvarchar(10),
@Time nvarchar(10),
@xUser int with encryption
as
if(@id=0)
  begin 

		   INSERT INTO tComnentStd
		                      (xYear, xStudent, DateInsert,TimeInsert,dayOfWeek, subject, comment, xUserInsert)
				VALUES (@xYear, @xStudent, @Date,@Time, @dayOfWeek, @subject, @comment, @xUser)
                 end
  else
  begin
                
			UPDATE    tComnentStd SET  subject =@subject, comment =@comment ,
		        DateUpdate =@Date+'-'+@Time, xUserUpdate =@xUser    where id=@id
                
         
  end