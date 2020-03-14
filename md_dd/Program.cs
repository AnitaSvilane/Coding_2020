using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_arraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            md();

            //While loop menu
            //1. Izvadit informaciju
            //ja saraksts ir tukss, tad ari pasakam
            //2. pievienot jaunu studentu
            //ja vairs nav vietas, tad ari pasakam
            //3. Rediget ierakstu
            //Izvelas, ko rediget
            //4. Iziet
            //5 vietas

            /*if (a[0] == null)
            {
            } */
            //parbaude vai ir izsaukts new

        }
        static void md()
        {
            List<Students> studenti = new List<Students>();
            //Students[] studenti = new Students[5];

            string choise = "";
            while (choise != "0")
            {
                printMenu();
                choise = Console.ReadLine();

                switch (choise)
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
            Console.WriteLine("2 pievienot jaunu studentu");
            Console.WriteLine("3 rediģēt");
            Console.WriteLine("0. iziet");
        }
        static void PrintStudents(List<Students> st)
        {
            if (st[0] == null)
            {
                Console.WriteLine("saraksts ir tukšs");
                //return; var likt šo, un tad nav jāliek else
            }
            else
            {
                for (int i = 0; i < st.Count; i++)
                {
                    if (st[i] == null)
                    {
                        break;
                    }
                    Console.Write(i + 1 + ")");
                    st[i].print();

                }
            }

        }

        static void AddStudent(List<Students> st)
        {            
            bool full = false;
            for (int i = 0; i < st.Count; i++)
            {
                if (st[i] == null)
                {
                    Console.WriteLine("Ievadiet vardu");
                    String name = Console.ReadLine();

                    Console.WriteLine("Ievadiet uzvardu");
                    String surname = Console.ReadLine();

                    Console.WriteLine("Ievadiet kursu");
                    int course = Convert.ToInt32(Console.ReadLine());

                    st[i] = new Students(name, surname, course);
                    break;
                }
                if (i == st.Count - 1)
                {
                    full = true;
                }
            }
            if (full)
            {
                Console.WriteLine("masivs ir pilns");
            }
        }

        static void EditStudent(List<Students> st)
        {
            PrintStudents(st);
            Console.WriteLine("kuru vēlaties rediģēt");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index - 1 > st.Count - 1 || index - 1 < 0 || st[index - 1] == null)
            {
                Console.WriteLine("ieraksts neeksistē");
                return;
            }
            Console.WriteLine("ko velaties rediģēt");
            Console.WriteLine("1- vards");
            Console.WriteLine("2- uzvards");
            Console.WriteLine("3- kurss");

            string choise = Console.ReadLine();
            switch (choise)
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
                    st[index - 1].SetCourse(Convert.ToInt32(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Tads lauks neeksiste");
                    break;
            }
        }       

    }
}
