namespace _261301_Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 4 sayı için aşağıdaki işlemlerin sonuçlarını hesaplayıp ekranda gösteriniz.
            // 1'den 4'e kadar sayının toplamı
            // 2- 1. 2. sayıların çarpım sonucuna 5. sayıya bölme
            // 3- 1. ve 2. sayıların toplam sonucu, 3. sayıdan 4. sayının çıkartılması sonucu bölüm
            // 4- 4. sayıya diğer 3 sayının toplamına bölünmesi
            // 5- 1. 2. 3. sayiların çarpımının sonucunun 4 sayıya bölünmesi
            

            Console.WriteLine("1. sayi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayi giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3. sayi giriniz");
            int sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine("4. sayi giriniz");
            int sayi4 = int.Parse(Console.ReadLine());

            //1
            int islem1 = sayi1 + sayi2 + sayi3+ sayi4;
            Console.WriteLine("1den 4'e kadar olan sayilarin toplami: " + islem1);

            //2
            double islem2 = (double)(sayi1 * sayi2) / (sayi4);
            Console.WriteLine("1. ve 2 sayinin carpim sonucunu 4. sayiya bolme" + islem2);

            //3
            double islem3 = (double)(sayi1 + sayi2) / (sayi3 - sayi4);
            Console.WriteLine("1. ve 2 sayinin toplam sonucunu 3. sayidan 4. sayinin cikarilması sonucu: " + islem3);

            //4
            double islem4 = (double)(sayi1 + sayi2 + sayi3) / (sayi4);
            Console.WriteLine("3 sayinin toplaminin 4. sayiya bolunmesi: " + islem4);

            //5
            double islem5 = (double)(sayi1 * sayi2 * sayi3) / sayi4;
            Console.WriteLine("3 sayinin carpiminin 4. sayiya bolunmesi: " + islem5);

            //-- 1. ve 2. sayilarin toplamini, 3. sayidan 4. sayinin çıkarilmasina bolunuz
            double islem6 = (double)(sayi1 + sayi2) / (sayi3 - sayi4);
            Console.WriteLine("1. ve 2. sayilarin toplaminin, 3. ve 4. sayinin cikarilmasina bolunuz: " + islem6);

            // kullanicidan string olarak 4 sayi aliniz sayilari int.Parse çevirip (1+2)x3/4
            Console.Write("1. sayi giriniz: ");
            string s1 = Console.ReadLine();

            Console.Write("2. sayi giriniz: ");
            string s2 = Console.ReadLine();

            Console.Write("3. sayi giriniz: ");
            string s3 = Console.ReadLine();

            Console.Write("4. sayi griniz: ");
            string s4 = Console.ReadLine();

            //int sayi1 = int.Parse(s1);
            //int sayi2 = int.Parse(s2);
            //int sayi3 = int.Parse(s3);
            //int sayi4 = int.Parse(s4);

            int sonuc = (sayi1 + sayi2) * sayi3 / sayi4;
            Console.WriteLine("sonuç:" + sonuc);

            /* Kullanıcıdan 4 sayı alınız.


            İlk 3 sayı int

             Son 1 sayı double

            (1.ve 2.sayıların çarpımı + 3.sayı) işleminin

            4.sayıya bölümünü hesaplayınız.

			Sonuç ondalıklı olmalı
			Parse ve gerekirse cast kullan

            */
            Console.Write("1. sayi: ");
            int ss1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayi: ");
            int ss2 = int.Parse(Console.ReadLine());

            Console.Write("3. sayi: ");
            int ss3 = int.Parse(Console.ReadLine());

            Console.Write("4. sayi: ");
            double ss4 = double.Parse(Console.ReadLine());

             //sonuc = (ss1 * ss2) + ss3) / ss4;

            Console.Write("Sonuç: " + sonuc);
        }
    }
}
