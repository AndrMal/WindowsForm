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
    public partial class fZad2 : Form
    {
        public fZad2()
        {
            InitializeComponent();
        }
        string f(double a, double b, double h)
        {
            string str = "";
            for (double x = a; x <= b; x += h)
            {
                if (x < 1)
                {
                    str += ((x * x - 1) * (x * x - 1)).ToString() + " ";
                }
                else if (x > 1)
                {
                    str += (1 / (1 + x * x)).ToString() + " ";
                }
                else
                {
                    str += "0 ";
                }
            }
            return str;
        }
        void f(double x, out double y)
        {
            if (x < 1)
            {
                y = (x * x - 1) * (x * x - 1);
            }
            else if (x > 1)
            {
                y = 1 / (1 + x * x);
            }
            else
            {
                y = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                for (double x=a; x<=b; x+=h)
                {
                    double y;
                    f(x, out y);
                    str += y + " ";
                }
                labRes1.Text = f(a, b, h);
                labRes2.Text = str;                
            }
            catch (System.FormatException)
            {
                labRes1.Text = "Введите числа!";
                labRes2.Text = "Введите числа!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
