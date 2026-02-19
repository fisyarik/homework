SELECT
    LEN(Название) AS КоличествоБукв,
    COUNT(*) AS КоличествоСтран
FROM Страна
GROUP BY LEN(Название)
ORDER BY КоличествоБукв DESC;