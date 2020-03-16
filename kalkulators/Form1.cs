using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double pirmaisSk = 0;
        double otraisSk = 0;
        double rez = 0;

        bool plus1 = false;
        bool minus1 = false;
        bool reizinat1 = false;
        bool dalit1 = false;

        private void button1_Click(object sender, EventArgs e)
        {
            ekrans.Text=ekrans.Text+"1";
            darbibas.Text = darbibas.Text + "1";
        }

        private void poga2_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text+"2";
            darbibas.Text = darbibas.Text + "2";
        }
        private void poga3_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "3";
            darbibas.Text = darbibas.Text + "3";
        }

        private void poga4_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "4";
            darbibas.Text = darbibas.Text + "4";
        }

        private void poga5_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "5";
            darbibas.Text = darbibas.Text + "5";
        }

        private void poga6_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "6";
            darbibas.Text = darbibas.Text + "6";
        }

        private void poga7_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "7";
            darbibas.Text = darbibas.Text + "7";
        }

        private void poga8_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "8";
            darbibas.Text = darbibas.Text + "8";
        }

        private void poga9_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "9";
            darbibas.Text = darbibas.Text + "9";
        }

        private void poga0_Click(object sender, EventArgs e)
        {
            ekrans.Text = ekrans.Text + "0";
            darbibas.Text = darbibas.Text + "0";
        }


        private void plus_Click(object sender, EventArgs e)
        {
            pirmaisSk = Convert.ToDouble(ekrans.Text);
            ekrans.Text = "";
            darbibas.Text = darbibas.Text + "+";
            plus1 = true;

        }
        private void minuss_Click(object sender, EventArgs e)
        {
            pirmaisSk = Convert.ToDouble(ekrans.Text);
            ekrans.Text = "";
            darbibas.Text = darbibas.Text + "-";
            minus1 = true;
        }
        private void reizinat_Click(object sender, EventArgs e)
        {
            pirmaisSk = Convert.ToDouble(ekrans.Text);
            ekrans.Text = "";
            darbibas.Text = darbibas.Text + "x";
            reizinat1 = true;
        }
        private void dalit_Click(object sender, EventArgs e)
        {
            pirmaisSk = Convert.ToDouble(ekrans.Text);
            ekrans.Text = "";
            darbibas.Text = darbibas.Text + "/";
            dalit1 = true;
        }
        private void rezultats_Click(object sender, EventArgs e)
        {
            otraisSk = Convert.ToDouble(ekrans.Text);
            if (plus1)
            {
                rez = pirmaisSk + otraisSk;
                plus1 = false;
            }
            else if(minus1)
            {
                rez = pirmaisSk - otraisSk;
                minus1 = false;;
            }
            else if(reizinat1)
            {
                rez = pirmaisSk * otraisSk;
                reizinat1 = false;
            }
            else if (dalit1)
            {
                rez = pirmaisSk / otraisSk;
                dalit1 = false;
            }
            
            ekrans.Text = Convert.ToString(rez);
            darbibas.Text = darbibas.Text + "=" + Convert.ToString(rez);           
            
        }

        private void nodzest_Click(object sender, EventArgs e)
        {
            ekrans.Text = "";
            darbibas.Text = "";
        }
    }
}
