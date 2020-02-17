using System;
using System.Collections.Generic;
using System.Text;

namespace day7_uzd
{
    class Aplis
    {
        private static double radiuss;

        public static double input()
        {
            Console.WriteLine("ievadiet radiusu");
            radiuss = Convert.ToDouble(Console.ReadLine());
            return radiuss;
        }
        
        public static void print()
        {
            Console.WriteLine("Laukums ir " + (radiuss*radiuss*3.14) + " radiuss ir " + radiuss);
        }

    }
}
