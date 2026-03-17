--View

--View maddeler
--1)View sanal tablolardır. Sanal tablo tablo gibi çalışır, tablo gibi datayı anlık olarak tutmayabilir
--2)View hantaldır. Proje içerisinde performans açısından hantal olduğu için kullanımı pek tercih edilmez
--3)View script saklamak için kullanılır. Database ile beraber taşınır. Bir script için bu saklama açısından çok iyi bir yöntemdir.
--4)parametre almaz (C# methodlar alırdı değer döndüren/döndürmeyen), değer döndürmez (void method).
--5) kesinlikler crud işlemleri yapılamaz

--soru: her kliniğe hangi doktor baktığını klinik , doktor bilgisi veren script
--view yazmadan önce view için gerekli olan script yazılır sonrasında view içine taşınır

use HastahaneDB

select distinct
k.Adi,d.Adi,d.Soyadi
from Klinikler as k
inner join Doktorlar as d on d.ID=k.DoktorID

--her yeni nesne(tablo,view,stred procedure,trigger) create yaparken 2 go arasında yazılır
--view oluşturmak için create kullanılır
go
create view vw_Doktor_Klinik_x --view oluşturmak için yapılan ilk isim yapısı
as--view kod gövdesinin başladığını gösterir
--script başlangıcı
select distinct
k.Adi as klinik,d.Adi as doktor,d.Soyadi as 'doktor soyadi'
from Klinikler as k
inner join Doktorlar as d on d.ID=k.DoktorID
--script bitiş
go

--view kullanmak
select * from vw_Doktor_Klinik

--olan bir view'in kolonlarını ya da yeni nesneler eklemek için alter kullanılır.
go
alter view vw_Doktor_Klinik
as
select distinct
k.Adi as klinik,d.Adi as 'doktor adi',d.Soyadi as 'doktor soyadi'
from klinikler as k
inner join Doktorlar as d on d.ID=k.DoktorID
--order by 1 desc= view içinde order by kullanılmaz
go
--tablo ile yapılan her şeyi view ile yapabilirsiniz
select * from vw_Doktor_Klinik
select Klinik,[doktor adi] from vw_Doktor_Klinik
where [doktor adi] like '%a%'

--her bir doktorun kaç randevusu olduğunu doktor bilgisi, randevu sayısı şeklinde hesaplayan 
--vw_Doktor_Randevu_Sayisi adında view yaparak kodlayınız
go
create view vw_Doktor_Randevu_Sayisi
as
select 
d.Id, d.Adi as 'Doktor Adi' , d.Soyadi as 'Doktor Soyadi', Count(r.Id) as 'Randevu sayisi'
from doktorlar d 
inner join Randevular r on d.Id= r.DoktorId
group by d.Id, d.Adi, d.Soyadi
go

select * from vw_Doktor_Randevu_Sayisi 
go
alter view vw_Doktor_Randevu_Sayisi
as
select 
d.Adi as 'Doktor Adi', d.Soyadi as 'Doktor Soyadi', Count(r.Id) as 'Randevu sayisi'
from Randevular as r
inner join Doktorlar as d on d.Id=r.DoktorID
group by d.Id, d.Adi, d.Soyadi
go
--drop (silme işlemi) /drop ile olan view silinir
drop view [dbo].[vw_Doktor_Klinik]

--3'ten fazla randevusu olan doktorların hangi hastalara randevusu olduğunu hesaplayınız?
--subquery kullanılmayacak

select DoktorId, Count(Id)as 'Randevu Sayısı'
from Randevular
group by DoktorID
having Count(Id)>3 
go
create view vw_Doktor_Randevu_SubQuery
as
select 
DoktorId, Count(Id)as 'Randevu Sayısı'
from Randevular
group by DoktorID
having Count(Id)>3 
go
--
select 
d.Adi, d.Soyadi,h.Adi, h.Soyadi, r.tarih,r.Saat
from vw_Doktor_Randevu_SubQuery as vw
inner join Doktorlar as d on d.Id=vw.DoktorId
inner join Randevular as r on r.Id=d.Id
inner join Hastalar as h on h.Id=r.HastaId

--ÖDEVLER
--Northwnd  için
--1) her bir üründe kaç adet satıldığını veren vw_UrunSatislari adında view yapınız
--2) Her bir müşterini kaç ürün aldığını hesaplayan vw_MusteriUrunSayisi adında view yapınız
--3)Her bir personelin getirdiği getiri toplamını hesaplayan vw_PersonelGetirileri adında view kodlayınız
--HastaneDB için
--4)Her bir klinikte kaç hastanın tedavi olduğunu bütün zamanlar için hesaplayan vw_KlinikHastaSayisi adında view kodlayınız

