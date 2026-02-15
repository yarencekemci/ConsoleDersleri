namespace _260215_2_Overload_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan 2 sayı için DortIslem() adında method ile kodlayarak alınız
            /*
            1- bu iki sayının toplamını DortISlem() adında method ile hesaplayınız?
            2- bu iki sayının carpımını DortIslem() adında method ile hesaplayınız?
            3- bu iki sayının farkını DortIslem() adında method ile hesaplayınız?
            4-Büyük sayinin kücük sayıya bölümünde kalını veren DortIslem() adında method ile kodlayınız?
            5-Büyük sayinin kücük sayıya bolumunden kbolumu veren DortIslem() adında method ile kodlayınız?
            */

            short sayi1 = DortIslem();
            short sayi2 = DortIslem();
        }
        /// <summary>
        /// Kullanıcının girdiği sayıyı short tipinde verir
        /// </summary>
        /// <returns></returns>
        static short DortIslem() // short!! 
        {
            DortIslem("Sayı giriniz?");
            return Convert.ToInt16(Console.ReadLine());
        }

        /// <summary>
        /// Ekrana girilen metni verir
        /// </summary>
        /// <param name="metin"></param>
        static void DortIslem(string metin)
        {
            Console.WriteLine(metin);
        }
    }
}
}
