SELECT MAX(MagicWandSize) AS  LongestMagicWand FROM 
(SELECT MAX(MagicWandSize) AS MagicWandSize  FROM WizzardDeposits
GROUP BY Id) AS MagicWandSize
 
 SELECT TOP(2) DepositGroup   FROM WizzardDeposits
GROUP BY DepositGroup  
ORDER BY AVG(MagicWandSize)

 
 SELECT DepositGroup, SUM(DepositAmount) AS TotalSum   FROM WizzardDeposits
GROUP BY DepositGroup

 SELECT DepositGroup, SUM(DepositAmount) AS TotalSum   FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup  

  SELECT DepositGroup, SUM(DepositAmount) AS TotalSum   FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup  
HAVING  SUM(DepositAmount)<150000
ORDER BY SUM(DepositAmount) DESC
 
 SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge) FROM WizzardDeposits
 GROUP BY DepositGroup,MagicWandCreator
  
 SELECT SUBSTRING(FirstName,1,1) AS FirstLetter FROM WizzardDeposits
 WHERE DepositGroup = 'Troll Chest'
 GROUP BY SUBSTRING(FirstName,1,1)
 ORDER BY FirstLetter 

 SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest) AS AverageInterest FROM WizzardDeposits
 WHERE DepositStartDate>'1985-01-01'
 GROUP BY DepositGroup,IsDepositExpired
 ORDER BY DepositGroup DESC, IsDepositExpired
 
 
 SELECT * FROM WizzardDeposits