SELECT  
	 	*  
FROM  
	 	Академики 
ORDER BY  
	 	ФИО 
	 	OFFSET 2 ROWS 
	 	FETCH NEXT 8 ROWS ONLY 
