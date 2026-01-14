SELECT  
	 	LEFT(Название, 1) AS Первая_буква 
 	, COUNT(Название) AS Количество_Стран FROM  
	 	Страны 
GROUP BY 
 	LEFT(Название, 1) ORDER BY  
	 	Первая_буква 
