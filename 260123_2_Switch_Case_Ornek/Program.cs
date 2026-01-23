namespace _260123_2_Switch_Case_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanicidan alinan kacinci ayda oldugunu bilgisini veren ayın adı ve hangi mevsim
            Console.WriteLine("Hangi aydasiniz?: ");
            byte ay = Convert.ToByte(Console.ReadLine());

       
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kıs mevsimindesiniz.");
                    if (ay == 12)
                        Console.WriteLine("Aralik");
                    else if (ay == 1)
                        Console.WriteLine("Ocak");
                    else if (ay == 2)
                        Console.WriteLine("Subat");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    if (ay == 3)
                        Console.WriteLine("Mart");
                    else if (ay == 4)
                        Console.WriteLine("Nisan");
                    else if (ay == 5)
                        Console.WriteLine("Mayis");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("YAZ mevsimindesiniz");
                    if (ay == 6)
                        Console.WriteLine("Haziran");
                    else if (ay == 7)
                        Console.WriteLine("Temmuz");
                    else if (ay == 8)
                        Console.WriteLine("Agustos");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevisimindesiniz");
                    if (ay == 9)
                        Console.WriteLine("Eylul");
                    else if (ay == 10)
                        Console.WriteLine("Ekim");
                    else if (ay == 11)
                        Console.WriteLine("Kasim");
                    break;
                default:
                    Console.WriteLine("Hatali ay girisi yaptiniz. Lutfen (1-12) arasi seciniz.");
                    break;


                    /*
                     Oneri:
                    Yaz mevsimi icin if else disinde switch-case de yapilabilir
                    switch(ay)
                    case 6:
                    Console.WriteLine("Haziran");
                    case 7:
                    Console.WriteLine("Temmuz");
                    case 8:
                    Console.WriteLine("Agustos");
                    break;
                    default:
                    // bu cozumde default alani okunmaz
                    Console.WriteLine("bu alan okunmaz");
                    break;

                     */
            }
        }
    }
}
