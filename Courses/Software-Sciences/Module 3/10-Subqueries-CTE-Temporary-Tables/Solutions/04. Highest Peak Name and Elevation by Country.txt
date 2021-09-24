WITH CTE_HighestPeakByCountry (CountryName, PeakName, Elevation, Mountain) AS (
	   SELECT c.CountryName, p.PeakName, MAX(p.Elevation), m.MountainRange
	     FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc 
	       ON mc.CountryCode = c.CountryCode
	LEFT JOIN Mountains AS m 
	  	   ON m.Id = mc.MountainId
	LEFT JOIN Peaks AS p 
	  	   ON p.MountainId = m.Id
	 GROUP BY c.CountryName, p.PeakName, m.MountainRange)

   SELECT TOP (5)
		  ce.CountryName AS Country, 
		  ISNULL(ct.PeakName, '(no highest peak)') AS [Highest Peak Name],
		  ISNULL(ct.Elevation, 0) AS [Highest Peak Elevation],
		  ISNULL(ct.Mountain, '(no mountain)') AS Mountain
     FROM (
	        SELECT CountryName, MAX(Elevation) AS MaxElevation
              FROM CTE_HighestPeakByCountry
	      GROUP BY CountryName) AS ce
LEFT JOIN CTE_HighestPeakByCountry AS ct
       ON ct.CountryName = ce.CountryName AND ct.Elevation = ce.MaxElevation
 ORDER BY ce.CountryName, ct.PeakName