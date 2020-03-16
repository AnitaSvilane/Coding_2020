using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day14_IO_Sample
{
    public class uzd
    {            //uztaisīt listo no int tipa elementiem
                 //1. izvadītu visus elementus
                 //2. pievienotu elementus
                 //3. sasummētu visus list elementus

        //jāsaglabā un jānolasa no faila

        public static void uzd1()
        {
            List<int> saraksts = new List<int>();

            try
            {
                string choice = "";
                while (choice != "0")
                {
                    PrintMenu();
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Print(saraksts);
                            break;
                        case "2":
                            Add(saraksts);
                            break;
                        case "3":
                            Summ(saraksts);
                            break;
                        default:
                            Console.WriteLine("Ievadiet 1, 2, 3 vai 0");
                            break;
                    }
                }
            }
                catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }     

            static void PrintMenu()
            {
                Console.WriteLine("1. Izvadit");
                Console.WriteLine("2. Pievienot");
                Console.WriteLine("3. Summa");
                Console.WriteLine("0. Iziet");
            }

            static void Add(List<int> st)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\anita\\Desktop\\Test.txt");

                    Console.WriteLine("ievadi skaitli");
                    st.Add(Convert.ToInt32((Console.ReadLine())));

                    for (int i=0; i<st.Count; i++)
                    {
                        sw.WriteLine(Convert.ToString(st[i]));
                    }                    
                    sw.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            static void Print(List<int> st)
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader("C:\\Users\\anita\\Desktop\\Test.txt");

                    line = sr.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            static void Summ(List<int> st)
            {
                int summa = 0;
                for (int i=0; i<st.Count; i++)
                {
                    summa += st[i];
                }
                Console.WriteLine(summa);
            }
        }
    }
}
