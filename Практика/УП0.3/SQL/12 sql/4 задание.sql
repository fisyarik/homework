-- 1 самостоятельный запрос --
CREATE FUNCTION Задание1
(
    @Столица AS VARCHAR(50)
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Страна AS VARCHAR(50)

    SELECT TOP 1 @Страна = Название
    FROM Страна
    WHERE Столица = @Столица

    RETURN @Страна
END
GO

SELECT dbo.Задание1('Пекин') AS [Страна со столицей Пекин]

-- 2 самостоятельный запрос --
CREATE FUNCTION Задание2
(
    @Население AS INT
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Население_млн AS FLOAT
    SET @Население_млн = ROUND(CAST(@Население AS FLOAT) / 1000000, 2)
    RETURN @Население_млн
END
GO
SELECT
    Название,
    Столица,
    Континент,
    Площадь,
    dbo.Задание2(Население) AS [Население млн чел.]
FROM Страна

-- 3 самостоятельный запрос --
CREATE FUNCTION Задание3
(
    @Континент AS VARCHAR(50)
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Плотность AS FLOAT
    SELECT @Плотность = ROUND(SUM(CAST(Население AS FLOAT)) / SUM(Площадь), 2)
    FROM Страна
    WHERE Континент = @Континент
    RETURN @Плотность
END
GO
SELECT dbo.Задание3('Европа') AS [Плотность населения Европы]

-- 4 самостоятельный запрос --
CREATE FUNCTION Задание4()
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Страна AS VARCHAR(50);

    WITH RankedCountries AS (
        SELECT
            Название,
            ROW_NUMBER() OVER (ORDER BY Население DESC) AS Rank
        FROM Страна
    )
    SELECT TOP 1 @Страна = Название
    FROM RankedCountries
    WHERE Rank = 3;

    RETURN @Страна;
END;
GO

SELECT dbo.Задание4() AS [Третья по населению страна];

-- 5 самостоятельный запрос --
CREATE FUNCTION Задание5
(
    @Континент AS VARCHAR(50) = 'Азия'
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Страна AS VARCHAR(50)
    SELECT TOP 1 @Страна = Название
    FROM Страна
    WHERE Континент = @Континент
    ORDER BY Население DESC
    RETURN @Страна
END
GO
SELECT dbo.Задание5('Европа') AS [Самая населённая страна в Европе]
SELECT dbo.Задание5(DEFAULT) AS [Самая населённая страна в Азии]

-- 6 самостоятельный запрос --
CREATE FUNCTION Задание6
(
    @Слово AS VARCHAR(50)
)
RETURNS VARCHAR(50)
AS
BEGIN
    IF LEN(@Слово) <= 3
        RETURN @Слово
    RETURN LEFT(@Слово, 2) + 'тест' + RIGHT(@Слово, 1)
END
GO
SELECT
    dbo.Задание6(Столица) AS [Обработанная столица],
    Название,
    Столица,
    Континент
FROM Страна

-- 7 самостоятельный запрос --
CREATE FUNCTION Задание7
(
    @Буква AS CHAR(1)
)
RETURNS INT
AS
BEGIN
    DECLARE @Количество AS INT
    SELECT @Количество = COUNT(*)
    FROM Страна
    WHERE CHARINDEX(@Буква, Название) = 0
    RETURN @Количество
END
GO
SELECT dbo.Задание7('А') AS [Количество стран без буквы А]

-- 8 самостоятельный запрос --
CREATE FUNCTION Задание8
(
    @МаксПлощадь AS FLOAT
)
RETURNS TABLE
AS
RETURN (
    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM Страна
    WHERE Площадь < @МаксПлощадь
)
GO
SELECT * FROM dbo.Задание8(100000)

-- 9 самостоятельный запрос --
CREATE FUNCTION Задание9
(
    @МинНаселение AS INT,
    @МаксНаселение AS INT
)
RETURNS TABLE
AS
RETURN (
    SELECT
        Название,
        Столица,
        Площадь,
        Население,
        Континент
    FROM Страна
    WHERE Население BETWEEN @МинНаселение AND @МаксНаселение
)
GO
SELECT * FROM dbo.Задание9(10000000, 50000000)

-- 10 самостоятельный запрос --
CREATE FUNCTION Задание10()
RETURNS @Конт_Нас TABLE
(
    Континент VARCHAR(50),
    Суммарное_население BIGINT
)
AS
BEGIN
    INSERT @Конт_Нас
    SELECT
        Континент,
        SUM(Население) AS Суммарное_население
    FROM Страна
    GROUP BY Континент
    RETURN
END
GO
SELECT * FROM dbo.Задание10() ORDER BY Суммарное_население DESC

-- 11 самостоятельный запрос --
CREATE FUNCTION IsPalindrom
(
    @P AS INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @StrP AS VARCHAR(20) = CAST(@P AS VARCHAR(20))
    DECLARE @Reversed AS VARCHAR(20) = ''
    DECLARE @Len AS INT = LEN(@StrP)
    DECLARE @I AS INT = @Len
    DECLARE @Result AS BIT  

    WHILE @I >= 1
    BEGIN
        SET @Reversed = @Reversed + SUBSTRING(@StrP, @I, 1)
        SET @I = @I - 1
    END

    IF @StrP = @Reversed
        SET @Result = 1
    ELSE
        SET @Result = 0

    RETURN @Result
END
GO

SELECT dbo.IsPalindrom(12321) AS [12321 — палиндром?] -- 1
SELECT dbo.IsPalindrom(12345) AS [12345 — палиндром?] -- 0
SELECT dbo.IsPalindrom(1) AS [1 — палиндром?] -- 1
SELECT dbo.IsPalindrom(1221) AS [1221 — палиндром?] -- 1

-- 12 самостоятельный запрос --
CREATE FUNCTION Quarter
(
    @x AS FLOAT,
    @y AS FLOAT
)
RETURNS INT
AS
BEGIN
    DECLARE @Result AS INT

    IF @x > 0 AND @y > 0
        SET @Result = 1
    ELSE IF @x < 0 AND @y > 0
        SET @Result = 2
    ELSE IF @x < 0 AND @y < 0
        SET @Result = 3
    ELSE IF @x > 0 AND @y < 0
        SET @Result = 4
    ELSE
        SET @Result = NULL

    RETURN @Result
END
GO

SELECT dbo.Quarter(1.0, 1.0) AS [Четверть (1,1)] -- 1
SELECT dbo.Quarter(-1.0, 1.0) AS [Четверть (-1,1)] -- 2
SELECT dbo.Quarter(-1.0, -1.0) AS [Четверть (-1,-1)] -- 3
SELECT dbo.Quarter(1.0, -1.0) AS [Четверть (1,-1)] -- 4
SELECT dbo.Quarter(0.0, 1.0) AS [Четверть (0,1)] -- NULL

-- 13 самостоятельный запрос --
CREATE FUNCTION IsPrime
(
    @N AS INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Result AS BIT

    IF @N <= 1
        SET @Result = 0
    ELSE IF @N = 2
        SET @Result = 1
    ELSE IF @N % 2 = 0
        SET @Result = 0
    ELSE
    BEGIN

        DECLARE @I AS INT = 3
        SET @Result = 1  

        WHILE @I * @I <= @N
        BEGIN
            IF @N % @I = 0
            BEGIN
                SET @Result = 0 
                BREAK  
            END
            SET @I = @I + 2
        END
    END

    RETURN @Result
END
GO

SELECT dbo.IsPrime(17) AS [17 — простое?] -- 1
SELECT dbo.IsPrime(25) AS [25 — простое?] -- 0
SELECT dbo.IsPrime(97) AS [97 — простое?] -- 1
SELECT dbo.IsPrime(2) AS [2 — простое?] -- 1
SELECT dbo.IsPrime(1) AS [1 — простое?] -- 0

-- 14 самостоятельный запрос --
DROP FUNCTION IF EXISTS Задание1;
DROP FUNCTION IF EXISTS Задание2;
DROP FUNCTION IF EXISTS Задание3;
DROP FUNCTION IF EXISTS Задание4;
DROP FUNCTION IF EXISTS Задание5;
DROP FUNCTION IF EXISTS Задание6;
DROP FUNCTION IF EXISTS Задание7;
DROP FUNCTION IF EXISTS Задание8;
DROP FUNCTION IF EXISTS Задание9;
DROP FUNCTION IF EXISTS Задание10;
DROP FUNCTION IF EXISTS IsPalindrom;
DROP FUNCTION IF EXISTS Quarter;
DROP FUNCTION IF EXISTS IsPrime;
GO

PRINT 'Все функции задания успешно удалены.';
