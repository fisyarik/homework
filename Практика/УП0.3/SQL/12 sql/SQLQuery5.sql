CREATE FUNCTION dbo.Пример5
(
    @Конт AS VARCHAR(50) = 'Европа'
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @P AS VARCHAR(50);
    DECLARE @M AS FLOAT;

    SELECT @M = MIN(Площадь)
    FROM Страны
    WHERE Континент = @Конт;

    SELECT @P = Название
    FROM Страны
    WHERE Континент = @Конт
      AND Площадь = @M;

    RETURN @P;
END;
GO

SELECT dbo.Пример5('Азия') AS [Наименьшая по площади страна в Азии];
SELECT dbo.Пример5(DEFAULT) AS [Наименьшая по площади страна в Европе];
