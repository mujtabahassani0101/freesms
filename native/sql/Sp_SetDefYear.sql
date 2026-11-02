Create procedure  dbo.Sp_SetDefYear
@xYear int with encryption
as
declare @id int
if not exists(select id from tExam where xYear=@xYear and term=1)
Begin
	select @id=isnull(max(id),100)+1 from tExam
	INSERT INTO tExam
	                      (id, xYear, NumExam, Name, term)
	VALUES     (@id, @xYear, - 10, N'چهار و نيم ماهه', 1)
End
if not exists(select id from tExam where xYear=@xYear and term=2)
Begin
	select @id=isnull(max(id),100)+1 from tExam
	INSERT INTO tExam
	                      (id, xYear, NumExam, Name, term)
	VALUES     (@id, @xYear, - 9, N'چهار و نيم ماهه دوم', 2)
End
if not exists(select id from tExam where xYear=@xYear and term=3)
Begin
	select @id=isnull(max(id),100)+1 from tExam
	INSERT INTO tExam
	                      (id, xYear, NumExam, Name, term)
	VALUES     (@id, @xYear, - 8, N'نهايي', 3)
End

update tDefYear set xYear=@xYear