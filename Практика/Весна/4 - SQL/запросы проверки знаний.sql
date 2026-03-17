--1 Задание--
select *
from Customers

--2 задание--
select CustomerName, City, Country
from Customers

-- 3 задание --
select distinct Country
from Customers

-- 4 задание --
select distinct City
from Customers

-- 5 задание --
select *
from Customers
where City = 'Paris'

-- 6 задание --
select *
from Products
where Price > 55

-- 7 задание --
select *
from Customers
where country = 'Germany' and city = 'Berlin'

-- 8 задание--
select *
from Customers
where city = 'London' or city = 'Berlin'

-- 9 задание--
select *
from Customers
where Country not like 'France'

-- 10 задание--
select ContactName
from Customers
where ContactName is not null and Address is null


-- ЗАПРОСЫ С JOIN --

-- 1 запрос --
select *
from Orders inner join Customers on Orders.CustomerID = Customers.CustomerID

-- 2 запрос --
select *
from Orders left join Customers on Orders.CustomerID = Customers.CustomerID