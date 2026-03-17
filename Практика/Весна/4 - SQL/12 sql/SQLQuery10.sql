CREATE FUNCTION dbo.Пример10()
RETURNS @Ст_Плот TABLE
(
    Название VARCHAR(50),
    Плотность FLOAT
)
AS
BEGIN
    INSERT INTO @Ст_Плот
    SELECT
        Название,
        CAST(Население AS FLOAT) / Площадь AS Плотность
    FROM
        Страны
    WHERE
        Площадь > 0;  -- Защита от деления на ноль

    RETURN;
END;
GO

SELECT
    Название,
    Плотность
FROM
    dbo.Пример10();
