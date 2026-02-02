SELECT  
	 	   Название 
      ,Столица 
      ,Площадь 
      ,Население 
      ,Континент 
	 	  ,ROUND(CAST(Население AS FLOAT) * 100 /  
	 	  ( 
	 	 	SELECT  
	 	 	 	SUM(Население)  
	 	 	FROM 
	 	 	 	Страна Б 
	 	 	WHERE 
	 	 	 	А.Континент = Б.Континент 
	 	  ), 3) AS Процент 
FROM  
	 	Страна А 
ORDER BY 
	 	Процент DESC
