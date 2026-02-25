DECLARE @A INT = 10 
WHILE @A < 100 
	BEGIN 	 
	 	IF (@A % 4 = 0) AND (@A % 6 != 0) 
	 	 	PRINT @A 
	 	SET @A = @A + 1 
END 
