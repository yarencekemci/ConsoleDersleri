namespace _260129_1_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR DÖNGÜSÜ
            // genelde sayısal işlemlerde kullanılır ama her türlü kullanılabilir

            int sayac = 0;
            // while ve do while döngülerinde bu şekilde bir değişkene ihtiyaç duyuluyor ama fot bu yapıyı kendi içinde getiriyor

            while(sayac<100)
            {
                Console.WriteLine("sayac");
                sayac++;
            }
            // yukarıdaki while ile aşağıdaki for u karşılaştırarak kullanın
            // for (1.adım; 2.adım; 3. adım)
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(i+",");
            }
            Console.WriteLine("");
            Console.WriteLine("tersten sama for ile");
            for (int i = 25; i > 10; i--)
            {
                Console.WriteLine(i+",");
            }
        }
    }
}
