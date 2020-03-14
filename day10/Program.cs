using System;

namespace day10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;

            //b=10, a=12
            int c = a;
            a = b;
            b = c;

            //masivs ar 10 skaitliem, izvada augošā secībā



            int[] masivs = new int[50000];
            for (int i = 0; i < masivs.Length; i++)
            {
                Random random = new Random();
                masivs[i] = random.Next(1, 100);
            }

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));

            int pagaidu;
            for (int j = 0; j < masivs.Length-1; j++)
            {
                for (int i = 0; i < masivs.Length-1; i++)
                {
                    if (masivs[i] > masivs[i + 1])
                    {
                        pagaidu = masivs[i + 1];
                        masivs[i + 1] = masivs[i];
                        masivs[i] = pagaidu;
                    }
                }                
            }
            //for (int i = 0; i < masivs.Length; i++)
            //{
            //Console.Write(" " + masivs[i]);
            //}
            DateTime after = DateTime.Now;
            Console.WriteLine(after.ToString("F"));

            int[] masivs2 = new int[50000];
            for (int i = 0; i < masivs2.Length; i++)
            {
                Random random = new Random();
                masivs2[i] = random.Next(1, 100);
            }
            DateTime now1 = DateTime.Now;
            Console.WriteLine(now1.ToString("F"));

            int temp, smallest;
                for (int i = 0; i < masivs.Length - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < masivs.Length; j++)
                    {
                        if (masivs[j] < masivs[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = masivs[smallest];
                    masivs[smallest] = masivs[i];
                    masivs[i] = temp;
                }
            DateTime after1 = DateTime.Now;
            Console.WriteLine(after1.ToString("F"));


            //for (int i = 0; i < masivs.Length; i++)
            //{
            //Console.Write(" "+masivs[i]);
            //}

        }         
    }

    }



