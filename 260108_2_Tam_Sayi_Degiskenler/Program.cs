using System.ComponentModel;

namespace _260108_2_Tam_Sayi_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //değişken nedir?
            byte yas = 35; //0-255 arası
            short yil = 2026; 
            int mesafe = 75000; //10 basamaklı 
            long tcNO = 1234567891; // max 19 basamaklı değer alır

            sbyte negatifByte = -89;
            ushort pozitifShort = 65535; //0-65535 arası değer alır
            uint pozitifint = 1234567891; // 10 basamaklı
            ulong pozitifLong = 12345678912345678911; // 20 basamaklı

            //başlarındaki u usigned demek pozitif değer alır
            // değişken nedir?
            //proje içinde data,değer,... taşımak için kullanılan kod yapılarıdır.

            Console.WriteLine(negatifByte);
            Console.WriteLine(mesafe);
            //değişken yazma kuralları
            //1- başında sayı olamaz
            int sayi1 = 900;
            //2- boşluk ve özel karakter kullanılamaz. özel karakterlerden alt tire kullanılabilir sadece
            //int sayi 2 = 800; kullanılamaz
            //int sayi*2 = 800; kullanılamaz
            int sayi_2 = 800;
            //3) türkçe karakter kullanılamaz
            int sayı3 = 899; // hata vermez ama kullanılmaz
            //ğ,ü,ş,ı,ö,ç gibi karakter kullanılmaz
            //g,u,s,i,o,c gibi karakter kullanılır
        }
    }
}
