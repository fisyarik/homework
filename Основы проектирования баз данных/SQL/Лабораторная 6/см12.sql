SELECT
    С.Фамилия
FROM Студент С
LEFT OUTER JOIN Экзамен Э
    ON С.Рег_номер = Э.Рег_номер
    AND Э.Дата = '2024-05-20'
WHERE Э.Рег_номер IS NULL;