using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie5
{
    public partial class Form1 : Form
    {
        double f(double x)
        {
            if ((x - 1) == 0 || (1 - 4 * x) == 0)
            {
                throw new DivideByZeroException();
            }
            return (1 / (x - 1)) + (2 / (1 - 4 * x));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Ответ: ";
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                for (double x = a; x <= b; x += h)
                {
                    str += f(x) + " ";
                }
                labRes.Text = str;
            }
            catch (System.FormatException)
            {
                labRes.Text = "Вы ввели что-то не то!";
            }
            catch (System.DivideByZeroException)
            {
                labRes.Text = "Деление на ноль!";
            }
        }
    }
}
