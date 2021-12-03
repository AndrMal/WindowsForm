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
    public partial class fZad2 : Form
    {
        public fZad2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbX.Text);
                if (x.ToString().Length != 2)
                {
                    throw new Exception();
                }
                if (((x/10)+(x%10)) % 2 == 0)
                {
                    labRes.Text = "Сумма четная";
                }
                else
                {
                    labRes.Text = "Сумма нечетная";
                }
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введите число!";
            }
            catch (Exception)
            {
                labRes.Text = "Введите двузначное число!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
