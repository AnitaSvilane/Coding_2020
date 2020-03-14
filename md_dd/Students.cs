using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_arraysAndLists
{
    class Students
    {
        private List<string> name = new List<string>();
        private List<string> surname = new List<string>();
        private List<int> course = new List<int>();

        public Students(String name, String surname, int course)
        {
            //a.Add(2);
            this.name.Add(name);
            this.surname.Add(surname);
            this.course.Add(course);
        }
        public String GetName()
        {
            return name[0];
        }
        public void SetName(String name)
        {
            this.name.Add(name);
        }
        public String GetSurname()
        {
            return surname[0];
        }
        public void SetSurname(String surname)
        {
            this.surname.Add(surname);
        }
        public int GetCourse()
        {
            return course[0];
        }
        public void SetCourse(int course)
        {
            this.course.Add(course);
        }
        public void print()
        {           
            Console.WriteLine(name + " " + surname + " " + course);
        }
    }
}
