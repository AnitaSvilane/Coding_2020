using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{

    class students
    {
        string vards;
        string uzvards;
        int kurss;
        int gads;
        public students(string vards, string uzvards, int kurss, int gads)
        {
            this.vards = vards;
            this.uzvards = uzvards;            
            this.gads = gads;

            if (kurss>3)
            {
                this.kurss = 3;
            }
            else if (kurss<1)
            {
                this.kurss = 1;
            }
            else
            {
                this.kurss = kurss;
            }
        }
        public void print ()
        {
            Console.WriteLine("Studenta vards "+vards);
            Console.WriteLine("Studenta uzvards "  + uzvards);
            Console.WriteLine("Kurss, kura macas " + kurss);
            Console.WriteLine("Iestasanas gads " + gads);
            Console.WriteLine();
        }

    }
}
