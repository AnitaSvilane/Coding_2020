using System;
using System.Collections.Generic;
using System.Text;

namespace day7_uzd
{
    class ievade
    {
        private static double sk1;
        private static double sk2;

        
        public static double ievadeSk1()
        {
            Console.WriteLine("ievadiet pirmo skaitli");
            sk1 = Convert.ToDouble(Console.ReadLine());
            
            return sk1;
        }
        
        public static double ievadeSk2()
        {
            Console.WriteLine("ievadiet otro skaitli");
            sk2 = Convert.ToDouble(Console.ReadLine());

            return sk2;
        }
        public static void print()
        {
            Console.WriteLine(sk1+sk2);
        }

    }
}
