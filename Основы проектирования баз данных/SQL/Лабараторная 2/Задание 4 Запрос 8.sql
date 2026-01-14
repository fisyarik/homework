SELECT TOP 1 
SUBSTRING(ФИО, 1, CHARINDEX(' ', ФИО + ' ') - 1) AS Фамилия
FROM Академики
ORDER BY Год_присвоения_звания ASC;