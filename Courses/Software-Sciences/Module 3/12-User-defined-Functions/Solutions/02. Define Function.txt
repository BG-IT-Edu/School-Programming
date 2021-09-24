CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
DECLARE @LettersCount INT
SET @LettersCount = LEN(@word)
DECLARE @i INT
SET @i = 1

WHILE(@i <= @LettersCount)
	BEGIN
		IF(CHARINDEX(SUBSTRING(@word,@i,1),@setOfLetters) = 0)
		RETURN 0
		ELSE
		SET @i += 1
	END
RETURN 1
END