--- 21 şubat perşembe
-- CRUD-> Create, Read, Update, Delete
-- DML - Data Manipulation Language
--Crud - Create(İnsert) , Read(List-Select), Update(Update), Delete(Delete)

use HastaneDB
select * from Doktorlar
select * from Branslar

insert into Doktorlar
(Adi, Soyadi, Cinsiyet, TC, BransId, Klinik, Adres, DogumYeri, GirisTarihi, CikisTarihi, Telefon, Email, Aciklama)
values
('Ayşe', 'Çiçek', 'Kadın', '13412312312', 1, 'KBB', 'Pendik, İstanbul', 'Sivas', GETDATE(), null, '4354565656', 'ayse@mail.com', null)


insert into Branslar (Adi,Aciklama) values ('KBB',null)
insert into Branslar (Adi,Aciklama) values ('Dahiliye',null)
insert into Branslar (Adi,Aciklama) values ('Ortopedi',null)

insert into Doktorlar
(Adi,Soyadi,Cinsiyet,TC,Telefon,BransId,Adres,DogumYeri,GirisTarihi,CikisTarihi)
values
('Mehmet','Yıldız','Erkek','34543467896','455 356 56 56',2,'İstanbul, Alperen Sokak Kartal','Antalya',GETDATE(),null)

--Dahiliye
insert into Doktorlar (Adi,Soyadi,Cinsiyet,TC,Telefon,BransId,Adres,DogumYeri,GirisTarihi,CikisTarihi)
values
('Ülkü','Erden','Kadın','10247565678','05446667656',3,'Salman Mahallesi, Konyalı sokak Kartal','Van',GETDATE(),null)

insert into Doktorlar (Adi,Soyadi,Cinsiyet,TC,Telefon,BransId,Adres,DogumYeri,GirisTarihi,CikisTarihi)
values
('Ömer','Erden','Erkek','19876565678','05543667656',4,'Kahtalı, Konyalı sokak Kartal','Van',GETDATE(),null)
--yaren
--5 tane klinik giriniz
insert into klinikler 
values
('KBB',null,5),
('KBB-2',null,4),
('Dahiliye',null,11),
('Dahiliye-2',null,10),
('Ortopedi-2',null,8)

--Data güncelleme
select * from Branslar
select * from Klinikler
select * from Doktorlar

update Doktorlar set Email='ayse@gmail.com',Aciklama='test data eklemesi' where ID=4

--her bir tabloya 5 data, randevular tablosuna da 30 data ekleyiniz
--doktorlar
insert into Doktorlar
(Adi,Soyadi,Cinsiyet,TC,BransId,Klinik,Adres,DogumYeri,GirisTarihi,CikisTarihi,Telefon,Email,Aciklama)
values
('Mehmet','Yıldız','Erkek','23412312312',2,'Dahiliye','Kartal, İstanbul','Antalya',GETDATE(),null,'5324565656','mehmet@mail.com',null),
('Fatma','Kaya','Kadın','33412312312',3,'Ortopedi','Maltepe, İstanbul','İzmir',GETDATE(),null,'5334565656','fatma@mail.com',null),
('Ali','Demir','Erkek','43412312312',1,'KBB','Kadıköy, İstanbul','Bursa',GETDATE(),null,'5344565656','ali@mail.com',null),
('Zeynep','Şahin','Kadın','53412312312',2,'Dahiliye','Üsküdar, İstanbul','Ankara',GETDATE(),null,'5354565656','zeynep@mail.com',null)

--
-- branslar
insert into Branslar (Adi,Aciklama)
values
('KBB','Kulak burun boğaz hastalıkları'),
('Dahiliye','İç hastalıkları'),
('Ortopedi','Kemik ve eklem hastalıkları'),
('Kardiyoloji','Kalp ve damar hastalıkları'),
('Nöroloji','Sinir sistemi hastalıkları') 
--hastalar
insert into Hastalar
(Adi,Soyadi,TC,Telefon,Email,Adres,KayitTarihi,DogumTarihi,DogumYeri,Cinsiyet,Aciklama)
values
('Ahmet','Kara','12345678901','05321234567','ahmet@mail.com','Kartal, İstanbul',GETDATE(),'1990-05-12','Ankara','Erkek',null),
('Elif','Yılmaz','12345678902','05332234567','elif@mail.com','Pendik, İstanbul',GETDATE(),'1995-07-20','İzmir','Kadın',null),
('Mustafa','Demir','12345678903','05343234567','mustafa@mail.com','Maltepe, İstanbul',GETDATE(),'1988-03-15','Bursa','Erkek',null),
('Zeynep','Aydın','12345678904','05354234567','zeynep@mail.com','Kadıköy, İstanbul',GETDATE(),'1992-11-08','Antalya','Kadın',null),
('Mert','Çelik','12345678905','05365234567','mert@mail.com','Üsküdar, İstanbul',GETDATE(),'1997-01-25','Adana','Erkek',null)
select * from Branslar
select * from Hastalar
--Klinikler
insert into Klinikler (Adi,Aciklama,DoktorID)
values
('KBB','Kulak burun boğaz kliniği',4),
('Dahiliye','İç hastalıkları kliniği',5),
('Ortopedi','Kemik ve eklem kliniği',6),
('KBB-2','KBB ikinci klinik',7),
('Dahiliye-2','Dahiliye ikinci klinik',8)
select * from Klinikler
--Kullanıcılar
insert into Kullanicilar
(KullaniciAdi,Adi,Soyadı,Sifre,YetkiId,AktifMi,OlusturanID,KayitTarihi)
values
('admin','Ahmet','Kara','123456',1,1,null,GETDATE())
select * from Kullanicilar
insert into Kullanicilar
(KullaniciAdi,Adi,Soyadı,Sifre,YetkiId,AktifMi,OlusturanID,KayitTarihi)
values
('eyilmaz','Elif','Yılmaz','123456',2,1,13,GETDATE()),
('mdemir','Mehmet','Demir','123456',2,1,13,GETDATE()),
('zaydin','Zeynep','Aydın','123456',3,1,13,GETDATE()),
('mcelik','Mert','Çelik','123456',3,1,13,GETDATE())
--Personeller
insert into Personeller
(Adi,Soyadi,TC,KayitTarihi,Adres,Telefon,GorevTanimi,Aciklama,AktifMi)
values
('Ahmet','Kara','12345678901',GETDATE(),'Kartal, İstanbul','05321234567','Sekreter','Test personel kaydı',1),
('Elif','Yılmaz','12345678902',GETDATE(),'Pendik, İstanbul','05332234567','Hemşire','Test personel kaydı',1),
('Mehmet','Demir','12345678903',GETDATE(),'Maltepe, İstanbul','05343234567','Teknik Personel','Test personel kaydı',1),
('Zeynep','Aydın','12345678904',GETDATE(),'Kadıköy, İstanbul','05354234567','Hasta Kayıt','Test personel kaydı',1),
('Mert','Çelik','12345678905',GETDATE(),'Üsküdar, İstanbul','05365234567','Güvenlik','Test personel kaydı',1)
--Yetkiler
insert into Yetkiler (YetkiAdi)
values
('Admin'),
('Doktor'),
('Sekreter'),
('Personel'),
('Hasta Kabul')
--randevular
select Id, Adi, Soyadi from Doktorlar --4,5,6,7,8,
select Id, Adi, Soyadi from Hastalar --1,2,3,4,5

insert into Randevular
(Tarih,Saat,DoktorId,HastaId,KayitTarihi,GeldiMi,Olusturan)
values
('2026-03-20','09:00',4,1,GETDATE(),1,13),
('2026-03-20','09:30',5,2,GETDATE(),0,13),
('2026-03-20','10:00',6,3,GETDATE(),1,13),
('2026-03-26','09:00',4,1,GETDATE(),1,13),
('2026-03-26','09:30',5,2,GETDATE(),0,18),
('2026-03-26','10:00',6,3,GETDATE(),1,19),
('2026-03-26','10:30',7,4,GETDATE(),0,20),
('2026-03-26','11:00',8,5,GETDATE(),1,21),
('2026-03-25','09:00',4,5,GETDATE(),1,21),
('2026-03-25','09:30',5,1,GETDATE(),0,13),
('2026-03-25','10:00',6,2,GETDATE(),1,18),
('2026-03-25','10:30',7,3,GETDATE(),0,19),
('2026-03-25','11:00',8,4,GETDATE(),1,20),
('2026-03-23','09:00',4,3,GETDATE(),1,19),
('2026-03-23','09:30',5,4,GETDATE(),0,20),
('2026-03-23','10:00',6,5,GETDATE(),1,21),
('2026-03-23','10:30',7,1,GETDATE(),0,13),
('2026-03-23','11:00',8,2,GETDATE(),1,18),
('2026-03-27','09:00',4,1,GETDATE(),1,13),
('2026-03-27','09:30',5,2,GETDATE(),0,18),
('2026-03-27','10:00',6,3,GETDATE(),1,19),
('2026-03-27','10:30',7,4,GETDATE(),0,20),
('2026-03-27','11:00',8,5,GETDATE(),1,21),
('2026-03-28','09:00',4,2,GETDATE(),1,18),
('2026-03-28','09:30',5,3,GETDATE(),0,19),
('2026-03-28','10:00',6,4,GETDATE(),1,20),
('2026-03-28','10:30',7,5,GETDATE(),0,21),
('2026-03-28','11:00',8,1,GETDATE(),1,13),
('2026-03-29','09:00',4,3,GETDATE(),1,19),
('2026-03-29','09:30',5,4,GETDATE(),0,20)

select * from Randevular
select count(*) from Randevular