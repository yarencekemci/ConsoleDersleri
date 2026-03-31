--*******************************
--27 Mart 2026 SQL ÖDEVİ
--****************************************
use HastahaneDB

select * from Branslar
select * from Doktorlar
select * from Randevular

-- =========================================
-- 1) BRANSLAR
-- =========================================

go
create proc sp_Brans_Ekle
(
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin

declare @sayi int = (select count(Id) from Branslar where Adi=@adi)

if(@sayi>0)
	begin
		print 'Bu brans zaten var'
	end
else
	begin
		insert into Branslar (Adi,Aciklama) values (@adi,@aciklama)
	end

end
go

-- UPDATE
go
create proc sp_Brans_Update
(
@id int,
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin

declare @sayi int = (select count(Id) from Branslar where Adi=@adi)

if(@sayi>0)
	begin
		print 'Bu brans zaten var'
	end
else
	begin
		update Branslar 
		set Adi=@adi, Aciklama=@aciklama 
		where Id=@id
	end

end
go

-- 10 DATA
exec sp_Brans_Ekle 'Goz','Goz hastaliklari'
exec sp_Brans_Ekle 'Kardiyoloji','Kalp hastaliklari'
exec sp_Brans_Ekle 'Noroloji','Sinir sistemi'
exec sp_Brans_Ekle 'Ortopedi','Kemik hastaliklari'
exec sp_Brans_Ekle 'Cildiye','Deri hastaliklari'
exec sp_Brans_Ekle 'Psikiyatri','Ruh sagligi'
exec sp_Brans_Ekle 'KBB','Kulak burun bogaz'
exec sp_Brans_Ekle 'Genel Cerrahi','Ameliyat'
exec sp_Brans_Ekle 'Dahiliye','Ic hastaliklari'
exec sp_Brans_Ekle 'Fizik Tedavi','Rehabilitasyon'


-- =========================================
-- 2) DOKTORLAR
-- =========================================

go
create proc sp_Doktor_Ekle
(
@adSoyad nvarchar(250),
@bransId int
)
as
begin

declare @sayi int = (select count(Id) from Doktorlar where AdSoyad=@adSoyad)

if(@sayi>0)
	begin
		print 'Doktor zaten var'
	end
else
	begin
		insert into Doktorlar (AdSoyad,BransId) values (@adSoyad,@bransId)
	end

end
go

-- UPDATE
go
create proc sp_Doktor_Update
(
@id int,
@adSoyad nvarchar(250),
@bransId int
)
as
begin

declare @sayi int = (select count(Id) from Doktorlar where AdSoyad=@adSoyad)

if(@sayi>0)
	begin
		print 'Doktor zaten var'
	end
else
	begin
		update Doktorlar 
		set AdSoyad=@adSoyad, BransId=@bransId 
		where Id=@id
	end

end
go

-- 10 DATA
exec sp_Doktor_Ekle 'Ahmet Yilmaz',1
exec sp_Doktor_Ekle 'Mehmet Demir',2
exec sp_Doktor_Ekle 'Ayse Kaya',3
exec sp_Doktor_Ekle 'Fatma Aydin',4
exec sp_Doktor_Ekle 'Ali Can',5
exec sp_Doktor_Ekle 'Zeynep Arslan',6
exec sp_Doktor_Ekle 'Hasan Kurt',7
exec sp_Doktor_Ekle 'Elif Yildiz',8
exec sp_Doktor_Ekle 'Murat Oz',9
exec sp_Doktor_Ekle 'Selin Cakir',10


-- =========================================
-- 3) RANDEVULAR
-- =========================================

go
create proc sp_Randevu_Ekle
(
@hastaId int,
@doktorId int,
@tarih datetime,
@aciklama nvarchar(max)
)
as
begin

declare @sayi int = (
select count(Id) from Randevular 
where HastaId=@hastaId and DoktorId=@doktorId and Tarih=@tarih
)

if(@sayi>0)
	begin
		print 'Bu randevu zaten var'
	end
else
	begin
		insert into Randevular (HastaId,DoktorId,Tarih,Aciklama)
		values (@hastaId,@doktorId,@tarih,@aciklama)
	end

end
go

-- UPDATE
go
create proc sp_Randevu_Update
(
@id int,
@hastaId int,
@doktorId int,
@tarih datetime,
@aciklama nvarchar(max)
)
as
begin

declare @sayi int = (
select count(Id) from Randevular 
where HastaId=@hastaId and DoktorId=@doktorId and Tarih=@tarih
)

if(@sayi>0)
	begin
		print 'Bu randevu zaten var'
	end
else
	begin
		update Randevular
		set HastaId=@hastaId,
			DoktorId=@doktorId,
			Tarih=@tarih,
			Aciklama=@aciklama
		where Id=@id
	end

end
go


exec sp_Randevu_Ekle 1,1,'2026-03-27 09:00','Kontrol'
exec sp_Randevu_Ekle 2,2,'2026-03-27 10:00','Muayene'
exec sp_Randevu_Ekle 3,3,'2026-03-27 11:00','Test'
exec sp_Randevu_Ekle 4,4,'2026-03-27 12:00','Kontrol'
exec sp_Randevu_Ekle 5,5,'2026-03-27 13:00','Muayene'