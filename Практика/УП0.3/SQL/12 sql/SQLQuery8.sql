CREATE FUNCTION dbo.Пример8
(
    @N AS INT
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
        Население > @N
);
GO

SELECT *
FROM dbo.Пример8(100000000);
