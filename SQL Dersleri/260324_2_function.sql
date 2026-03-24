-- 24.03.2026
--sql'de function

--fonksiyon nedir?
--tablolar,kolonlar üzerinde işlem yapmak için kullanılır
--değer verir(döndürür), parametre alır
--kolon işlemleri için kullanılan function(fonksiyonlar)
--*************
--function oluşturma
go
create function fnc_Topla(@sayi1 int, @sayi2 int)
returns int -- değer döndüreceği veri tipini returns anahtar kelimesi ile verilmelidir
as-- kod gövdesinin başladığını gösterir
begin -- başla {
declare @sonuc int -- declare - değişken tanımlayınca kullanılır
--@sonuc - değişken, int  veri tipi
set @sonuc = @sayi1 + @sayi2 -- sqlde bir değişken değer atarken, işlem yaparken set anahtar kelimesi kullanılır
return @sonuc
--return @sayi1 + @sayi2 -- kısa olarak bu şekilde tanımlanabilir
end -- bitir
go
--bu işlemi execute yaptıktan sonra programmability/function/scalar-valued functions klasörü altında fnc_Tablo adında bir function oluşacaktır
--scalar(tekil-tek) valued(değer) döndüren anlamına gelir
--function kullanımı ve çağrılması
select dbo.fnc_Topla(5,6),dbo.fnc_Topla(-9,582)
select * from Products
--fiyata belli bir zam yapan function kodlayalım
select ProductName,UnitPrice,(UnitPrice +UnitPrice*10/100 ) from products
go
create function fnc_Zam(@zamOran decimal(5,2),  @fiyat decimal(18,2))
returns decimal(18,2)
as
begin
--unitprice + unitprice *10/100
return @fiyat + @fiyat*@zamoran/100
end
go

select dbo.fnc_Zam(10,100)
select
ProductName,
UnitPrice,
dbo.fnc_Zam(10,UnitPrice) as 'Zam %10',
dbo.fnc_Zam(25,UnitPrice) as 'Zam %25'
from Products

