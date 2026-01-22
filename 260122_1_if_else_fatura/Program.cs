using System.Collections.Concurrent;

namespace _260122_1_if_else_fatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Kullanıcıdan alınan aylık elektrik harcama bilgisi kw cinsinden alındıktan sonra aşağıdaki bilgiler doğrultusunda  aylık fatura hesaplanacaktır
    1-Eğer harcanan 0-100(dahil) kw arasında ise 1 kw başına 0.95 kr alınacaktır
    2-Harcanan 100-150(dahil) kw ise ilk 100 kw için 85 TL, 100 kw ı geçen her  kw başına 0.98 kr hesaplanacak
    3- Harcanan 150-275 (dahil) ise ilk 150 kw için 135 TL, 150 kw ı geçen her kw başına 1.05 kr kesaplanacak 
    3- Harcanan 275-400 (dahil) ise ilk 275 kw için 250 TL, 275 kw ı geçen her kw başına 1.25 kr kesaplanacak 
    3- Harcanan 400-600 (dahil) ise ilk 400 kw için 430 TL, 400 kw ı geçen her kw başına 1.45 kr kesaplanacak 
    5-600 kw geçen hesaplama için ilk 600 kw için 750 TL, 600 kw ı geçen her kw başına 1.55 hesaplacak şekilde toplam fatura ne kadar olacağını hesaplayan ve ekranda gösteren yapıyı kodlayınız???
            
            */
            
            double fatura = 0;
            Console.WriteLine("kw cinsinden elektiriği giriniz: ");
            double kw = Convert.ToDouble(Console.ReadLine());

            if (kw > 0 && kw <= 100)
            {
                fatura = kw * 0.95;
                Console.WriteLine("kw değer için {0} olan fatura bedeli:{1}", kw, fatura);
            }
            else if (kw > 100 && kw <= 150)
            {
                double ilk100 = 85;
                double SonDeger = (kw - 100) * 0.98;
                fatura = ilk100 + SonDeger;
                Console.WriteLine("kw deger icin {0} olan fatura bedeli: {1}", kw, fatura);
            }
            else if (kw > 150 && kw <= 275)
            {
                double ilk150 = 135;
                double SonDeger2 = (kw - 150) * 1.05;
                fatura = ilk150 + SonDeger2;
                Console.WriteLine("kw deger icin {0} olan fatura bedeli: {1}", kw, fatura);
            }
            //Harcanan 275-400 (dahil) ise ilk 275 kw için 250 TL, 275 kw ı geçen her kw başına 1.25 kr kesaplanacak 
            else if (kw > 275 && kw <= 400)
            {
                double ilk275 = 250;
                double SonDeger3 = (kw - 275) * 1.25;
                fatura = ilk275 + SonDeger3;
                Console.WriteLine("kw deger icin {0} olan fatura bedeli: {1}", kw, fatura);
            }
            // Harcanan 400-600 (dahil) ise ilk 400 kw için 430 TL, 400 kw ı geçen her kw başına 1.45 kr kesaplanacak 
            else if (kw > 400 && kw <= 600)
            {
                fatura = 430 + (kw - 400) * 1.45;
                Console.WriteLine("kw deger icin {0} olan fatura bedeli: {1}", kw, fatura);
            }
            // 600 kw geçen hesaplama için ilk 600 kw için 750 TL, 600 kw ı geçen her kw başına 1.55 hesaplacak şekilde toplam fatura
            else
            {
                fatura = 750 + (kw - 600) * 1.55;
                Console.WriteLine("kw deger icin {0} olan fatura bedeli: {1}", kw, fatura);
            }




        }
    }
}
