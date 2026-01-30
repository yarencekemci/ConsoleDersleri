namespace _260130_6_Dizi_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // random - rastgele sayi üretmek icin kullanilan bir class yapisidir
            Random rastgele = new Random();
            Console.WriteLine(rastgele.Next(200));

            for (int i = 0; i < 150; i++)
            {
                int sayi = rastgele.Next(200);
                Console.Write(sayi+",");
            }
            /*
           

            */

        }
    }
}
