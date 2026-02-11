SELECT  
 	 С.Фамилия FROM 
	 	Студент С 
	 	 	LEFT OUTER JOIN Экзамен Э ON С.Рег_номер = Э.Рег_номер 
WHERE 
	 	Э.Рег_номер IS NULL 
