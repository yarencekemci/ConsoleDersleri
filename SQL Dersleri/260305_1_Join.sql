--5 mart 2026 join
use nortwinddb

--en fazla siparişte görev alan personelin hangi ürün siparişlerinde görev aldığını 
--ürün, birim fiyat, satış fiyatı, satılan miktar, mevcut stok ve personel bilgileri veren scripti kodlayınız

select top 1 EmployeeID , Count(OrderID) Sayı from orders 
group by EmployeeID order by Sayı desc

select

p.ProductName,
SUM(od.UnitPrice) as 'satış fiyatı',
Sum(od.Quantity) as [Satılan Adet],
p.UnitsInStock,
p.UnitPrice
		from Employees as e
inner join Orders as o on o.EmployeeID=e.EmployeeID
inner join [Order Details] as od on od.OrderID=o.OrderID
inner join Products as p on p.ProductID=od.ProductID
 where e.EmployeeID in (select top 1 EmployeeID  Sayı from orders 
group by EmployeeID order by Sayı desc)
group by p.ProductName, p.UnitPrice, p.UnitsInStock
order by p.ProductName

--En az sipariş veren Müşterinin müşteri bilgileri ile beraber hangi ürünleri sipariş ettiğini hesaplayınız

select top 1 EmployeeID, Count(OrderID) Sayı from orders 
group by EmployeeID order by Sayı asc

select 
p.ProductID, p.ProductName, SanalTablo.Sayı
from (select CustomerID, Count(OrderID) Sayı from Orders group by CustomerID) as SanalTablo

inner join orders as c on c.CustomerID=SanalTablo.CustomerID
inner join Orders as o on o.CustomerID=c.CustomerID
inner join [Order Details] as od on od.OrderID=o.OrderID
inner join Products as p on p.ProductID=od.ProductID

group by p.ProductName,SanalTablo.Sayı,p.ProductID
order by sayı

-----


select 
p.ProductID, p.ProductName, SanalTablo.Sayı
from 
(select top 1 CustomerID,COUNT(OrderId) Sayı from orders
group by CustomerId order by Sayı asc) as SanalTablo

inner join orders as c on c.CustomerID=SanalTablo.CustomerID
inner join Orders as o on o.CustomerID=c.CustomerID
inner join [Order Details] as od on od.OrderID=o.OrderID
inner join Products as p on p.ProductID=od.ProductID
where sayı=(select top 1 MIN(COUNT(OrderID))Over() from Orders group by CustomerID)
group by p.ProductName,SanalTablo.Sayı, p.ProductID
order by sayı

---





--yaren