SELECT  
	 	ФИО 
 	, CASE MONTH(Дата_рождения)  	 	WHEN 3 THEN N'Весна' 
	 	 	WHEN 4 THEN N'Весна' 
	 	 	WHEN 5 THEN N'Весна' 
	 	 	WHEN 6 THEN N'Лето' 
	 	 	WHEN 7 THEN N'Лето' 
	 	 	WHEN 8 THEN N'Лето' 
	 	 	WHEN 9 THEN N'Осень' 
	 	 	WHEN 10 THEN N'Осень' 
	 	 	WHEN 11 THEN N'Осень' 
	 	 	ELSE N'Зима' 
	 	 	END AS Времени_года 
FROM Академики 
