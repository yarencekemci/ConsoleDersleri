using System.ComponentModel.Design;

namespace _260127_1_SuperSayilar_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kendisi hariç bolununlerin toplamı kendisini veren sayiya super sayi denir. 1-100000 arasindaki süper sayilari listeleyiniz.

            int sayi = 0;
            

            while(sayi<100000)
            {
                int bolenSayi = 1;
                int toplam = 0;
                while(sayi>bolenSayi)
                {
                    if (sayi % bolenSayi == 0)
                    { 
                        toplam = toplam + bolenSayi; 
                    }
                    bolenSayi++;
                    
                }
                
                if (toplam == sayi)
                {
                    Console.WriteLine("Super sayi: " + sayi);
                }
                sayi++;
            }
            Console.ReadLine();
            
            

        }
    }
}
