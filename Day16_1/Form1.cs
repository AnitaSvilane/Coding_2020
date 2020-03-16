using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttDemo_Click(object sender, EventArgs e)
        {//
            if (vards_ievade==null)
            {
                izvade.Text = "Nav ievadīts vārds!";
            }
            else if (vecums_ievade==null)
            {
                izvade.Text = "Nav ievadīts vārds!";
            }
            else
            {
                izvade.Text = "Labdien " + vards_ievade.Text + "! Tu esi " + vecums_ievade.Text + " gadus vecs.";
            }
            
        }

    }
}
