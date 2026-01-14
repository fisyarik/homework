SELECT  
 ROUND(AVG(CAST(Население AS FLOAT)), 2) AS Среднее_население FROM  
	 	Страны 
WHERE 
	 	Континент != 'Европа' 
