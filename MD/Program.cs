using System;

namespace MD
{
    class Program
    {
        static void Main(string[] args)
        {
            md1();
            //md2();
            //md3();
                       
        }
        static void md1()
        {
            Console.WriteLine("Lūdzu ievadiet skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int rezultats = 1;
            for (int i = 1; i <= skaitlis; i++)
            {
                rezultats = rezultats * i;
            }
            Console.WriteLine("rezultāts ir " + rezultats);
        }
        static void md2()
        {
        int i = 1;
        while (i != 0)
        {
            Console.WriteLine("ievadi 1 skaitli");
            string ievade1 = Console.ReadLine();
            double skaitlis1 = Convert.ToDouble(ievade1);

            Console.WriteLine("ievadi veicamo darbību.");
            Console.WriteLine("Saskaitīt (+), atņemt (-), reizināt (*), dalīt (/)");
            string ievade3 = Console.ReadLine();

            Console.WriteLine("ievadi 2 skaitli");
            string ievade2 = Console.ReadLine();
            double skaitlis2 = Convert.ToDouble(ievade2);

            if (ievade3 == "+")
            {
                Console.WriteLine("rezultāts ir " + (skaitlis1 + skaitlis2));
            }
            else if (ievade3 == "-")
            {
                Console.WriteLine("rezultāts ir " + (skaitlis1 - skaitlis2));

            }
            else if (ievade3 == "*")
            {
                Console.WriteLine("rezultāts ir " + (skaitlis1 * skaitlis2));
            }
            else if (ievade3 == "/")
            {
                Console.WriteLine("rezultāts ir " + (skaitlis1 / skaitlis2));
            }
            else
            {
                Console.WriteLine("nav tādas darbības!");
            }
            Console.WriteLine("vai vēlaties pārtraukt? nospiediet 0, lai pārtrauktu");
            i = Convert.ToInt32(Console.ReadLine());
        }
        }
        static void md3()
        {
            for (int i=1; i<11; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("ja vēlaties pārtraukt, nospiediet 0, ja turpināt, tad jebkuru citu skaitli");
                int partraukums = Convert.ToInt32(Console.ReadLine());

                if (partraukums == 0)
                {
                    break;
                }

            }
        }
    }
}
