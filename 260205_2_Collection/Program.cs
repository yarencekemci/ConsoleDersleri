using System.Collections.ObjectModel;
namespace _260205_2_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection kullanmak için using System.Collections.ObjectModel; kütüphanesini en üst taraf olan using alanina eklenmesi gereklidir.
            Collection<string> list1 = new Collection<string>(); // çalışanların isimleri
            list1.Add("c#");

            List<int> sayilar = new List<int>();// Fabrika çalışan sırası
            sayilar.Add(10);

            Collection<double> maaslar = new Collection<double>(); //Maaşları listelemek için kullanılır
            maaslar.Add(65152);
            maaslar.Add(35125);
            maaslar.Add(65100);
            maaslar.Add(95400);
            //foreach- eleman sayısı belli olmayan collection yapılar içni listeleme yapar
            foreach (var item in maaslar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
