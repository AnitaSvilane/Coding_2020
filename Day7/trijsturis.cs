using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class trijsturis
    {
        private static int a = 0;
        private static int b = 0;
        private static int c = 0;

        public static void setA(int localA)
        {
            a = localA;
        }
        public static void setB(int localB)
        {
            b = localB;
        }
        public static void setC(int localB)
        {
            c = localB;
        }
        public static string perimetrs()
        {
            int summ = 0;
            if (a<=0 || b<=0 || c<=0)
            {
                return "kāda no malām ir 0 vai negatīvs skaitlis";
            }
            else if (a>b+c || b>a+c || c>a+b)
            {
                return "šāds trijstūris neeksistē";
            }
            else
            {
                summ = a + b + c;
                string rez = Convert.ToString(summ);
                return "perimetrs ir "+rez;
            }
            
        }


    }
}
