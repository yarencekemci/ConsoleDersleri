namespace _260129_3_For_Dongusu_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-15000 arasindaki sayilarin 5'in kati olup, 2'nin kati olmayan sayilarin sayisi ve toplamlarını hesaplayınız

            int toplam = 0;
            int adet = 0;

            for (int i = 1; i < 15000; i++)
            {
                if((i%5==0) && (i%2!=0))
                {
                    adet++;
                    toplam += i;
                }
              
            }
            Console.WriteLine("5'in kati olan, 2 nin kati olmayan sayilar: " + adet);
            Console.WriteLine("5'in kati olan, 2 nin kati olmayan sayilar: " + toplam);
        }
    }
}
