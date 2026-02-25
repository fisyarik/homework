DECLARE @D INT = 31, @M INT = 12 
SET @D = CASE 
	 	 	 	WHEN @M IN (1, 3, 5, 7, 8, 10, 12) AND @D = 31 THEN 1 
	 	 	 	WHEN @M  IN (4, 6, 9, 11) AND @D = 30 THEN 1 
	 	 	 	WHEN @M = 2 AND @D = 29 THEN 1 
	 	 	 	ELSE @D + 1 
	 	 	END 
SET @M = CASE 
	 	 	 	WHEN @D = 1 AND @M = 12 THEN 1 
	 	 	 	WHEN @D = 1 AND @M < 12 THEN @M + 1 	 	 	 
	 	 	 	ELSE @M 
	 	 	END 
PRINT CAST(@D AS VARCHAR(2)) + '/' + CAST(@M AS VARCHAR(2))
