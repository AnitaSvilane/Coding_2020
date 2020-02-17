using System;
using System.Collections.Generic;
using System.Text;

namespace day7_uzd
{
    class darbiba
    {
        private double sk1;
        private double sk2;
        private string darb;
        private double rez = 0;
        public darbiba (double sk1, double sk2, string darb)
        {
            this.sk1 = sk1;
            this.sk2 = sk2;
            this.darb = darb;            
            
            
        }
        public void print()
        {
            if (darb == "+")
            {
                rez = sk1 + sk2;
            }
            else if (darb == "-")
            {
                rez = sk1 - sk2;
            }
            else if (darb == "*")
            {
                rez = sk1 * sk2;
            }
            else if (darb == "/")
            {
                rez = sk1 / sk2;
            }
            else
            {
                Console.WriteLine("šādas darbības nav");
            }
            Console.WriteLine("rezultāts ir " + rez);

        }

    }
}
