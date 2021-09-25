   SELECT TOP (5)
   	      c.CountryName,
   	      MAX(p.Elevation) AS HighestPeakElevation,
          MAX(r.[Length]) AS LongestRiverLength
     FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
       ON mc.CountryCode = c.CountryCode
LEFT JOIN Peaks AS p
       ON p.MountainId = mc.MountainId
LEFT JOIN CountriesRivers AS cr
       ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r
       ON r.Id = cr.RiverId
 GROUP BY c.CountryName
 ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName