using System.Security.Cryptography;

namespace _260206_1_Method_Tanim
{
    internal class Program
    {
        //string[] - string bir dizi, int[], double, ArrayList,.. olabilir
        //args - değişken- parametre.dizi, sayilar, isimler, sehirler olabilir
        // Main(string[] args) -> string bir dizisi olan Main adında method(function)-> Topla,Fark,MaasZam , GetirKisiBilgileri
        //void-> method türü-> int,double,.. (var dışında bütün veri tipleri kullanılabilir)
        //static-> Erişim belirtleyicisi, bir yapıya(değişken, method,class) erişim yani kullanmak için izin olup olmadığını erişim belirleyicileri(internal, static, public, private, protected, protected internal) ile sağlayınız
        //Method Nedir?-> sürekli kodlanan bir kod varsa bu kodu sürekli kodlamak yerine onu bir format ile sürekli kullanabileceğimiz halde tutmak için Method içinde kodlarız ve her lazım olduğunda MEthod çağırmak yeterli olacaktır, artık aynı kodu tekrar tekrar yazmaya gerek yoktur
        // aşağıdaki yapıyı method ile yapalım 
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); // bu bir method'tur
            Toplam(sayi1, sayi2);
            // bu iki sayının büyükten küçük sayıyı çıkartın fark adında method kodlayınız
            Fark(sayi1, sayi2);
            //büyük sayıya küçük sayının bölünmesinde kalanı veren modül adında method kodlayınız
            Modul(sayi1, sayi2); // method kullanımı
            // ctrl+m+o - bütün methodları gizler
            // ctrl+m+l - bütün methodları gösterir
            //ctrl+k+d - düzenler

            /*
              Erişim Belirleyicileri
            1-public => herkese açık
            2-private=> özel, sadece tanımlandığı yerde kullanılabilir
            3-internal=> aynı proje altında kullanılabilir
            4-protected=> kalıtım verdiği class larda kullanılabilir
            5-internal protected=> aynı proje altında ve kalıtım verdiği class larda kullanılabilir
            6-static=> tanımlama yapmadan direk kullanma imkanı sağlar
         
            Method Çeşitleri:
            1-Değer döndürmeyen void method
            2-Değer döndüren return moethod
            3-Aşırı yüklenmiş Overload method

            */
        }
        /// <summary>
        /// Bu iki sayının toplamını hesaplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Toplam(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("2 sayinin toplami" + toplam);
        }
        /// <summary>
        /// Bu iki sayının büyük olandan küçük olanın farkını verir
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>
        static void Fark(int deger1, int deger2)
        {
            if (deger1 > deger2)
            {
                int fark1 = deger1 - deger2;
                Console.WriteLine("Fark: " + fark1);
            }
            else
            {
                int fark2 = deger2 - deger1;
                Console.WriteLine("Fark: " + fark2);
            }

        }
        /// <summary>
        /// Bu iki sayının büyük olandan küçük olanı böldüğünde kalanı verir
        /// </summary>
        /// <param name="modul1"></param>
        /// <param name="modul2"></param>
        static void Modul(int modul1, int modul2)
        {
            int kalan;
            if (modul1 > modul2)
            {
                kalan = modul1 % modul2;
                Console.WriteLine("Kalan sayi: " + kalan);
            }
            else
            {
                kalan = modul2 % modul1;
                Console.WriteLine("Kalan sayi: " + kalan);
            }
        }
    }
}