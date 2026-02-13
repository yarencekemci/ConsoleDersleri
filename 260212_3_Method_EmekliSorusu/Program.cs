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
            while (true)
            {
                Console.Write("cinsiyet giriniz (-kadın/erkek- yazınız): ");
                string cinsiyet = Console.ReadLine();

                if (cinsiyet != "kadın" && cinsiyet != "erkek")
                {
                    Console.WriteLine("hatalı cinsiyet girdiniz!!!!");
                    continue;
                }

                int yas = YasHesapla();
                int prim = PrimHesapla();

                Console.Write("maas giriniz: ");
                double maas = Convert.ToDouble(Console.ReadLine());

                switch (cinsiyet)
                {
                    case "kadın":
                        if (yas >= 60 && prim >= 7300)
                        {
                            double ikramiye = maas * 15;
                            Console.WriteLine($"Emekli oldunuz. İkramiyeniz: {ikramiye}");
                        }
                        else
                        {
                            EmekliDegil(yas, prim, 60, 7300);
                        }
                        break;

                    case "erkek":
                        if (yas >= 65 && prim >= 8500)
                        {
                            double ikramiye = maas * 17.5;
                            Console.WriteLine($"Emekli oldunuz. İkramiyeniz: {ikramiye}");
                        }
                        else
                        {
                            EmekliDegil(yas, prim, 65, 8500);
                        }
                        break;
                }
            }
        }

        static int YasHesapla()
        {
            Console.Write("yas giriniz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int PrimHesapla()
        {
            Console.Write("prim gün sayısını giriniz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void EmekliDegil(int yas, int prim, int gerekenYas, int gerekenPrim)
        {
            if (yas < gerekenYas)
                Console.WriteLine($"yas uymuyor. gerekli yaş: {gerekenYas}");

            if (prim < gerekenPrim)
                Console.WriteLine($"prim gün uymuyor. gerekli prim: {gerekenPrim}");
        }
    }
}

    
