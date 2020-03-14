using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_arraysAndLists
{
    class Students
    {
        private String name;
        private String surname;
        private int course;

        public Students(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public String GetSurname()
        {
            return surname;
        }

        public void SetSurname(String surname)
        {
            this.surname = surname;
        }


        public int GetCourse()
        {
            return course;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }


        public void print()
        {
            Console.WriteLine(name + " " + surname + " " + course);
        }



    }
}