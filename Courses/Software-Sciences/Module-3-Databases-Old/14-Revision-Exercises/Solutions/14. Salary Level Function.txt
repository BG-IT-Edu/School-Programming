CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(MAX)
AS
BEGIN
DECLARE @Level VARCHAR(MAX);
	IF (@salary < 30000)
	SET @Level = 'Low'
	ELSE IF(@salary BETWEEN 30000 AND 50000)
	SET @Level = 'Average'
	ELSE
	SET @Level = 'High'
	RETURN @Level
END