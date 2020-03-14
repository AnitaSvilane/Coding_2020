using System;
using System.Collections.Generic;

namespace day14_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHomeWork();
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Izvadit");
            Console.WriteLine("2. Pievienot jaunu studentu");
            Console.WriteLine("3. Rediget informaciju");
            Console.WriteLine("0. Iziet");
        }

        static void TaskHomeWork()
        {
            List<Students> studenti = new List<Students>();
            String choice = "";

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
                    case "3":
                        EditStudent(studenti);
                        break;
                    case "4":
                        RemoveStudent(studenti);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ievadiet 1,2,3,4 vai 0");
                        break;
                }
            }
        }

        static void PrintStudents(List<Students> st)
        {
            foreach (Students s in st)
            {
                s.print();
            }
        }

        static void AddStudent(List<Students> st)
        {
            Console.WriteLine("Ievadiet vardu");
            String name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu");
            String surname = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu");
            try
            {
                int course = Convert.ToInt32(Console.ReadLine());
                st.Add(new Students(name, surname, course));
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
            }

        }

        static void EditStudent(List<Students> st)
        {
            PrintStudents(st);
            Console.WriteLine("Kuru ierakstu velaties rediget?");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index - 1 > st.Count - 1 || index - 1 < 0 || st[index - 1] == null)
            {
                Console.WriteLine("Tads ieraksts neeksiste");
                return;
            }

            Console.WriteLine("Ko velaties rediget?");
            Console.WriteLine("1. Vards");
            Console.WriteLine("2. Uzvards");
            Console.WriteLine("3. Kurss");

            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ievadiet vardu!");
                    st[index - 1].SetName(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("Ievadiet uzvrdu!");
                    st[index - 1].SetSurname(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Ievadiet kursu!");
                    try
                    {
                        st[index - 1].SetCourse(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("Nepareiza ievade");
                    }
                    
                    break;
                default:
                    Console.WriteLine("Tads lauks neeksiste");
                    break;
            }
        }

        static void RemoveStudent(List<Students> st)
        {

            PrintStudents(st);
            Console.WriteLine("Kuru ierakstu velaties rediget?");
            int index=0;
            try
            {
                index = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
            }

            if (index - 1 > st.Count - 1 || index - 1 < 0 || st[index - 1] == null)
            {
                Console.WriteLine("Tads ieraksts neeksiste");
                return;
            }
            st.RemoveAt(index - 1);
            Console.WriteLine("Ieraksts dzests!");

        }
    }
}
