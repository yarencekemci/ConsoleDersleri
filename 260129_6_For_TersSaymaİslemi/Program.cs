namespace _260129_6_For_TersSaymaİslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dik ücgen karakter sayisi max alıncak sekilde max degerden 0 dogru ayni satida yazdiriniz

            string yildiz = "*";
          
            for (int i = 1; i < 10; i++)
            {

                Console.Write(yildiz+"-");
                
                for (int k = i; k >= 0; k--)
                {
                    Console.Write(k+",");
                    
                }
                Console.WriteLine();
                yildiz += "*";

            }
        }
    }
}
