CREATE PROC Пример6  
	 	@Конт AS VARCHAR(50) = 'Европа' 
AS 
BEGIN 
	 	SELECT TOP 3 
	 	 	Название 
	 	 	,Столица 
	 	,Площадь 
	 	,Население 
	 	,Континент 
FROM 
	 	Страны 
WHERE  
	 	 	Континент = @Конт 
	 	ORDER BY  
	 	 	Площадь 
END 
EXECUTE Пример6 DEFAULT 
