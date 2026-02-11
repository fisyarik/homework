SELECT  
	 	Континент 
 	, AVG(CAST(Население AS FLOAT) / Площадь) AS Сред_Плотность FROM  
	 	Страны 
GROUP BY  
	 	Континент 
HAVING  
	 	AVG(CAST(Население AS FLOAT) / Площадь) > 100 
