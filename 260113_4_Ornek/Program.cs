namespace _260113_4_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 3 adet sayı için
            //1. ve 2. sayının toplamı
            //1. ve 3. sayının toplamı
            //2. ve 3. sayıların toplamı

            Console.WriteLine ("1. sayi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayi giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3. sayi giriniz");
            int sayi3 = int.Parse(Console.ReadLine());

            int toplam1 = sayi1 + sayi2;
            Console.WriteLine("1. ve 2. sayinin toplami:" + toplam1);

            int toplam2 = sayi1 + sayi3;
            Console.WriteLine("1. ve 3. sayinin toplami:" + toplam2);

            int toplam3 = sayi2 + sayi3;
            Console.WriteLine("2. ve 3. sayinin toplami:" + toplam3);

            // 1. sayının 2. sayıya bölümü
            // 1. sayının 3. sayıdan çıkartılması
            // 2. ve 3. sayıların toplamının, 1. sayıya bölünmesi sonucu hesaplayıp ekranda gösteriniz.
            // 3 sayının çarpımı

            double bolme1 =(double) sayi1 / sayi2;
            Console.WriteLine("1. sayinin 2. sayiya bolumu:" + bolme1);

            int cikarma1 = sayi3 - sayi1;
            Console.WriteLine("1. sayinin 3. sayidan cikartilmasi: " + cikarma1);

            double ucislem =(double) sayi2 + sayi3 / sayi1;
            Console.WriteLine("2. ve 3. sayilarin toplaminin 1. sayiya bolunmesi: "+ ucislem);

            int carpim1 = sayi1 * sayi2 * sayi3;
            Console.WriteLine("Uc sayinin carpimi: " + carpim1);




        }
    }
}
