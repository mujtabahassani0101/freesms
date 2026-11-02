CREATE procedure dbo.spRpt_ListStdHozehMinMax  with encryption
as
SELECT     tYear_Student.xhozeh, tHozeh.Name AS Hozeh, MIN(tYear_Student.idx) AS minidx, MAX(tYear_Student.idx) AS maxidx, count(tYear_Student.idx) as countidx
FROM         tStudent INNER JOIN
                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN
                      tHozeh ON tYear_Student.xhozeh = tHozeh.id
where tYear_Student.idx is not null  and tYear_Student.xyear in(select xyear from tDefYear) 
GROUP BY tHozeh.Name, tYear_Student.xhozeh
ORDER BY MIN(tYear_Student.idx)