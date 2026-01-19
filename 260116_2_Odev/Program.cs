namespace _260116_2_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ATAMA OPERATORLERI ODEV 
            // kullanicidan 5 sayi al

            Console.Write("1. sayi giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayi giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. sayi giriniz: ");
            int s3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("4. sayi giriniz: ");
            int s4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("5. sayi giriniz: ");
            int s5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");



            // 1. soru= KUllanicidan alinan 5 sayi 2 nin kati mi? 2nin kati ise true, değilse false
            Console.WriteLine("Girdiginiz sayilar 2nin kati mi?");
            Console.WriteLine("1. sayi ikinin kati mi?: " + (s1 % 2 == 0));
            Console.WriteLine("2. sayi ikinin kati mi?: " + (s2 % 2 == 0));
            Console.WriteLine("3. sayi ikinin kati mi?: " + (s3 % 2 == 0));
            Console.WriteLine("4. sayi ikinin kati mi?: " + (s4 % 2 == 0));
            Console.WriteLine("5. sayi ikinin kati mi?: " + (s5 % 2 == 0));
            Console.WriteLine(" ");

            //2. soru= 1. sayidan 5. sayiya kadar olan sayilarin toplami
            int toplam = 0;
            toplam += s1;
            toplam += s2;
            toplam += s3;
            toplam += s4;
            toplam += s5;
            Console.WriteLine("1. sayidan 5. sayiya kadar olan sayilarin toplami: " + toplam);
            Console.WriteLine(" ");

            //3. soru= yeni degisken tanimlamadan 1. sayiya 5 ekleyin, 2. sayidan 10 cikartin, 3. sayiyi da 5 ile carparak islemin sonucunu ekranda gosteriniz
            s1 += 5;
            s2 -= 10;
            s3 *= 5;
            Console.WriteLine("1. sayiya 5 ekleyin, 2. sayidan 10 cikartin, 3. sayiyi 5 ile carpin: ");
            Console.WriteLine("1. sayiya 5 ekleyin: " +s1);
            Console.WriteLine("2. sayidan 10 cikartin: " + s2);
            Console.WriteLine("3. sayiyi 5 ile carpin: " + s3);
            Console.WriteLine(" ");

            //4. soru= Sayilarin toplami 9,11,13 ile bolunebiliyor mu?
            Console.WriteLine("Sayilarin toplami 9,11,13 ile bolunebiliyor mu?");
            Console.WriteLine("9'a bolunebiliyor mu?: " + (toplam % 9 == 0));
            Console.WriteLine("11'e bolunebiliyor mu?:" + (toplam % 11 == 0));
            Console.WriteLine("13'e bolunebiliyor mu?" + (toplam % 13 == 0));
            Console.WriteLine(" ");

            //5. soru 1.,2., 3. sayilarin toplamini 4. ve 5. sayinin cikarma islemi sonucuna bol. (1+2+3) / (4-5)
            double sonuc = (double)(s1 + s2 + s3) / (s4 - s5);
            Console.WriteLine("(1+2+3) / (4-5) isleminin sonucu: " + sonuc);

        }
    }
}
