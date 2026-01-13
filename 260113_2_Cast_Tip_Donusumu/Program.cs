namespace _260113_2_Cast_Tip_Donusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Convert- bütün tipler arası dönüşüm
             Parse- string olan diğer tiplere dönüştürür
            cast-sayısal tipler arası dönüşümü sağlar
             */

            int sayi1 = 950;
            int sayi2 = 150;

            int toplam=sayi1 + sayi2;
            Console.WriteLine("2 sayının toplamı" + toplam);
            int bolme1 = sayi1 / sayi2;

            double bolme2 = sayi1 / sayi2;
            double bolme3 = (double)sayi1 / sayi2;
            double bolme4 = Convert.ToDouble(sayi1) / sayi2; //6,3333

            Console.WriteLine("Bölme işlemi:" + bolme1);
            Console.WriteLine("Bölme işlemi:" + bolme2);
            Console.WriteLine("Bölme işlemi CAST:" + bolme3);
            Console.WriteLine("Bölme işlemi CONVERT:" + bolme4);
            int sayiBolmeTam = (int)bolme4;

            Console.WriteLine("bölme sonucu tam sayı Cast:" + sayiBolmeTam);

        }
    }
}
