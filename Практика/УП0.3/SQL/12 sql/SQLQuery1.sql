CREATE FUNCTION dbo.Пример1
(
    @Страна AS VARCHAR(50)
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @S AS VARCHAR(50);
    
    SELECT @S = Столица
    FROM Страны
    WHERE Название = @Страна;
    
    RETURN @S;
END;
GO

SELECT dbo.Пример1('Австрия') AS Столица;
