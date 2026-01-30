namespace _260130_2_DızıOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanicidan alinan 7 sayinin alindiktan sonra ekranda gosteriniz toplamlarini hesaplayiniz

            int[] sayilar = new int[7];
            int elemanSayisi = sayilar.Count();
            int toplam = 0;

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine((i+1)+". sayiyi giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
            }
            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine(i+1+". eleman: "+sayilar[i]);
            }
            Console.WriteLine("Toplamlari: " + toplam);
        }
    }
}
