namespace _260115_1_Aritmetik_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Operatörler, programlama dillerinde belirli işlemleri gerçekleştirmek için kullanılan sembollerdir.
             1- Aritmetik
             2- Karşılaştırma
             3- Atama
             4- Mantıksal
             */
            // Aritmetik operatörler: +,-,*,/,% (toplama,çıkartma,çarpma,bölme,mod alma)
            int sayi1 = 57;
            int sayi2 = 25;
            int topla= sayi1 + sayi2;
            int carp = sayi1 * sayi2;
            int bol = sayi1 / sayi2;
            int cikart = sayi1 - sayi2;

            //mod alma- bir sayının diğer sayıya  bölümünden modu verir.
            int modAl = sayi1 * sayi2;
            Console.WriteLine("Toplam: "+topla);
            Console.WriteLine("Cikarma: " + cikart);
            Console.WriteLine("Bolme: " + bol);
            Console.WriteLine("Carpma: " + carp);
            Console.WriteLine("Mod Alma: " + modAl);
            //

        }

    }
}
