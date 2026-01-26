namespace _260123_6_While_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) 1-100 arasindaki sayilari ekrana yazin ve toplamlarini hesaplayiniz
            2) 55-255 arasindaki 5in katlari ekrana yazin ve toplamlarini hesaplayiniz
            3) 500 den 0'a dogru 13 katlarini ekranda yaziniz (tersten sayim olacak)
            4) 1-10000 arasindaki asal sayilarin toplamini hesaplayiniz
            */

            // 1-100 arasindaki sayilari ekrana yazin ve toplamlarini hesaplayiniz
            int sayi = 1;
            int toplam = 0;

            while(sayi<=100)
            {
                Console.Write(sayi + ", ");
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine(" "); 
            Console.WriteLine("1-100 arasindaki sayilarin toplami: " + toplam);
            Console.WriteLine("----------");

            //55-255 arasindaki 5in katlari ekrana yazin ve toplamlarini hesaplayiniz
            int sayi2 = 55;
            int toplam2 = 0;
            while(sayi2<=255)
            {
                if(sayi2 %5 ==0)
                {
                    Console.Write(sayi2 + ", ");
                    toplam2 += sayi2;
                }
                sayi2++;
            }
            Console.WriteLine("55 ve 255 arasindaki 5in katlari olan sayinin toplami: "+toplam2);
            Console.WriteLine("----------");

            //500 den 0'a dogru 13 katlarini ekranda yaziniz (tersten sayim olacak)
            int sayi3 = 500;

            while(sayi3 >= 0)
            {
                if(sayi3 % 13 == 0)
                {
                    Console.Write(sayi3 + ", ");
                }
                sayi3--;
            }
            Console.WriteLine();        
            Console.WriteLine("----------");

            // 1-10000 arasindaki asal sayilarin toplamini hesaplayiniz
            // 1 asal sayı degildir

            int sayi4 = 2;
            int toplam4 = 0;

            while (sayi4 <= 10000)
            {
                int i = 2;
                bool asalMi = true;

                while (i < sayi4)
                {
                    if (sayi4 % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                    i++;
                }

                if (asalMi)
                {
                    Console.Write(sayi4 + ", ");
                    toplam4 += sayi4;
                }

                sayi4++; 
            }

            Console.WriteLine(" ");
            Console.WriteLine("Asal sayilarin toplami: " + toplam4);

        }
    }
}
