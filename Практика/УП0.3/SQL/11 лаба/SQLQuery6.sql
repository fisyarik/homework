DECLARE @a INT = RAND() * 100 
	IF @a % 3 = 0 	 
 	PRINT CAST(@a AS VARCHAR(3)) + ' делится на 3' ELSE 
	 	PRINT CAST(@a AS VARCHAR(3)) + ' не делится на 3'
