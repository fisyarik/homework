SELECT
    LEN(Название) AS КоличествоБукв,
    COUNT(*) AS КоличествоСтран
FROM Страны
GROUP BY LEN(Название)
ORDER BY КоличествоБукв DESC;