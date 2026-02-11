SELECT  Название 
      ,Столица 
      ,Площадь 
      ,Население 
      ,Континент 
	 	  ,ROUND(CAST(Население AS FLOAT) * 100 /  
	 	  ( 
	 	 	SELECT  
	 	 	 	SUM(Население)  
	 	 	FROM
	 	 	 	Страна 
	 	  ), 3) AS Процент 
FROM  
	 	Страна 
ORDER BY 
	 	Процент DESC 
