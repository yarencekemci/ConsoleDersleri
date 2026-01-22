namespace _260120_2_If_Else_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sonuc = 10 > 5 || "Ali" == "Veli";

            //if (sonuc true)
            if (10 > 5 || "Ali" == "Veli") 
            {
                Console.WriteLine("işlem doğru");
            }
            else
            {
                Console.WriteLine("işlem yanlış");
            }
        //kullanıcıdan alınan bir sayının 2 basamaklı bir sayı olup olmadığını kontrol ediniz ve ekranda gösteriniz

        basla:

            Console.WriteLine("Sayi giriniz?");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if(sayi>=10 && sayi<=99)
            {
                Console.WriteLine("Sayi 2 basamaklidir." + sayi);
            }
            else
            {
                Console.WriteLine("Sayi 2 basamakli değildir." + sayi);
            }
            Console.WriteLine(" ");
            goto basla;

        }
    }
}
