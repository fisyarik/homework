SELECT  
	 	Континент 	 
FROM  
	 	Страны 
GROUP BY  
	 	Континент 
HAVING MAX(Население) <= 1000 * MIN(Население)
