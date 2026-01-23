namespace _260123_4_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ardışık işlemleri kosula baglı ya da kosulsuz yapmak icin donguler kullanilir
            1- while
            2- do while
            3- for
            4- foreach
            */

            int sayi = 0;
            // while(true)
            while (sayi<10) // 0<10,1<10,2<10,3<10,....,9<10,10<10- false- dongu bıter
            {
                // dongu true oldugunda bu alandaki kodlar okunacaktır
                Console.WriteLine(sayi); //0,1,2,3,...,8,9
                sayi++; //0+1+2+3+4+5+6+....
                // sayi bir sayactir dongu icin. Burada sayac sürekli arrtırma islemi yapmis
            }
        }
    }
}
