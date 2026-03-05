use OkulDB
select * from Sınıflar
--her bir sınıfta kaç öğrenci olduğunu hesaplayınız

select s.SınıfNo, s.SınıfSubesi, Count(OgrencilerID) as OgrenciSayisi from Sınıflar s 
join Ogrenciler o on s.SınıflarID=o.SinifID
Group by s.SınıfSubesi, s.SınıfNo

----Her bir bölümde kaç öğrenci olduğunu hesaplayınız
select * from Bolumler

select  b.BolumAdi, Count(o.OgrencilerID) as OgrenciSayisi from bolumler as b 
inner join Sınıflar as s on s.BolumID=b.BolumlerID
inner join Ogrenciler as o on o.OgrencilerID=s.SınıflarID
group by b.BolumAdi
--
select 
b.BolumlerID,b.BolumAdi, Count(b.BolumlerID)
from bolumler as b
join sınıflar as s on s.BolumID=b.BolumlerID
join Ogrenciler as o on s.SınıflarID= o.SinifID
group by b.BolumlerID,b.BolumAdi
order by BolumlerID

--ÖDEVLER
--1)hangi öğrencilerin sınıf ataması olmamıştır
--2)Hangi sınıflara hanüz kayıt yapılamıştır
--3)her bir öğrencinin aldığı ders sayısı
--4)her bir velinin iletişimde olduğu öğrencisinin Sınıf öğretmerni bilgisi veli bilgi , öğrenci bilgisi veren script
--5)en çok izin yapan 10 öğrencilerin bilgisi  ve öğrencilerin veli bilgisi listesini veriniz
