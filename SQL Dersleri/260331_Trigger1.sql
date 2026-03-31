-- 31 Mart 2026 Sql Dersleri
-- Trigger - Tetikleyici
-- bir tabloya data eklerken, güncellerken ya da silerken o tabloda SQL tarafında başka işlemlerin de gerçekleşmesini sağlayan yapılardır. 
-- Her tablo altında trigger klasörü bulunmaktadır. Trigger'lar tabloya özgü olduğundan tablo altında kayıt edilir

use NorthwindDB

select * from Products

go
create trigger trg_DogumGunu
/*
on [table_name] - tablo adı
[before | after] - gerçeklemesini istediği işlem öncesi/sonrası
{insert | update | delete } işlem adı. Tabloda hangi işlem olurken çalışması isteniliyorsa o yazılır
*/

on employees
after insert 
as
begin
-- ===========
declare @dogumGunu datetime
declare @id int
select @dogumGunu= BirthDate, @id = EmployeeID from inserted
update Employees set sayac = 365 where EmployeeID= @id
end
go
-- ============
select * from Employees

insert into Employees
values ('Snippe', 'Angela','Sales', 'Ms', '02.03.1965', '5.5.1994', 'test', 'California', null, 'ad-654', 'USA', '544', 655, null, 'test', 2, null, null )

/*
mesaj ekranı:
(1 row affected) -- insert için

(1 row affected)-- trigger için

Completion time: 2026-03-31T19:54:48.6741032+03:00
*/

select * from orders
go
create trigger trg_StokKontrol
on [Order Details]
after insert
as
begin
declare @satilanStok int
declare @productId int

select @satilanStok= Quantity, @productId= productId from inserted

declare @mevcutStok int =(select UnitsInStock from Products where ProductID= @productId)

if(@mevcutStok>= @satilanStok)
	begin
	update Products set UnitsInStock=UnitsInStock-@satilanStok where ProductId=@productId
	end
else
	begin
	print 'Product tablosunda yeterli stoğunuz yok'
	end
end
go
insert into [Order Details] (OrderId,ProductID,UnitPrice,Quantity,Discount) values(10332,6,19,21,0)
select * from [Order Details] where OrderID= 10332
select * from Products where ProductId in (18,42,47,2,3,6,10,13) --120
insert into [Order Details] (OrderId, ProductID, UnitPrice, Quantity, Discount) values (10332,10,19,1,0.10)
insert into [Order Details] (OrderId, ProductID, UnitPrice, Quantity, Discount) values (10332,13,19,30,0.10) -- trigger before özelliği ile verilmesi gereklidir
-- stok o zaman istenilen şekilde ayarlanabilir, fazla stok verilmez

--order details tablosunda insert yapılırken discount verildiğinde 
--verilen fiyat üzerinde discount kadar indirim yapılarak yeni fiyat UnitPrice kolonunda gösteriniz
select * from [Order Details]
go
create trigger trg_IndirimUygula
on [Order Details]
after insert
as
begin
declare @indirimOrani decimal(5,2)
declare @satisFiyati decimal(18,2)
declare @productId int
declare @orderId int

select @indirimOrani= Discount, @satisFiyati= UnitPrice, @productId= ProductId, @orderId = OrderId from inserted

update [Order Details] set UnitPrice=UnitPrice-UnitPrice*Discount where OrderId= @orderId and ProductId= @productId

end
go
select * from [Order Details] where OrderID=10248

insert into [Order Details] (OrderID, ProductID, UnitPrice,Quantity,Discount) values (10248,2,19,7,0.15)


/*
(1 row affected) -- insert

(1 row affected) --trigger

(1 row affected) -- trigger

Completion time: 2026-03-31T21:04:57.0766917+03:00
*/