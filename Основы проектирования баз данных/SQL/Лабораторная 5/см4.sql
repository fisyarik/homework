SELECT COUNT(*) AS КоличествоСтран
FROM Страны
WHERE Название LIKE '%ан'
  AND Название NOT LIKE '%стан';