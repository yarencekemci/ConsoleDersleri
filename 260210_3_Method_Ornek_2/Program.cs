namespace _260210_3_Method_Ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan 3 sayiyi kücükten buyuge dogru sıralamasını yapan islemi kodlayınız

            int sayi1 = Sayi();
            int sayi2 = Sayi();
            int sayi3 = Sayi();
            Siralama(sayi1, sayi2, sayi3);
            Siralama(sayi2,sayi1,sayi3);
            Siralama(sayi3, sayi1, sayi2);
            

            Sirala(sayi1,sayi2,sayi3);
          //  EkranaYaz("Uc sayinin siralamasi: " );
        }
        static int Sayi()
        {
            Console.WriteLine("sayi giriniz: ");
            return Convert.ToInt32(Console.ReadLine());

        }
        static void Sirala(int sayi1, int sayi2, int sayi3)
        {
            #region My Code but not short
            /*
                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    if (sayi2 > sayi3)
                        Console.WriteLine("sayi1>sayi2>sayi3");
                    else if (sayi3 > sayi2)
                        Console.WriteLine("sayi1>sayi3>sayi2");
                    else if (sayi2 == sayi3)
                        Console.WriteLine("{0}>{1}={2}",sayi1,sayi2,sayi3);
                }
                else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    if (sayi1 > sayi3)
                        Console.WriteLine("sayi2>sayi1>sayi3");
                    else if (sayi3 > sayi1)
                        Console.WriteLine("sayi2>sayi3>sayi1");
                    else if (sayi1 == sayi3)
                        Console.WriteLine("sayi2>sayi1=sayi3");
                }
                else if (sayi3 < sayi1 && sayi3 < sayi2)
                {
                    if (sayi1 < sayi2)
                        Console.WriteLine("sayi3<sayi1<sayi2");
                    else if (sayi1>sayi2)
                        Console.WriteLine("sayi1>sayi3>sayi2");
                    else if (sayi1==sayi3)
                        Console.WriteLine("sayi1==sayi3>sayi2");
                }
                */ 
            #endregion
        }
        static void Siralama(int x, int y, int z)
        {
            if (x > y && x > z) // x en büyük
            {
                if (y > z)
                    Console.WriteLine(x + ">" + y + ">" + z);
                else if (z > y)
                    Console.WriteLine(x + ">" + z + ">" + y);
                else
                    Console.WriteLine(x + ">" + z + "=" +y);
            }
        }
        
    }
}
