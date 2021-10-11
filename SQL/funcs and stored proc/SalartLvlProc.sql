CREATE PROC usp_EmployeesBySalaryLevel(@SalaryLvl NVARCHAR(MAX))
AS
SELECT FirstName,LastName FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLvl 

GO

EXEC usp_EmployeesBySalaryLevel 'high'