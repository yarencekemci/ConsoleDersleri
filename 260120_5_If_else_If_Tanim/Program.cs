namespace _260120_5_If_else_If_Tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BASLA:

            Console.WriteLine("SAYİ GİRİNİZ: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi <= 0 && sayi >= 9)
            {
                Console.WriteLine("Sayi tek basamaklidir.");
            }
            else if (sayi >= 10 && sayi <= 99)
            {
                Console.WriteLine("Sayi cift basamaklidir.");
            }
            else if (sayi >= 100 && sayi <= 999)
            {
                Console.WriteLine("Sayi 3 basamaklidir.");
            }
            else if (sayi >= 1000 && sayi <= 9999)
            {
                Console.WriteLine("Sayi 4 basamaklidir.");
            }
            else if (sayi >= 10000 && sayi <= 99999)
            {
                Console.WriteLine("Sayi 5 basamaklidir.");
            }
            else
            {
                Console.WriteLine("Bitti");
            }
            goto BASLA;

            /*
             1- kullanıcıdan alınan haftanın kaçıncı günündesin yapısına günü gününe adını veren (1.gün= pazartesi 2.gün=salı...) şeklinde kodlamayı yapınız
             2- kullanıcıdan alınan ay numarasına göre ayın adını ve kaç gün olduğunu gösteriniz (1 ocak - 31 gğn, 2 şubat 28 gün)
            3-kullanicidan alınan bir sayinin pozitif, negatif veya 0 olduğunu ekranda gosteriniz
            3-kullanicidan alınan bir sayinin pozitif, negatif veya 0 olduğunu ekranda gosteriniz
            
            
             */

        }
    }
}
