using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            else
            {
                return x / 2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(tbX.Text);
                labRes.Text = f(x).ToString();
            }
            catch(System.FormatException)
            {
                labRes.Text = "Нужно ввести число!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fZad2 z2 = new fZad2();
            z2.ShowDialog();
        }
    }
}
