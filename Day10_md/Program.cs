using System;

namespace Day10_md
{
    class Program
    {
        static void Main(string[] args)
        {
            masivs pirmais = new masivs();
            masivs otrais = new masivs();

            Console.WriteLine("Bubble");
            DateTime now1 = DateTime.Now;
            Console.WriteLine(now1.ToString("F"));

            bubble(pirmais.masiv);

            DateTime after1 = DateTime.Now;
            Console.WriteLine(after1.ToString("F"));

            /*for (int i = 0; i < pirmais.masiv.Length; i++)
            {
                Console.WriteLine(pirmais.masiv[i]);
            }
            Console.WriteLine();*/

            Console.WriteLine("Select");
            DateTime now2 = DateTime.Now;
            Console.WriteLine(now2.ToString("F"));

            selection(otrais.masiv);
            
            DateTime after2 = DateTime.Now;
            Console.WriteLine(after2.ToString("F"));

            /*for (int i = 0; i < otrais.masiv.Length; i++)
            {
                Console.WriteLine(otrais.masiv[i]);
            }
            Console.WriteLine();*/


            Console.WriteLine();

            if ((after1-now1)>(after2-now2))
            {
                Console.WriteLine("Bubble metode ir par " + ((after1 - now1) - (after2 - now2)) + "s ilgāka");
            }
            else
            {
                Console.WriteLine("Select metode ir par" + ((after2-now2) - (after1-now1)) + "s ilgāka");
            }

            Console.WriteLine();
            Console.WriteLine("Bubble metode prasa " +(after1-now1)+"s");
            Console.WriteLine("Select metode prasa "+(after2-now2)+"s");

        }
        public static void bubble(int[] masiv)
        {
            int pagaidu;
            for (int j = 0; j < masiv.Length - 1; j++)
            {
                for (int i = 0; i < masiv.Length - 1; i++)
                {
                    if (masiv[i] > masiv[i + 1])
                    {
                        pagaidu = masiv[i + 1];
                        masiv[i + 1] = masiv[i];
                        masiv[i] = pagaidu;
                    }
                }
            }
        }
        public static void selection(int[] masiv)
        {
            int temp, smallest;
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < masiv.Length; j++)
                {
                    if (masiv[j] < masiv[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = masiv[smallest];
                masiv[smallest] = masiv[i];
                masiv[i] = temp;
            }
        }
        
    }
}
