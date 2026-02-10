using System.Collections;
namespace _260210_1_Collection_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kart = { "AD", "SOYAD", "DOĞUM TARİHİ","CİNSİYET", "MEDENİ DURUM", "AYLIK GELİR" };
            ArrayList kartItem = new ArrayList();
            Console.WriteLine("Kaç kişi bilgisi gireceksiniz?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kisiSayisi; i++)
            {
                Console.WriteLine(i + 1 + ". kişi bilgileri");
                foreach (var item in kart)
                {
                    if (item == "Medeni Durum")
                    {
                        Console.WriteLine("Bekar 1, evli olan için 0 yazınız");
                    }
                    else 
                    {
                        Console.WriteLine(item+ " giriniz?");
                    }
                    kartItem.Add(Console.ReadLine());
                }
            }
            Console.WriteLine("Kişi kartları: ");
            int sayac = 0;
            for (int i = 0; i < kartItem.Count; i++)
            {
                Console.WriteLine(kart[sayac] + ":" + kartItem[i]);
                sayac++;
                if(kart.Length == (i+1))
                {
                    sayac = 0;
                }

                /*if (sayac == 0)
                {
                    Console.WriteLine(kart[sayac]+": "+ kartItem[i]);
                    sayac++;
                }
                else if (i == 1)
                {
                    Console.WriteLine(kart[sayac] + ": " + kartItem[i]);
                    sayac++;
                }
                else if (i == 2)
                {
                    Console.WriteLine(kart[sayac] + ": " + kartItem[i]);
                    sayac++;
                }
                else if (i == 3)
                {
                    Console.WriteLine(kart[sayac] + ": " + kartItem[i]);
                    sayac++;
                }
                else if (i == 4)
                {
                    Console.WriteLine(kart[sayac] + ": " + kartItem[i]);
                    sayac++;
                }
                else if (i == 5)
                {
                    Console.WriteLine(kart[sayac] + ": " + kartItem[i]);
                    sayac++;
                }*/

            }
        }
    }
}
