DECLARE @a INT = RAND() * 100, @b INT = RAND() * 100 
IF @a > @b  
	 	PRINT '@a = ' + CAST(@a AS VARCHAR(3)) 
ELSE 
	 	PRINT '@b = ' + CAST(@b AS VARCHAR(3)) 
