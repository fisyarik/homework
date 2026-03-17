DECLARE @A INT = RAND() * 5, @C INT = 1 
DECLARE @B INT = @A + RAND() * 5 
PRINT '@A = ' + CAST(@A AS CHAR(1)) + ', @B = ' +  CAST(@B AS CHAR(1)) 
WHILE @A <= @B 
	BEGIN 	 
	 	PRINT REPLICATE(@A, @C) 
	 	SET @A = @A + 1 
	 	SET @C = @C + 1 
END 
