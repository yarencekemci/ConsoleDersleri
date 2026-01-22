using System.ComponentModel.Design;
using System.Threading.Channels;

namespace _260120_1_Tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // karar yapıları ve koşul yapıları
            // if else, switch case, ternary operatör
            /*
             1- if else- eşitlik, karşılaştırma, oran,...
               if else
               if , else if, .... , else
             2- switch case - eşitlik durumu
             3- ternary operatör - if else kısaltılmış hali
            */

            if(true) // if içinde true yerine koşul yazılır (sayi==1, sayi>0, sayi<10 vb.) eğer bu koşul doğru ise if bloğundaki kodlar okunur
            {
                // if blok kodları
            }
            else // else değilse anlamına gelir bu da if için false(hayır-koşul false sonucunu verdi) demektir. false olması durumunda else bloğundaki kodlar okunur
            {
                //else blok kodları
            }
            Console.WriteLine("Sayi giriniz?");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > 0) 
                //buraya kod yazılmaz
            {
                //evet ise bu alan okunacaktır
                Console.WriteLine("Sayi 0dan kucuktur");
            }
            //buraya kod yazılmaz
            else
            //buraya kod yazılmaz
            {
                //hayır ise bu alan okunacaktır
                Console.WriteLine("Sayi 0dan kucuktur");
            }
            


        }
    }
}
