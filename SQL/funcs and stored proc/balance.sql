 CREATE PROC usp_GetHoldersWithBalanceHigherThan(@salary DECIMAL(18,4))
 AS
 SELECT ah.FirstName,ah.LastName FROM Accounts a
 JOIN AccountHolders ah ON a.AccountHolderId=ah.Id
 GROUP BY FirstName,LastName
 HAVING  SUM(a.Balance) > @salary
 ORDER BY FirstName,LastName
 GO
 EXEC usp_GetHoldersWithBalanceHigherThan 1

 SELECT * FROM Accounts