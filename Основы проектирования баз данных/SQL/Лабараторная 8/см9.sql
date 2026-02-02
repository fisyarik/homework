SELECT *
FROM Страны
WHERE
    Континент = 'Африка'
    AND EXISTS (
        SELECT 1
        FROM Страны
        WHERE
            Континент = 'Африка'
            AND Площадь > 2000000
    );