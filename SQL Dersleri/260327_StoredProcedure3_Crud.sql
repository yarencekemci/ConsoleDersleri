--*******************************
--27 Mart 2026 SQL Dersleri
--****************************************
--SP ile CRUD islemleri
--SP ile Insert, Update, Delete islemlerinin yapilmasi
use hastahanedb

select * from doktorlar
select * from branslar

insert into Branslar (Adi, Aciklama) values ('Goz','Uzmanlik alanda hizmet verir')

go
create proc sp_Brans_Ekle
(
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin
insert into Branslar (Adi,Aciklama) values (@adi,@aciklama)
end
go

execute dbo.sp_Brans_Ekle 'Goz','test1'
select * from branslar

--ayni data insert edilmesini engellemek icin asagidaki islemi SP ye alter yaparak uygulayalim
go
alter proc sp_Brans_Ekle
(
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin

declare @dataSayisi int = (select COUNT(Id) from Branslar where Adi=@adi)

if(@dataSayisi>1)
	begin
		print 'Bu data DB de mevcut'
	end
else
	begin
		insert into Branslar (Adi,Aciklama) values (@adi,@aciklama)
	end
end
go

--Update ile sp 
go
create proc sp_Brans_Update
(
@id int,
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin
declare @dataSayisi int = (select COUNT(Id) from Branslar where Adi=@adi)

if(@dataSayisi>0)
	begin
		print 'Bu data DB de mevcut'
	end
else
	begin
		update Branslar set Adi=@adi, Aciklama=@aciklama where Id=@id
	end
end
go

select * from Branslar
exec sp_Brans_Update 5,'Fizik Tedavi-3','teknisyen fizyoterapist bakmaktadir'

go
alter proc sp_Brans_Update
(
@id int,
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin
-- Exists => data varsa true, yoksa false verir
if (exists(select * from Branslar where Adi=@adi))
	begin
		print 'Bu data DB de mevcut'
	end
else
	begin
		-- ic ice if-else bloklari SQL icinde kullanilir
		if (exists(select * from Branslar where Id=@id))
		begin
			update Branslar set Adi=@adi, Aciklama=@aciklama where Id=@id
		end
		else
		begin
			print 'Bu Id degerinde bir Brans yok'
		end
	end
end
go

exec sp_Brans_Update 69,'Fizik Tedavi-5','teknisyen fizyoterapist bakmaktadir'

--CRUD konusunda yapilan odevler icin sp yapilacak
/*
--30 tane Randevular, diger tablolar icin 10'er tane data SP yapilarak eklenecek
Kosul-1) her tablo icin SP update islemi de yapilacak
Kosul-2) tekrarlayan data eklemesi engellenecek (Insert-Update icin ayri ayri yapilacak)
*/