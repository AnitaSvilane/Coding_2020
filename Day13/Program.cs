using System;
using System.Collections.Generic;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            iznemums.uzd2();
        }   
        static void uzd1()
        {
            //uztaisīt listu ar string
            //lai cilvēks pats aizpilda sarakstu
            //uztaisīt 2 metodes 1 izdzēš konkrētu saraksta elementu
            //2 iztīra visu sarakstu

            List<string> saraksts = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ievadi kaut ko");
                saraksts.Add(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
            }
            Console.WriteLine();

            saraksts.RemoveAt(2);
            for (int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
            }

            saraksts.Clear();

            if (saraksts.Count == 0)
            {
                Console.WriteLine("saraksts ir tukšs");
            }
        }
    }
}
