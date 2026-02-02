SELECT 
	 	Название 
    ,Столица 
    ,Площадь 
    ,Население 
    ,Континент 
FROM  
 	Страна  WHERE 
	 	Континент IN ( 
	 	 	SELECT 
 	 	 	Континент  	 	FROM  
	 	 	 	Страна  
	 	 	GROUP BY 
 	 	 	Континент  	 	HAVING 
	 	 	 	AVG(Население) > ( 
	 	 	 	 	SELECT  
	 	 	 	 	 	AVG(Население)  
	 	 	 	 	FROM 
	 	 	 	 	 	Страна 
	 	 	 	 	) 
	 	) 	 	 	 	 	
