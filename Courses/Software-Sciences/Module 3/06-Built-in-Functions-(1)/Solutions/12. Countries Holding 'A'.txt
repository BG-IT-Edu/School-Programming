SELECT CountryName, IsoCode
	FROM Countries
	WHERE CountryName LIKE '%A%A%A%'
	ORDER BY IsoCode