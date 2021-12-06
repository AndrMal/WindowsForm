using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double N)
        {
            return N / sqr(N, 1);
        }
        static double sqr(double N, double i)
        {
            if (i > N)
            {
                return 0;
            }
            else
            {
                return Math.Sqrt(i + sqr(N, i + 1));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double N = Double.Parse(tbN.Text);
                if (N < 0)
                {
                    throw new Exception("N должно быть больше нуля!");
                }
                labRes.Text = "Результат: " + f(N);
            }
            catch (System.FormatException)
            {
                labRes.Text = "Вы ввели что-то не то!";
            }
            catch (Exception exc)
            {
                labRes.Text = exc.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
