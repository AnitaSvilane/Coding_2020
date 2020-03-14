using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_md
{
    class masivs
    {
        public int[] masiv;
        public masivs()
        {
            this.masiv = new int[50000];
            for (int i = 0; i < masiv.Length; i++)
            {
                {
                    Random random = new Random();
                    masiv[i] = random.Next(1, 100);
                    //Console.Write(" " + masiv[i]);
                    
                }
            }
            //Console.WriteLine();
        }

    }
    
}
