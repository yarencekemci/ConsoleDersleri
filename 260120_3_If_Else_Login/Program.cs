namespace _260120_3_If_Else_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // kullanıcıdan bir web steisi için login sayfasında giriş ekranı için kullanıcı ve şifre isteyen sistemi kodlayarak tasarlayınız
        //kullanıcı adı: admin
        // kullanıcı şifre: ab?0

        Basla:
            Console.WriteLine("Kullanıcı adınızı giriniz: ");
            string kullaniciadi = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciadi == "admin" && sifre == "ab?0")
            {
                Console.WriteLine("Giriş başarılı");
                Console.WriteLine("Hoş geldiniz");
            }
            else
            {
                Console.WriteLine("kullanici adi ve sifre hatali, tekrar deneyiniz");
                goto Basla; 
            }
        }
    }
}
