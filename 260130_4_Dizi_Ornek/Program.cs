namespace _260130_4_Dizi_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = new double[6];
            //6 elemani ekleyip eklenen elemanlari ekranda gosteriniz

            //int diziler = dizi.Length;
            //dizi[0] = 10;
            //dizi[1] = 20;
            //dizi[2] = 30;
            //dizi[3] = 40;
            //dizi[4] = 50;
            //dizi[5] = 60;

            //kullanici girerse
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i+1+". elemani");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("diziler");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine((i+1)+" dizi elemani: " + dizi[i]);
            }


        }
    }
}
