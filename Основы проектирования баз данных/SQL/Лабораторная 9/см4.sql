
CREATE TABLE Животные_Туринге (
    ID INT UNIQUE,
    Код_животного INT IDENTITY(1,1) PRIMARY KEY,
    Вид NVARCHAR(100) NOT NULL,
    Семейство NVARCHAR(100),
    Отряд NVARCHAR(50) DEFAULT 'Хищные',
    Среда_обитания NVARCHAR(100),
    Вес_кг DECIMAL(8,2) CHECK (Вес_кг > 0),
    Продолжительность_жизни_лет INT
);