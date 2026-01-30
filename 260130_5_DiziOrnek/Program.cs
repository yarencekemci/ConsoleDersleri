namespace _260130_5_DiziOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 sayi aliniz, girilen 11 sayiyi listelerken cift olan sayilarin sagında cift, tek olan sayilarin saginda tek yaziniz
            int[] sayilar = new int[11];
            int elemansayisi = sayilar.Length;
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+". eleman: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = elemansayisi;
                
            }
            for (int i = 0; i < elemansayisi; i++)
            {
                //if (i % 2 == 0)
                //{
                //    Console.WriteLine((i) + "cift");
                //    i++;
                //}
                //if (i % 2 != 0)
                //{
                //    Console.WriteLine((i) + "tek");
                //    i++;
                //}
                string yaz = sayilar[i] % 2 == 0 ? "-Çift" : "-Tek";
                Console.WriteLine(sayilar[i]+yaz);
            }
        }
    }
}
