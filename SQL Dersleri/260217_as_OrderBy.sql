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
 --MS-SQL- Microst Structured(Mimari,yapý) Query(Sorgu) Language (Dil)
 --Sql bir programlama dili deðildir
 -- T-SQL=> Transact Sql
 --where,order by,top,operatörler,hazýr fonksiyonlar,group by, having, koþul,döngü,deðiþken tanýmý(declare), fonksiyon,view, stored procedure,trigger, create,update,delete,insert
 --where
 select *from Products where UnitPrice=10
 select ProductName, UnitPrice, UnitsInStock, QuantityPerUnit from Products where UnitPrice=10

 /*
 Operatörler
 <,>,=>,<=,=,+,-,*,/,% - c# ta olduðu gibi kullanýlýr
 and,or => and(&&) ve or(||) c# taki olduðu gibi ayný þekilde kullanýlýr

 in, betweem => ??

 */
 select * from Orders where ShipCountry<>'Brazil'--<> eþit deðildir
 select * from Orders where ShipCountry!='Brazil'--!= eþit deðildir
 select * from Products where UnitPrice<>10 and UnitsInStock>100 -- fiyatý 10 olmayan ve stoðu 100den büyük olan datalarý listeledik
 -- sayý sorgularý direkt yazýlýr ama metin için '' tek týrnak alýnmasý gereklidir
 --sýralama için order by kullanýlýr
 select * from Customers order by City
 select * from Customers order by City asc -- a'dan z'ye sýralama yapar
 select * from customers order by city desc -- descanding z'den a'ya sýralama yapar
 select top 15 *from customers order by city asc-- þehirlere göre a'dan z'ye sýralama ilk 15 detayý listeledik
 select top 15 CustomerID as Kod, CompanyName as [Firma Adý],ContactName as 'Yetkili Kiþi', City as þehir,Country as ülke from customers order by City
