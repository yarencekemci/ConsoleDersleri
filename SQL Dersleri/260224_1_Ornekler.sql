
-- 24.02.2026
-- where, like, order by, operatorler, top
use OkulDB
-- sınıflar tablosunu şubelerine göre sıralayınız
select * from Sınıflar order by SınıfSubesi;


--Kadın öğrenciler arasında en genç olan 5 tanesini gösteriniz
--Ad-soyad,doğum tarihi,TC,Adres,

select top 5
OgrenciAdi,
OgrenciSoyadi,
DogumTarihi,
OgrenciTC,
Adres
from Ogrenciler where Cinsiyeti = 'Kadın' and DogumTarihi is not null
order by DogumTarihi desc;

--Soyadı içinde d harfi olan  ve TC si olan erkek öğrencileri ad-soyad,adres, doğum tarihi listesini yapınız

select 
OgrenciTC,
OgrenciAdi,
OgrenciSoyadi,
Adres,
DogumTarihi
from Ogrenciler where Cinsiyeti = 'Erkek' and OgrenciSoyadi like '%d%' and (OgrenciTc is not null and OgrenciTC <> ' ')

--Bir okuldaki öğrencileri babalarına mesaj atılacaktır. Bu mesaj için TC,Telefon numarası gereklidir. 
--Bu şartlara göre veritabanından Veli adı,soyadı, Cinsiyet, TC, telefon  ve adres bilgilerini getiren scripti(SQL kodu) kodlayınız?
select 
VeliAdi,
VeliSoyadi,
Cinsiyet,
VeliTC,
Telefon,
Adres
from veliler where Cinsiyet = 'Erkek' and (VeliTC is not null and VeliTc <> ' ' ) and (Telefon is not null and Telefon <> ' ' )




