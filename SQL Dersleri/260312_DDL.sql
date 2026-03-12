--- 21 mart perşembe
-- CRUD-> Create, Read, Update, Delete
--DFL - data definiton langue yapısı create,alter drop ile tablo işlemleri yapmaktır
use HastaneDB
--tabloyu create ile yapmak
go
create table Deneme
(
ID int Identity(1,1) not null,
Adi nvarchar(250) not null,
Soyadi nvarchar(250) not null,
Constraint PK_Deneme Primary Key clustered
(ID asc)
);
go

-- olan tabloya kolon eklemek için alter kullanılır
alter table Deneme
add Adres nvarchar(MAX) null;

--tabloyu komple silmek için (DROP TABLOADI)
drop table Deneme
