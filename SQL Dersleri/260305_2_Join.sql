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
select o.OgrencilerID,o.OgrenciAdi,o.OgrenciSoyadi,o.SinifID from ogrenciler as o
left join Sınıflar as s on o.SinifID=s.SınıflarID
where s.SınıflarID is null

--2)Hangi sınıflara hanüz kayıt yapılamıştır 
select
S.SınıflarID,
S.SınıfNo,
S.SınıfSubesi
from sınıflar as s 
left join ogrenciler o on o.SinifID=s.SınıflarID
where o.OgrencilerID is null

--3)her bir öğrencinin aldığı ders sayısı
select 
O.OgrencilerID,
O.OgrenciAdi,
O.OgrenciSoyadi,
COUNT(od.DersID) as aldigiDersSayisi
from ogrenciler as o
left join OgrenciDers as od on od.OgrenciID = o.OgrencilerID
group by o.ogrencilerID,o.OgrenciAdi,o.OgrenciSoyadi
order by aldigiDersSayisi desc

--4)her bir velinin iletişimde olduğu öğrencisinin Sınıf öğretmerni bilgisi veli bilgi , öğrenci bilgisi veren script
select
v.VelilerID,
v.VeliAdi,
v.VeliSoyadi,
v.Telefon,
o.OgrencilerID,
o.OgrenciAdi,
o.OgrenciSoyadi,
og.OgretmenlerID,
og.OgretmenAdi,
og.OgretmenSoyadi
from veliler as v
inner join OgrenciVeli ov on ov.VeliID=v.VelilerID
inner join ogrenciler o on o.OgrencilerID=ov.OgrenciID
left join Sınıflar s on s.SınıflarID=o.SinifID 
left join Ogretmenler og on og.OgretmenlerID=s.OgretmenID 
order by v.VelilerID , o.OgrenciSoyadi

--5)en çok izin yapan 10 öğrencilerin bilgisi  ve öğrencilerin veli bilgisi listesini veriniz


