SELECT SUM([data].Diff) AS SumDifference
	FROM (SELECT wd.DepositAmount - (SELECT w.DepositAmount
		FROM WizzardDeposits w
		WHERE w.Id = wd.id + 1) AS Diff
	FROM WizzardDeposits wd) AS [data]