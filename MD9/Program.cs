using System;

namespace MD9
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd5();
        }
        static void uzd1()
        {
            string[] masivs = new string[6];

            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = "#";
            }
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write(masivs[i]);
            }
        }
        static void uzd2()
        {
            string[] masivs = new string[6];

            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = "#";
            }
            for (int i = 0; i < masivs.Length; i++)
            {
                for (int j=0; j< masivs.Length; j++)
                {
                    Console.Write(masivs[j]);
                }
                Console.WriteLine();                
            }
        }
        static void uzd3()
        {
            int[] masivs = new int[6];
            masivs[0] = 2;

            for (int i = 1; i < masivs.Length; i++)
            {
                masivs[i] = masivs[i-1]+2;
            }
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine(masivs[i]);
            }
        }
        static void uzd4()
        {
            Console.WriteLine("ieraksti masiva garumu");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[garums];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("ieraksti masiva vertibu");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine(masivs[i]);
            }
        }
        static void uzd5()
        {
            Console.WriteLine("ieraksti masiva garumu");
            int garums = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[garums];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("ieraksti masiva vertibu");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] % 2 != 0)
                {
                    Console.WriteLine(masivs[i]);
                }               
            }
        }
    }
}
