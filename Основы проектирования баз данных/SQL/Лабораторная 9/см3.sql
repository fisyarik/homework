
CREATE TABLE Цветы_фисы (
    ID INT UNIQUE,
    Код_цветка INT IDENTITY(1,1) PRIMARY KEY,
    Название NVARCHAR(100) NOT NULL,
    Семейство NVARCHAR(100),
    Класс NVARCHAR(50) DEFAULT 'Двудольные',
    Период_цветения NVARCHAR(50),
    Высота_см DECIMAL(6,2)
);