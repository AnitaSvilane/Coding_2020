using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day14_IO_Sample
{
    public class uzd2
    {           

        public static void uzd1()
        {
            Console.WriteLine("ievadi meklējamo skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            try
            {
                string line;
                int atkartojas = 0;
                StreamReader sr = new StreamReader("C:\\Users\\anita\\Desktop\\text.txt");

                line = sr.ReadLine();
                if (Convert.ToInt32(line)==skaitlis)
                {
                    atkartojas++;
                }

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    if (Convert.ToInt32(line)==skaitlis)
                    {
                        atkartojas++;
                    }
                }
                sr.Close();
                Console.Write("ievaditais skaitlis atkārtojas "+atkartojas+" reizes");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }   
    }
}
