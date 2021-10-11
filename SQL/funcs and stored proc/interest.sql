CREATE FUNCTION ufn_CalculateFutureValue(@sum DECIMAL(18,4),@rate FLOAT,@years INT)
RETURNS DECIMAL(18,4)
BEGIN
SET @sum = @sum*(POWER(1+@rate,@years)) 
RETURN @sum
END
SELECT dbo.ufn_CalculateFutureValue(1000,0.1,5)