CREATE FUNCTION dbo.Пример2
(
    @Площадь AS FLOAT
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @P AS FLOAT;
    SET @P = ROUND(@Площадь / 1000, 2);
    RETURN @P;
END;
GO

SELECT
    Название,
    Столица,
    Континент,
    Население,
    dbo.Пример2(Площадь) AS [Площадь тыс.кв.км]
FROM
    Страны;
