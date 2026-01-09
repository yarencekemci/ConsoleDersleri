namespace _260109_4_Convert_Tip_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bilgisayar dili string yani text(metin) tir

            Console.WriteLine("Ekrana yazıyor");

            Console.WriteLine("Ekrana adınızı yazınız");
            string isim = Console.ReadLine();//Read - okuma, Line- Satır,çizgi,hat

            Console.WriteLine("Ekrana yazılan isim:" + isim);
            Console.WriteLine("Sayı giriniz");
            string ekranaYazilanSayi = Console.ReadLine();
            Console.WriteLine("Sayi:"+ekranaYazilanSayi); // bu işlem için ekranaYazilanSayi
            //sayisal değer dönüştürülmesi gereklidir
            // Tip dönüşümü ile tipler kendi aralarında birbirlerine dönüştürülür
            /*
             Tip dönüşümleri 4 başlık altında incelenecek
            1-Convert
            2-Parse
            3-Casting
            4-ToString()
             */
            Console.WriteLine("Bir sayi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1+ sayi2;
            Console.WriteLine("Girilen 2 sayinin toplami:" + toplam);


            byte s1 = Convert.ToByte(Console.ReadLine());
            sbyte s2 = Convert.ToSByte(Console.ReadLine());
            short s3 = Convert.ToInt16(Console.ReadLine());
            ushort s4 = Convert.ToUInt16(Console.ReadLine());
            int s5 = Convert.ToInt32(Console.ReadLine());
            uint s6 = Convert.ToUInt32(Console.ReadLine());
            long s7 = Convert.ToInt64(Console.ReadLine());
            ulong s8 = Convert.ToUInt64(Console.ReadLine());

            //ondalık
            float s9 = Convert.ToSingle(Console.ReadLine());
            double s10=Convert.ToDouble(Console.ReadLine());
            decimal s11 = Convert.ToDecimal(Console.ReadLine());

            //tarih
            DateTime tarih = Convert.ToDateTime(Console.ReadLine());

            //
            bool mantiksal = Convert.ToBoolean(Console.ReadLine());

            //metinsel
            string metin1 = Convert.ToString(12);
            char metin2 = Convert.ToChar(Console.ReadLine());
            //test

        }
    }
}
