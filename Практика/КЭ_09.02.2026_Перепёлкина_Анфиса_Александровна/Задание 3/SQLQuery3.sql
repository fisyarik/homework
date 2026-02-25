USE shop_db;
GO

-- 1. Удаляем старую таблицу, если она мешает
DROP TABLE order_summary;
GO

-- 2. Создаем её заново с актуальными именами и суммами
SELECT 
    c.first_name + ' ' + c.last_name AS customer_name, 
    o.product_name, 
    o.total_amount
INTO order_summary
FROM customers c
JOIN orders o ON c.customer_id = o.customer_id;
GO

-- 3. Смотрим результат
SELECT * FROM order_summary;