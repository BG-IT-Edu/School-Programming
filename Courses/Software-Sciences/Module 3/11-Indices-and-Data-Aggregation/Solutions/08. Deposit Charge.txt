SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge) as MinDepositCharge
	FROM WizzardDeposits
	GROUP BY DepositGroup,MagicWandCreator
ORDER BY MagicWandCreator