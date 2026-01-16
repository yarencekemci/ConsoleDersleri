namespace _260109_2_Mantıksal_Veri_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //doğru- true false-yanlış

            bool mantik1 = true;
            bool mantik2 = false;
            Console.WriteLine(mantik1);
            //< küçüktür, >büyüktür

            bool durum1 = 10 > 9; //true
            bool durum2 = 10 < 9; // false
            Console.WriteLine("10>9 Sonuç:" + durum1);
            Console.WriteLine("10<9 Sonuç:" + durum2);

        }
    }
}
