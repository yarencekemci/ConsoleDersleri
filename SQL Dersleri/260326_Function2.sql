-- 26 mart 2026 sql dersleri
-- function, tablo döndüren fonksiyonlar

use HastahaneDB

go
create function fnc_Carp (@sayi1 int, @sayi2 int)
returns int
as
begin
--kodlar
return @sayi1*@sayi2
end
go

select * from Randevular
select dbo.fnc_Carp(5,6)

select dbo.fnc_Carp(DoktorId,HastaId) , DoktorId, HastaId, tarih, saat, GeldiMi from Randevular
--tablo döndüren fonksiyonlar
select * from Hastalar
go
create function fnc_Hastalar(@cinsiyet nvarchar(10))
returns table
as
return (select*from Hastalar where Cinsiyet like '%'+@cinsiyet+'%')
go

-- table function kullanımı
select * from dbo.fnc_Hastalar('er')
select * from dbo.fnc_Hastalar('kadin')

-- KBB BÖLÜMÜ RANDEVU ALAN  HASTA,DOKTOR,RANDEVU BİLGİLERİNİ LİSTELEYİNİZ

select * from Randevular
select * from Doktorlar
select * from Randevular
select * from Klinikler
-------------
declare @brans nvarchar(20) = 'Dahiliye'
select
h.Adi as 'HastaAdi', h.Soyadi as 'HastaSoyadi', r.tarih,r.Saat,d.Adi as 'DoktorAdi',d.Soyadi as 'DoktorSoyadi',b.Adi as 'BransAdi'
from Randevular as r
inner join Doktorlar as d on d.Id=r.DoktorId
inner join Branslar as b on b.Id=d.BransId
inner join Hastalar as h on h.Id=r.HastaId
where b.Adi like '%'+@brans+'%'
go
create function fnc_BransaGoreRandevuAra(@brans nvarchar(20))
returns table
as
return (select
h.Adi as 'HastaAdi', h.Soyadi as 'HastaSoyadi', r.tarih,r.Saat,d.Adi as 'DoktorAdi',d.Soyadi as 'DoktorSoyadi',b.Adi as 'BransAdi'
from Randevular as r
inner join Doktorlar as d on d.Id=r.DoktorId
inner join Branslar as b on b.Id=d.BransId
inner join Hastalar as h on h.Id=r.HastaId
where b.Adi like '%'+@brans+'%')
go
select* from Branslar
select * from fnc_BransaGoreRandevuAra('dah')
select * from fnc_BransaGoreRandevuAra('orto')


-- hasta adına göre arama yapan, bulunan hastaların kaç randevusu olduğunu hasta bilgisi, randevu bilgisi veren fnc_HastaRandevuları adından function ile kodlayınız


declare @hastaadi nvarchar(100) = 'a'
select 
h.Adi as 'HastaAdi'
from Randevular as r 
inner join Hastalar as h on h.Id=r.HastaId
where h.Adi like '%'+ @hastaadi + '%'
go
create function fnc_HastaRandevulari(@hastaadi nvarchar(100))
returns table
as
return (select 
h.Adi as 'HastaAdi', h.Soyadi as 'HastaSoyadi' , r.Id , r.tarih, r.KayitTarihi
from Randevular as r 
inner join Hastalar as h on h.Id=r.HastaId
where h.Adi like '%'+@hastaadi+ '%')
go
select * from fnc_HastaRandevulari('a')


--yaren