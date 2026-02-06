namespace _260206_2_Deger_Dondurmeyen_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // değer döndürmeyen void method, method adından önce void ifadesi içeriyorsa değer döndürmeyen method olur
            Cizgi();
            AdSoyadBuyukHarf("Yaren", "Çekemci");
            Console.WriteLine("Adınız: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyadınız: ");
            string soyad = Console.ReadLine();
            AdSoyadBuyukHarf(ad, soyad);

        }
        /// <summary>
        /// Tire ile cizgi cizer
        /// </summary>
        static void Cizgi()
        {
            Console.WriteLine("----------------");
        }
        static void AdSoyadBuyukHarf(string ad, string soyad)
        {
            Console.WriteLine("AD:{0} ve SOYAD:{1}",ad.ToUpper(),soyad.ToUpper());
        }
    }
}
