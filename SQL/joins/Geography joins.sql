SELECT c.CountryCode,m.MountainRange,p.PeakName,p.Elevation FROM  Countries c
JOIN MountainsCountries mc ON c.CountryCode=mc.CountryCode
JOIN Mountains m ON m.Id=mc.MountainId
JOIN Peaks p ON p.MountainId = m.Id
WHERE c.CountryCode = 'BG' AND Elevation >2835
ORDER BY Elevation DESC
 
SELECT mc.CountryCode, COUNT(mc.MountainId) AS MountainRanges FROM MountainsCountries mc
 WHERE mc.CountryCode IN ('BG','RU','US')
 GROUP BY mc.CountryCode
 
 SELECT TOP(5) c.CountryName, r.RiverName FROM CountriesRivers cr
 JOIN Rivers r ON  r.Id = cr.RiverId
 RIGHT JOIN Countries c ON cr.CountryCode = c.CountryCode
 WHERE c.ContinentCode = 'AF'
 ORDER BY c.CountryName

 SELECT   COUNT(c.CountryName)  FROM MountainsCountries mc
 RIGHT JOIN Countries c ON mc.CountryCode = c.CountryCode
 LEFT JOIN Mountains m ON mc.MountainId = m.Id
 WHERE m.MountainRange IS NULL 

 SELECT TOP(5) c.CountryName,MAX(p.Elevation) AS HighestPeakElevation,MAX(r.Length) AS LongestRiverLength FROM Countries c
  JOIN MountainsCountries mc ON mc.CountryCode=c.CountryCode
 LEFT JOIN Mountains m ON  m.Id=mc.MountainId
 LEFT JOIN CountriesRivers cr ON cr.CountryCode = c.CountryCode
 LEFT JOIN Rivers r ON cr.RiverId = r.Id
 LEFT JOIN Peaks p ON p.MountainId = m.Id
 GROUP BY c.CountryName
 ORDER BY HighestPeakElevation DESC,LongestRiverLength DESC,c.CountryName