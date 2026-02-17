-- yorum satýrý - tek satýrlýk 
/*
çoklu
yorum
satýrý
*/

use Nortwinddb -- DB (Database) çaðýrmak için use kullanýlýr

select * from Products  -- Nortwind DB altýnda Products tablosundaki data (veri) larý listeler
-- select- seçmek
-- * bütün kolonlarý getirir, hepsi demek
-- from- den dan, tablo(tablo adý)'dan
-- Products- tablo
-- bir tabloda istenilen kadar data çekmek
select ProductID, ProductName, UnitPrice, UnitsInStock from Products

-- ctrl+R- Sonuç penceresini göster- gizle
-- execute - seçim+f5 = seçimi çalýþtýr - eðer seçim yapmadan execute-f5 yaparsanýz bütün sayfadaki kodlar çalýþtýrýlýr

select * from Customers
--sql küçük büyük harf duyarlýlýðý yoktur

select 
CustomerId as Kod,
Companyname as 'Firma Adý',
ContactName as 'Ýletisim isminde kisi',
Address as[Adres],
City as 'Sehir', Country as Ülke
from Customers

--personel (Employee) tablosunda Adý,soyad, doðum tarihi, þehir, ülke kolonlarýný getirip kolonlarý TR ile gösteriniz?
 --Sipariþler(Order) tablosunda Sipariþ tarihi(OrderDate), Kargo maliyeti(Freight),Nakliye þehri,ülkei(shipCity,ShipCountry)þeklinde listeleyiniz

 select FirstName as ad,  LastName as soyadý, BirthDate as 'Doðum Tarihi', City as þehir, Country as Ülke
 from Employees


 select ShippedDate as [Sipariþ Tarihi], Freight as [Kargo Maliyeti], ShipCity as 'Nakliye Þehri', ShipCountry as [Nakliye Ülkesi] 
 from Orders 
