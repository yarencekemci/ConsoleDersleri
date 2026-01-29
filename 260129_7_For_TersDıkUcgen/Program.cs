namespace _260129_7_For_TersDıkUcgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
                        *
                      ***
                     ****
                    *****
                   ******
                 ********
            */

            string yildiz = "*";
            for (int i = 0; i <= 15; i++)
            {
                
                for (int k = 15; k > i; k--)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine(yildiz);
                yildiz += "*";

            }
        }
    }
}
