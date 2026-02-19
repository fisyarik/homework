-- 1 самостоятельный запрос --
CREATE TABLE Управление_фиса (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Название_отдела NVARCHAR(100) NOT NULL,
    Руководитель NVARCHAR(100),
    Дата_создания DATE DEFAULT GETDATE(),
    Бюджет DECIMAL(15,2) DEFAULT 0.00
);

-- 2 самостоятельный запрос --
CREATE TABLE Страны_фисы (
    Код_страны CHAR(3) PRIMARY KEY,
    Название NVARCHAR(100) NOT NULL,
    Столица NVARCHAR(100),
    Площадь DECIMAL(12,2) CHECK (Площадь > 0),
    Население INT CHECK (Население >= 0),
    Континент NVARCHAR(50) NOT NULL,
    Дата_вступления_ООН DATE
);

-- 3 самостоятельный запрос --
CREATE TABLE Цветы_фисы (
    ID INT UNIQUE,
    Код_цветка INT IDENTITY(1,1) PRIMARY KEY,
    Название NVARCHAR(100) NOT NULL,
    Семейство NVARCHAR(100),
    Класс NVARCHAR(50) DEFAULT 'Двудольные',
    Период_цветения NVARCHAR(50),
    Высота_см DECIMAL(6,2)
);

-- 4 самостоятельный запрос --
CREATE TABLE Животные_фисы (
    ID INT UNIQUE,
    Код_животного INT IDENTITY(1,1) PRIMARY KEY,
    Вид NVARCHAR(100) NOT NULL,
    Семейство NVARCHAR(100),
    Отряд NVARCHAR(50) DEFAULT 'Хищные',
    Среда_обитания NVARCHAR(100),
    Вес_кг DECIMAL(8,2) CHECK (Вес_кг > 0),
    Продолжительность_жизни_лет INT
);