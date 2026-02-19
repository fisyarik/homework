SELECT Континент
FROM Страна
GROUP BY Континент
HAVING MAX(Площадь) / MIN(Площадь) <= 10000
ORDER BY Континент;
