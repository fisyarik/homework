: SELECT  
	 	С.Фамилия 
FROM  
	 	Студент С 
	 	 	INNER JOIN Экзамен Э ON С.Рег_номер = Э.Рег_номер 
GROUP BY  
	 	С.Фамилия 
 