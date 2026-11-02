CREATE VIEW dbo.vPass
AS
SELECT     TOP 100 PERCENT dbo.tStudent.id, dbo.tStudent.FName, dbo.tStudent.LName, dbo.tStudent.PName, dbo.tStudent.pass, dbo.tStudent.pass2, 
                      dbo.tStudent.xPaye
FROM         dbo.tStudent INNER JOIN
                      dbo.tPaye ON dbo.tStudent.xPaye = dbo.tPaye.id
ORDER BY dbo.tStudent.xPaye
