namespace _260127_2_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                while döngüsü ilk koşulu ele alır, koşul doğru ise döngü içinde kodlar işleme alınır
                do while koşula bakmadanişlem yapar, sonra koşula bakar, koşul doğru ise döngü içinde kodlar tekrar işleme alınır
             
            while(true) //1.adım döngü içinde koşul ele alınır
            {

            }
            do //do-> yap
                // buraya kod yazılmaz
            {
                // do while için kod alanı
                // 1. adım-> döngü kodlarının yazıldığı bu alan 1 kez işleme alınır. 1 kez işleme alındıktan sonra aşağıdaki do yapısının döngü koşuluna bakılır
                //kod alanı bittiğinde aşağıdaki while yapısı ile anlaşılır
            } while (true); //2. adım koşul doğru ise tekrar kod alanına dönülür ve kodlar işleme alınır
            
             */
            //int sayi = 1;
            //while (sayi>0) 0>0-> false
            // Console.WriteLine("Sayi 0'dan büyüktür");
            int sayi = 1;
            Console.WriteLine("*do while*");
            do
            {
                Console.WriteLine("Sayi 0dan büyüktür: ");
            } while (sayi > 0);
            Console.ReadLine();
        }
    }
}
