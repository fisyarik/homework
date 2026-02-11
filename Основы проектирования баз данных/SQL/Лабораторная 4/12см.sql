SELECT
    DISTINCT Специализация,
    CASE
        WHEN LEN(Специализация) > 8 THEN N'длинный'
        ELSE N'короткий'
    END AS Длина
FROM Академики
ORDER BY Специализация;