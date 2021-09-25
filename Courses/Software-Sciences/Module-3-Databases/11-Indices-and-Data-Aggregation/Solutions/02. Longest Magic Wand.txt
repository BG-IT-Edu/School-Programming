SELECT TOP(1) MagicWandSize AS LongestMagicWand
	FROM WizzardDeposits
GROUP BY MagicWandSize
ORDER BY MagicWandSize DESC