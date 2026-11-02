--14020427
ALTER TABLE tParmetr ADD
	ShowGread bit NULL
GO
update tParmetr set ShowGread=1
GO
alter procedure updatetParmetr  
@heder1 nvarchar(300),  
@heder2 nvarchar(300),  
@Foter1 nvarchar(300),  
@Foter2 nvarchar(300),  
@sch nvarchar(300),  
@showBartar bit,
@ShowGread bit  with encryption  
as  
  
  
if not exists(select heder1 from tParmetr)  
INSERT INTO tParmetr  
                      (heder1, heder2, Foter1, Foter2, sch,showBartar,ShowGread)  
          VALUES     (@heder1, @heder2,@Foter1, @Foter2,@sch,@showBartar,@ShowGread)  
else  
update tParmetr set heder1=@heder1,heder2=@heder2,  
Foter1=@Foter1,Foter2=@Foter2,sch=@sch ,showBartar=@showBartar, ShowGread=@ShowGread, 
xExportRpt=null  

GO
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFVZ0JrQURBQU1RQndBRThBU0FCa0FFOEFVUUI2QUdnQU5RQlVBRzRBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO