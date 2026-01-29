namespace _260129_4_For_Dongusu_TersGosterim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-50 arasinda her ekrana yazilacak sayi icin buyukten kucuge ekranda sayilari gosteriniz (0'a kadar)

            for (int i = 0; i <=25; i++)
            {
                Console.Write(i+"-");
                for (int k = i; k >= 0; k--)
                {
                    Console.Write(k+",");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
