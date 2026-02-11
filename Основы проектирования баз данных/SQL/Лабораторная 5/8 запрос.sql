SELECT  
	 	Континент 
, COUNT(Название) AS Количество_Стран FROM  
	 	Страны 
GROUP BY 
	 	Континент 
ORDER BY  
Количество_Стран DESC 