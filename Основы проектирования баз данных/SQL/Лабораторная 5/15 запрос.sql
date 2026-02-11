SELECT  
	 	Континент 
 	,AVG(CAST(Население AS FLOAT) / Площадь) AS Плотность FROM  
	 	Страны 
WHERE 
 	Площадь > 1000000 GROUP BY  
	 	Континент 
HAVING 
	 	AVG(CAST(Население AS FLOAT) / Площадь) > 30 
ORDER BY  
	 	Плотность DESC 
