namespace _260130_6_Dizi_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // random - rastgele sayi üretmek icin kullanilan bir class yapisidir
            /* Random rastgele = new Random();
            Console.WriteLine(rastgele.Next(200));

            for (int i = 0; i < 150; i++)
            {
                int sayi = rastgele.Next(200);
                Console.Write(sayi + ",");
            }*/
            /*
            1)rastgele üretilen 200 sayı arasında tek olanları ve çift olanları ayrı ayrı diziler içinde dizi eleman sayısı az/çok olmayacak şekilde oluşturan yapıyı kodlayınız
            (2 döngü ile işlem yapılıyor)
            2)Kullanıcıdan alınan 5 sayıyı dizi-döngü kullanarak küçükten büyüğe doğru sıralayınız?
            3)Kullanıcıdan bir fabrikadan çalışan sayısı alındıktan sonra çalışanların isimlerini bir bir isteyip(1. personel Ahmet) girilen isimleri aldıktan sonra her bir personelin
            aldığı maaşı(Ahmet ne kadar maaş alıyor-49000) şeklinde istedikten sonra son olarak 
            her bir isim karşısında isim için girilen maaşı listeleyen(Ahmet-49000) şeklinde veren yapıyı kodlayınız         
            */

            // 1)rastgele üretilen 200 sayı arasında tek olanları ve çift olanları ayrı ayrı diziler içinde dizi eleman sayısı az/çok olmayacak şekilde oluşturan yapıyı kodlayınız
            // (2 döngü ile işlem yapılıyor)
            int[] sayilar = new int[200];
            int[] tek = new int[200];
            int[] cift = new int[200];
           
            int tekSayac = 0;
            int ciftSayac = 0;

            Random rnd = new Random();

            //1.- dongu
            for (int i = 0; i < 200; i++)
            {
                sayilar[i] = rnd.Next(1,200); // sınır verilmeli
            }
            //2.dongu
            for (int i = 0; i < 200; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift[ciftSayac] = sayilar[i];
                    ciftSayac++;
                }
                else
                {
                    tek[tekSayac++] = sayilar[i];
                }
            }
            Console.WriteLine("---------");
            Console.WriteLine("cift sayilar: ");
            for (int i = 0; i < ciftSayac; i++)
            {
                Console.Write(cift[i]+ ", ");
            }
            Console.WriteLine("---------");
            Console.WriteLine("tek sayilar: ");
            for (int i = 0; i < tekSayac; i++)
            {
                Console.Write(tek[i] + ", ");
            }
            // 2)Kullanıcıdan alınan 5 sayıyı dizi-döngü kullanarak küçükten büyüğe doğru sıralayınız ?
            int[] sayilar2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i+1)+". sayiyi giriniz: ");
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j= i+1; j<5; j++)
                {
                    if (sayilar2[i] > sayilar2[j])
                    {
                        sayilar2[i] = sayilar2[j];
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar2[i]+ " ");
            }

            /* Kullanıcıdan bir fabrikadan çalışan sayısı alındıktan sonra çalışanların isimlerini bir bir isteyip(1. personel Ahmet) girilen isimleri aldıktan sonra her bir personelin
             aldığı maaşı(Ahmet ne kadar maaş alıyor-49000) şeklinde istedikten sonra son olarak
            her bir isim karşısında isim için girilen maaşı listeleyen(Ahmet-49000) şeklinde veren yapıyı kodlayınız */

            Console.Write("calisan sayisi giriniz: ");
            int personelsayisi = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[personelsayisi];
            int[] maaslar = new int[personelsayisi];

            //1-.dongu ısım ve maas
            for (int i = 0; i < personelsayisi; i++)
            {
                Console.Write((i + 1) + ". personelin ismi: ");
                isimler[i] = Console.ReadLine();

                Console.WriteLine(" ");
                Console.Write(isimler[i] + " maas: ");
                maaslar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("personel maas listesi: ");
            //listeleme
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(isimler[i] + " , " + maaslar[i]);
            }
        }
    }
}
