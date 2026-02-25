DECLARE @N INT = RAND() * 10, @M INT = 1, @S INT = 0 
WHILE @M <= 2 * @N - 1 
BEGIN 
	 	SET @S = @S + @M 
	 	PRINT @S 
	 	SET @M = @M + 2 
END 
