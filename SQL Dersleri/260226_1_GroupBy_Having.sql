-- 26 ŞUBAT 2026
-- group by, having 

use nortwinddb

select * from Products 

select CategoryID, ProductName, UnitPrice from Products order by CategoryID

select CategoryID,COUNT(ProductID) from Products

select Country,City,CompanyName,ContactName from Customers order by Country

select country,Count(CustomerID)as 'Müşteri Adı' from customers 
group by Country
--1 group by ile yazılan kolonlar select from arasında kullanımalıdır
--2 group by genelde hazır fonksiyon ile beraber kullanılır
--3 select from arasında yazılan kolon group bu ile beraber kullanılması zorunludur

select top 3 Country, COUNT(CustomerID) as 'Müşteri Sayısı' from Customers
group by Country order by [Müşteri Sayısı] desc
--en az müşteri sahip 5 ülke
select top 3 Country, COUNT(CustomerID) as 'Müşteri Sayısı' from Customers
group by Country order by [Müşteri Sayısı] asc
 
 select * from Orders -- 830 data

 -- her bir ülkeye kaç sipariş gönderildiğini hesaplayınız
 select ShipCountry,Count(OrderID) AS SiparisSayisi from Orders 
 group by ShipCountry;

 select * from Orders where ShipCountry='Finland'

 select ShipCountry from Orders --830 data
 select distinct ShipCountry,ShipCity from Orders -- distinct gruplamadan aynı dataları tek satırda verir
 -- distinct bir kolondaki tekrar eden aynı değerleri tekelleştirir
 select ShipCountry from Orders
 group by ShipCountry 
 
 select YEAR(OrderDate),Count(OrderID) as 'Yıllık Sayı' from orders
 group by Year(OrderDate)
 -- year- tarih içinde yılı verir
 -- month- tarih için ayı verir
 -- day- tarih içinde günü verir

 --her ülkeye giden sipariş sayısı
 select ShipCountry,COUNT(OrderID) from orders
 group by ShipCountry
--her bir ülkenin şehirlerine giden sipariş sayısı
select ShipCountry,ShipCity,COUNT(OrderID) as 'Sipariş Sayısı' from orders 
group by ShipCountry,ShipCity order by ShipCountry,ShipCity

--1998 yılında en çok sipariş verilen 4 ay bilgisini bulunuz
select top 4 MONTH(OrderDate) as AY, COUNT(ORDERID) AS 'Siparis Sayisi'
from orders where year(OrderDate)=1998 group by month(orderdate) order by COUNT(OrderID)desc 

 select * from orders
 select * from customers
 --her bir kategoride kaç ürün olduğunu hesaplayınız
-- kategori, ürün
select * from Categories
select * from Products 

select CategoryID, Count(ProductID) from Products group by CategoryID

--subquery,join
--having- group by için koşul bağlama işlemi yapar

select ShipCountry,COUNT(OrderID) as Sayı from Orders
--where Count(OrderID)=30 where tablo kolonları için sorgu yapar
group by ShipCountry
having Count(OrderID)=30

--tablo kolon sorgu işlemlerinde where nasıl sorgu yapıyorsa group by ile beraber having te o sorgu işlemini yapar. having ile where burda farklı görevleri üstlenir. where olan kolonlarda çalışır, having group by ile hesaplama için kullanılan hazır fonksiyonla beraber oluşturulan yeni hesaplayıcı yapı için sorgu yapar