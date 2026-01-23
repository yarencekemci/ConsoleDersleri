using System.Threading.Channels;

namespace _260123_3_ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ternary operatörü = if else yerine kullanılan operatorlerdir.
            // kullanicidan alinan bir sayi pozitif mi, negatif mi hesabini ternary ile yapalim

            // Console.WriteLine("Sayi giriniz");
            // int sayi = int.Parse(Console.ReadLine());

        // string sonuc = sayi > 0 ? "Pozitif" : sayi < 0 ? "Negatif" : "Sıfır";
        BASLA:
            Console.WriteLine("sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)
                Console.WriteLine("Pozitif: " + sayi);
            else
                Console.WriteLine("Negatif: "+sayi);
            // Console.WriteLine("---- Ternary ile");
            string sonuc;
            // Console.WriteLine(sayi > 0 ? "Pozitif:"+sayi : "Negatif:"+sayi);
            sonuc = sayi > 0 ? "Pozitif" : "Negatif";
            goto BASLA;
        }
        
    }
}
