namespace _260127_3_DoWhile_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan 5 sayıdan en büyük sayıyı hesaplayan yapıyı kodlayınız
            int sayac = 1;
            int enBuyuk;
            int sayi;

            Console.Write("1. sayiyi giriniz: ");
            enBuyuk = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(sayac + 1 + ". sayiyi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
                sayac++;
            } while (sayac < 5);
            Console.WriteLine("en büyük sayi: " + enBuyuk);
            Console.WriteLine("-------");
            Console.WriteLine();

            //kullanıcıdan negatif sayı alınana kadar girilen pozitif sayıların toplamını ve adetini hesaplayan do while yapısını kodlayınız
            int sayi2;
            int toplam2 = 0;
            int adet = 0;
            do
            {
                Console.WriteLine("sayi giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi2 > 0)
                {
                    toplam2 += sayi2;
                    adet++;
                }
            } while (sayi2 >= 0);
            Console.WriteLine("toplam: " + toplam2);
            Console.WriteLine("adet: "+adet);
            Console.WriteLine("-------");
            Console.WriteLine();


            //kullanıcıdan 1-100 arasında sayı girmesini isteyiniz, girilen sayı 1-100 arasında değil ise tekrar sayı girmesini isteyiniz, girilen sayı 1-100 arasında ise sayıyı ekranda gösteriniz ve 1-100 arasında 11 sayı girildikten sonra işlemi sonlandırıp girilen sayıların toplamını ekranda gösteriniz
            //1-100 arası 11 sayi al- yanlıssa tekrar istedi dogruysa topla
            int sayi3;
            int toplam3 = 0;
            int adet3 = 0;

            do
            {
                do
                {
                    Console.WriteLine("1-100 arasindaki sayi giriniz: ");
                    sayi3 = Convert.ToInt32(Console.ReadLine());
                } while (sayi3 < 1 || sayi3 > 100);
                Console.WriteLine("girilen sayi: "+ sayi3);
                toplam3 += sayi3;
                adet3++;
            } while (adet3<11);
            Console.WriteLine("girilen sayilarin toplami: " + toplam3);
            Console.WriteLine("-------");
            Console.WriteLine();

            //kullanıcı adı admin, şifresi 12?ab olan bir sistem için 3 defa giriş hakkı tanıyan do while sistemini kodlayınız
            string kullaniciadi;
            string sifre;
            int hak = 1;
            do
            {
                Console.WriteLine("kullanici adi: ");
                kullaniciadi = Console.ReadLine();

                Console.WriteLine("sifre giriniz: ");
                sifre = Console.ReadLine();

                if (kullaniciadi == "admin" && sifre == "12?ab")
                {
                    Console.WriteLine("giris basarili");
                    break;
                }
                else
                {
                    Console.WriteLine("hatali giris");
                    Console.WriteLine("-------");
                    Console.WriteLine();
                }
                hak++;
            } while (hak <= 3);
            if(hak>3)
            {
                Console.WriteLine("giris hakkiniz bitti");
            }
            Console.WriteLine("-------");
            Console.WriteLine();


        }
    }
}
