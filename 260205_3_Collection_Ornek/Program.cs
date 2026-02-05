using System.Collections;
namespace _260205_3_Collection_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kulanıcıdan alınan adı, soyadı, doğum tarihi, cinsiyet, medeni durum,aylık gelir gibi islemleri bir arraylist içinde kullanarak kullanıcıya bir kart oluşturup gösteriniz
            /*
             AD:
            SOYADI:
            DOĞUM TARİHİ:
            CİNSİYET:
            MEDENİ DURUM:

            */
            //DENEME
            /*ArrayList musteriKart = new ArrayList();
            
            Console.WriteLine("AD: ");
            string isim = Console.ReadLine();
            musteriKart.Add(isim);

            Console.WriteLine("SOYADI: ");
            string soyisim = Console.ReadLine();
            musteriKart.Add(soyisim);

            Console.WriteLine("DOGUM TARİHİ: ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            musteriKart.Add(dogumTarihi);

            Console.WriteLine("CİNSİYET: ");
            string cinsiyet = Console.ReadLine();
            musteriKart.Add(cinsiyet);

            Console.WriteLine("MEDENİ DURUM: ");
            bool medeniDurum = bool.Parse(Console.ReadLine());
            musteriKart.Add(!medeniDurum);

            Console.WriteLine("AYLIK GELİR: ");
            double aylikGelir = double.Parse(Console.ReadLine());
            musteriKart.Add(aylikGelir);


            */
            //COZUM
            string[] kart = { "AD", "SOYAD", "DOGUM TARIHI", "CINSIYET", "MEDENI DURUM", "AYLIK GELIR" };
            ArrayList kartItem = new ArrayList();
            foreach (var item in kart)
            {
                if (item == "MEDENİ DURUM")
                    Console.WriteLine("Bekar 1, evli için 0 yazınız.");
                else
                    Console.WriteLine(item+" giriniz: ");
                kartItem.Add(Console.ReadLine());

            }
            for (int i = 0; i < kartItem.Count; i++)
            {
                if (kart[i] == "MEDENI DURUM")
                {
                    if (kartItem[i] == "1")
                        Console.WriteLine(kart[i] + ": Bekar");
                    else
                        Console.WriteLine(kart[i] + ": Evli");
                }
                else
                    Console.WriteLine(kart[i] + ":" + kartItem[i]);
            }

            // BU SORU İCİN EGER 2 DEN FAZLA KİSİ KARTI İSTENSEYDİ NASIL BİR YOL İZLENİRDİ?


        }
    }
}
