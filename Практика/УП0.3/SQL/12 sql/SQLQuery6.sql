CREATE FUNCTION dbo.Пример6_Улучшенная
(
    @A AS VARCHAR(100)
)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @Result AS VARCHAR(100);

    IF @A IS NULL
        SET @Result = NULL;
    ELSE IF LEN(@A) = 1
        SET @Result = @A;
    ELSE IF LEN(@A) = 2
        SET @Result = LEFT(@A, 1) + RIGHT(@A, 1);
    ELSE
        SET @Result = LEFT(@A, 1) + REPLICATE('.', LEN(@A) - 2) + RIGHT(@A, 1);

    RETURN @Result;
END;
GO

SELECT
    dbo.Пример6_Улучшенная(Название) AS [Скрытое название],
    Столица,
    Континент,
    Площадь,
    Население
FROM
    Страны;
