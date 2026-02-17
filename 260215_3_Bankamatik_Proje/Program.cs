namespace _260215_3_Bankamatik_Proje
{
    internal class Program
    {
        static decimal bakiye = 250; // Başlangıç Bakiyesi: 250 TL
        static string sifre = "ab18";
        static int girisHakki = 3;
        static void Main(string[] args)
        {
            //bakiye,sifre ve giris hakkı burada tanımalandığında hata veriyor diğer methodlar görmüyor
            Baslangic();
        }
        //1 - Kartlı İşlem
        //2 - Kartsız İşlem
        static void Baslangic()
        {
            Console.WriteLine("HOSGELDİNİZ: KARTLI ISLEM İCİN 1'E BASINIZ. KARTSIZ İSLEM İCİN 2'YE BASINIZ.");
            Console.Write("seciminiz:");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Sifre();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Kartsiz islem yapmak istiyorsanız QR kod okutabilirsiniz.");
                Console.Read();
                Baslangic();
            }
            else
            {
                Console.WriteLine("Hatali secim, Lütfen 1 veya 2'ye basiniz.");
                Console.Read();
                Baslangic();
            }
        }
        /// <summary>
        /// ŞİFRE
        /// </summary>
        static void Sifre()
        {
            Console.WriteLine("---Şifre---");

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Sifre giriniz: ");
                string girilenSifre = Console.ReadLine();

                if (girilenSifre == sifre)
                {
                    Console.WriteLine("sifre dogru");
                    return;
                }
                else if (i < 3)
                    Console.WriteLine("yanlış!" + (3 - i));
                else
                {
                    Console.WriteLine("3 kez yanlış giriş yapıldı!");

                }
            }
        }
        /*
        ANA MENÜ: 
        1 - Para Çekme
        2 - Para Yatırma
        3 - Para Transferleri
        4 - Eğitim Ödemeleri
        5 - Ödemeler
        6 - Bilgi Güncelleme
        0 - Çıkış
        */
        static void AnaMenu()
        {
            Console.WriteLine("----Ana Menüye Hoş geldiniz---");
            Console.WriteLine("Bakiye: " +bakiye);
            Console.WriteLine("1- Para Çekme");
            Console.WriteLine("2- Para Yatırma");
            Console.WriteLine("3 - Para Transferleri");
            Console.WriteLine("4 - Eğitim Ödemeleri");
            Console.WriteLine("5 - Ödemeler");
            Console.WriteLine("6 - Bilgi Güncelleme");
            Console.WriteLine("0 - Çıkış");

            if (secim == "1")
            {
                ParaCek();
            }
            else if (secim == "2")
            {
                ParaYatir();
            }
            else if (secim == "3")
            {
                ParaTransfer();
            }
            else if (secim == "4")
            {
                EgitimOdemeleri();
            }
            else if (secim == "5")
            {
                Odemeler();
            }
            else if (secim == "6")
            {
                BilgiGuncelleme();
            }
            else if (secim == "0")
            {
                Cikis();
            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz");

            }
            static void ParaCek()
            {
                Console.WriteLine("para çekme işlemi");
                Console.WriteLine("bakiye: " + bakiye);
                Console.WriteLine("Çekmek istediğiniz tutar(Lütfen 5 ve 10'un katlarını giriniz:)");

                decimal tutar = decimal.Parse(Console.ReadLine());
                if (tutar > bakiye)
                {
                    Console.WriteLine("yetersiz bakiye!!!");
                }
                else
                {
                    bakiye = bakiye - tutar;
                    Console.WriteLine("işlem başarılı. lütfen paranızı bölmeden aliniz.");
                    Console.WriteLine("yeni bakiyeniz: " + bakiye + "TL");
                }
            }
            static void ParaYatirmaMenu()
            {
                Console.WriteLine("Para Yatırma");
                Console.WriteLine("1- Kredi Karti");
                Console.WriteLine("2- Kendi Hesaplarım arasında");
                Console.WriteLine("9- Ana Menü");
                Console.WriteLine("0- Çıkış");
                Console.WriteLine("------");

                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    KrediKartineYatir();
                }
                else if (secim == "2")
                {
                    KendiHesabinaYatir();
                }
                else if (secim == "9")
                {
                    AnaMenu();
                }
                else if (secim == "0")
                {
                    Cikis();
                }
                else
                {
                    Console.WriteLine("Hatali Secim");
                    ParaYatirmaMenu();
                }
            }
            //kredi kartina para yatirma
            static void KrediKartinaYatir()
            {
                Console.WriteLine("---Kredi Kartina Para Yatir");
                Console.WriteLine("KArt numarası giriniz: (en az 12 hane)");

                string kartNo = Console.ReadLine();

                if (kartNo.Length < 12)
                {
                    Console.WriteLine("12 haneden az kart numarası giremezsiniz. Geçersiz!"); //Geçersiz kart girişi yaptığında menüye dönsün
                    Console.Write("---Menüye dönüyorsunuz---");
                    MenuSecenek();
                    return;
                }
                Console.Write("Yatırmak istediginiz tutar: ");
                decimal tutar = decimal.Parse(Console.ReadLine());

                if (tutar > bakiye)
                {
                    Console.WriteLine("Yetersiz bakiye!");

                }
                else
                {
                    bakiye = bakiye - tutar;
                    Console.WriteLine("Para çekme işlemi başarılı");
                    Console.WriteLine("YENİ BAKİYENİZ: " + bakiye + "TL");
                }
                MenuSecenek();

                //kendi hesabına para yatırma ParaYatir();
                //para transfer menüsü ParaTransfer();
                //Eğitim Ödemeleri 
                //ödemeler havale işlemleri Odemeler();
                //bilgi güncelleme BilgiGuncelleme();
                //MenuSecenek 9-Ana Menü 0-Çıkış işlemi

            }



        }
        
    }
}
