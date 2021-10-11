CREATE PROC usp_GetTownsStartingWith (@startText NVARCHAR(MAX))

AS
SELECT  Name FROM  Towns
WHERE Name LIKE @startText+'%'
GO

EXEC usp_GetTownsStartingWith 'ba'