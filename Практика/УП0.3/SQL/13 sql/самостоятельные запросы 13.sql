-- 1 самостоятельный запрос --
CREATE PROC Задание1
AS
BEGIN
    SELECT
        @@Servername AS Сервер,
        @@Version AS [Версия СУБД],
        Db_Name() AS [База данных],
        User AS [Пользователь базы данных],
        System_User AS [Системный пользователь],
        GETDATE() AS [Текущее время]
END
GO

EXECUTE Задание1

-- 2 самостоятельный запрос --
CREATE PROC Задание2
AS
BEGIN
    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM
        Страна
END
GO

EXECUTE Задание2

-- 3 самостоятельный запрос --
CREATE PROC Задание3
    @Континент AS VARCHAR(50)
AS
BEGIN
    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM
        Страна
    WHERE
        Континент <> @Континент
END
GO

EXECUTE Задание3 'Европа'

-- 4 самостоятельный запрос --
CREATE PROC Задание4
    @MinPop AS BIGINT,
    @MaxPop AS BIGINT
AS
BEGIN
    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM
        Страна
    WHERE
        Население BETWEEN @MinPop AND @MaxPop
END
GO

EXECUTE Задание4 10000000, 50000000

-- 5 самостоятельный запрос --
CREATE PROC Задание5
    @Буква AS CHAR(1),
    @Количество AS INT OUTPUT
AS
BEGIN
    SELECT
        @Количество = COUNT(*)
    FROM
        Страна
    WHERE
        CHARINDEX(@Буква, Название) = 0
END
GO

DECLARE @Кол AS INT
DECLARE @Бук AS CHAR(1)
SET @Бук = 'А'
EXECUTE Задание5 @Бук, @Кол OUTPUT
SELECT @Кол AS [Количество стран без буквы]

-- 6 самостоятельный запрос --
CREATE PROC Задание6
    @Континент AS VARCHAR(50) = 'Африка'
AS
BEGIN
    SELECT TOP 5
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM
        Страна
    WHERE
        Континент = @Континент
    ORDER BY
        Население DESC
END
GO

EXECUTE Задание6 DEFAULT

-- 7 самостоятельный запрос --
CREATE PROC Задание7
AS
BEGIN
    IF OBJECT_ID('Страны_И', 'U') IS NOT NULL
        DROP TABLE Страны_И

    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    INTO
        Страны_И
    FROM
        Страна
    WHERE
        LEFT(Название, 1) = 'И'
END
GO

EXECUTE Задание7

-- 8 самостоятельный запрос --
IF OBJECT_ID('Задание8', 'P') IS NOT NULL
    DROP PROC Задание8
GO

CREATE PROC Задание8
AS
BEGIN
    DECLARE @КоличествоСтрок AS INT

    IF OBJECT_ID('Страны_И', 'U') IS NOT NULL
    BEGIN
        SELECT @КоличествоСтрок = COUNT(*) FROM Страны_И
        DROP TABLE Страны_И
    END
    ELSE
        SET @КоличествоСтрок = 0

    RETURN @КоличествоСтрок
END
GO

DECLARE @Счёт AS INT
EXECUTE @Счёт = Задание8
SELECT @Счёт AS [Количество удалённых строк]

-- 9 самостоятельный запрос --
CREATE PROC Задание9
    @Число AS BIGINT,
    @КолЦифр AS INT OUTPUT
AS
BEGIN
    SET @КолЦифр = LEN(CAST(ABS(@Число) AS VARCHAR))
END
GO

DECLARE @Цифры AS INT
EXECUTE Задание9 12345, @Цифры OUTPUT
SELECT @Цифры AS [Количество цифр]

-- 10 самостоятельный запрос --
CREATE PROC AddRightDigit
    @K AS BIGINT OUTPUT,
    @D AS INT
AS
BEGIN
    IF @D BETWEEN 0 AND 9
        SET @K = @K * 10 + @D
    ELSE
        RAISERROR('Цифра D должна быть в диапазоне [0..9]', 16, 1)
END
GO

DECLARE @Число AS BIGINT = 123
EXECUTE AddRightDigit @Число OUTPUT, 7
SELECT @Число AS [Результат]

-- 11 самостоятельный запрос --
CREATE PROC InvDigit
    @K AS BIGINT OUTPUT
AS
BEGIN
    DECLARE @Обратное AS BIGINT = 0
    DECLARE @Остаток AS INT

    WHILE @K > 0
    BEGIN
        SET @Остаток = @K % 10
        SET @Обратное = @Обратное * 10 + @Остаток
        SET @K = @K / 10
    END

    SET @K = @Обратное
END
GO

DECLARE @Исходное AS BIGINT = 12345
EXECUTE InvDigit @Исходное OUTPUT
SELECT @Исходное AS [Обращённое число]

-- 12 самостоятельный запрос --
CREATE PROC Swap
    @X AS FLOAT OUTPUT,
    @Y AS FLOAT OUTPUT
AS
BEGIN
    DECLARE @Temp AS FLOAT
    SET @Temp = @X
    SET @X = @Y
    SET @Y = @Temp
END
GO

DECLARE @A AS FLOAT = 5.5
DECLARE @B AS FLOAT = 3.2
EXECUTE Swap @A OUTPUT, @B OUTPUT
SELECT @A AS X, @B AS Y

-- 13 самостоятельный запрос --
CREATE PROC SortInc
    @A AS FLOAT OUTPUT,
    @B AS FLOAT OUTPUT,
    @C AS FLOAT OUTPUT
AS
BEGIN
    DECLARE @Min AS FLOAT, @Mid AS FLOAT, @Max AS FLOAT

    -- Находим минимальное значение
    SET @Min = CASE
        WHEN @A <= @B AND @A <= @C THEN @A
        WHEN @B <= @A AND @B <= @C THEN @B
        ELSE @C
    END

    -- Находим максимальное значение
    SET @Max = CASE
        WHEN @A >= @B AND @A >= @C THEN @A
        WHEN @B >= @A AND @B >= @C THEN @B
        ELSE @C
    END

    -- Среднее значение — оставшееся
    SET @Mid = @A + @B + @C - @Min - @Max

    SET @A = @Min
    SET @B = @Mid
    SET @C = @Max
END
GO

DECLARE @X AS FLOAT = 7.2
DECLARE @Y AS FLOAT = 1.5
DECLARE @Z AS FLOAT = 4.8
EXECUTE SortInc @X OUTPUT, @Y OUTPUT, @Z OUTPUT
SELECT @X AS A, @Y AS B, @Z AS C

-- 14 самостоятельный запрос --
CREATE PROC DigitCountSum
    @K AS BIGINT,
    @C AS INT OUTPUT,
    @S AS INT OUTPUT
AS
BEGIN
    SET @C = 0
    SET @S = 0

    WHILE @K > 0
    BEGIN
        SET @C = @C + 1
        SET @S = @S + (@K % 10)
        SET @K = @K / 10
    END
END
GO

DECLARE @Число AS BIGINT = 12345
DECLARE @Кол AS INT
DECLARE @Сумма AS INT
EXECUTE DigitCountSum @Число, @Кол OUTPUT, @Сумма OUTPUT
SELECT @Кол AS [Количество цифр], @Сумма AS [Сумма цифр]

-- 15 самостоятельный запрос --
DROP PROC IF EXISTS Задание1, Задание2, Задание3, Задание4, Задание5,
                  Задание6, Задание7, Задание8, Задание9,
                  AddRightDigit, InvDigit, Swap, SortInc, DigitCountSum