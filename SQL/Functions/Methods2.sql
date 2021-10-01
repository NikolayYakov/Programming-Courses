SELECT CountryName,IsoCode FROM Countries
WHERE CountryName LIKE '%A%A%A%'
ORDER BY IsoCode
SELECT p.PeakName,r.RiverName, LOWER(p.PeakName+SUBSTRING(r.RiverName,2,LEN(r.RiverName)-1)) AS [Mix] FROM Peaks p
JOIN Rivers r On Right(p.PeakName,1) = LEFT(r.RiverName,1) 
ORDER BY Mix