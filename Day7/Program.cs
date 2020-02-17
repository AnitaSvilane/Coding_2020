using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd6();


        }
        static void uzd1()
        {
            //uztaisīt jaunu klasi ar nosaukumu skaitļu summa
            //cilvēks ievada 2 int tipa skaitļus no main
            //uztaisīt, lai ir get, set un publiska metode, kas izvada skaitļu summu
            //abiem skaitļiem jābūt pieejamiem skaitļu summu klasē, bet no main tikai ar get un set


            int skaitlis = ievade();
            skaitlu_summa.setA(skaitlis);

            skaitlis = ievade();
            skaitlu_summa.setB(skaitlis);            

            Console.WriteLine(skaitlu_summa.summ());
        }
        static void uzd2()
        {
            //klases nosaukums - trijstūris
            //cilvēks ievada 3 malu vērtības - mainīgie jaunajā klasē
            //metode, kas izvada trijstūra perimetru
            //visa ievade un izvade notiek no main
            //ja kāda mala ir 0, jāpaziņo, ka ir kļūda

            int skaitlis = ievade();
            trijsturis.setA(skaitlis);
            skaitlis = ievade();
            trijsturis.setB(skaitlis);
            skaitlis = ievade();
            trijsturis.setC(skaitlis);

            Console.WriteLine(trijsturis.perimetrs());
        }
        static int ievade()
        {
            Console.WriteLine("ievadiet skaitli");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        static void objEx1()
        {
            objpiem obj = new objpiem(0,0);
            obj.setA(1);
            obj.setB(2);
            obj.print();

            obj.setA(3);
            obj.setB(4);
            obj.print();

            objpiem obj2 = new objpiem(0,0);
            obj2.print();

            objpiem obj3 = new objpiem(9,9);
            obj3.print();

        }
        static void uzd3()
        {
            //jauna klase - trijsturis obj
            //jāizmanto to, kas jau ir uzd2
            //parametri un lauki vairs nav statiski
            //uztaisīt 2 trijsturi
            //vienu ar pareizam malu vertibam
            //otru ar nepareizam
                        
            trijsturisObj obj1 = new trijsturisObj();
            obj1.setA(3);            
            obj1.setB(3);            
            obj1.setC(3);
            Console.WriteLine(obj1.perimetrs());

            trijsturisObj obj2 = new trijsturisObj();
            obj2.setA(0);
            obj2.setB(2);
            obj2.setC(3);
            Console.WriteLine(obj2.perimetrs());

            trijsturisObj obj3 = new trijsturisObj();
            obj3.setA(3);
            obj3.setB(2);
            obj3.setC(10);
            Console.WriteLine(obj3.perimetrs());
        }


        static void uzd4()
        {
            trijsturisObj[] masivs = new trijsturisObj[5];  
            
            for (int i=0; i<5; i++)
            {
                Console.Clear();
                masivs[i] = new trijsturisObj();
                int skaitlis = ievade();
                masivs[i].setA(skaitlis);
                skaitlis = ievade();
                masivs[i].setB(skaitlis);
                skaitlis = ievade();
                masivs[i].setC(skaitlis);
                Console.WriteLine(masivs[i].perimetrs());
                Console.ReadLine();
            }
            Console.Clear();
            for (int i=0; i<5; i++)
            {
                Console.WriteLine(masivs[i].perimetrs());
            }          

        }
        static void uzd5()
        {
            //parveidot, uzd3 ar konstruktoru
            trijsturisObj1 obj1 = new trijsturisObj1(1,2,3);            
            Console.WriteLine(obj1.perimetrs());

            trijsturisObj1 obj2 = new trijsturisObj1(0,0,6);            
            Console.WriteLine(obj2.perimetrs());

            trijsturisObj1 obj3 = new trijsturisObj1(9,1,1);            
            Console.WriteLine(obj3.perimetrs());
        }
        static void uzd6()
        {
            //klase ar nosaukumu students
            //klase konstruktors ar parametriem
            //vārds, Uzvārds, Kurss, iestāšanās gads
            //print() izvada visu informāciju
            // kurss 1-3
            //ja ir vairāk par 3, iestata 3
            //ja ir mazāk par 1, iestata 1
            //uztaisa 2 testa objektus                                             

            students obj1 = new students("Janis","Berzins",0,2000);
            obj1.print();            

            students obj2 = new students("Juris", "Skuja", 4, 2009);
            obj2.print();
        }
                
        static void uzd7()
        {
            //uztaisīt statisku klasi
            //kura atgriež double tipa skaitli pēc cilvēka ievades

            //uztaisīt klasi, kur ir metodes saskaitīt, atņemt, reizināt, dalīt
            //skaitļus iedodam klasē kā parametrus katrai metodei atsevišķi
            

            //no main cilvēks ievada skaitli 1 un skaitli 2, izvēlas darbību un izvada rezultātu
        }
    }
}
