using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet 9 a");
            string input = Console.ReadLine();

            int garums = input.Length;

            if (input=="aaaaaaaaa" && garums==9)
            {
                Console.WriteLine("Viss pareizi");
            }
            else
            {
                Console.WriteLine("Viss nepareizi");
            }

        }
        //mājās sameklēt kā pārbaudīt divus nosacījumus
        //pārbaudīt vai cilvēks ievada pareiza garuma string
        //vai ievadītais string ir vienāds ar "aaaaaaaaa"

        static void piemers()
        {
            int a = 5;
            int b = 7;

            int c = a + b;

            Console.WriteLine("Ievadiet skaitli");
            string ievade = Console.ReadLine();

            int konvertetsNr = Convert.ToInt32(ievade);
            c = konvertetsNr - a;

            Console.WriteLine("skaitlis ir " + c);

            string virkne1 = "vertiba ";
            string virkne2 = "ir ";

            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);

        }
        static void piemers2 ()
        {
            int a = 5;
            int b = 6;

            if (a > 5)
            {
                Console.WriteLine("ir");
            }
            else
            {
                Console.WriteLine("nav");
            }

            string piem = "aaa";

            if (piem == "aaa")
            {

            }

            //int c = piem.Length; //simbolu skaits
        }
        static void uzd1()
        {
            //lietotājam paprasam kurš gads ir šobrīd
            //lietotājs ievada
            //lietotājam paprasa kurā gadā dzimis
            //lietotājs ievada
            //atņem skaitļus, lai izvadītu starpību
            //izvada vecums ir

            Console.WriteLine("Ievadiet gadu");
            string gads1 = Console.ReadLine();

            Console.WriteLine("Ievadiet gadu, kurā esat dzimis");
            string gads2 = Console.ReadLine();

            int konvGads1 = Convert.ToInt32(gads1);
            int konvGads2 = Convert.ToInt32(gads2);

            int vecums = konvGads1 - konvGads2;

            Console.WriteLine("Jūs esat " + vecums + " gadus vecs");
        }
        static void uzd2()
        {
            //cilvēks ievada skaitli
            //pārbauda vai ir lielāks par 5
            //ja ir izvada ##
            //ja nav #

            Console.WriteLine("Ievadiet skaitli");
            string ievade = Console.ReadLine();
            int konv = Convert.ToInt32(ievade);

            if (konv > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
        }
        

    }
}
