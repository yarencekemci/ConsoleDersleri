--24.02.2026
--Hazır fonksiyonlar, group by, having

use nortwinddb
-- hazır fonksiyonlar
-- max,min,count(sayar ama null değilse),sum(toplama işlemi yapar),avarage(AVG-ortalama alır),

select * from Products order by UnitPrice
select top 1 *from Products order by UnitPrice -- asc oto vardır. Fiyatı en düşük olandan getirir
select top 1 *from Products order by UnitPrice desc -- fiyatı en yüksek olandan getirir

select MIN(UnitPrice) as 'Min Fiyat' from Products
select MAX(UnitPrice) as 'Max Fiyat' from Products 
select sum(UnitPrice) as 'Fiyat Toplamı' from Products 
select sum(UnitPrice) as 'Sayı' from Products -- Count sadece dolu kolonları getirir, null olanları saymaz, bu nedenle kullanılmasına
--dikkat edilmelidir
-- count(*) yıldız ile kullanımı bütün kolonları say demektir, bu garanti bir yoldur sayma işlemi olur ama performans konusunda iyi bir seçim değildir (yıldız yazmak)

select * from Products
select count(ProductID) from Products --80
select Count (categoryID) from Products -- 78 sonuç geldi çünkü CategoryId için 2 data null içerir
select count(*) from products
----

select top 1 * from products order by UnitPrice
select min(UnitPrice) as 'Min Fiyat' from products
select ProductName, MIN(UnitPrice) AS 'Min Fiyat' FROM Products

--group by
