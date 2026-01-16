namespace _260116_1_Atama_Operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Atama Operatörleri
            += topla ve eşitle
            -= çıkart ve eşitle
            *= çarp ve eşitle
            /= böl ve eşitle
            %= mod al ve eşitle
            ++ 1 arttır
            -- 1 azalt
            + string olarak birleştir
            */

            int sayi1 = 900;
            //kodun içinde herhangi bir yerde sayi1 e yeni değer eklenmesi gerekiyor

            
            // sayi yeniSayi1 olarak devam edicek
            // int yeniSayi1 = sayi1 +10; // bunun yerine aşağıdaki atama işlemi yapılarak yeni değişken tanımlaması yapılmaz, sayi degiskeni yeni aldigi deger uzerinden islem görmesini saglayacaktır
            // sayi1 = sayi1 + 10;
            sayi1 += 10;
           
            // kod ilerledi, sayi1 için yeni bir işlem gerekli oldu, örneğin %20 artırılmak istendi

            //int yeniSayi2 = yeniSayi1 + yeniSayi1 * 20/100;
            //sayi1 artik yeniSayi2 olarak devam edicek
            // sayi1 = sayi1 + sayi1 * 20 /100;
            sayi1 += sayi1 * 20 / 100;
            // --------------------
            int sayi2 = 100; // değerini 5 ile çarpalım
            //sayi2 = sayi2 * 5;
            sayi2 *= 5;
            Console.WriteLine("sayi2=100, sayi2 değeri 5 ile çarptık: "+ sayi2);
            
            int sayi3 = 450;
            // sayi3 9 ile bölündüğünde sonucunu atama operatoru ile yazalim
            sayi3 /= 9;
            Console.WriteLine("450 degerinin 9 ile bolunmesi: "+ sayi3);

            int sayi4 = 845;
            // sayi4 degerinin 9 ile bolunmesinde kalani atama operatoru ıle hesaplayiniz
            sayi4 %= 9;
            Console.WriteLine("845 sayisinin 9 ile bolunmesınden kalan: " + sayi4);
            /*
             ++
             --
             +
             operatorlerin kullanilmasi

            */

            int deger1 = 10;
            deger1++; // deger1 in degeri 1 arttirildi
            Console.WriteLine("deger1 = 10 degeri ++ ile arttirildi"+ deger1);
            deger1 += 1; // deger ++ ile aynidir
            Console.WriteLine("deger1=10 +=1 ile arrildi:"+ deger1);
            int deger2 = deger1; // deger1 in degeri 1 arttirilir ve deger2 ye atanir
            Console.WriteLine("++deger1 : "+ deger2);
            //int deger3 = deger2++ +10; //ilkin deger2 değeri deger3 e eşitlenir sonra ++ işlemi deger2 ye uygulanır
            int deger3 = ++deger2 + 10; // deger2 nin degeri 1 arttirilir ve 10 ile toplanarak deger 3 e atanır. deger artimi yapilarak eşitleme yapilir
            Console.WriteLine("deger3 icin: "+deger3);

            //------
            // TOPLAMA VE ÇARPMA İŞLEMİ YAPILIYORSA PARANTEZ İÇİNE ALINIR YOKSA STRİNG BİR İFADE OLARAK ALGILAR
            int s1 = 10;
            int s2 = 20;
            int toplam = s1 + s2;
            Console.WriteLine("hesaplanan toplam: "+toplam);
            Console.WriteLine("string toplam: " + +s1+s2); //1020
            Console.WriteLine("parantez toplam: " + (s1+s2)); //30
            Console.WriteLine("carpim: " + s1*s2);
            Console.WriteLine("parantez fark: " + (s1-s2));
            Console.WriteLine("bolme: " + s1 / s2);
            Console.WriteLine("mod alma: "+ s1% s2);
            Console.WriteLine("----------");
            Console.WriteLine(s1+s2); // 30 olacaktır, önünde herhangi bir string ifade olmadığı için toplar
            Console.WriteLine(""+s1+s2); //1020 olacaktır. + işleminden önce "" var.
            // -----------------------
            // BÖLME İŞLEMİ İÇİN BAZI NOTLAR
            // 10/2=5 10 2'nin katıdır
            //14125-> 2,3,5,11,53
            int kat1 = 14125;
            Console.WriteLine("14125,2nin katı mı?: "+kat1%2);
            Console.WriteLine("14125,3ün katı mı?: " + kat1 % 3);
            Console.WriteLine("14125,5in katı mı?: " + kat1 % 5);
            Console.WriteLine("14125,11in katı mı?: " + kat1 % 11);
            Console.WriteLine("14125,53ün katı mı?: " + kat1 % 53);

        }
    }
}
