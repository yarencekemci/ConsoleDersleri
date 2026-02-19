using System;

namespace ATM_Uygulamasi
{
    internal class Program
    {
        static decimal bakiye = 250;
        static string sifre = "ab18";
        static int girisHakki = 3;

        static void Main(string[] args)
        {
            GirisEkrani();
        }

        static void GirisEkrani()
        {
            Console.WriteLine("---Hos geldiniz. Lutfen yapmak istediginiz islemi seciniz---");
            Console.WriteLine("Kartli islem icin: 1");
            Console.WriteLine("Kartsiz islem icin: 2");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                SifreKontrol();
            }
            else
            {
                Console.WriteLine("Kartsiz islem icin Ana sayfaya donup QR kod okutunuz.!");
            }
        }

        static void SifreKontrol()
        {
            while (girisHakki > 0)
            {
                Console.Write("Sifre giriniz: ");
                string girilenSifre = Console.ReadLine();

                if (girilenSifre == sifre)
                {
                    AnaMenu();
                    return;
                }
                else
                {
                    girisHakki--;
                    Console.WriteLine("Hatali sifre.! Kalan hak: " + girisHakki);
                }
            }

            Console.WriteLine("Deneme hakkiniz bitti. Sistem cikis yapiliyor.");
        }

        static void AnaMenu()
        {
            Console.WriteLine("--- ANA MENÜ ---");
            Console.WriteLine("1 - Para Çekme");
            Console.WriteLine("2 - Para Yatırma");
            Console.WriteLine("3 - Para Transferleri");
            Console.WriteLine("4 - Eğitim Ödemeleri");
            Console.WriteLine("5 - Ödemeler");
            Console.WriteLine("6 - Bilgi Güncelleme");
            Console.WriteLine("0 - Çıkış");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                ParaCekme();
            }
            else if (secim == "2")
            {
                ParaYatirma();
            }
            else if (secim == "3")
            {
                ParaTransferleri();
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
                return;
            }
            else
            {
                Console.WriteLine("Hatali secim! Lütfen kontrol ediniz.");
                AnaMenu();
            }
        }

        static void ParaCekme()
        {
            Console.Write("Cekilecek tutar: ");
            decimal tutar = Convert.ToDecimal(Console.ReadLine());

            if (tutar <= bakiye)
            {
                bakiye -= tutar;
                Console.WriteLine("Para cekildi. Yeni bakiyeniz: " + bakiye);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }

            MenuDonus();
        }

        static void ParaYatirma()
        {
            Console.WriteLine("1 - Kredi Kartına");
            Console.WriteLine("2 - Kendi Hesabına");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Kart numarasi giriniz: ");
                string kartNo = Console.ReadLine();

                if (kartNo.Length >= 12)
                {
                    Console.Write("Yatirilacak tutar: ");
                    decimal tutar = Convert.ToDecimal(Console.ReadLine());

                    if (tutar <= bakiye)
                    {
                        bakiye -= tutar;
                        Console.WriteLine("İslem basarili.");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz kart numarasi.");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Yatirilacak tutar: ");
                decimal tutar = Convert.ToDecimal(Console.ReadLine());
                bakiye += tutar;
                Console.WriteLine("yeni bakiye: " + bakiye);
            }

            MenuDonus();
        }

        static void ParaTransferleri()
        {
            Console.WriteLine("1 - EFT");
            Console.WriteLine("2 - Havale");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("IBAN : ");
                string iban = Console.ReadLine();

                /*
                 StartsWith() = başlangıcı kontrol eder
                 EndsWith()	= sonu kontrol eder
                 Contains()	= içeriyor mu bakar
                 */
                if (iban.StartsWith("TR") && iban.Length == 14) //TR ile başlayıp başlamadığını kontrol ettik
                {
                    Console.Write("Gonderilecek tutar: ");
                    decimal tutar = Convert.ToDecimal(Console.ReadLine());

                    if (tutar <= bakiye)
                    {
                        bakiye -= tutar;
                        Console.WriteLine("EFT başarılı.");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                    }
                }
                else
                {
                    Console.WriteLine("gecersiz IBAN.");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Hesap numarası giriniz: ");
                string hesapNo = Console.ReadLine();

                if (hesapNo.Length == 11)
                {
                    Console.Write("Gonderilecek tutar: ");
                    decimal tutar = Convert.ToDecimal(Console.ReadLine());

                    if (tutar <= bakiye)
                    {
                        bakiye -= tutar;
                        Console.WriteLine("Gonderim basarili.");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz hesap numarası.");
                }
            }

            MenuDonus();
        }

        static void EgitimOdemeleri()
        {
            Console.WriteLine("Bu sayfa bakim asamasindadir. Anlayisiniz icin tesekkür ederiz");
            MenuDonus();
        }

        static void Odemeler()
        {
            Console.Write("fatura tutari: ");
            decimal tutar = Convert.ToDecimal(Console.ReadLine());

            if (tutar <= bakiye)
            {
                bakiye -= tutar;
                Console.WriteLine("Odeme yapildi.");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }

            MenuDonus();
        }

        static void BilgiGuncelleme()
        {
            Console.Write("Mevcut Sifre: ");
            string eski = Console.ReadLine();

            if (eski == sifre)
            {
                Console.Write("Yeni sifre: ");
                sifre = Console.ReadLine();
                Console.WriteLine("Sifre guncellendi.");
            }
            else
            {
                Console.WriteLine("Sifre yanlis.");
            }

            MenuDonus();
        }

        static void MenuDonus()
        {
            Console.WriteLine("9 -Ana menu");
            Console.WriteLine("0 -Cıkıs");

            string secim = Console.ReadLine();

            if (secim == "9")
                AnaMenu();
            else if (secim == "0")
            {
                Cikis();
            }
            else
            { 
                Console.WriteLine("Hatali secim yaptiniz. Ana menuye yonlendiriliyorsunuz"); 
                Console.ReadKey(); 
                AnaMenu(); 
            }
        }

        static void Cikis()
        {
            Console.WriteLine("Cikis yapiliyor...");
            Environment.Exit(0);
        }
    }
}

