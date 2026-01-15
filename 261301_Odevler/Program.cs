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

            
        }
    }
}
