--27 şubat 2026

use nortwinddb

select * from Products
select * from Categories
select * from [Order Details]

select CategoryID, (select CategoryName from Categories where Categories.CategoryID=Products.CategoryID) as 'Kategori adı' ,
ProductID,ProductName,UnitPrice,UnitsInStock
from Products
/*
1- subquery ile tanımlanan script sadece bir kolon çağırılabilir
2- subquery ile ana sorgu where ile ortok kolonlar eşitlenmeli ve bu eşitlenme subquery (iç select) ile yapılmalı
3-2.maddenin devami olarak iç select ile tanımlanan tablo PK (Primary Key) kolon olmalıdır
*/

select * from Products
select * from Categories
select * from Suppliers

select 
(select s.CompanyName from Suppliers as s where s.SupplierID=p.SupplierID) as 'Tedarikçi Firma' ,
(select s.ContactName from Suppliers as s where s.SupplierID=p.SupplierID) as 'Tedarikçi Firma Yetkilisi',
(select c.CategoryName from Categories as c where c.CategoryID=p.CategoryID) as 'Kategori adı' ,
p.ProductName,p.UnitPrice,p.UnitsInStock
from Products as p

--her bir siparişin hangi personel tarafından yapıldığını sipariş tarihi, kargo maliyeti personel adını getiren scripti kodlayınız

select
OrderDate as 'Sipariş Tarihi' , Freight as 'Kargo', 
(select e.FirstName + SPACE(1) + e.LastName from Employees as e where e.EmployeeID=o.EmployeeID) as 'Personel Adı'
-- iç select ile operatörler kullanarak birden fazla kolonu tek kolon gibi göstermek şartıyla kullanabilirsiniz
from Orders as o
-- iç select ile geçmiş konulardaki group by,order by, where, like,... bütün işlemleri yapabilirsiniz
--örnek
--her bir personelin kaç sipariş verdiğini hesaplayalım
select 
(select e.FirstName + SPACE(1) + e.LastName from Employees as e where e.EmployeeID=o.EmployeeID) as 'Personel Adı Soyadı',
COUNT(OrderID) as 'Sipariş Sayısı'
from Orders as o 
group by o.EmployeeID having Count(OrderID)>100
Order by [Sipariş Sayısı]

--her bir müşterinin(customer) kaç siparişi olduğunu Firmaadı, Firma yetkili ad-soyad, şehir ve ülke şeklinde hesaplayınız
select * from orders
select * from customers
--PK OLAN KOLONA SAHİP TABLO İÇ SELECT OLMAK ZORUNDADIR
-- Customer ID Customers tablosu için PK'dir, o nedenle Customers tablosu iç select olmalıdır

select 
CustomerID as 'Customer ID',
(select c.CompanyName from Customers c where c.CustomerID= o.CustomerID) as 'Firma Adı' ,
(select c.ContactName from Customers c where c.CustomerID= o.CustomerID) as 'Firma Yetkilisi' ,
(select c.city from Customers c where c.CustomerID= o.CustomerID) 'Şehir',
(select c.country from customers c where c.CustomerID= o.CustomerID) as 'Ülke'

from orders o group by CustomerID 
--YAREN

--1)Her bir üründen kaç tane satıldığını ürün adı , birim fiyatı , kalan stok şeklinde gösteriniz
--2)her bir siparişte kaç ürün olduğunu getiren scripti kodlayınız
--3)her bir müşterinin aldığı ürün sayısı Firmaadı, Firma yetkili ad-soyad, şehir ve ülke şeklinde hesaplayınız