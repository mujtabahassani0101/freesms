CREATE Procedure dbo.sp_tPaymentStudent_insertFromXls
@xYear int,
@xStudent int,
@PaynemtDate nvarchar(10),
@dayOfWeek nvarchar(20),
@Fee int,
@Exam int,
@uniform int,
@dakhle int,
@Date nvarchar(20),
@xUser int with encryption
as
            
 INSERT INTO tPaymentStudent
      (xYear, xStudent, PaynemtDate,dayOfWeek,  Fee,  Exam, uniform, dakhle,DateInsert, xUserInsert)
VALUES (@xYear, @xStudent, @PaynemtDate, @dayOfWeek, @Fee,  @Exam, @uniform,@dakhle, @Date, @xUser)