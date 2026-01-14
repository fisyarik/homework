SELECT *
FROM Академики
WHERE Год_присвоения_звания IN (
    SELECT DISTINCT TOP 5 Год_присвоения_звания
    FROM Академики
    ORDER BY Год_присвоения_звания ASC
)
ORDER BY Год_присвоения_звания ASC, ФИО ASC;