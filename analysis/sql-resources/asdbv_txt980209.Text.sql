--13980209
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFNEFZUUJVQUdnQU13QlVBREVBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO

CREATE TABLE [dbo].[tRptPayment] (
	[id] [int] NOT NULL ,
	[Caption] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[Rpt] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[sp] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[subReport] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[type] [int] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tRptPayment] ADD 
	CONSTRAINT [PK_tRptPayment] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO
INSERT INTO tRptPayment
                      (id, Caption, Rpt, sp, type)
VALUES     (1, N'جدول پرداخت فیس بر اساس صنف', N'CrRptPayment1', N'sp_RptPayment1', 1)
GO
create procedure dbo.sp_RptPayment1
@Class varchar(500)  ,
@xYear int with encryption
as
SELECT     tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.xStudent, tYear_Student.sort, tStudent.FName, tStudent.LName, tStudent.PName, tClass.answerable, 
                      tClass.name AS Class, tPaye.Name AS Paye, tParmetr.heder1, tParmetr.sch, tStudent.NumberAsas, tStudent.RegDate,cast(tClass.xYear as nvarchar(4)) as xYear,
                      tYear_Student.Sumtransport, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, tYear_Student.transport4, tYear_Student.transport5, 
                      tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, tYear_Student.transport9, tYear_Student.SumFee, tYear_Student.fee1, 
                      tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, tYear_Student.fee7, tYear_Student.fee8,tYear_Student.fee9,
                      isnull(tmpMali.Pay_Fee,0 ) as Pay_Fee,tmpMali.Pay_Transport,tmpMali.Pay_racing,tmpMali.Pay_Celebration,tmpMali.Pay_Exam,tmpMali.Pay_uniform,
                      tmpMali.Pay_maghnae,tmpMali.Pay_ketab,tmpMali.Pay_komakdarsi,tmpMali.Pay_dakhle, tmpMali.Pay_other
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN
                       tPaye ON tYear_Student.xPaye = tPaye.id  left outer join
                      
	                 (SELECT     xStudent, SUM(Fee) AS Pay_Fee, SUM(Transport) AS Pay_Transport, SUM(racing) AS Pay_racing, SUM(Celebration) AS Pay_Celebration,
                          SUM(Exam) AS Pay_Exam, SUM(uniform) AS Pay_uniform,SUM(maghnae) AS Pay_maghnae, SUM(ketab) AS Pay_ketab, SUM(komakdarsi) AS Pay_komakdarsi,
                          SUM(dakhle) AS Pay_dakhle, SUM(other) AS Pay_other FROM  tPaymentStudent
			  WHERE     (xYear = @xYear) and xStudent in(select xstudent from tYear_Student where mali=1 and  xYear = @xYear and xclass in(select * from SplitNumber(@Class)) )
			  GROUP BY xStudent)tmpMali on tYear_Student.xStudent=tmpMali.xStudent

                        CROSS JOIN
                      tParmetr
WHERE     (tYear_Student.mali = 1) AND (tYear_Student.xYear = @xYear)
and tYear_Student.xclass in(select * from SplitNumber(@Class))

GO