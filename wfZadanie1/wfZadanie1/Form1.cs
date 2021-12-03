using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double V = Double.Parse(tbV.Text);
                labRes.Text = "Результат: "+Math.Pow(V, 1 / 3.0).ToString();
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введите число!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fZad2 z2 = new fZad2();
            z2.ShowDialog();
        }
    }
}
