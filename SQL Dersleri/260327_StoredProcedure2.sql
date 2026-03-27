-- 27.03.2026
-- Ürün araması yapan sp_Urun_Satis_Sonuc_Ara adında bir sp için arama sonuçlarını 
-- fiyat, stok, bilgileri veren yapıyı kodlayınız?

use nortwinddb

select
p.ProductName as 'Ürün Adı',
p.UnitPrice as 'Birim fiyatı',
p.UnitsInStock as 'Mevcut Stok',
od.UnitPrice as 'Satis Fiyatı',
sum(od.Quantity) as 'Satıan adet'
from Products as p 
join [Order Details] as od on od.ProductID=p.ProductID
where p.ProductName like '%'+@aranacakUrunAdiKelimesi+'%'
group by p.ProductName, p.UnitPrice, p.UnitsInStock, od.UnitPrice
go
create proc sp_Urun_Satis_Sonuc_Ara 
(
@aranacakUrunAdiKelimesi nvarchar(250)
)
as
begin
select
p.ProductName as 'Ürün Adı',
p.UnitPrice as 'Birim fiyatı',
p.UnitsInStock as 'Mevcut Stok',
od.UnitPrice as 'Satis Fiyatı',
sum(od.Quantity) as 'Satıan adet'
from Products as p 
join [Order Details] as od on od.ProductID=p.ProductID
where p.ProductName like '%'+@aranacakUrunAdiKelimesi+'%'
group by p.ProductName, p.UnitPrice, p.UnitsInStock, od.UnitPrice
end
go

-- --tarih verildiğinde o tarihte hangi siparişleri olduğunu sipariş, müşteri bilgilerini getiren sp_Musteri_Satis_Rapor sp adı ile kodlayınız
--sp_Musteri_Satis_Rapor

select *from Orders where OrderDate = '1996-07-04'
select
o.OrderID as 'Sipariş ID',
o.OrderDate as 'Sipariş tarihi',
c.CompanyName as 'Müşteri Adı'
from Orders as o 
join Customers as c on o.CustomerID = c.CustomerID
where o.OrderDate = @tarih
group by o.OrderID, o.OrderDate, c.CompanyName
go
create proc sp_Musteri_Satis_Rapor
(
@tarih datetime
)
as
begin
select
o.OrderID as 'Sipariş ID',
o.OrderDate as 'Sipariş tarihi',
c.CompanyName as 'Müşteri Adı'
from Orders as o 
join Customers as c on o.CustomerID = c.CustomerID
where o.OrderDate = @tarih
group by o.OrderID, o.OrderDate, c.CompanyName
end
go

-- yaren

