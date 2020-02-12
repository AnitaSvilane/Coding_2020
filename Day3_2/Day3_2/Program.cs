using System;

namespace Day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais

            int skaitlis1 = skaitli();
            int skaitlis2 = skaitli();
            int skaitlis3 = skaitli();

            int biggest = rezultatsisaversija(skaitlis1, skaitlis2);
            biggest = rezultatsisaversija(biggest, skaitlis3);

            Console.WriteLine("rezultats ir " + biggest);

            //rezultats(skaitlis1, skaitlis2, skaitlis3);          

        }
        static int skaitli ()
        {
            Console.WriteLine("Ievadiet skaitli!");
            string skaitlaIevade = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(skaitlaIevade);

            return skaitlis3;
        }
        static int isaversija()
        {
            Console.WriteLine("Ievadiet skaitli!");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int rezultatsisaversija(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void rezultats(int a, int b, int c)
        {
            int biggest = 0;
            if (a > b)
            {
                biggest = a;
            }
            else
            {
                biggest = b;
            }

            if (biggest < c)
            {
                biggest = c;
            }
            Console.WriteLine("Rezultats ir " + biggest);
        }












        static void piemers1()
        {
            Console.WriteLine("Parasta void metode");
            
        }
        static int ievades1 (int a, int b)
        {
            return a+b;
        }

        static void piemers2(int a, int b)
        {
            //metodes obligāti ir jāizsauc no main vai citas metodes
            Console.WriteLine("Rezultats ir "+(a+b));

        }
        static int piemers3(int a, int b)
        {
            return (a + b);        
        }

        static int piemers4 ()
        {
            int sk1 = 5;
            int sk2 = 6;

            return sk1 + sk2;
        }

        static string piemers5()
        {
            Console.WriteLine("ievadi kaut ko");
            string ievads = Console.ReadLine();

            return ievads;
        }
        static int ievades()
        {
            Console.WriteLine("ievadi skaitli");
            string ievade = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade);

            Console.WriteLine("ievadi skaitli");
            ievade = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade);

            int summa = skaitlis1 + skaitlis2;

            return summa;

        }
        static void tasks()
        {
            /*piemers1();
            piemers2();
            piemers3(3,7);
            int c = piemers4();*/

            //1. saskaitišana-
            //ievads main metode, padodam skaitļus uz mūsu izveidoto kā parametrus
            //izvade notiek tur

            Console.WriteLine("ievadi skaitli");
            string ievade = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(ievade);

            Console.WriteLine("ievadi skaitli");
            ievade = Console.ReadLine();
            int skaitlis4 = Convert.ToInt32(ievade);

            piemers2(skaitlis3, skaitlis4);

            //2. ievade notiek mūsu izveidotajā metode
            //rezultātu atgriž ar return

            int r = ievades();
            Console.WriteLine("rezultāts ir " + r);

            //3.apvieno 1 un 2 metodi
            //musu izveidotajā metodē notiek tikai darbība
            //visa ievade/ izvade notiek main

            int t = ievades1(skaitlis3, skaitlis4);
            Console.WriteLine("rezultāts ir " + t);
        }
    }
}
