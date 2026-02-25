CREATE FUNCTION dbo.Пример4()
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @P AS VARCHAR(50);
    DECLARE @M1 AS FLOAT;
    DECLARE @M2 AS FLOAT;

    SELECT @M1 = MAX(Площадь)
    FROM Страны;

    SELECT @M2 = MAX(Площадь)
    FROM Страны
    WHERE Площадь < @M1;

    SELECT @P = Название
    FROM Страны
    WHERE Площадь = @M2;

    RETURN @P;
END;
GO

SELECT dbo.Пример4() AS [Второй по площади страна];
