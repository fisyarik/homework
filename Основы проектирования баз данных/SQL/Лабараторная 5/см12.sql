SELECT
    Континент
FROM Страны
WHERE Население > 1000000
GROUP BY Континент
HAVING ROUND(AVG(Население / Площадь), 2) > 30
ORDER BY Континент;
