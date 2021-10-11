CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(MAX), @word NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
 DECLARE @count INT = 1
 DECLARE @isThere BIT = 1
 WHILE @count<=LEN(@word)
 BEGIN
     DECLARE @letter NVARCHAR(1) = SUBSTRING(@word,@count,1)
     IF(CHARINDEX(@letter,@setOfLetters)=0)
	 BEGIN
		SET @isThere = 0
		BREAK
	 END
	 SET @count+=1
 END
 RETURN @isThere
END

SELECT dbo.ufn_IsWordComprised('Bor','Rob')