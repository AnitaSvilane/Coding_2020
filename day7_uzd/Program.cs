using System;

namespace day7_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzd1();
            uzd2();            
        }
        static void uzd2()
        {
            Aplis obj = new Aplis();
            obj.getLaukums();
            obj.print();
        }
        static void uzd1()
        {
            //uztaisīt statisku klasi
            //kura atgriež double tipa skaitli pēc cilvēka ievades
            //uztaisīt klasi, kur ir metodes saskaitīt, atņemt, reizināt, dalīt
            //skaitļus iedodam klasē kā parametrus katrai metodei atsevišķi
            //no main cilvēks ievada skaitli 1 un skaitli 2, izvēlas darbību un izvada rezultātu

            double sk1 = ievade.ievadeSk1();
            double sk2 = ievade.ievadeSk2();

            Console.WriteLine("Lūdzu izvēlieties darbību, +, -, *, /");
            string darbiba = Console.ReadLine();

            darbiba obj1 = new darbiba(sk1, sk2, darbiba);
            obj1.print();
        }

    }
}
