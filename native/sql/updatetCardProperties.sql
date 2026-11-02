CREATE procedure updatetCardProperties
@heder1 nvarchar(300),
@heder2 nvarchar(300),
@Foter1 nvarchar(300) with encryption
as


if not exists(select heder1 from tCardProperties)
INSERT INTO tCardProperties
                      (heder1, heder2, Foter1 )
          VALUES     (@heder1, @heder2,@Foter1)
else
update tCardProperties set heder1=@heder1,heder2=@heder2,Foter1=@Foter1