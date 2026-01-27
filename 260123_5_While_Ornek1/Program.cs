namespace _260123_5_While_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 ile 135 arasindaki sayilari ekrana yaziniz
            int sayi = 5;
            // bu sayilarin toplamlarini hesaplayalim
            int toplam = 0;
            while (sayi <= 135)
            {
                // toplam = toplam + sayi;
                toplam += sayi;
                Console.WriteLine(sayi + ",");
                sayi++;
            }
            Console.WriteLine("5 ve 135 arasindaki sayilarin toplami: " + toplam);
        }
    }
}
