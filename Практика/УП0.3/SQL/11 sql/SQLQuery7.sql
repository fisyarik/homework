DECLARE @a INT = RAND() * 1000 
WHILE @a % 3 = 0  
	 	SET @a = @a / 3 
IF @a = 1 
	 	PRINT 'Да' 
ELSE 
	 	PRINT 'Нет' 
