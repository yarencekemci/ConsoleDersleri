-- 26 mart 2026 sql dersleri
-- stored procedure
--kısaca sp olarak isimlendirilir SP ler performans konusunda iyidir. 
-- Saklı yordamlar olarak bilinir
--Saklı yordamlar olarak bilinir.
/*
SP lerin özellikleri
1-Performansları çok başarıldır. 
2-CRUD işlemleri SP ler ile yapılır
3-Parametre alır, döngü, karar yapıları , case when then yapıları kullanılabilir
*/
--Sp oluşturulması
use NorthwindDB
go
create procedure sp_Kategori_Urunler
as
begin
select
c.CategoryName , p.ProductName , p.UnitPrice , p.UnitsInStock
from Categories as c
join Products as p on p.CategoryId = c.CategoryID
end
go
-- SP ÇAĞIRILMASI
execute sp_Kategori_Urunler
--
go
create procedure sp_Kategori_Urun_Ara(@aranacakKelime nvarchar(100))
as
begin
select
c.CategoryName , p.ProductName , p.UnitPrice , p.UnitsInStock
from Categories as c
join Products as p on p.CategoryId = c.CategoryID
where p.ProductName like '%'+@aranacakKelime+'%'
end
go

--yaren