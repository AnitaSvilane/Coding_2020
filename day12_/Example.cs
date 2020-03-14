using System;
using System.Collections.Generic;
using System.Text;

namespace day12_
{
    class Example
    {
        public static void ex1()
        {
            var List <int> a = new List<int>();
            a.Add(2);
            a.Add(4);
            a.Add(-2);

            for (int i=0; i<a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            foreach(int b in a)
            {
                Console.WriteLine(b);
            }

            a.Sort();

            foreach (int b in a)
            {
                Console.WriteLine(b);
            }
        }
        //Lists ar integer
        //cilvēks izvēlas cik skaitļus vēlas pievienot
        //pievieno skaitļus
        //izvada skaitļus
        public static void uzd()
        {
            List<int> saraksts = new List<int>();
            Console.WriteLine("cik skaitļus pievienot");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int summa = 0;
            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine("ievadi skaitli");
                saraksts.Add(Convert.ToInt32(Console.ReadLine()));                
            }
            foreach (int vertiba in saraksts)
            {
                summa = summa + vertiba;
            }
            Console.Write(summa);

        }
        //ieprieksējo mājasdarbu pārveidot ar listu
    }
}
