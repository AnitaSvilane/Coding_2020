using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            //forloopexample();
            //whileundowhile();
            uzd4();
           

        }
        static void uzd4()
        {
            //*
            //**
            //***
            //****

            //*
            //**
            //***
            //****
            //**
            //*
            string b = "*";            
            for (int i = 0; i < 4; i++)               
            {                
                Console.WriteLine(b);
                b = b+"*";
            }
            b = "";
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(b);
                b = b + "*";
            }
            for (int i=0; i<5; i++)
            {
                Console.WriteLine(b);
                b = b.Remove(0, 1);
            }
           

            

        }
        static void uzd3()
        {
            //cilvēks ievada skaitli ko kāpināt
            //ievada pakāpi
            //izvada rezultātu
            Console.WriteLine("ievadi veselu skaitli");
            int baze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi pakapi");
            int pakape = Convert.ToInt32(Console.ReadLine());
            int rezultats = 1;
            for(int i=0; i<pakape; i++)
            {
                rezultats*=baze;
            }
            Console.WriteLine("rezultats "+rezultats);
        }
        static void uzd2()
        {
            //cilvēks ievada 5 skaitļus, izvadām skaitļu summu
            int a = 0;
            for(int i =0; i<5; i++)
            {
                Console.WriteLine("ievadi skaitli");
                a += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("šo skaitļu summa ir "+a);
        }
        static void uzd1()
        {
            //ar for cikla palīdzību sasummēt skaitļus no 1 līdz 10, izvadīt summu
            int b = 0;
            for(int i=1; i<11; i++)
            {
                b+=i;
            }
            Console.WriteLine("10 skaitļu summa ir " + b);
        }
        static void forloopexample()
        {
            /*for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Cikls "+i);
            }*/
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("skaitlis " + i);
            }
        }
        static void whileundowhile()
        {
            int a = 10;
            while(a<10)
            {
                Console.WriteLine("Cikls " + a);
                a++;
            }

            a = 100;
            do//pēc do ieiet ciklā un pārbauda nosacījumu pēc tam
            {
                Console.WriteLine("Cikls " + a);
                a++;
            } while (a < 9);
        }
    }
}
