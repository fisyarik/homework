DECLARE @L INT, @M INT, @N CHAR(13) 
SET @N = 'Нижневартовск' 
SET @L = LEN(@N) 
SET @M = @L 
WHILE @L > 0 
BEGIN 
 	PRINT LEFT(@N, @L) + SPACE(2 * (@M - @L)) + RIGHT(REVERSE(@N), @L)  	SET @L = @L - 1 
END 
SET @L = 2 
WHILE @L <= @M 
BEGIN 
	 	PRINT LEFT(@N, @L) + SPACE(2 * (@M - @L)) + RIGHT(REVERSE(@N), @L) 
	 	SET @L = @L + 1 
END 
