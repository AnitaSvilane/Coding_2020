using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class skaitlis
    {
        private int number;
        public skaitlis()
        {            
            Random random = new Random();
            this.number = random.Next(1, 10);
        }
        public int jaunsskaitlis()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
        public int getSk()
        {
            return number;
        }

    }
}
