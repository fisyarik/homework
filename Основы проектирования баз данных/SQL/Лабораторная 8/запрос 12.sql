SELECT 
	 	Название 
    ,Столица 
    ,Площадь 
    ,Население 
    ,Континент 
FROM  
 	Страны  WHERE 
	 	Население = ( 
	 	 	SELECT  
	 	 	 	MAX(Мин_Нас) 
	 	 	FROM  
	 	 	 	( 
	 	 	 	 	SELECT  
	 	 	 	 	 	MIN(Население) AS Мин_Нас 
	 	 	 	 	FROM 
 	 	 	 	 	Страны  	 	 	 	GROUP BY 
	 	 	 	 	 	Континент 
	 	 	 	) A 	 	 
	 	) 
