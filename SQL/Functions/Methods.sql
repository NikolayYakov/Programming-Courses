SELECT FirstName,LastName FROM Employees
WHERE LEFT(FirstName,2) = 'Sa' 
SELECT FirstName,LastName FROM Employees
WHERE LastName LIKE '%ei%' 
SELECT FirstName FROM Employees
WHERE (DepartmentID = 3 OR DepartmentID=10) AND YEAR(HireDate) BETWEEN '1995' AND '2005'
SELECT FirstName,LastName FROM Employees
WHERE JobTitle NOT LIKE '%Engineer%'
SELECT [Name] FROM Towns
WHERE LEN([Name])=5 OR LEN([Name])=6
ORDER BY [Name]
SELECT * FROM Towns
WHERE LEFT([Name],1) != 'R' AND LEFT([Name],1) != 'B' AND LEFT([Name],1) != 'D'
ORDER BY [Name]
SELECT * FROM Towns
WHERE LEFT([Name],1) = 'M' OR LEFT([Name],1) = 'B' OR LEFT([Name],1) = 'K' OR LEFT([Name],1) = 'E'
ORDER BY [Name]
 
SELECT FirstName,LastName FROM Employees
WHERE YEAR(HireDate)>'2000' 
SELECT FirstName, LastName FROM Employees
WHERE LEN(LastName) = 5
 SELECT *
FROM (
       SELECT EmployeeID,
              FirstName,
              LastName,
              Salary,
              DENSE_RANK() over (partition by Salary ORDER BY EmployeeID) AS Rank
       FROM Employees
       WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
       WHERE [Rank] = 2
ORDER BY Salary DESC
