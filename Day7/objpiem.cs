using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class objpiem
    {
        private int a;
        private int b;

        public objpiem(int localA, int b)
        {
            a = localA; //1. veids
            this.b = b; //2. veids
        }

        public void setA(int localA)
        {
            a = localA;
        }
        public void setB(int localB)
        {
            b = localB;
        }
        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public void print()
        {
            Console.WriteLine("a=" + a + " b="+b);
        }
    }
}
