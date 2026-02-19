SELECT 
    Континент,
    COUNT(*) AS КоличествоСтран
FROM Страна
WHERE Население > 100000000
GROUP BY Континент
ORDER BY КоличествоСтран ASC;