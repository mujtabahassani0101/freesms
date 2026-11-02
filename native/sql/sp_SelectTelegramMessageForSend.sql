CREATE Procedure dbo.sp_SelectTelegramMessageForSend with encryption
as
SELECT    tTelegramMessage.id,  tTelegramId.telegranID, tTelegramMessage.Message
FROM         tStudent INNER JOIN
                      tTelegramMessage ON tStudent.id = tTelegramMessage.xStudent
 inner join tTelegramId on  cast( MobileFather as bigint)=tTelegramId.Mobile
WHERE  sentTo=1 and   (tTelegramMessage.isSend = 0) 
union
SELECT    tTelegramMessage.id, tTelegramId.telegranID,  tTelegramMessage.Message
FROM         tStudent INNER JOIN
                      tTelegramMessage ON tStudent.id = tTelegramMessage.xStudent
 inner join tTelegramId on  cast( MobileMother as bigint)=tTelegramId.Mobile
WHERE    sentTo=2 and    (tTelegramMessage.isSend = 0)
union
SELECT    tTelegramMessage.id,  tTelegramId.telegranID, tTelegramMessage.Message
FROM         tTelegramConfig INNER JOIN
                      tTelegramId ON tTelegramConfig.testmobil = tTelegramId.Mobile CROSS JOIN
                      tTelegramMessage
WHERE     (tTelegramMessage.isSend = 0) AND (tTelegramMessage.xStudent = 0)