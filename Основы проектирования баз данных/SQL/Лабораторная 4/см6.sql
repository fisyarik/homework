SELECT DISTINCT
    Специализация,
    REVERSE(Специализация) AS Специализация_обратно
FROM Академик
ORDER BY Специализация;