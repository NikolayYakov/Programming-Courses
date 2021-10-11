SELECT DepartmentID,SUM(Salary) AS TotalSalary  FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

SELECT DepartmentID, MIN(Salary) AS MinimumSalary FROM Employees 
WHERE DepartmentID IN (2,5,7) AND HireDate> '2000-01-01'
GROUP BY  DepartmentID

SELECT * INTO Over30000 FROM Employees as e
WHERE Salary>30000

DELETE FROM Over30000
Where ManagerID = 42

UPDATE Over30000
SET Salary+=5000
WHERE DepartmentID = 1

SELECT DepartmentID,AVG(Salary) AS AverageSalary FROM Over30000
GROUP BY DepartmentID

SELECT DepartmentID, MAX(Salary) AS MaxSalary FROM  Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

SELECT COUNT(Salary) FROM Employees
WHERE ManagerID IS NULL