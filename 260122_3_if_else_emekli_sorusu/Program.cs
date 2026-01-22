namespace _260122_3_if_else_emekli_sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -Emekli yaş hesabı sistemine göre aşağıdaki sistem ile kişi emekli edilerek ikramiye verilmektedir
      -Eğer cinsiyet kadın ise ve ve yaşı 60 ve üstü ise kişi maaşının 13 katı kadar ikramiye
      verilerek emekli eilecek


      -Eğer cinsiyet erkek ise ve yaşı 65 ve üstü ise kişi maaşının 15 katı kadar ikramiye
      verilerek emekli eilecek


      bu 2 koşulu sağlamayan yapı varsa emekli olamıyacaktır.
      Bu sistem emekli olup olmayacağını, emekli olursa alacağı ikramiyeyi hesaplayıp gösteren
      yapıyı kodlayınız
            */

            // Cinsiyet = 'K' Yas >= 60 maas x13 ikramiye
            // Cinsiyet = 'E' Yas >= 65 maas x15
            // iki kosul da yoksa emekli olamaz

            Console.WriteLine("Yas giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cinsiyet giriniz: ");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Maas giriniz: ");
            double maas = Convert.ToDouble(Console.ReadLine());

            double ikramiye; 

            if (yas >= 60 && cinsiyet == "kadın")
            {
                ikramiye = maas * 13;
                Console.WriteLine("İkramiyeniz: "+ikramiye);
            }
            else if (yas >= 65 && cinsiyet == "erkek")
            {
                ikramiye = maas * 15;
                Console.WriteLine("ikramiyeniz"+ikramiye);
            }
            else
            {
                Console.WriteLine("Emekli olamadiniz");
            }


        }
    }
}
