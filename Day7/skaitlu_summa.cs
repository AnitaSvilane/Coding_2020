using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class skaitlu_summa
    {
        private static int a = 0;
        private static int b = 0;

        public static void setA(int localA)
        {
            a = localA;
        }
        public static void setB(int localB)
        {
            b = localB;
        }
        public static int getA()
        {
            return a;
        }
        public static int getB()
        {
            return b;
        }
        public static int summ()
        {
            return a + b;
        }
    }
}
