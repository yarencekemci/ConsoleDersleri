namespace _260123_1_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             switch case karar yapisi sadece esitlik durumunda calisan bir karar yapisidir
             */
            int sayi = 0;

            switch (sayi) // degisken sadece tanımlanır, burada tanımlanan degisken herhangi bir karsilastirma operatörü ile kullanılmaz, sadece case ler icin hangi degisken kullanılacak belirtilir
            {
                case 1: // sayi degiskeni 1'e esit oldugunda buradaki kodlar okunacaktir
                    // kodlaması
                    break; // 1 icin son
                case 2:
                    break; // her bir case icin break ile sonlanir
                default:
                    // bir deger almaz, eger case lerde verilen deger sayi degiskeninde yoksa default kısmındaki kodlar okunacaktir: if-else yapisindaki else gibi calisir
                    //kodlar 
                    break; // default icin son
                case 56:
                    //56 icin kodlar
                    break;

            
            }

            string metin = "merhaba";

            switch (metin)
            {
                default:
                    break;
                    // 1 den fazla case break ile sonlanabilir
                case "hello":
                case "merhaba":
                case "":
                    break;

                case "slaw":
                    break;
                case "hallo":
                    break;

            }
        }  
    }
}
