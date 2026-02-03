namespace _260130_5_DiziOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 sayi aliniz, girilen 11 sayiyi listelerken cift olan sayilarin sagında cift, tek olan sayilarin saginda tek yaziniz
            int[] sayilar = new int[11];
            int elemansayisi = sayilar.Length;
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+". eleman: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = elemansayisi;
                
            }
            for (int i = 0; i < elemansayisi; i++)
            {
                //if (i % 2 == 0)
                //{
                //    Console.WriteLine((i) + "cift");
                //    i++;
                //}
                //if (i % 2 != 0)
                //{
                //    Console.WriteLine((i) + "tek");
                //    i++;
                //}
                string yaz = sayilar[i] % 2 == 0 ? "-Çift" : "-Tek";
                Console.WriteLine(sayilar[i]+yaz);
            }
            // Kullanıcıdan alınan 5 sayıyı bir diziye ata ve toplamını ekrana yazdır.

            int[] sayilarx = new int[5];
            int toplamy = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. sayiyi giriniz.");
                sayilarx[i] = int.Parse(Console.ReadLine());
                toplamy += sayilarx[i];
            }
            Console.WriteLine("toplam: " + toplamy);

            // Bir dizideki sayıların ortalamasını bulan programı yaz. 
            // dizideki sayıyı program verecek
            int[] sayilar2 = { 10, 20, 30, 40 };
            int toplam2 = 0;
            for (int i = 0; i < 4; i++)
            {
                toplam2 += sayilar2[i];
            }
            double ortalama2 = (double)toplam2 / sayilar2.Length;
            Console.WriteLine("Ortalama: " + ortalama2);

            //En büyük sayiyi bulma
            int[] sayilar3 = { 1, 2, 3, 4, 5, 6, 7, };
            int enBuyuk = sayilar3[0]; //?
            for (int i = 0; i < sayilar3.Length; i++)
            {
                if (sayilar3[i] > enBuyuk)
                    enBuyuk = sayilar3[i];
            }
            Console.WriteLine("En büyük sayi: " + enBuyuk);
            //Bir dizideki çift sayıları ekrana yazdır.
            int[] sayilar4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < sayilar4.Length; i++)
            {
                if (sayilar4[i] % 2 == 0)
                {
                    Console.WriteLine(sayilar4[i]);
                }

            }
            //Bir dizideki tek sayıların adedini bulan programı yaz.
            int[] sayilar5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int tekAdet = 0;
            for (int i = 0; i < sayilar5.Length; i++)
            {
                if (sayilar5[i] % 2 == 0)
                    tekAdet++;
            }
            Console.WriteLine("tek sayi adeti: " + tekAdet);
            //Küçükten büyüğe sıralama
            int[] sayilar6 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < sayilar6.Length; i++)
            {
                for (int j = 0; j < sayilar6.Length; j++) //?? j kullanildi
                {
                    if (sayilar6[i] > sayilar6[j]) // i ve j dizi kullanımı?
                    {
                        int gecici = sayilar6[i];
                        sayilar6[i] = sayilar6[j];
                        sayilar6[j] = gecici;
                    }
                }
            }
            foreach (int s in sayilar6) //foreach kullanimi
                Console.WriteLine(s);
            // en kücük ve en büyük sayi
            int[] sayilar7 = { 8, 7, 45, 78, 154, 452, 658, 55, 78, 45968 };
            int enKucuk7 = 0;
            int enBuyuk7 = 0;
            for (int i = 0; i < sayilar7.Length; i++)
            {
                if (sayilar7[i] < enKucuk7)
                    enKucuk7 = sayilar7[i];
                if (sayilar7[i] > enBuyuk7)
                    enBuyuk7 = sayilar7[i];
            }
            Console.WriteLine("En kucuk sayi" + enKucuk7);
            Console.WriteLine("En buyuk sayi: " + enBuyuk7);
            // bir sayinin kac kez gectigi
            int[] sayilar8 = { 2, 3, 4, 2, 6, 7, 2 };
            int aranan8 = 2;
            int adet8 = 0;
            for (int i = 0; i < sayilar8.Length; i++)
            {
                if (sayilar8[i] == aranan8)
                    adet8++;
            }
            Console.WriteLine($"{aranan8} sayisi {adet8} gecti");

            //diziyi tersten yazdırma
            int[] sayilar9 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for (int i = sayilar9.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sayilar9[i]);
            }
            //pozitif ve negatif ayırma
            int[] sayilar10 = { 1, 2, 3, -3 - 8, -4, 47, -65 };
            for (int i = 0; i < sayilar10.Length; i++)
            {
                if (sayilar10[i] > 0)
                    Console.WriteLine(sayilar10[i] + " pozitif");
                else if (sayilar10[i] < 0)
                    Console.WriteLine(sayilar10[i] + " negatif");
                else
                    Console.WriteLine("0");
            }
            // Kullanıcıdan alınan 10 sayıda, her sayının kaç kez geçtiğini bulmak.
            int[] sayilar11 = new int[10];
            // 10 sayiyi alma
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. sayiyi giriniz: ");
                sayilar11[i] = int.Parse(Console.ReadLine());
            }
            // kaç kez geçtiğini bulma
            for (int i = 0; i < 10; i++)
            {
                int adet11 = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (sayilar11[i] == sayilar11[j])
                        adet11++;
                }
                Console.WriteLine($"{sayilar11[i]} sayisi {adet11} kadar gecti");
            }

        }
    }
}
