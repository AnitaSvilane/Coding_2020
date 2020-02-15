using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class piemers
    {
        //public - var piekļūt no ārpasaules
        //private - var izmantot tikai šajā klasē
        public static int a = 5;
        private static int b = 8;
        public static void test()
        {
            Console.WriteLine("Hello");
            privatetest();
        }
        private static void privatetest()
        {
            Console.WriteLine("Cits piemērs");
            Console.WriteLine(b);
        }
    }
}
