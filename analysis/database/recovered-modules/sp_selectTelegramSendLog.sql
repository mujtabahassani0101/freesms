


CREATE procedure dbo.sp_selectTelegramSendLog
@datefrom nvarchar(10),
@dateto nvarchar(10) with encryption
as


SELECT     tTelegramMessage.id, tTelegramMessage.typMsg,tTelegramTypeMessage.name as TypeMessage, tTelegramMessage.xStudent, tTelegramMessage.sentTo, tTelegramMessage.dateTosend, 
                      tTelegramMessage.TimeTosend, tTelegramMessage.dateSend, tTelegramMessage.TimeSend, tTelegramMessage.isSend, 
                      tStudent.FName, tStudent.LName, tStudent.MobileFather, tStudent.MobileMother, tClass.name AS Class, tPaye.Name AS Paye
                      , case  when tTelegramMessage.sentTo=1  and tTelegramMessage.xStudent>0 then N'پدر ' + tStudent.FName+N' '+ tStudent.LName
                           when tTelegramMessage.sentTo= 2 and tTelegramMessage.xStudent>0 then N'مادر ' + tStudent.FName+N' '+ tStudent.LName
                          when tTelegramMessage.xStudent= 0 then N'ارسال تستي'  end as std
                      
                    
FROM         tTelegramMessage  left OUTER JOIN 
                      tStudent ON   tTelegramMessage.xStudent=tStudent.id left OUTER JOIN 
                      tPaye  ON  tStudent.xPaye=  tPaye.id  left OUTER JOIN 
                      tClass ON tStudent.xClass = tClass.id INNER JOIN
                     tTelegramTypeMessage on tTelegramMessage.typMsg=tTelegramTypeMessage.id
where tTelegramMessage.dateTosend>=@datefrom and  tTelegramMessage.dateTosend<=@dateto

