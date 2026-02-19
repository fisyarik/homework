SELECT Название
FROM Страна
WHERE (Название LIKE 'А%' OR
       Название LIKE 'В%' OR
       Название LIKE 'Г%')
  AND Название NOT LIKE 'Б%';
