namespace _260109_1_Tarih_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarih veri tipi
            int sayi = 90;
            string metin = "Merhaba";
            //09.01.2026
            DateTime tarih = DateTime.Now; //Şimdinin tarihini verir

            DateTime xTarih = new DateTime(); //nesne 

            Console.WriteLine("Şu anın tarih saat  bilgisini verir:" + tarih);
            Console.WriteLine("Yıl"+tarih.Year);
            Console.WriteLine("Ay" + tarih.Month);
            Console.WriteLine("Gün" + tarih.Day);
            Console.WriteLine("Saat" + tarih.Hour);
            Console.WriteLine("Dakika" + tarih.Minute);
            Console.WriteLine("Saniye" + tarih.Second);
            Console.WriteLine("Yılın Günü"+tarih.DayOfYear);
            Console.WriteLine("Haftanın Günü" + tarih.DayOfWeek);
            //ay-gün-yıl- ingiliz
            //gün-ay-yıl- Türk 


        }
    }
}
