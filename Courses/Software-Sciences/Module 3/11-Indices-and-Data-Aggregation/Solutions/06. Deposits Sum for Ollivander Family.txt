SELECT DepositGroup, SUM(DepositAmount) as TotalSum
	FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
HAVING MagicWandCreator = 'Ollivander family'