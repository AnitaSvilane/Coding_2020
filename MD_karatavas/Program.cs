using System;

namespace MD_karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi minamo vārdu");
            string minamais = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Uzmini vārdu! Vārds sastāv no " + minamais.Length + " burtiem.");

            string vardsCon = null;
            char[] vards = new char [minamais.Length];
            for (int i = 0; i<vards.Length; i++)
            {
                vards[i]= '_';                
            }

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine();
                Console.WriteLine("atlikušo minējumu skaits " + (i));
                char burts = Convert.ToChar(Console.ReadLine());


                for (int k = 0; k < minamais.Length; k++)
                {
                    if (minamais[k] == burts)
                    {
                        vards[k] = burts;
                    }
                }

                for (int j = 0; j < minamais.Length; j++)
                {
                    Console.Write(vards[j]);
                    vardsCon = vardsCon + Convert.ToString(vards[j]);                    
                }
                Console.WriteLine();
                if (vardsCon == minamais)
                {
                    Console.WriteLine("Jēē");
                    break;
                }
            }           
           
         }
            

     }
    
}
