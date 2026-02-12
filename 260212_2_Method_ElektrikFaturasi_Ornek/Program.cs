namespace _260212_2_Method_ElektrikFaturasi_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 Bir elektrik faturası için bazı şartlar ile fatura hesabı yapılmaktadır. Bu şartlar
eğer kullanılan elektrik kw olarak 0-150 arasında ise her kw için 1.06 Tl ile çarpılarak hesaplanmaktadır
--60*1.06=>       
eğer kullanılan elektrik kw olarak 150-300 arasında ise ilk 150 kw için 140 TL, 150 kw ve üstü içinde her kw için 1.16 Tl ile çarpılarak hesaplanmaktadır
eğer kullanılan elektrik kw olarak 300-450 arasında ise ilk 300 kw için 320 TL, 300 kw ve üstü içinde her kw için 1.25 Tl ile çarpılarak hesaplanmaktadır
 eğer kullanılan elektrik kw olarak 450-650 arasında ise ilk 450 kw için 530 TL, 450 kw ve üstü içinde her kw için 1.29 Tl ile çarpılarak hesaplanmaktadır
eğer 650 ve üstü ise ilk 650 için 800 Tl, 650 ve üstü içnde 1.32 Tl   ile çarpılarak hesaplanmaktadır
bu şartlar kullanıcının gireceği harcadoğı elektriği kw cinsinden  aldoktan sonra ödeyeceği faturayı hesaplayınız?


 */
            double fatura = 0;
            FaturaHesapla();
        }
        static double FaturaHesapla ()
        {
            Console.WriteLine("Lütfen kw giriniz: ");
            double fatura = 0;
            double kw = Convert.ToDouble(Console.ReadLine());
            
            if (kw > 0 && kw <= 150)
            {
                fatura = kw * 1.06;
                Console.WriteLine("Harcanan:{0} ve fatura:{1} ", kw, fatura);

            }
            // kullanılan elektrik kw olarak 150-300 arasında ise ilk 150 kw için 140 TL, 150 kw ve üstü içinde her kw için 1.16 Tl ile çarpılarak hesaplanmaktadır
            else if (kw > 150 && kw <= 300) 
            {
                //160 harcanan kw
                //160-150=>140=>(fatura-150)=>140
                //10 *1.16=>(fatura-150)*1.16
                //Ödenecek=140+(fatura-150)*1.16;
                fatura = (kw - 150) * 1.16;
                Console.WriteLine("Harcanan:{0} ve fatura:{1} ", kw, fatura);
            }
            else if (kw > 300 && kw <= 450)
            {
                // 320-300
                fatura = 320 + (kw - 300) * 1.25;
                Console.WriteLine("Harcanan:{0} ve fatura:{1} ", kw, fatura);
            }
            else if (kw > 450 && kw <= 650)
            {
                // 450-530
                fatura = 530 + (kw - 450) * 1.29;
                Console.WriteLine("harcanan:{0} ve fatura:{1} ", kw, fatura);
            }
            else if(kw>650)
            {
                fatura = 850 - (kw - 650) * 1.32;
                Console.WriteLine("harcanan:{0} ve fatura:{1} ",kw,fatura);
                
            }
            return fatura;

        }
    }
}
