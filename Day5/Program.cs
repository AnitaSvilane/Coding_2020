using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzd1();//sanāca
            //uzd2();//nesapratu kāpēc neiet viss aprēķins vienā līnijā
            //uzd3();//sanāca
            //uzd4();//sanāca
            //uzd5();//droš vien var arī efektīvāk, bet strādā
            //uzd6();//sanāca
            uzd7();

        }
        static void uzd7()
        {
            int [] masivs = new int [5];
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("ievadi skaitli");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }

            int biggest = 0;

            for (int i = 0; i < 5; i++)
            {                
                if (biggest < masivs[i])
                {
                    biggest = masivs[i];
                }
            }
            Console.WriteLine("Rezultats ir " + biggest);
        }
        static void uzd6()
        {
            Console.WriteLine("lūdzu ievadiet savu vārdu");
            string vards = Console.ReadLine();
            Console.WriteLine("Labdien "+vards);
        }
        static void uzd5()
        {
            Console.WriteLine("lūdzu ievadiet minamo vārdu");
            string vards = Console.ReadLine();
            string minamais = null;
            Console.WriteLine("uzmini vārdu");

            for (int i=0; i<5; i++)
            {             
                minamais = Console.ReadLine();

                if (minamais != vards)
                {
                    Console.WriteLine("mini vēl!");
                }
                else
                {
                    Console.WriteLine("Uzvarēja 2 spelētājs");
                    break;
                }                
            }
            if (minamais != vards)
            {
                Console.WriteLine("Uzvarēja 1 spelētājs");
            }
        }
        static void uzd4()
        {
            Console.WriteLine("lūdzu ievadiet teikumu");
            string vards = Console.ReadLine();

            string vards1 = "zirgs";
            string vards2 = "suns";

            bool a = vards.Contains(vards1);
            bool b = vards.Contains(vards2);

            while (a || b)
                {
                Console.WriteLine("lūdzu ievadiet citu teikumu");
                vards = Console.ReadLine();

                a = vards.Contains(vards1);
                b = vards.Contains(vards2);
            }                      

        }
        static void uzd3()
        {
            int a = ievade();
            int b = ievade();

            for (int i=0; i<a; i++)
            {
                string linija = null;
                for (int j=0; j<b; j++)
                {
                    linija += "#";
                }
                Console.WriteLine(linija);
            }

        }
        static void uzd2()
        {
            Console.WriteLine("Lūdzu ievadiet cik ārā ir grādu pēc Fārenheita");
            double a = Convert.ToDouble(Console.ReadLine());
            double rezultats = (a - 32);
            double rez = rezultats * 5 / 9;
            Console.WriteLine("Pēc celsija "+rez);
        }
        static void uzd1()
        {                   
            int biggest = 0;

            for (int i=0; i<6; i++)
            {
                int skaitlis = ievade();
                if (biggest < skaitlis)
                {
                    biggest = skaitlis;
                }                
            }                        
            Console.WriteLine("Rezultats ir " + biggest);

        }
        static int ievade()
        {
            Console.WriteLine("Lūdzu ievadiet skaitli");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
