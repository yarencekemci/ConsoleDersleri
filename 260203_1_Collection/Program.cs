using System.Collections; //array list için gerekli


namespace _260203_1_Collection
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
                Console.WriteLine(sayilar[i]+ "-");
            }
            int kapasite = arrayList.Capacity; // kapasite 2'nin üstü şeklinde değer ile artar
            Console.WriteLine("kapasite, eleman sayısı değildir.: "+ kapasite);
            Console.WriteLine("count ile eleman sayisi: "+arrayList.Count); // Count, arraylist eleman sayısı verir.
            // index?
            Console.WriteLine("index no: "+ arrayList.IndexOf("Yaren"));
            Console.WriteLine("index no: " + arrayList.IndexOf(25.5m));
            Console.WriteLine("45 elemanı var ama: " + arrayList.Contains(45));
            if (arrayList.Contains(45))
            {
                Console.WriteLine("Index numarası: "+ arrayList.IndexOf(45));
            }
            //ArrayList kopyalamak
            //ArrayList newList = (ArrayList)arrayList.Clone();

            /*ArrayList newList = new ArrayList();
            newList.CopyTo(arrayList.ToArray());
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i]+",");
            }*/
            
        }
    }
}
