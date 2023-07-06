using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Form3 : Form
    {
        public Form3(double[,] kol)
        {
            InitializeComponent();

            l11.Text = kol[0, 0].ToString();
            l12.Text = kol[0, 1].ToString();
            l13.Text = kol[0, 2].ToString();
            l14.Text = kol[0, 3].ToString();


            l21.Text = kol[1, 0].ToString();
            l22.Text = kol[1, 1].ToString();
            l23.Text = kol[1, 2].ToString();
            l24.Text = kol[1, 3].ToString();


            l32.Text = kol[2, 1].ToString();
            l33.Text = kol[2, 2].ToString();
            l34.Text = kol[2, 3].ToString();

            l42.Text = kol[3, 1].ToString();
            l43.Text = kol[3, 2].ToString();
            l44.Text = kol[3, 3].ToString();


            l53.Text = kol[4, 2].ToString();
            l54.Text = kol[4, 3].ToString();

            l63.Text = kol[5, 2].ToString();
            l64.Text = kol[5, 3].ToString();


            l74.Text = kol[6, 3].ToString();

            l84.Text = kol[7, 3].ToString();

            double r1 = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    r1 += kol[i, j];
                }
            }
            res1.Text += r1.ToString();

            double r2 = 0;
            for (int i = 2; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    r2 += kol[i, j];
                }
            }
            res2.Text += r2.ToString();

            double r3 = 0;
            for (int i = 4; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    r3 += kol[i, j];
                }
            }
            res3.Text += r3.ToString();

            double r4 = 0;
            for (int i = 6; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    r4 += kol[i, j];
                }
            }
            res4.Text += r4.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
