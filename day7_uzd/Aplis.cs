using System;
using System.Collections.Generic;
using System.Text;

namespace day7_uzd
{
    class Aplis
    {
        private double radiuss;

        public Aplis ()
        {
            Console.WriteLine("ievadiet radiusu");
            this.radiuss = Convert.ToDouble(Console.ReadLine());
        }
        private double laukums()
        {
            return radiuss * radiuss * Math.PI;
        }
        public void getLaukums()
        {
            Console.WriteLine("Laukums ir " + laukums());
        }
        public void print()
        {            
            Console.WriteLine("Laukums ir " + laukums() + " radiuss ir " + radiuss);
        }

    }
}
