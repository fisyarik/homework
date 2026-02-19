SELECT COUNT(*) AS КоличествоСтран
FROM Страна
WHERE Название LIKE '%ан'
  AND Название NOT LIKE '%стан';