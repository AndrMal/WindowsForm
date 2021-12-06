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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string f(int N)
        {
            if (N == 0)
            {
                return "0";
            }
            else if (N == 1)
            {
                return "1";
            }
            else
            {
                if (N % 2 == 0)
                {
                    return f(N / 2) + "0";
                }
                else
                {
                    return f(N / 2) + "1";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(tbN.Text);
                labRes.Text = "Ответ: " + f(N);
            }
            catch (System.FormatException)
            {
                labRes.Text = "Вы ввели что-то не то!";
            }
        }
    }
}
