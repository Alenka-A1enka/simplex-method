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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            l11.Text = "0";
            l12.Text = "0,8";
            l13.Text = "1,6";
            l14.Text = "2,4";


            l21.Text = "1";
            l22.Text = "1,8";
            l23.Text = "2,6";
            l24.Text = "3,4";


            l32.Text = "0";
            l33.Text = "0,8";
            l34.Text = "1,6";


            l42.Text = "1";
            l43.Text = "1,8";
            l44.Text = "2,6";


            l53.Text = "0";
            l54.Text = "0,8";

            l63.Text = "1";
            l64.Text = "1,8";


            l74.Text = "0";
            l84.Text = "1";

            p1.Text = "125";
            p3.Text = "125";
            p5.Text = "125";
            p7.Text = "125";
            p2.Text = "25";
            p4.Text = "25";
            p6.Text = "25";
            p8.Text = "25";

            s1.Text = "100";
            s2.Text = "140";
            s3.Text = "170";
            s4.Text = "90";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double[,] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            mas = new double[8, 4]     { { 0, 0.8, 1.6, 2.4},   {1, 1.8, 2.6, 3.4 },
                 {10, 0, 0.8, 1.6 },   {10, 1, 1.8, 2.6 },
            {10, 10, 0, 0.8 },  {10, 10, 1, 1.8 },
            {10, 10, 10, 0 }, {10, 10, 10, 1 }  };

            double[,] m1 = mas;
            double[] p1 = {125, 25, 125, 25, 125, 25, 125, 25 };
            double[] s1 = { 100, 140, 170, 90};
            double[,] kol = new double[8, 4];
            while (!MassIsNull(s1))
            {
                double current = 100000;
                int i_min = -1;
                int j_min = -1;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (m1[i, j] < current && m1[i, j] != -1)
                        {
                            current = m1[i, j];
                            i_min = i;
                            j_min = j;
                        }
                    }
                }
                double x = p1[i_min];
                double y = s1[j_min];
                double min = Math.Min(x, y);
                kol[i_min, j_min] = min;
                p1[i_min] -= min;
                s1[j_min] -= min;
                m1[i_min, j_min] = -1;

                
            }

            var f = new Form3(kol);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private bool MassIsNull(double[] a)
        {
            //все элементы равны 0 - true
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0) return false;
            }
            return true;
        }
    }
}
