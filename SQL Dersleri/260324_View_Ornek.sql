-- 24.03.2026 sql dersleri
-- view örnek
 
use NorthwindDB

-- her bir kategoride kaç ürün satıldığını hesaplayan vw_Categori_Order_Detail adında view içinde kodlayınız
--pro Id, pro name



select 
c.CategoryID,c.CategoryName,sum(Quantity) as 'Product sum'
from Categories as c
join Products as p on p.CategoryID=c.CategoryID
join[Order Details] as od on od.ProductID=p.ProductID
group by c.CategoryID, c.CategoryName
go
create view vw_Categori_Order_Detail
as
select 
c.CategoryID,c.CategoryName,sum(Quantity) as 'Product sum'
from Categories as c
join Products as p on p.CategoryID=c.CategoryID
join[Order Details] as od on od.ProductID=p.ProductID
group by c.CategoryID, c.CategoryName
go
select * from vw_Categori_Order_Detail



