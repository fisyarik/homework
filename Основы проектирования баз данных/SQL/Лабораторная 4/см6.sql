SELECT DISTINCT
    Специализация,
    REVERSE(Специализация) AS Специализация_обратно
FROM Академики
ORDER BY Специализация;