DECLARE @licey FLOAT, @gimn FLOAT, @diff FLOAT 
SET @licey = ( 
	 	 	SELECT  
	 	 	 	MAX(Баллы)  
	 	 	FROM  
 	 	 	Ученик   	 	WHERE  
	 	 	 	Школа = 'Лицей' 
	 	 	)  
SET @gimn  = ( 
	 	 	SELECT  
 	 	 	MAX(Баллы)   	 	FROM  
 	 	 	Ученик   	 	WHERE  
	 	 	 	Школа = 'Гимназия' 
	 	 	)  
SET @diff = ABS(@licey - @gimn) 
PRINT @diff 
