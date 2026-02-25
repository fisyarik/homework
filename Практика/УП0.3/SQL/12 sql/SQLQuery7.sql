CREATE FUNCTION dbo.Пример7
(
    @C AS CHAR(1)
)
RETURNS INT
AS
BEGIN
    DECLARE @K AS INT;

    SELECT @K = COUNT(*)
    FROM Страны
    WHERE CHARINDEX(@C, Название) > 0;

    RETURN @K;
END;
GO

SELECT dbo.Пример7('А') AS [Количество стран с буквой 'А'];
