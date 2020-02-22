using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class arrayEx
    {
        public static void ex1()
        {
            int[] a = new int[5];

            a[0] = 4;
            a[1] = 89;
            a[2] = 23;
            a[3] = 13;
            a[4] = 87;

            int[] c = { 4, 89, 23, 13, 87 };

            string[] b = new string[3];

            b[0] = "a";
            b[1] = "df";
            b[2] = "5";

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);

            for (int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    
}
