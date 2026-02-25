CREATE FUNCTION dbo.Пример3
(
    @Население AS INT,
    @Площадь AS FLOAT
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @P AS FLOAT;
    SET @P = ROUND(CAST(@Население AS FLOAT) / @Площадь, 2);
    RETURN @P;
END;
GO

SELECT
    Название,
    Столица,
    Континент,
    Население,
    Площадь,
    dbo.Пример3(Население, Площадь) AS Плотность
FROM
    Страны
ORDER BY
    Плотность DESC;
