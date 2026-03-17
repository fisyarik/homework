CREATE PROC Пример5 
 	@Буква AS CHAR(1),  	@Количество AS INT OUTPUT 
AS 
BEGIN 
	 	SELECT  
	 	 	@Количество = COUNT(*) 
	 	FROM 
	 	 	Страны 
	 	WHERE  
	 	 	CHARINDEX(@Буква, Название) > 0 
END 
 
DECLARE @К AS INT 
DECLARE @Б AS CHAR(1) 
SET @Б = 'у' 
EXECUTE Пример5 @Б, @К OUTPUT SELECT  
	 	@К AS [Количество стран] 
