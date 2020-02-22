using System;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd1();
        }
        static void piemers()
        {
            example ex = new example(4, 8);
            ex.print();
            int mainigais = ex.getA();
        }
        static void uzd1()
        {
            //jāizveido klase, kur jābūt laukam, kur glabājas int
            //jāuzģenerē random skaitlis 1-10, kas ir jāģenerē konstruktorā 
            //jābūt get number, kas atgriež skaitli
            //regenerate number - par jaunu uzģenerē random skaitli

            //uztaisam vienu objektu, un otru objektu
            //while cikls, pārbauda, kurš skaitlis ir lielāks
            //lielākais uzvar
            //saskaita uzvaras
            //apstājas, kad viens objekts ir uzvarējis 3 reizes
            int rez1 = 0;
            int rez2 = 0;
            
            skaitlis sk1 = new skaitlis();
            skaitlis sk2 = new skaitlis();

            while (rez1 < 3 && rez2 < 3)
            {
                int skaitlis1 = sk1.jaunsskaitlis();
                int skaitlis2 = sk2.jaunsskaitlis();

                if (skaitlis1 > skaitlis2)
                {
                    Console.WriteLine("uzvar pirmais");
                    rez1 = rez1 + 1;                    
                }
                else if (skaitlis1 < skaitlis2)
                {
                    Console.WriteLine("uzvar otrais");
                    rez2 = rez2 + 1;                    
                }
                else
                {
                    Console.WriteLine("neizšķirts");                    
                }
            } ;



            //Console.WriteLine(sk1.getSk());
            //Console.WriteLine(sk2.getSk());
            Console.WriteLine("rezultāts " + rez1 + ":" + rez2);











        }
    }

}
