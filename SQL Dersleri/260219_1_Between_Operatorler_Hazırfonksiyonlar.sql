 /*
 ||=> or
  true or True=True
  true or False=True
  False or True=True
  False or False=False

 &&=> and
 True and True= True
 True and False= False
 False and True= False
 False and False= False
 */

use Nortwinddb

select * from Customers where Country='Germany' and City='Berlin'
Select * from Customers where Country='Germany' or Country='Mexico' or City='Sao Paulo'
---
Select * from Customers where Country in ('Germany', 'Mexico','Sou Paulo')-- in içerenleri getir
Select * from Customers where Country not in ('Germany', 'Mexico','Brazil') -- not içinde olmayanlarý getir
----------
-- is null, is not null
-- null - boþ
-- ' ' - boþ ama space tuþu ile müdahele edilen boþluk
-- => boþ
--null
select * from Customers where Region=''
select * from Customers where Region is null -- null olanlarý getirir. doðal olarak SQL ilk defa eklenirken müdahele edilmeyen data null olarak gelir
select * from Customers where Region is not null 

--between- aralýk filtrelemek için kullanýlýr
select * from Products 

select * from Products where UnitsInStock>=10 and UnitsInStock<=15
select * from Products where UnitsInStock>=10 and UnitsInStock<=15
select * from Products where UnitsInStock between 10 and 15 -- 10 ve 15 dahil ederek aralýk vermektedir

select * from Orders where OrderDate between '01.01.1996' and '12.31.1996'

---
--like => arama yapmak için kullanýlýr
select * from customers where ContactName like 'Maria' -- like ile beraber mutlaka % iþareti kullanýlmalýdýr. aksi halde eþittir gibi çalýþýr
select * from customers where ContactName = 'Maria' -- like ile % iþareti olmadan ayný anlama gelir
select * from customers where ContactName like 'Maria%' -- % iþareti hem baþ hem sonda olarak verildiðinde Maria geçen cümlenin ortasý,sonu,baþý yani neresinde Maria geçiyorsa getirir
select * from customers where ContactName like 'Mar%' -- ilk 3 harfi mar olan contactname datalarý getirir
-- 1996 yýlýnda olan sipariþleri like ile getirin
select * from Orders where orderDate like '%1996%'
--1998 olan sipariþler için Fransaya gidenleri listeleyiniz
select* from Orders where orderdate like '%1998%' and ShipCountry like '%France%'
--% iþareti baþta ise
select * from customers where ContactName like '%Mar' --son 3 harfi mar olanlarý getirir
--arama içinde _ kullanýlmasý
select * from Products where ProductName like 'c_a%' -- her bir alt tire bir bilinmeyen karaktere denk gelir
select * from Products where ProductName like 'c_to%' 
--like için soru çözümü yapýlacak

