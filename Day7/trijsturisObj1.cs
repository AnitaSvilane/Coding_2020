﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class trijsturisObj1
    {
        private int a;
        private int b;
        private int c;

        public trijsturisObj1(int a, int b, int c)
        {
            this.a = a; 
            this.b = b;
            this.c = c;

        }
        public void setA(int localA)
        {
            a = localA;
        }
        public void setB(int localB)
        {
            b = localB;
        }
        public void setC(int localB)
        {
            c = localB;
        }
        public string perimetrs()
        {
            int summ = 0;
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "kāda no malām ir 0 vai negatīvs skaitlis";
            }
            else if (a > b + c || b > a + c || c > a + b)
            {
                return "šāds trijstūris neeksistē";
            }
            else
            {
                summ = a + b + c;
                string rez = Convert.ToString(summ);
                return "perimetrs ir " + rez;
            }

        }


    }
}
