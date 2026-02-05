using System.Collections;
namespace _260203_1_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list, Collection, Array,Delegate
            // arrayList kullanmak için using System.Collections: kütüphanesini en başa eklemeniz gereklidir
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Yaren"); // Arraylist için eleman add ile eklenir
            arrayList.Add(45);
            arrayList.Add(25.5m);
            arrayList.Add(true);
            arrayList.Add(DateTime.Now.Year);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            ArrayList sayilar = new ArrayList();
            sayilar.Add(87);
            sayilar.Add(23);
            sayilar.Add(8);
            sayilar.Add(57);
            sayilar.Add(787);
            sayilar.Add(657);

            sayilar.Sort(); // küçükten büyüğe sıralama yapar.
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i] + "-");
            }
            int kapasite = arrayList.Capacity; // kapasite 2'nin üstü şeklinde değer ile artar
            Console.WriteLine("kapasite, eleman sayısı değildir.: " + kapasite);
            Console.WriteLine("count ile eleman sayisi: " + arrayList.Count); // Count, arraylist eleman sayısı verir.
            // index?
            Console.WriteLine("index no: " + arrayList.IndexOf("Yaren"));
            Console.WriteLine("index no: " + arrayList.IndexOf(25.5m));
            Console.WriteLine("45 elemanı var ama: " + arrayList.Contains(45));
            Console.WriteLine("----array list elemanları-----");
            if (arrayList.Contains(45))
            {
                Console.WriteLine("Index numarası: " + arrayList.IndexOf(45));
            }
            Console.WriteLine("array list kopya devam");
            //ArrayList kopyalamak
            //ArrayList newList = (ArrayList)arrayList.Clone();

            /*ArrayList newList = new ArrayList();
            newList.CopyTo(arrayList.ToArray());
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i]+",");
            }*/
            ArrayList newArrayList = new ArrayList(arrayList); //arraylist elemanlarını newArraylist içine kopyalar newArrayList içine kopyalar/atar
            for (int i = 0; i < newArrayList.Count; i++)
            {
                Console.WriteLine(newArrayList[i]);
            }
            Console.WriteLine("--- yeni kopya arraylist");
            arrayList.Add("Clone işlemi");
            ArrayList newCopyList = (ArrayList)arrayList.Clone(); //ArrayList bu işlemle newCopyList e kopyalanır
            //(ArrayList) işlemi class düzeyinde bir cast(tip dönüşümü) işlemidir.
            for (int i = 0; i < newCopyList.Count; i++)
            {
                Console.WriteLine(newCopyList[i]);
            }
            //------------
            Console.WriteLine("---Dongu ile ekleme----");
            ArrayList arrayListDongu = new ArrayList();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". eleman type: " + arrayList[i].GetType());
                arrayListDongu.Add(arrayList[i]);
                Console.WriteLine(arrayListDongu[i]);
            }

            //----------
            Console.WriteLine("----sayilar ArrayList----");
            sayilar.Reverse();//elemanları index numarasına göre ters çevirir
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            // ArrayList için CopyTo işlemi
            Console.WriteLine("--- copy to işlemi ----");
            string[] sehirler = new string[12];
            sehirler[0] = "İzmir";
            sehirler[1] = "Mardin";
            sehirler[2] = "Zonguldak";
            sehirler[3] = "Muğla";
            sehirler[4] = "Diyarbakır";
            sehirler[5] = "Iğdır";

            ArrayList city = new ArrayList();
            city.Add("Adana");
            city.Add("Kars");
            city.Add("Afyon");
            city.Add("Trabzon");
            city.Add("Mersin");
            city.Add("Malatya");

            //city.CopyTo(cityIndex,kopyalanacak Collection/Dizi,üzerine yazılacak Index, başlangıç değeri)
            city.CopyTo(1, sehirler, 9, 1);
            city.CopyTo(4, sehirler, 11, 1);
            for (int i = 0; i < sehirler.Count(); i++)
            {
                Console.WriteLine(i + ".index: " + sehirler[i]);
            }
        }
    }
}
