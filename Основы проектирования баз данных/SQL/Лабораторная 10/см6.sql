CREATE TABLE Гимназисты (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Фамилия NVARCHAR(50) NOT NULL,
    Предмет NVARCHAR(50),
    Баллы DECIMAL(5,2)
);

INSERT INTO Гимназисты (Фамилия, Предмет, Баллы)
SELECT Фамилия, Предмет, Баллы
FROM Ученик
WHERE Школа LIKE '%Гимназия%' AND Баллы >= 60;