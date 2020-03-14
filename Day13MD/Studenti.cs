using System;
using System.Collections.Generic;
using System.Text;

namespace Day13MD
{
    class Studenti
    {
        private List<string> vards = new List<string>();
        private List<string> uzvards = new List<string>();
        private List<int> kurss = new List<int>();
        public Studenti(string vards, string uzvards, int kurss)
        {
            this.vards.Add(vards);
            this.uzvards.Add(uzvards);
            this.kurss.Add(kurss);
        }
        public String GetName()
        {
            return vards[0];
        }
        public void SetName(String vards)
        {
            this.vards.Add(vards);
        }
        public String GetSurname()
        {
            return uzvards[0];
        }
        public void SetSurname(String uzvards)
        {
            this.uzvards.Add(uzvards);
        }
        public int GetCourse()
        {
            return kurss[0];
        }
        public void SetCourse(int course)
        {
            this.kurss.Add(course);
        }
        public void print()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss);
        }
    }
}
