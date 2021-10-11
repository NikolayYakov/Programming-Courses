CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS NVARCHAR(MAX)
AS
BEGIN
IF(@salary<30000)
	RETURN 'Low'
ELSE IF(@salary BETWEEN 30000 AND 50000)
	RETURN 'Average'
ELSE IF(@salary>50000)
	RETURN 'High' 
RETURN NULL
END
SELECT Salary,dbo.ufn_GetSalaryLevel(Salary) FROM Employees
 