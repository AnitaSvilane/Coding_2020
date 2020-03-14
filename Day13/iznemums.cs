using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    class iznemums
    {
        public static void ex1()
        {
            //cilveks ievada skaitlis
            //pārliecinās, ka tiek ievadīts skaitlis
            //turpina ievadi, kamēr ievada skaitli
            bool z = false;
            do
            {
                Console.WriteLine("ievadiet skaitli");

                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ok");
                    z = true;
                }
                catch
                {
                    Console.WriteLine("Nav skaitlis");
                }
            } while (!z);
             
            
        }
        public static void uzd2()
        {
            //saraksts sastāv no integer
            //saraksts, ko aizpilda cilvēks
            //uztaisīt menu
            //pivienot sarakstam jaunu vērtību
            //izvadīt sarakstu
            //izdzēst pēc vērtības
            //izdzēst pēc indeksa

            //exception nevar atrast elementu
            //cikls iet pāri saraksta garumam

            List<int> saraksts = new List<int>();
            string menu = "";
            while (menu != "0")
            {
                
                printMenu();
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        izvadit(saraksts);
                        break;
                    case "2":
                        ievadit(saraksts);
                        break;
                    case "3":
                        izdzestIerakstu(saraksts);
                        break;
                    case "4":
                        izdzestCiparu(saraksts);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("ievadiet 1, 2, 3, 4 vai 0");
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

        static void izvadit(List<int> saraksts)
        {
            if (saraksts.Count==0)
            {
                Console.WriteLine("saraksts ir tukšs");
            }
            else
            {
                for (int i = 0; i < saraksts.Count; i++)
                {
                    Console.WriteLine(saraksts[i]);
                }
            }                       
        }
        static void ievadit (List<int> saraksts)
        {
            bool turpinat = true;
            while (turpinat)
            {
                bool parb = true;
                while(parb)
                {
                    try
                    {
                        Console.WriteLine("pievieno vertibu");
                        saraksts.Add(Convert.ToInt32(Console.ReadLine()));
                        parb = false;
                    }
                    catch
                    {
                        Console.WriteLine("nav skaitlis");
                    }
                }
                Console.WriteLine("ja velies turpinat, nospied y");
                if (Console.ReadLine()!="y")
                {
                    turpinat = false;
                }                
            }
        }
        static void izdzestIerakstu(List<int> saraksts)
        {
            try
            {
                Console.WriteLine("kuru iekakstu velaties izdzest");
                int index = Convert.ToInt32(Console.ReadLine());
                saraksts.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("nav tāda ieraksta");
            }          
        }
        static void izdzestCiparu(List<int> saraksts)
        {
            try
            {
                Console.WriteLine("kuru skaitli velaties izdzest");
                int index = Convert.ToInt32(Console.ReadLine());
                saraksts.Remove(index);
            }
            catch
            {
                Console.WriteLine("nav tāda ieraksta");
            }
        }


    }
}
