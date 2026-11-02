
CREATE procedure updatetTelegramConfigTestMobil
@testmobil nvarchar(11),
@heder nvarchar(200),
@foter nvarchar(200) with encryption
as


if not exists(select testmobil from tTelegramConfig)
INSERT INTO tTelegramConfig
                      (testmobil,heder, foter)
          VALUES     (@testmobil,@heder, @foter)
else
update tTelegramConfig set testmobil=@testmobil,heder=@heder,foter= @foter

