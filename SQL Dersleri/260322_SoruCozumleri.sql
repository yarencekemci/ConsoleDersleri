--22.03.2026 SQL View Exercise Solutions

use nortwinddb

--1) her bir üründe kaç adet satıldığını veren vw_UrunSatislari adında view yapınız
go
create view vw_UrunSatislari
as
select 
p.ProductID,
p.ProductName,
sum(od.Quantity) as ToplamSatisAdedi
from Products p
inner join [Order Details] od
on p.ProductID = od.ProductID
group by 
p.ProductID,
p.ProductName
go
select * from vw_UrunSatislari

--2) Her bir müşterini kaç ürün aldığını hesaplayan vw_MusteriUrunSayisi adında view yapınız
go
create view vw_MusteriUrunSayisi
as
select 
c.CustomerID,
C.ContactName,
sum(od.Quantity) as ToplamUrunSayisi
from customers as c
inner join orders as o
on c.CustomerID = o.CustomerID
inner join [Order Details] od on o.OrderID = od.OrderID
group by c.CustomerID,c.CompanyName,c.ContactName
go
select*from vw_MusteriUrunSayisi

--3)Her bir personelin getirdiği getiri toplamını hesaplayan vw_PersonelGetirileri adında view kodlayınız
--?

--4)Her bir klinikte kaç hastanın tedavi olduğunu bütün zamanlar için hesaplayan vw_KlinikHastaSayisi adında view kodlayınız
use HastahaneDB
go
create view vw_KlinikHastaSayisi
as
select
k.Adi as KlinikAdi,
count(distinct r.HastaId) as HastaSayisi
from Randevular r
inner join Doktorlar d on r.DoktorId = d.Id
inner join Klinikler k on d.Id = k.DoktorId
group by
k.Adi
go
select * from vw_KlinikHastaSayisi