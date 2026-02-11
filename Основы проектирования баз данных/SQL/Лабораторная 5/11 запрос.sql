SELECT  
	 	Континент 
	 	, CASE  
	 	WHEN Континент IN ('Европа', 'Азия') THEN FLOOR(SUM(Население) * 1.2)
 	 	 
	 	WHEN Континент IN ('Северная Америка', 'Африка') THEN FLOOR(SUM(Насе-
ление) * 1.5) 
	 	ELSE FLOOR(SUM(Население) * 1.7) 
 	END AS Суммарное_Население FROM  
	 	Страны 
GROUP BY  
	 	Континент 
