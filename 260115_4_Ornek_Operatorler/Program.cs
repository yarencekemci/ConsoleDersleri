namespace _260115_4_Ornek_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sonuc;

            sonuc = 14 >= 14;
            //true
            Console.WriteLine("14>= 14 sonuç: " + sonuc);
            sonuc = 14 >= 14 || (45 == 45);
            Console.WriteLine("14 >= 14 || (45 == 45) sonuc: " + sonuc);
            sonuc = 14 >= 14 && (45 == 45 && "software" == "yazilim");
            //true && (true && false)
            //true && false
            //false
            Console.WriteLine("14>=14 && (45 == 45 && \"software\"==\"yazilim\") sonuç):" + sonuc);
            sonuc = 'a' != 'A' && (14 >= 4 || (DateTime.Now.Year == 2026 && true != false)); //işlem sonucunu adım adım yazınız
            sonuc = "Yaşar kemal Van" != "Orhan Pamuk İstanbul" && ((14.5 == Convert.ToDouble("14.5") || false == true) && (double)45 == Convert.ToDouble("45")); //Adım adım çözümlerini veriniz

            /*
			
			
            1-
           sonuc = 'a' != 'A' && (14 >= 4 || (DateTime.Now.Year == 2026 && true != false)); 
		   (DateTime.Now.Year == 2026 && true != false)
		   true && true = true
		   14 >= 4 || true
		   true || true = true
		   'a' != 'A' && true = ?
		   true && true = true
		   
		   sonuc = "Yaşar kemal Van" != "Orhan Pamuk İstanbul" && ((14.5 == Convert.ToDouble("14.5") || false == true) && (double)45 == Convert.ToDouble("45"));
		   
		   //1. işlem 
		   (14.5 == Convert.ToDouble("14.5") || false == true) && (double)45 == Convert.ToDouble("45")
		   true || false => true && true => true
		   "Yaşar kemal Van" != "Orhan Pamuk İstanbul" && true
		   true && true = true 
		   */
        }
    }
}
