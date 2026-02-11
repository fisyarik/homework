
CREATE TABLE Страны_Туринге (
    Код_страны CHAR(3) PRIMARY KEY,
    Название NVARCHAR(100) NOT NULL,
    Столица NVARCHAR(100),
    Площадь DECIMAL(12,2) CHECK (Площадь > 0),
    Население INT CHECK (Население >= 0),
    Континент NVARCHAR(50) NOT NULL,
    Дата_вступления_ООН DATE
);