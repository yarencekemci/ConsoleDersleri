namespace _260129_2_For_Dongusu_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tek for ile 50-5000 arasındaki 11 ve 13ün katları sayısı ve katları toplamlarını ayrı ayrı gosteriniz
            int toplam11 = 0;
            int toplam13 = 0;

            int adet11 = 0;
            int adet13 = 0;
            

            for (int i = 50; i < 5000; i++)
            {

                if (i % 11 == 0)
                {
                    adet11++;
                    toplam11 += i;
                }
                
                
                if (i % 13 == 0)
                {
                    adet13++;
                    toplam13 += i;
                }

            }
                Console.WriteLine("11'in katlari sayisi:{0} ve toplami:{1} ",adet11,toplam11);
                Console.WriteLine("13'in katlari sayisi:{0} ve toplami:{1} ", adet13, toplam13);

        }
    }
}
