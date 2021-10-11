CREATE PROC usp_GetEmployeesFromTown  (@townName NVARCHAR(MAX))
AS
SELECT e.FirstName,e.LastName FROM  Towns t
JOIN Addresses a ON t.TownID = a.TownID 
JOIN Employees e ON e.AddressID = a.AddressID
WHERE Name = @townName

GO
EXEC usp_GetEmployeesFromTown 'Sofia'