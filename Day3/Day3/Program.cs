using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi 1 skaitli");
            string ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("ievadi 2 skaitli");
            string ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade2);

            Console.WriteLine("ievadi 3 skaitli");
            string ievade3 = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(ievade3);

            if (skaitlis1>skaitlis2 && skaitlis1>skaitlis3)
            {
                Console.WriteLine("Lielākais skaitlis ir pirmais skaitlis "+skaitlis1);
            }
            else if (skaitlis2>skaitlis1 && skaitlis2>skaitlis3)
            {
                Console.WriteLine("Lielākais skaitlis ir otrais skaitlis " + skaitlis2);
            }
            else if (skaitlis3 > skaitlis1 && skaitlis3 > skaitlis2)
            {
                Console.WriteLine("Lielākais skaitlis ir trešais " + skaitlis3);
            }
            else if (skaitlis1==skaitlis2 && skaitlis1>skaitlis3)
            {
                Console.WriteLine("Pirmais un otrais skaitlis ir vienādi un lielāki par trešo " + skaitlis1);
            }
            else if (skaitlis1 == skaitlis3 && skaitlis1 > skaitlis2)
            {
                Console.WriteLine("Pirmais un trešais skaitlis ir vienādi un lielāki par otro. Lielākais ir " + skaitlis1);
            }
            else if (skaitlis2 == skaitlis3 && skaitlis2 > skaitlis1)
            {
                Console.WriteLine("Otrais un trešais skaitlis ir vienādi un lielāki par trešo. Lielākais ir " + skaitlis2);
            }
            else
            {
                Console.WriteLine("Visi skaitļi ir vienādi " + skaitlis2);
            }
        }
        static void uzd()
        {
            //int a = 5;
            //int b = 6;

            //if (a>=5 && b==6) //and && izpildās abi
            //{

            //}
            //if (a > 5 || b == 6) ; //|| or, izpildās viens no nosacījumiem
            //{

            //}
            Console.WriteLine("ievadi skaitli");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(ievade);

            if (skaitlis > 5)
            {
                Console.WriteLine("skaitlis ir lielāks par 5");
            }
            else if (skaitlis < 5)
            {
                Console.WriteLine("skaitlis ir mazāks par 5");
            }
            else
            {
                Console.WriteLine("skaitlis ir 5");
            }
        }
        static void uzd1()
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
        }
    }
}
