namespace _260210_2_Method_Ornek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 3 sayının toplamını veren işlemi method kullanarak kodlayınız

            /*int toplam = 0;

            Console.WriteLine("Birinci sayi: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayi: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ucuncu sayi: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("3 sayının toplamı: " + toplam);
            */
            int toplam = 0;
            int s1 = SayiAl();
            toplam = Islem(s1, toplam);

            int s2 = SayiAl();
            toplam = Islem(s2, toplam);

            int s3 = SayiAl();
            toplam = Islem(s3, toplam);

            EkranaYaz("3 sayinin toplamı: " + toplam);


        }
        static int SayiAl()
        {
            // Console.WriteLine(". sayi giriniz");
            EkranaYaz("Sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }
        static int Islem(int sayi1, int toplam)
        {
            return toplam + sayi1;
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }
        
        
    }
}
