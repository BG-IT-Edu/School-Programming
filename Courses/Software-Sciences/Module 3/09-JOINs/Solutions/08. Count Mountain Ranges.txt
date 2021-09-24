  SELECT CountryCode,
  	     COUNT(MountainId) AS MountainRanges
    FROM MountainsCountries
   WHERE CountryCode IN ('BG', 'RU', 'US')
GROUP BY CountryCode