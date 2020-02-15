using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            //piemers.test();
            //piemers.privatetest(); te nevar izsaukt, jo pieres klasē ir private
            // Console.WriteLine(piemers.a);

            Console.WriteLine(tasks.getA());
            int sk1 = tasks.getA();

            Console.WriteLine("ievadiet skaitli");
            string input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);

            tasks.setA(skaitlis);
            Console.WriteLine(tasks.getA());
            

            

        }
    }
}
