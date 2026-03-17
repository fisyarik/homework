-- 1 самостоятельный запрос --
CREATE TRIGGER Задание1 ON Ученик
FOR UPDATE
AS
BEGIN
    PRINT 'Запись изменена'
END
GO

-- 2 самостоятельный запрос --
CREATE TRIGGER Задание2 ON Ученик
FOR INSERT, DELETE
AS
BEGIN
    PRINT 'Количество строк изменено'
END
GO

-- 3 самостоятельный запрос --
CREATE TRIGGER Задание3 ON Ученик
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @Сообщение VARCHAR(200)
    SET @Сообщение = SYSTEM_USER + ' изменил таблицу. Время: ' + CONVERT(VARCHAR, GETDATE(), 120)
    PRINT @Сообщение
END
GO

-- 4 самостоятельный запрос --
CREATE TRIGGER Задание4 ON Ученик
INSTEAD OF UPDATE
AS
BEGIN
    PRINT 'Нельзя редактировать данные'
END
GO

-- 5 самостоятельный запрос --
-- Создаём таблицу для архива
CREATE TABLE Ученики_Иванов (
    Фамилия VARCHAR(50) NOT NULL,
    Удалено DATETIME NOT NULL
)
GO

-- Создаём триггер
CREATE TRIGGER Задание5 ON Ученик
FOR DELETE
AS
BEGIN
    INSERT INTO Ученики_Иванов (Фамилия, Удалено)
    SELECT
        d.Фамилия,
        GETDATE() AS Удалено
    FROM
        DELETED d
    WHERE
        EXISTS (
            SELECT 1
            FROM Ученики u
            WHERE u.Фамилия = d.Фамилия
        )
END
GO

-- 6 самостоятельный запрос --
-- Приостановить триггер
DISABLE TRIGGER Задание5 ON Ученик
GO

-- Запустить триггер
ENABLE TRIGGER Задание5 ON Ученик
GO

-- 7 самостоятельный запрос --
DROP TRIGGER IF EXISTS Задание1, Задание2, Задание3, Задание4, Задание5
GO
