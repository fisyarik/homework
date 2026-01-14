SELECT  
	 	COUNT(*) AS Количество 
FROM  
	 	Страны 
WHERE 
	 	LEFT(Название, 1) = 'С' 
