SELECT ROUND(AVG(LEN(Название)), 2) AS СредняяДлинаНазваний
FROM Страна
WHERE Континент = 'Африка';
