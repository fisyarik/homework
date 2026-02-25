DECLARE @maxp FLOAT, @minp FLOAT, @diff FLOAT 
SELECT  
	 	@maxp = MAX(Баллы),  
 	@minp = MIN(Баллы) FROM  
	 	Ученик  
SET @diff = @maxp - @minp 
PRINT @diff 
