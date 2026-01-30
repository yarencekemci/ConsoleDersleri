namespace _260130_3_Dizi_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan alinan 7 sayiyi aldiktan sonra ekranda gosterip toplamlarini hesaplayiniz

            int[] sayilar = new int[7];
            int elemanSayisi = sayilar.Count();
            int toplam = 0;
            int i = 0;
            do
            {
                
                Console.WriteLine((i+1) + ". sayiyi giriniz.");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += i;
                i++;
            } while (i < elemanSayisi);
            
            
            Console.WriteLine("toplam: " + toplam);
            Console.WriteLine("---------son");
             Console.ReadLine();
            
        }
    }
}
