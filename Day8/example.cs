using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class example
    {
        private int a;
        private int b;
        public example(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void print()
        {
            Console.WriteLine("a=" + a + " b=" + b);
            priv();
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return a;
        }
        private void priv()
        {
            Console.WriteLine("šito nevar izsaukt no main");
        }
    }
}
