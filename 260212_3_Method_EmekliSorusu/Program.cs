using System.Runtime.InteropServices;

namespace _260212_3_Method_EmekliSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
  Bir ülkede emeklilik hesabı cinsiyet,yaş,prim gün sayısı(Çalıştığı gün sayısı) şartlarına göre hesaplanıp emekli edilmektedir 
 Eğer Cinsiyet kadın ise
 yaş 60 ve üstü ise, prim 7300 ise kişi maaşının 15 katı kadar ikramiye alarak emekli ediliyor

 Eğer Cinsiyet erkek ise
 yaş 65 ve üstü ise, prim 8500 ise kişi maaşının 17.5 katı kadar ikramiye alarak emekli ediliyor 

 bu şartlara kişi emekli ise alacağı ikramiye, emekli değilse emekli olmama nedenini veren yapıyı kodlayınız
 NOT:Cinsiyet seçimi switch case ile yapılacaktır
            not: eğer prim, yaş, cinsiyet hatalı girilirse kullanicidan bir daha girmesi istenecektir.
            tekrar giriş yapmayacaksa bu koşul kullanıcıya bırakılır ve kullanıcı klavyeden belirlenen bir harf, yazı,karakter ile çıkış sağlanmalıdır.
  */
            Emeklilik();
        }

        static void Emeklilik()
        {
            string cinsiyet = "cinsiyet";
            switch (cinsiyet)
            {
                
            
                double maas = 0;
                double ikramiye = 0;
                case "kadın":
                    EkranaYaz("yas giriniz: ");
                    YasHesapla();
                    EkranaYaz("prim gün sayisi: ");
                    PrimHesapla();
                    Oku();
                    if (YasHesapla =>60 && PrimHesapla = 7300)
                    {
                        ikramiye = maas * 13;
                        Console.WriteLine("İkramiyeniz: " + ikramiye);
                    }
                    break;
                case "erkek":
                    EkranaYaz("yas giriniz: ");
                    YasHesapla();
                    EkranaYaz("prim gün sayisi: ");
                    PrimHesapla();
                    Oku();

                    break;
            }

        }
        static int YasHesapla()
        {
            Console.WriteLine("yas giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int PrimHesapla()
        {
            Console.WriteLine("prim gün: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Oku()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }

    }
}
