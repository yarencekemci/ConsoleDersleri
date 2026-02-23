---20 Şubat Cuma 2026 
--like sorular

use nortwinddb

select *from Customers
--başta %,sonda %,_ işareti ile karakter sayımı
--Ülkesi içinde swe olan ve şehri için br geçen müşterileri listeleyiniz
select *from Customers where Country like '%swe%' and City like '%br%'
select *from Products

--Ürün adı içinde 3.harfi i ve 4. harfi c olan ve stok değerleri 0(dahil)-10(dahil)  arasında olanları Name, Stok, Price kolonlarını TR yaparak ürünleri listeleyiniz
select 
ProductName 'Ürün Adı',
UnitsInStock Stok,
UnitPrice Fiyat
from Products where ProductName like '__ic%' and UnitsInStock>=0 and UnitsInStock<=10
--aralık için between kullanalım
select 
ProductName 'Ürün Adı',
UnitsInStock Stok,
UnitPrice Fiyat
from Products where ProductName like '__ic%' and UnitsInStock between 0 and 10
-------------------------------------------------
--Genel Tekrar soruları
--Aliases, kolon adı,select, from, Tablo adı, where(koşul kelimesi), Operatörler(<,>,<=,>=,!=,<>(Eşit değildir),=,between,and,or,in,not in, is null,is not null, order by (sıralama),like (% yeri, _ konumu))
--ürün fiyatları 15-25 arasında olan ürünleri fiyatına göre küçükten büyüğe doğru Ad,Stok, Fİyat , Birim Tanımı (QuantityPerUnit) şeklinde listeleyiniz?
--
--1)ürün fiyatları 15-25 arasında olan -OK
--2)ürünleri fiyatına göre küçükten büyüğe doğru-OK
--3)Ad,Stok, Fİyat , Birim Tanımı (QuantityPerUnit) -
--şeklinde listeleyiniz?
select 
ProductName as Ad,
UnitsInStock as 'Stok',
UnitPrice 'Birim Fiyat',
QuantityPerUnit [Birim Tanımı]
--from Products where UnitPrice >=15 and UnitPrice<=25 order by UnitPrice --asc default atar
--operatör yerine between kullanalım
from Products where UnitPrice between 15 and 25 order by UnitPrice --asc default atar
select*from Products
--ürün stokları 100 üzerinde olan ürünleri , ürün isimlerine göre  a'dan z'ye sıralayınız?
--Ad,Birim Fiyat, Stok, Birim Tanımı , Üretimdemi(Discontinued)

select 
ProductName as Ad,
UnitPrice  as'Birim Fiyat',
UnitsInStock as Stok,
QuantityPerUnit as [Birim Tanımı],
Discontinued Üretimdemi
from Products where UnitsInStock>100 order by ProductName
----------------------------------------------------------------------------
--top kullanımı
select *from Products order by UnitPrice--ürünler fiyata göre küçükten büyüğe doğru sıralar
select *from Products order by UnitsInStock--
select *from Orders order by Freight --
--Orders Siparişler, freight kargo bedeli

select *from Customers order by CompanyName-- a-z
select *from Products --ürünleri listeler
order by UnitPrice --fiyatı küçükten büyüğe doğru
--en düşük fiyta sahip olan ilk 5 ürün
select top 5 *from Products --ürünleri listeler
order by UnitPrice --fiyatı küçükten büyüğe doğru

--en yüksek fiyata sahip 5 ürün
select top 5  *from Products --ürünleri listeler
order by UnitPrice desc--fiyatı  büyükten küçüğe doğru
--en genç 3 personelin adı,soyadı, Doğum Tarihi,address,Şehir ve ülkesini gösterini
select 
top 3 
FirstName Adı,
LastName Soyadı,
BirthDate 'Doğum Tarihi',
Address as Adres,
City Şehir,
Country Ülke
from Employees order by BirthDate desc
/*
Console Ödevi
Onur	=> %90-95
Yağız	=>%90-95
Ahmet	=>%85-90
*/