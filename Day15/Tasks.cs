using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day14_IO_Sample
{
    class Tasks
    {
        //string tipa lists
        //menu
        //pievienot sarakstam
        //izvadīt
        //iziet
        //saraksts ir jānolasa no faila un jāieraksta failā
        public static void uzd1()
        {
            List<string> studenti = new List<string>();
            string choice = "";

            while (choice != "0")
            {
                PrintMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintStudents(studenti);
                        break;
                    case "2":
                        AddStudent(studenti);
                        break;
                }
            }


            static void PrintMenu()
            {
                Console.WriteLine("1. Izvadit");
                Console.WriteLine("2. Pievienot");
                Console.WriteLine("0. Iziet");
            }

            static void AddStudent(List<string> st)
            {
                try
                {                    
                    StreamWriter sw = new StreamWriter("C:\\Users\\anita\\Desktop\\Test.txt");

                    Console.WriteLine("ievadi tekstu");
                    st.Add(Console.ReadLine());
                    for (int i=0; i<st.Count; i++)
                    {
                        
                        string[] strlist = st[i].Split(',');
                        
                        foreach (string s in strlist)
                        {
                            sw.WriteLine(s);
                        }                
                    }                    
                    sw.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            static void PrintStudents(List<string> st)
            {

                try
                {
                    string[] line;
                    StreamReader sr = new StreamReader("C:\\Users\\anita\\Desktop\\Test.txt");

                    line[0] = sr.ReadLine();

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
        }
    }
}
