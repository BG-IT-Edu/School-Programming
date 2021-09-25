  SELECT mc.CountryCode,
  	     m.MountainRange,
  	     p.PeakName,
  	     p.Elevation
    FROM MountainsCountries AS mc
    JOIN Mountains AS m
      ON m.Id = mc.MountainId
    JOIN Peaks AS p
      ON p.MountainId = mc.MountainId
   WHERE mc.CountryCode = 'BG'
     AND p.Elevation > 2835
ORDER BY p.Elevation DESC