namespace _260206_4_Method_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine();//Ekrana Yazar
            // Console.ReadLine(); // Ekranı Okur
            EkranaYaz("1. sayi giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi1 = Convert.ToInt32());
            int sayi1 = IntYap();
            EkranaYaz("Girilen sayi: " + sayi1);
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static string Oku()
        {
            return Console.ReadLine();
        }
        static int IntYap()
        {
            return Convert.ToInt32(Oku());
        }

    }
}
