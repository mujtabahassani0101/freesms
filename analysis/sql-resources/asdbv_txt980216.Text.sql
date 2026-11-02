--13980216
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFNEFZUUJVQUdnQU5BQlVBRzBBWXdCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO

CREATE TABLE [dbo].[tParmetrBalance] (
	[heder1] [nvarchar] (1000) COLLATE Arabic_CI_AS NULL ,
	[heder2] [nvarchar] (1000) COLLATE Arabic_CI_AS NULL ,
	[Foter1] [nvarchar] (1000) COLLATE Arabic_CI_AS NULL ,
	[Foter2] [nvarchar] (1000) COLLATE Arabic_CI_AS NULL ,
	balance int,
) ON [PRIMARY]
GO
if not exists(select balance from tParmetrBalance)
INSERT INTO tParmetrBalance
                      (heder1, heder2, Foter1, Foter2, balance)
VALUES     (N'خواهشمند است بقایای فیس',N'تحویل نموده و ما را در برنامه ریزی بهتر برای آینده فرزندتان یازی نمایید.',N'تذکر : در صورت تأخیر در پرداخت مبلغ متذکره طبق صلاحدید مکتب عمل خواهد شد.',N'با تشکر
اداره لیسه عالی دین و دانش',500)
GO
INSERT INTO tRptPayment
                      (id, Caption, Rpt, sp, type)
VALUES     (5, N'گزارش وضعیت فیس و ترانسپورت بر اساس کلاس', N'CrRptSumPaymentGroupByClass', N'sp_RptSumPaymentGroupByClass', 1)
GO
INSERT INTO tRptPayment
                      (id, Caption, Rpt, sp, type)
VALUES     (6, N'گزارش کلی وضعیت فیس و ترانسپورت', N'CrRptSumPaymentKoll', N'sp_RptSumPaymentkoll', 1)
GO

CREATE procedure dbo.sp_RptSumPaymentGroupByClass
@Class varchar(500)  ,
@xYear int  with encryption
as
select tmpkoll.*,  tClass.name AS Class, tParmetr.heder1, tParmetr.sch,tClass.xPaye,cast(tClass.xYear as varchar(4)) as xYear   from
(select xClass,
sum(SumFee) as SumFee,
sum(Sumtransport) as SumTransport,
sum(Pay_Fee) as Pay_Fee,
sum(Pay_Transport) as Pay_Transport,
sum(fee1) as fee1,
sum(fee2) as fee2,
sum(fee3) as fee3,
sum(fee4) as fee4,
sum(fee5) as fee5,
sum(fee6) as fee6,
sum(fee7) as fee7,
sum(fee8) as fee8,
sum(fee9) as fee9,
sum(Pay_fee1) as Pay_fee1,
sum(Pay_fee2) as Pay_fee2,
sum(Pay_fee3) as Pay_fee3,
sum(Pay_fee4) as Pay_fee4,
sum(Pay_fee5) as Pay_fee5,
sum(Pay_fee6) as Pay_fee6,
sum(Pay_fee7) as Pay_fee7,
sum(Pay_fee8) as Pay_fee8,
sum(Pay_fee9) as Pay_fee9,
sum(transport1) as transport1,
sum(transport2) as transport2,
sum(transport3) as transport3,
sum(transport4) as transport4,
sum(transport5) as transport5,
sum(transport6) as transport6,
sum(transport7) as transport7,
sum(transport8) as transport8,
sum(transport9) as transport9,
sum(Pay_transport1) as Pay_transport1,
sum(Pay_transport2) as Pay_transport2,
sum(Pay_transport3) as Pay_transport3,
sum(Pay_transport4) as Pay_transport4,
sum(Pay_transport5) as Pay_transport5,
sum(Pay_transport6) as Pay_transport6,
sum(Pay_transport7) as Pay_transport7,
sum(Pay_transport8) as Pay_transport8,
sum(Pay_transport9) as Pay_transport9

from
(SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent,
 tYear_Student.Sumtransport, tYear_Student.SumFee, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, tYear_Student.transport4, tYear_Student.transport5, 
                      tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, tYear_Student.transport9, tYear_Student.fee1, 
                      tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, tYear_Student.fee7, tYear_Student.fee8,tYear_Student.fee9,
                      isnull(tmpMali.Pay_Fee,0 ) as Pay_Fee,  isnull(tmpMali.Pay_Transport,0) as Pay_Transport ,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0) then fee1 
                           else isnull(tmpMali.Pay_Fee,0 ) end  as Pay_fee1,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0) then fee2 
                           when isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0)<0 then 0 
                           else isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0) end  as Pay_fee2,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0) then fee3 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)) end  as Pay_fee3,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0) then fee4 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)) end  as Pay_fee4,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)   then fee5
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)) end  as Pay_fee5,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0) then fee6   
                           when  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)) end  as Pay_fee6,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)   then fee7
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)) end  as Pay_fee7,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                            +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0) then fee8 
                          when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0))<0 then 0
                          else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)) end  as Pay_fee8,
                       case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                             +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)+isnull(tYear_Student.fee9,0)  then fee9
                            when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) end  as Pay_fee9,

		       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0) then transport1 
                           else isnull(tmpMali.Pay_transport,0 ) end  as Pay_transport1,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0) then transport2 
                           when isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0)<0 then 0 
                           else isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0) end  as Pay_transport2,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0) then transport3 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)) end  as Pay_transport3,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0) then transport4 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)) end  as Pay_transport4,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)   then transport5
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)) end  as Pay_transport5,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0) then transport6   
                           when  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)) end  as Pay_transport6,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)   then transport7
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)) end  as Pay_transport7,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                            +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0) then transport8 
                          when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0))<0 then 0
                          else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)) end  as Pay_transport8,
                       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                             +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)+isnull(tYear_Student.transport9,0)  then transport9
                            when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) end  as Pay_transport9

                    
FROM      tYear_Student   left outer join
                      
	                 (SELECT     xStudent, SUM(Fee) AS Pay_Fee, SUM(Transport) AS Pay_Transport FROM  tPaymentStudent
			  WHERE     (xYear = @xYear) and xStudent in(select xstudent from tYear_Student where mali=1 and  xYear = @xYear and xclass in(select * from SplitNumber(@Class)) )
			  GROUP BY xStudent)tmpMali on tYear_Student.xStudent=tmpMali.xStudent
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class)))tmpPay
group by xClass)tmpkoll inner join tclass on tmpkoll.xclass=tclass.id  CROSS JOIN
tParmetr







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE procedure dbo.sp_RptSumPaymentkoll
@Class varchar(500)  ,
@xYear int  with encryption
as
select tmpkoll.*,  tParmetr.sch,cast(@xYear as varchar(4)) as xYear ,1 as xclass  from
(select sum(SumFee) as SumFee,
sum(Sumtransport) as SumTransport,
sum(Pay_Fee) as Pay_Fee,
sum(Pay_Transport) as Pay_Transport,
sum(fee1) as fee1,
sum(fee2) as fee2,
sum(fee3) as fee3,
sum(fee4) as fee4,
sum(fee5) as fee5,
sum(fee6) as fee6,
sum(fee7) as fee7,
sum(fee8) as fee8,
sum(fee9) as fee9,
sum(Pay_fee1) as Pay_fee1,
sum(Pay_fee2) as Pay_fee2,
sum(Pay_fee3) as Pay_fee3,
sum(Pay_fee4) as Pay_fee4,
sum(Pay_fee5) as Pay_fee5,
sum(Pay_fee6) as Pay_fee6,
sum(Pay_fee7) as Pay_fee7,
sum(Pay_fee8) as Pay_fee8,
sum(Pay_fee9) as Pay_fee9,
sum(transport1) as transport1,
sum(transport2) as transport2,
sum(transport3) as transport3,
sum(transport4) as transport4,
sum(transport5) as transport5,
sum(transport6) as transport6,
sum(transport7) as transport7,
sum(transport8) as transport8,
sum(transport9) as transport9,
sum(Pay_transport1) as Pay_transport1,
sum(Pay_transport2) as Pay_transport2,
sum(Pay_transport3) as Pay_transport3,
sum(Pay_transport4) as Pay_transport4,
sum(Pay_transport5) as Pay_transport5,
sum(Pay_transport6) as Pay_transport6,
sum(Pay_transport7) as Pay_transport7,
sum(Pay_transport8) as Pay_transport8,
sum(Pay_transport9) as Pay_transport9

from
(SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent,
 tYear_Student.Sumtransport, tYear_Student.SumFee, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, tYear_Student.transport4, tYear_Student.transport5, 
                      tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, tYear_Student.transport9, tYear_Student.fee1, 
                      tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, tYear_Student.fee7, tYear_Student.fee8,tYear_Student.fee9,
                      isnull(tmpMali.Pay_Fee,0 ) as Pay_Fee,  isnull(tmpMali.Pay_Transport,0) as Pay_Transport ,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0) then fee1 
                           else isnull(tmpMali.Pay_Fee,0 ) end  as Pay_fee1,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0) then fee2 
                           when isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0)<0 then 0 
                           else isnull(tmpMali.Pay_Fee,0 )-isnull(tYear_Student.fee1,0) end  as Pay_fee2,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0) then fee3 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)) end  as Pay_fee3,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0) then fee4 
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)) end  as Pay_fee4,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)   then fee5
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0))<0 then 0
                           else isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)) end  as Pay_fee5,
		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0) then fee6   
                           when  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)) end  as Pay_fee6,
 		      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                            +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)   then fee7
                           when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0))<0 then 0
                           else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)
                                                                  +isnull(tYear_Student.fee4,0)+isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)) end  as Pay_fee7,
                      case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                            +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0) then fee8 
                          when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0))<0 then 0
                          else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                 +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)) end  as Pay_fee8,
                       case when isnull(tmpMali.Pay_Fee,0 )>= isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                             +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)+isnull(tYear_Student.fee9,0)  then fee9
                            when isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_Fee,0 )-(isnull(tYear_Student.fee1,0)+isnull(tYear_Student.fee2,0)+isnull(tYear_Student.fee3,0)+isnull(tYear_Student.fee4,0)
                                                                  +isnull(tYear_Student.fee5,0)+isnull(tYear_Student.fee6,0)+isnull(tYear_Student.fee7,0)+isnull(tYear_Student.fee8,0)) end  as Pay_fee9,

		       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0) then transport1 
                           else isnull(tmpMali.Pay_transport,0 ) end  as Pay_transport1,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0) then transport2 
                           when isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0)<0 then 0 
                           else isnull(tmpMali.Pay_transport,0 )-isnull(tYear_Student.transport1,0) end  as Pay_transport2,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0) then transport3 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)) end  as Pay_transport3,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0) then transport4 
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)) end  as Pay_transport4,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)   then transport5
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0))<0 then 0
                           else isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)) end  as Pay_transport5,
		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0) then transport6   
                           when  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)) end  as Pay_transport6,
 		      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                            +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)   then transport7
                           when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0))<0 then 0
                           else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)
                                                                  +isnull(tYear_Student.transport4,0)+isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)) end  as Pay_transport7,
                      case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                            +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0) then transport8 
                          when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0))<0 then 0
                          else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                 +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)) end  as Pay_transport8,
                       case when isnull(tmpMali.Pay_transport,0 )>= isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                             +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)+isnull(tYear_Student.transport9,0)  then transport9
                            when isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) <0 then 0
                       else  isnull(tmpMali.Pay_transport,0 )-(isnull(tYear_Student.transport1,0)+isnull(tYear_Student.transport2,0)+isnull(tYear_Student.transport3,0)+isnull(tYear_Student.transport4,0)
                                                                  +isnull(tYear_Student.transport5,0)+isnull(tYear_Student.transport6,0)+isnull(tYear_Student.transport7,0)+isnull(tYear_Student.transport8,0)) end  as Pay_transport9

                    
FROM      tYear_Student   left outer join
                      
	                 (SELECT     xStudent, SUM(Fee) AS Pay_Fee, SUM(Transport) AS Pay_Transport FROM  tPaymentStudent
			  WHERE     (xYear = @xYear) and xStudent in(select xstudent from tYear_Student where mali=1 and  xYear = @xYear )
			  GROUP BY xStudent)tmpMali on tYear_Student.xStudent=tmpMali.xStudent
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear) and tYear_Student.xClass is not null)tmpPay
)tmpkoll CROSS JOIN
tParmetr

GO