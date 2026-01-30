namespace _260130_1_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // diziler= aynı veri tipinde birden fazla data tutan yapılara denir

            int sayi1 = 0;
            int sayi2 = 90;
            int sayi3 = 50;
            int sayi4 = 45;
            // yukarıdaki gibi birden fazla sayı lazım olduğunda sayıları bir diziye ekleyip kullanabiliriz
            int[] sayilar = { 0, 90, 50, 45 };// rastgele eleman alan dizi
            int[] numbers = new int[4]; // eleman sayısı belirtilerek oluşturulan dizi
            numbers[0] = 0; // 0 index numbers[0] şeklinde tanımlanır ama 1. eleman olarak ifade edilir.
            // diziye eleman atamak için kullanılan yoldur
            numbers[1] = 90; // 2. eleman ataması
            numbers[2] = 50; // 3. eleman ataması
            numbers[3] = 45; // 4. eleman ataması
            // Console.WriteLine({0} {1}, sayi1 sayi2)

            Console.WriteLine("Dizinin 0. index'i yani 1. elemanı: "+ numbers[0]);
            Console.WriteLine("Dizinin 1. index'i yani 2. elemanı: " + numbers[1]);
            Console.WriteLine("Dizinin 2. index'i yani 3. elemanı: " + numbers[2]);
            Console.WriteLine("Dizinin 3. index'i yani 4. elemanı: " + numbers[3]);

            string[] isimler = new string[172];
            int personelSayisi = 172;
            double[] maas = new double[personelSayisi];
            DateTime[] dogumTarihi = new DateTime[personelSayisi];

            Console.WriteLine("---- diziyi for ile listelemek----");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("dizinin "+i+" index'i yani "+ (i+1) +". elemani: "+ numbers[i]);
            }

            // dizinin eleman sayısı

            int elemanSayisi1 = sayilar.Length;
            int elemanSayisi2 = sayilar.Count();
            Console.WriteLine("sayilar dizisi icin eleman sayisi: "+elemanSayisi1);
            int[] islem = new int[0];
            Console.WriteLine("sayilar icin eleman sayisi: "+islem.Count());
            //for (int i = 0; i < 6; i++)
            //{
              //  Console.WriteLine(islem[i]); //hata alinir dizinin disina cikiyor
            //}
            // bir int dizi elemanları atanmadıysa int için değer 0 atanır
            int elSayisi = islem.Length;
            islem[0] = 475;
            islem[1] = 75;
            islem[2] = 5;
            islem[3] = 50;
            islem[4] = 425;
            islem[5] = 545;
            Console.WriteLine("--- eleman ataması yapıldıktan sonra islem dizisi---");
            for (int i = 0; i < elSayisi; i++)
            {
                Console.WriteLine(i+1+". elemani: " + islem[i]);
            }
            // dizi eleman sayisi 6 ama biz 7 eleman eklersek ne olur?
            //islem[6] = 301; // eleman sayisi asildi
            for (int i = 0; i < elSayisi; i++)
            {
                Console.WriteLine(islem[i]);
            }
            //tersten
            for (int i = islem.Length-1; i >= 0; i--)
            {
                Console.WriteLine(islem[i]+",");
            }
        }
    }
}
