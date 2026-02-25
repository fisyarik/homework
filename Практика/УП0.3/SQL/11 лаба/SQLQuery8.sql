DECLARE @a INT = RAND() * 1000, @b INT = RAND() * 1000 
PRINT '@a = ' + CAST(@a AS VARCHAR(4)) 
PRINT '@b = ' + CAST(@b AS VARCHAR(4)) 
 
WHILE @a != @b 
BEGIN 
	 	IF @a > @b 
 	 	SET @a = @a - @b  	ELSE 
	 	 	SET @b = @b - @a 
END 
PRINT 'мнд = ' + CAST(@a AS VARCHAR(4))
