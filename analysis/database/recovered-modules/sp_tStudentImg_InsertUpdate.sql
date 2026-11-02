
CREATE procedure sp_tStudentImg_InsertUpdate
@id bigint,
@img image with encryption
as
if exists(select xStudent from tStudentImg where xStudent=@id)
update tStudentImg set Student_img=@img ,xExportRpt=null where xStudent=@id
else 
insert into tStudentImg(xStudent,Student_img) values(@id,@img)
