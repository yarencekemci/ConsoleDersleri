namespace _260115_3_Mantiksal_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Mantıksal operatorler
             and işareti &&
            or işareti ||
            ----
            && - and 2 koşul true olursa sonuç true olur
            true && true = true 
            true && false = false
            false && true = false
            false && false = false
            
            || - or (veya) 1 koşulda true olması sonucun true olması için yeterlidir
            true || true = true
            false || true = true
            true || false = true
            false || false = false
             */
            bool sonuc = 10 > 5 && 20 > 15;
            // true && true
            // true
            Console.WriteLine("10>5 && 20>15 işlem sonucu:" +sonuc);
            sonuc = 10>5 && 0>=2;
            //true && false - false
            Console.WriteLine("10>5 && 0>=2 sonuç: " +sonuc);
            sonuc = 10 >=5 || 0>=2;
            Console.WriteLine("10>=5 || 0>=2 sonuç: "+sonuc);

        }
    }
}
