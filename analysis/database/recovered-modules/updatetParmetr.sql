CREATE procedure updatetParmetr
@heder1 nvarchar(300),
@heder2 nvarchar(300),
@Foter1 nvarchar(300),
@Foter2 nvarchar(300),
@sch nvarchar(300)  with encryption
as


if not exists(select heder1 from tParmetr)
INSERT INTO tParmetr
                      (heder1, heder2, Foter1, Foter2, sch)
          VALUES     (@heder1, @heder2,@Foter1, @Foter2,@sch)
else
update tParmetr set heder1=@heder1,heder2=@heder2,Foter1=@Foter1,Foter2=@Foter2,sch=@sch