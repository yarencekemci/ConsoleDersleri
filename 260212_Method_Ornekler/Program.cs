namespace _260212_Method_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*
             * Kullanıcıdan 2 sayı istenecek büyük sayıdan küçük sayı için 4 işlem ve mod alma metodu Kullanıcıdan istenilen 7 şehir için maximum 
             * 7 bölgeli method Kullanıcıdan 4 sayı alınacak 1 2 3 4 şeklinde ayrı 4 method yapılacak 
             * 1 yazılırsa Ege Bölgesi için şehirler yazılacak 
             * 2 yazılırsa Akdeniz Bölgesi için şehirler yazılacak 
             * 3 yazılırsa Karadeniz Bölgesi için şehirler yazılacak 
             * 4 yazılırsa Marmara Bölgesi için şehirler yazılacak 
             */

            /*
            Kullanıcıdan 3 sayı istenecek 1 Batı 2 Doğu 3 Güney olacak şekilde method tanımlanacak ve hangi sayı girilirse ona göre
            türkiyenin komşuları ekrana yazılacak
             */

            
        }
        //sayının pozitif mi negatif mi olduğunu ekrana yazdıran methodu kodlayınız.
        static void pozitifMi(int sayi)
        {
            if (sayi > 0)

                Console.WriteLine("pozitif");
            else if (sayi < 0)
                Console.WriteLine("negatif");
            else
                Console.WriteLine("sıfır");
        }
        //sayının tek mi çift mi olduğunu ekrana yazdıran methodu kodlayınız
        static void tekCift(int sayi)
        {
            if (sayi % 2 == 0)
                Console.WriteLine("çift");
            else
                Console.WriteLine("tek");
        }
        //bir sayının 3e ve 5e bölünüp bölünmediğini kontrol eden method nedir?
        static void UcveBesBolme(int sayi)
        {
            if (sayi % 3 == 0 && sayi % 5 == 0)
                Console.WriteLine("3'e ve 5'e bolunur");
            else
                Console.WriteLine("bolunmez");
        }
        // TÜRKİYE - 1/2/3/4 BÖLGE SEÇİMLERİ
        static void BolgeSecim(int secim)
        {
            if (secim == 1)
                Console.WriteLine("Ege-> İzmir,Aydın,Muğla");
            else if (secim == 2)
                Console.WriteLine("Akdeniz-> Antalya");
            else if (secim == 3)
                Console.WriteLine("Karadeniz-> Trabzon, Samsun, Rize");
            else if (secim == 4)
                Console.WriteLine("Marmara->İstanbul, Kocaeli");
        }
        //TÜRKİYE KOMŞULAR - 1 Batı – 2 Doğu – 3 Güney

        // dizideki sayıların ortalamasını hesaplayıp ekrana yazdıran method nedir?
        static void TrKomsular(int secim)
        {
            if (secim == 1)
                Console.WriteLine("Bulgaristan, Yunanistan");
            else if (secim == 2)
                Console.WriteLine("İran", "Azerbaycan");
            else if (secim == 3)
                Console.WriteLine("suriye");
        }
    }
}
