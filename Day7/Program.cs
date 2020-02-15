using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd3();
            
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
            objpiem obj = new objpiem();
            obj.setA(1);
            obj.setB(2);
            obj.print();

            obj.setA(3);
            obj.setB(4);
            obj.print();

            objpiem obj2 = new objpiem();
            obj2.print();

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
    }
}
