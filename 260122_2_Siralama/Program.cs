using System.Security.Cryptography;

namespace _260122_2_Siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan 3 sayı için, sayıları küçükten büyüğe doğru sıralayan yapıyı kodlayınız?

            int s1, s2, s3;

            Console.WriteLine("1. sayi giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayi giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayi giriniz: ");
            s3 = Convert.ToInt32(Console.ReadLine());


            if (s1 > s2 && s1 > s3)
            {
                if (s2 > s3)
                {
                    Console.WriteLine("s1 > s2 > s3");
                }
                else if (s3 > s2)
                {
                    Console.WriteLine("s1>s3>s2");
                }
                else if (s1 == s3)
                {
                    Console.WriteLine("s1>s2=s3");
                }
            }
            else if (s2 > s1 && s2 > s3)
            {
                if (s1 > s3)
                {
                    Console.WriteLine("s2 > s1 < s3");
                }
                else if (s3 > s1)
                {
                    Console.WriteLine("s2 > s3 > s1");
                }
                else if (s1 == s3)
                {
                    Console.WriteLine("s2>s1=s3");
                }
            }
            else if (s3 < s1 && s3 > s2)
            {
                if (s1 < s2)
                {
                    Console.WriteLine("s3 < s1 < s2");
                }
                else if (s1 > s2)
                {
                    Console.WriteLine("s1 > s3 > s2");
                }
                else if (s1 == s3)
                {
                    Console.WriteLine("s1=s3>s2");
                }
            }
        }
    }
}
