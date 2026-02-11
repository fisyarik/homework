
CREATE TABLE Управление_Туринге (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Название_отдела NVARCHAR(100) NOT NULL,
    Руководитель NVARCHAR(100),
    Дата_создания DATE DEFAULT GETDATE(),
    Бюджет DECIMAL(15,2) DEFAULT 0.00
);