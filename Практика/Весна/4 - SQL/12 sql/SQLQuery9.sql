CREATE FUNCTION dbo.Пример9
(
    @A AS FLOAT,
    @B AS FLOAT
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
    FROM
        Страны
    WHERE
        Площадь BETWEEN @A AND @B
);
GO

SELECT *
FROM dbo.Пример9(1000, 10000);
