namespace _260120_4_if_else_maas_cinsiyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // kullanicidan alinan cinsiyet ve maas bilgisine göre
        // eger kadin ise ve maasına %20.5 zami eger cinsiyet erkek ise maasina %21.25 zam yapilacak sekilde kodlayin yeni zamlı maası ve zam oranını da kullaniciya gosterecek sekilde kodlayiniz
        Basla:
            Console.WriteLine("Cinsiyet giriniz: (K/E ya da kadın/erkek) "); 
            string cinsiyet = Console.ReadLine().ToLower(); //ToLower() - hepsini kücük yapar ToUpper() - büyük yapar

            Console.WriteLine("Maas giriniz: ");
            double Maas = Convert.ToDouble(Console.ReadLine());

            if(cinsiyet=="kadın" || cinsiyet=="k")
            {
                Maas = Maas + Maas * 20.5 / 100;
                Console.WriteLine("Zam oranı 20.5 ile yeni maasiniz: " + Maas);
            }
            else //erkek
            {
                Maas = Maas + Maas * 21.25 / 100;
                Console.WriteLine("Zam orani 21.25 ile yeni maasiniz "+Maas);
            }

            Console.WriteLine("------");
            goto Basla;


        }
    }
}
