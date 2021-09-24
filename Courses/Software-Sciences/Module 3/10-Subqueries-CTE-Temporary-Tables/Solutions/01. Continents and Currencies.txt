WITH CTE_Continents_Currencies (ContinentCode, CurrencyCode, CurrencyUsage) AS (
	  SELECT ContinentCode, 
	  	     CurrencyCode, 
			 COUNT(CurrencyCode) AS CurrencyUsage
	    FROM Countries
	GROUP BY ContinentCode, CurrencyCode
	  HAVING COUNT(CurrencyCode) > 1
)

SELECT cc.ContinentCode, 
	   cte.CurrencyCode, 
	   cc.MaxUsage AS CurrencyUsage
  FROM (
		  SELECT ContinentCode, 
			     MAX(CurrencyUsage) AS MaxUsage
		    FROM CTE_Continents_Currencies
		GROUP BY ContinentCode
		) AS cc
  JOIN CTE_Continents_Currencies AS cte
    ON cte.ContinentCode = cc.ContinentCode AND cte.CurrencyUsage = cc.MaxUsage