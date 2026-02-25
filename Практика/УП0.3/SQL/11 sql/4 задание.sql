-- 1 самостоятельный запрос --
declare @A int, @B int, @C int;
set @A = 9;
set @B = 10;
set @C = @A * @B print @C

-- 2 самостоятельный запрос --
declare @lic float, @gim float, @cravn float;
set @lic = (
			select
				max(баллы)
				from 
				Ученик
				where
				Школа = 'лицей')
set @gim  = ( 
	 	 	select  
 	 	 	max(Баллы)   	 	
			from  
 	 	 	Ученик   	 	
			where  
	 	 	Школа = 'Гимназия')  
set @cravn = abs(@lic - @gim) 
print @cravn 

-- 3 самостоятельный запрос --

DECLARE @count_rows INT
SELECT @count_rows = COUNT(*) FROM Ученик

IF @count_rows % 2 = 0
    PRINT N'Количество строк четное (' + CAST(@count_rows AS VARCHAR(5)) + ')'
ELSE
    PRINT N'Количество строк нечетное (' + CAST(@count_rows AS VARCHAR(5)) + ')'

-- 4 самостоятельный запрос --
DECLARE @num INT = 5483, @sum INT = 0, @temp INT
SET @temp = @num

WHILE @temp > 0
BEGIN
    SET @sum = @sum + (@temp % 10)
    SET @temp = @temp / 10
END

PRINT N'Сумма цифр числа ' + CAST(@num AS VARCHAR(5)) + ' = ' + CAST(@sum AS VARCHAR(5))

-- 5 самостоятельный запрос --
DECLARE @a INT = RAND() * 100, @b INT = RAND() * 100, @c INT = RAND() * 100
DECLARE @min INT = @a  

PRINT 'a = ' + CAST(@a AS VARCHAR(5))
PRINT 'b = ' + CAST(@b AS VARCHAR(5))
PRINT 'c = ' + CAST(@c AS VARCHAR(5))

IF @b < @min SET @min = @b
IF @c < @min SET @min = @c

PRINT 'Наименьшее число = ' + CAST(@min AS VARCHAR(5))

-- 6 самостоятельный запрос --
DECLARE @a INT = RAND() * 200

IF @a % 11 = 0
    PRINT CAST(@a AS VARCHAR(5)) + ' делится на 11'
ELSE
    PRINT CAST(@a AS VARCHAR(5)) + ' не делится на 11'

-- 7 самостоятельный запрос --
DECLARE @N INT = RAND() * 1000, @temp INT
SET @temp = @N

PRINT 'Число N = ' + CAST(@N AS VARCHAR(5))

WHILE @temp % 3 = 0 AND @temp > 1
    SET @temp = @temp / 3

IF @temp = 1
    PRINT 'Да'
ELSE
    PRINT 'Нет'

-- 8 самостоятельный запрос --
DECLARE @a INT = RAND() * 50, @b INT = RAND() * 50
DECLARE @x INT = @a, @y INT = @b, @gcd INT, @lcm INT

PRINT 'a = ' + CAST(@a AS VARCHAR(5))
PRINT 'b = ' + CAST(@b AS VARCHAR(5))

-- Находим НОД (алгоритм Евклида)
WHILE @x != @y
BEGIN
    IF @x > @y SET @x = @x - @y
    ELSE SET @y = @y - @x
END
SET @gcd = @x

-- Вычисляем НОК
SET @lcm = (@a * @b) / @gcd

PRINT 'НОК = ' + CAST(@lcm AS VARCHAR(10))

-- 9 самостоятельный запрос --
DECLARE @A INT = 2, @B INT = 5, @i INT, @sum INT = 0
SET @i = @A

WHILE @i <= @B
BEGIN
    SET @sum = @sum + SQUARE(@i)
    SET @i = @i + 1
END

PRINT 'Сумма квадратов от ' + CAST(@A AS VARCHAR(5)) + ' до ' + CAST(@B AS VARCHAR(5)) + ' = ' + CAST(@sum AS VARCHAR(10))

-- 10 самостоятельный запрос --
DECLARE @num INT = 1

WHILE 1 = 1  -- Бесконечный цикл
BEGIN
    IF (@num % 2 = 1) AND (@num % 3 = 1) AND (@num % 4 = 1) AND (@num % 5 = 1) AND (@num % 6 = 1) AND (@num % 7 = 0)
    BEGIN
        PRINT 'Искомое число: ' + CAST(@num AS VARCHAR(10))
        BREAK  -- Выход из цикла, когда число найдено
    END
    SET @num = @num + 1
END

-- 11 самостоятельный запрос --
DECLARE @surname NVARCHAR(20) = 'Прелкина'
DECLARE @count INT = LEN(@surname)

PRINT 'Фамилия: ' + @surname + ', количество букв: ' + CAST(@count AS VARCHAR(5))

WHILE @count > 0
BEGIN
    PRINT @surname
    SET @count = @count - 1
END
-- 12 самостоятельный запрос --
DECLARE @word NVARCHAR(20) = N'Нижневартовск'
DECLARE @len INT = LEN(@word)
DECLARE @i INT = 1
DECLARE @currentLetters NVARCHAR(MAX) = ''

WHILE @i <= @len
BEGIN
    -- На каждой итерации добавляем следующую букву и пробел после неё
    SET @currentLetters = @currentLetters + SUBSTRING(@word, @i, 1) + ' '
    
    -- Печатаем: (отступ слева для центрирования) + (накопленные буквы)
    PRINT SPACE(@len - @i) + @currentLetters
    
    SET @i = @i + 1
END






