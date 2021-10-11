SELECT TOP(5) EmployeeID,JobTitle,a.AddressID,a.AddressText FROM Employees e
 LEFT JOIN Addresses a ON a.AddressID=e.AddressID
 ORDER BY AddressID

SELECT TOP(50) FirstName,LastName,t.Name,a.AddressText FROM Employees e
 LEFT JOIN Addresses a ON a.AddressID=e.AddressID
 JOIN Towns t ON a.TownId = t.TownID
 ORDER BY FirstName,LastName

 SELECT EmployeeID, FirstName,LastName,d.Name FROM Employees e
 LEFT JOIN Departments d ON d.DepartmentID=e.DepartmentID
 WHERE d.Name LIKE '%Sales%'
 ORDER BY EmployeeID

 SELECT TOP(5) EmployeeID, FirstName,Salary,d.Name AS DepartmentName FROM Employees e
 JOIN Departments d ON d.DepartmentID=e.DepartmentID
 WHERE Salary>15000
 ORDER BY d.DepartmentID

 SELECT TOP(3) e.EmployeeID,FirstName FROM  Employees e
 LEFT JOIN EmployeesProjects ep ON ep.EmployeeID=e.EmployeeID
 WHERE ep.ProjectID IS NULL
 ORDER BY EmployeeID

 SELECT FirstName,LastName,HireDate,d.Name AS DeptName FROM Employees e
  JOIN Departments d ON d.DepartmentID=e.DepartmentID
  WHERE HireDate>'1.1.1999' AND d.Name IN ('Sales','Finance')
  ORDER BY HireDate

 SELECT TOP(5) e.EmployeeID,FirstName,p.Name AS ProjectName FROM  Employees e
  JOIN EmployeesProjects ep ON ep.EmployeeID=e.EmployeeID
  JOIN Projects p ON ep.ProjectID = p.ProjectID
  WHERE p.EndDate IS NULL
  ORDER BY EmployeeID

 SELECT  e.EmployeeID,FirstName,
 CASE 
    WHEN YEAR(P.StartDate)>='2005' THEN NULL
	ELSE p.Name 
	END AS ProjectName
 FROM  Employees e
  JOIN EmployeesProjects ep ON ep.EmployeeID=e.EmployeeID
  JOIN Projects p ON ep.ProjectID = p.ProjectID
  WHERE  e.EmployeeID = 24
  
  SELECT e.EmployeeID,e.FirstName,e.ManagerID,em.FirstName AS ManagerName FROM Employees e
  JOIN Employees em ON e.ManagerID = em.EmployeeID 
  WHERE e.ManagerID IN (3,7)
  ORDER BY e.EmployeeID

   SELECT TOP(50) e.EmployeeID,e.FirstName+ ' ' + e.LastName AS EmployeeName,em.FirstName+' '+em.LastName AS ManagerName,d.Name AS DepartmentName FROM Employees e
   JOIN Employees em ON e.ManagerID = em.EmployeeID 
   JOIN Departments d ON e.DepartmentID = d.DepartmentID
  ORDER BY e.EmployeeID

 SELECT MIN(avg) AS [MinAverageSalary] FROM
 (SELECT AVG(Salary) as avg
 FROM Employees
 GROUP BY DepartmentID) AS AverageSalary

