alter procedure dbo.sp_RptPaymentBalance1
@Class varchar(500)  ,
@xYear int,
@Fasl int,
@Balance int  with encryption
as
update tYear_Student set notShowBalance=0 where notShowBalance is null



select tmpPay.*,(AmountMostPayTransPort+AmountMostPayFee)-StdPay as Balance,
AmountMostPayTransPort-Pay_Transport as Balance_Transport,
AmountMostPayFee-Pay_Fee as Balance_Fee,

@Fasl as Fasl
from
(SELECT    isnull(tYear_Student.notShowBalance,0) as notShowBalance, tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas,
                      case @Fasl when 1 then  isnull(tYear_Student.transport1,0)+ isnull(tYear_Student.transport2,0)+ isnull(tYear_Student.transport3,0)
                                           

                                 when 2 then isnull(tYear_Student.transport1,0)+ isnull(tYear_Student.transport2,0)+ isnull(tYear_Student.transport3,0)+
                                             isnull(tYear_Student.transport4,0)+ isnull(tYear_Student.transport5,0)+ isnull(tYear_Student.transport6,0)
					  

                                 when 3 then isnull(tYear_Student.transport1,0)+ isnull(tYear_Student.transport2,0)+ isnull(tYear_Student.transport3,0)+
                                             isnull(tYear_Student.transport4,0)+ isnull(tYear_Student.transport5,0)+ isnull(tYear_Student.transport6,0)+
					     isnull(tYear_Student.transport7,0)+ isnull(tYear_Student.transport8,0)+ isnull(tYear_Student.transport9,0)
					   
end  as AmountMostPayTransPort,

                     case @Fasl when 1 then isnull(tYear_Student.fee1,0)+ isnull(tYear_Student.fee2,0)+ isnull(tYear_Student.fee3,0) 

                                 when 2 then isnull(tYear_Student.fee1,0)+ isnull(tYear_Student.fee2,0)+ isnull(tYear_Student.fee3,0)+
                                             isnull(tYear_Student.fee4,0)+ isnull(tYear_Student.fee5,0)+ isnull(tYear_Student.fee6,0)

                                 when 3 then isnull(tYear_Student.fee1,0)+ isnull(tYear_Student.fee2,0)+ isnull(tYear_Student.fee3,0)+
                                             isnull(tYear_Student.fee4,0)+ isnull(tYear_Student.fee5,0)+ isnull(tYear_Student.fee6,0)+
					     isnull(tYear_Student.fee7,0)+ isnull(tYear_Student.fee8,0)+ isnull(tYear_Student.fee9,0)
end  as AmountMostPayFee,

                      isnull(tmpMali.Pay_Fee,0 ) + isnull(tmpMali.Pay_Transport,0) as StdPay,  isnull(tmpMali.Pay_Fee,0 ) as Pay_Fee, isnull(tmpMali.Pay_Transport,0) as Pay_Transport
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                       tPaye ON tYear_Student.xPaye = tPaye.id  left outer join
                      
	                 (SELECT     xStudent, SUM(Fee) AS Pay_Fee, SUM(Transport) AS Pay_Transport  from  tPaymentStudent
			  WHERE     (xYear = @xYear) and xStudent in(select xstudent from tYear_Student where mali=1 and  xYear = @xYear and xclass in(select * from SplitNumber(@Class)) )
			  GROUP BY xStudent)tmpMali on tYear_Student.xStudent=tmpMali.xStudent

                        CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class)))tmpPay
where (AmountMostPayTransPort+AmountMostPayFee)-StdPay>=@Balance