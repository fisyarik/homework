SELECT *
FROM Страна
WHERE
    Континент = 'Африка'
    AND EXISTS (
        SELECT 1
        FROM Страна
        WHERE
            Континент = 'Африка'
            AND Площадь > 2000000
    );