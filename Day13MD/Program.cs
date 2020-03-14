using System;
using System.Collections.Generic;

namespace Day13MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop menu
            //1. Izvadit informaciju
            //ja saraksts ir tukss, tad ari pasakam
            //2. pievienot jaunu studentu
            //ja vairs nav vietas, tad ari pasakam
            //3. Rediget ierakstu
            //Izvelas, ko rediget
            //4. Iziet
            //5 vietas
            
            List<Studenti> students = new List<Studenti>();

            string menu = "";
            while (menu != "0")
            {

                printMenu();
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        izvadit(students);
                        break;
                    case "2":
                        pievienot(students);
                        break;
                    case "3":
                        rediget(students);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("ievadiet 1, 2, 3 vai 0");
                        break;
                }
            }          
        }
        static void printMenu()
        {
            Console.WriteLine("1 izvadīt");
            Console.WriteLine("2 pievienot vertibu");
            Console.WriteLine("3 izdzest konkreto vertibu saraksta");
            Console.WriteLine("4 izdzest konkretu ciparu");
            Console.WriteLine("0 iziet");
        }

        static void izvadit(List<Studenti> st)
        {
            if (st.Count==0)
            {
                Console.WriteLine("saraksts ir tukšs");
            }
            else
            {
                for (int i=0; i<st.Count; i++)
                {
                    st[i].print();
                }
            }
        }
        static void pievienot(List<Studenti> st)
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("ievadiet vardu");
                string vards = Console.ReadLine();

                Console.WriteLine("ievadiet uzvardu");
                string uzvards = Console.ReadLine();

                int kurss = 0;

                bool parb = true;
                while (parb)
                {
                    try
                    {
                        Console.WriteLine("ievadiet kursu, kā ciparu");
                        kurss = Convert.ToInt32(Console.ReadLine());
                        parb = false;
                    }
                    catch
                    {
                        Console.WriteLine("nav ievadīts cipars");
                    }
                }
                st.Add(new Studenti(vards, uzvards, kurss));
            }
            
                      
        }
        static void rediget(List<Studenti> st)
        {

        }

    }
}
