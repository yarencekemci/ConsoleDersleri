using System.Collections;

namespace _260205_1_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50 };
            string[] isimler = { "ahmet", "yaren", "yagız", "onur", "mahmut", "selin", "berk", "samet" };
            ArrayList arrayList = new ArrayList();
            arrayList.Add("c# ArrayList-foreach");
            arrayList.Add(12);
            arrayList.Add(100);
            arrayList.Add(55.78);
            arrayList.Add(true);
            arrayList.Add(isimler[2]);
            arrayList.Add(DateTime.Now);
            arrayList.Add(sayilar[5]);

            //while, do while, for döngülerinde sayaç mantığı vardır, foreach bu konuda daha kullanışlıdır sayaç gibi değerler almaz
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
