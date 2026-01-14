SELECT ROUND(AVG(LEN(Название)), 2) AS СредняяДлинаНазваний
FROM Страны
WHERE Континент = 'Африка';
