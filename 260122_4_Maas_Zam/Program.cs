namespace _260122_4_Maas_Zam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             kullanıcıdan alınan bir maas icin
            eger maas degeri 25.000 ve altında ise %45 zam
            eger maas degeri 50.000 ve üstünde ise %17 zam
            eger maas 100.000 ve üstünde ise %9 zam 
            eger maas 150.000 ve üstünde ise %5 zam yapacak şekilde yazılan zam oranını ve yeni maaş kullaniciya gosteren yapiyi kodlayiniz

            */
            Console.WriteLine("Maasiniz giriniz: ");
            double maas = Convert.ToDouble(Console.ReadLine());
            double yeniMaas;

            if(maas>= 150000)
            {
                yeniMaas = maas + (maas * 0.05);
                Console.WriteLine("Yeni zam oraniniz ile maasiniz (0.05): ");
            }
            else if (maas >=100000)
            {
                yeniMaas = maas + (maas * 0.09);
                Console.WriteLine("Yeni zam oraniniz ile maasiniz (0.09): ");
            }
            else if(maas >= 50000)
            {
                yeniMaas = maas + (maas * 0.17);
                Console.WriteLine("Yeni zam oraniniz ile maasiniz (0.17): ");
            }
            else
            {
                yeniMaas = maas + (maas * 0.45);
                Console.WriteLine("Yeni zam oraniniz ile maasiniz (0.45): ");
            }

            Console.WriteLine("Yeni maasiniz: " + yeniMaas);
        }
    }
}
