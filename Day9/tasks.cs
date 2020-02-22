using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class tasks
    {
        public static void uzd2()
        {
            //masīvs ar 5 elementiem
            //string tipa
            //4 elementus aizpilda cilvēks
            //5 glabājas pārējo elementu summa
                        
            string[] masivs = new string[5];

            for (int i = 0; i < masivs.Length-1; i++)
            {
                Console.WriteLine("aizpildi masivu ar burtiem");
                masivs[i] = (Console.ReadLine());
                masivs[masivs.Length - 1] = masivs[masivs.Length - 1] + masivs[i];
            }      
                       
             Console.WriteLine(masivs[masivs.Length - 1]);           

        }
        public static void uzd1()
        {
            //uztaisīt masīvu, kuram garumu ievada lietotājs
            //pēc tam, lai lietotājs, šo masīvu aizpilda ar izvēlētām vērtībām

            //int tipa masīvs
            //izvadīt masivu

            Console.WriteLine("ievadi masīva garumu");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[garums];

            for (int i=0; i<a.Length; i++)
            {
                Console.WriteLine("aizpildi masivu ar skaitliem");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);                
            }

        }
        


    }
}
