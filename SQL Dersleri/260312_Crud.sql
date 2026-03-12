--- 21 mart perşembe
-- CRUD-> Create, Read, Update, Delete
-- DML - Data Manipulation Language
--Crud - Create(İnsert) , Read(List-Select), Update(Update), Delete(Delete)

use HastaneDB
select * from Doktorlar
select * from Branslar

insert into Doktorlar
(Adi,Soyadi,Cinsiyet,TC,Telefon,BransId,Adres,DogumYeri,GirisTarihi,CikisTarihi)
values
('Ayşe','Çiçek','Kadın','13412312312','435 456 56 56',1,'Pendik,İstanbul','01.01.1976','Sivas',GETDATE(),null)


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


