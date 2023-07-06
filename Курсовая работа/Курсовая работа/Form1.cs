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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            x11.Text = "";
            x12.Text = "";
            x13.Text = "";
            x14.Text = "";
            x15.Text = "";
            x16.Text = "";
            x17.Text = "";


            x21.Text = "";
            x22.Text = "";
            x23.Text = "";
            x24.Text = "";
            x25.Text = "";
            x26.Text = "";
            x27.Text = "";


            x31.Text = "";
            x32.Text = "";
            x33.Text = "";
            x34.Text = "";
            x35.Text = "";
            x36.Text = "";
            x37.Text = "";


            x41.Text = "";
            x42.Text = "";
            x43.Text = "";
            x44.Text = "";
            x45.Text = "";
            x46.Text = "";
            x47.Text = "";

            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
            r4.Text = "";

            l1.Text = "0";
            l2.Text = "0";
            l3.Text = "0";
            l4.Text = "0";
            l5.Text = "0";
            l6.Text = "0";
            l7.Text = "0";
            l8.Text = "0";

        }
        double[,] x = new double[5, 12];
        private void label12_Click(object sender, EventArgs e)
        {
            label13_Click(sender, e);

            x11.Text = "8.0";
            x12.Text = "0.0";
            x13.Text = "4.0";
            x14.Text = "12.0";
            x15.Text = "0.0";
            x16.Text = "6.0";
            x17.Text = "-1.0";

            x21.Text = "0.0";
            x22.Text = "3.0";
            x23.Text = "1.0";
            x24.Text = "0.0";
            x25.Text = "4.0";
            x26.Text = "2.0";
            x27.Text = "-1.0";

            x31.Text = "1.0";
            x32.Text = "1.0";
            x33.Text = "1.0";
            x34.Text = "0.0";
            x35.Text = "0.0";
            x36.Text = "0.0";
            x37.Text = "0.0";

            x41.Text = "0.0";
            x42.Text = "0.0";
            x43.Text = "0.0";
            x44.Text = "1.0";
            x45.Text = "1.0";
            x46.Text = "1.0";
            x47.Text = "0.0";

            r1.Text = "0.0";
            r2.Text = "0.0";
            r3.Text = "200.0";
            r4.Text = "100.0";

            x[0, 0] = 0.0;
            x[0, 1] = -8.0;
            x[0, 2] = 0.0;
            x[0, 3] = -4.0;
            x[0, 4] = -12.0;
            x[0, 5] = 0.0;
            x[0, 6] = -6.0;
            x[0, 7] = 1.0;
            x[0, 8] = 1.0;
            x[0, 9] = 0.0;
            x[0, 10] = 0.0;
            x[0, 11] = 0.0;

            x[1, 0] = 0.0;
            x[1, 1] = 0.0;
            x[1, 2] = -3.0;
            x[1, 3] = -1.0;
            x[1, 4] = 0.0;
            x[1, 5] = -4.0;
            x[1, 6] = -2.0;
            x[1, 7] = 1.0;
            x[1, 8] = 0.0;
            x[1, 9] = 1.0;
            x[1, 10] = 0.0;
            x[1, 11] = 0.0;


            x[2, 0] = 200.0;
            x[2, 1] = 1.0;
            x[2, 2] = 1.0;
            x[2, 3] = 1.0;
            x[2, 4] = 0.0;
            x[2, 5] = 0.0;
            x[2, 6] = 0.0;
            x[2, 7] = 0.0;
            x[2, 8] = 0.0;
            x[2, 9] = 0.0;
            x[2, 10] = 1.0;
            x[2, 11] = 0.0;


            x[3, 0] = 100.0;
            x[3, 1] = 0.0;
            x[3, 2] = 0.0;
            x[3, 3] = 0.0;
            x[3, 4] = 1.0;
            x[3, 5] = 1.0;
            x[3, 6] = 1.0;
            x[3, 7] = 0.0;
            x[3, 8] = 0.0;
            x[3, 9] = 0.0;
            x[3, 10] = 0.0;
            x[3, 11] = 1.0;


            x[4, 0] = 0.0;
            x[4, 1] = 0.0;
            x[4, 2] = 0.0;
            x[4, 3] = 0.0;
            x[4, 4] = 0.0;
            x[4, 5] = 0.0;
            x[4, 6] = 0.0;
            x[4, 7] = -1.0;
            x[4, 8] = 0.0;
            x[4, 9] = 0.0;
            x[4, 10] = 0.0;
            x[4, 11] = 0.0;

        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (x11.Text == "") { MessageBox.Show("Не все поля заполнены!"); return; }

            Label[] labels = new Label[8];
            labels[0] = l1;
            labels[1] = l2;
            labels[2] = l3;
            labels[3] = l4;
            labels[4] = l5;
            labels[5] = l6;
            labels[6] = l7;
            labels[7] = l8;
            int[] basis = new int[4] { 8, 9, 10, 11 };
            double[,] result = GetResultMass(x, basis);
            int k = 0;
            foreach (int b in basis)
            {
                labels[b - 1].Text = result[k, 0].ToString();
                k++;
            }
            l8.Text = l7.Text;
        }
        private double[,] GetResultMass(double[,] x, int[] basis)
        {
            while(allFIsBigger0(x))
            {
                //нашли наибольшее значение функции по модулю (посл строка)
                int index = BiggestIndInF(x);
                //поиск минимальной строки (В / xi)
                double[] min = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    if (x[i, index] <= 0) min[i] = 10000;
                    else min[i] = x[i, 0] / x[i, index];
                }
                int index2 = -1;
                double min_el = 1000;
                for (int i = 0; i < min.Length; i++)
                {
                    if(min[i] < min_el)
                    {
                        index2 = i;
                        min_el = min[i];
                    }
                }
                double razr = x[index2, index];

                   
                //пересчет одного из базовых элементов
                int index_baz = basis[index2];
                for (int i = 0; i < 5; i++)
                {
                    x[i, index_baz] = 0;
                }
                x[index2, index_baz] = 1;

                //пересчет таблицы
                double[] razr_mas = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    razr_mas[i] = x[i, index];
                }

                for (int i = 0; i < 5; i++)
                {
                    if (i == index2) continue;
                    for (int j = 0; j < 12; j++)
                    {
                        x[i, j] = x[i, j] - (x[index2, j]*razr_mas[i]) / razr;
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    x[index2, i] = x[index2, i] / razr;
                }
                basis[index2] = index;
            }
            return x;
        }


        private bool allFIsBigger0(double[,] mas)
        {
            for (int i = 0; i < 12; i++)
            {
                if (mas[4, i] < 0) return true;
            }
            return false;
        }
        private int BiggestIndInF(double[,] mas)
        {
            int index = -1;
            double max = -1;
            for (int i = 1; i < 12; i++)
            {
                if (i == 11) continue; 
                if(Math.Abs(mas[4, i]) > max)
                {
                    max = Math.Abs(mas[4, i]);
                    index = i;
                }
            }
            return index;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label13_Click(sender, e);

            x11.Text = "8.0";
            x12.Text = "0.0";
            x13.Text = "4.0";
            x14.Text = "12.0";
            x15.Text = "0.0";
            x16.Text = "6.0";
            x17.Text = "-1.0";

            x21.Text = "0.0";
            x22.Text = "3.0";
            x23.Text = "1.0";
            x24.Text = "0.0";
            x25.Text = "4.0";
            x26.Text = "2.0";
            x27.Text = "-1.0";

            x31.Text = "1.0";
            x32.Text = "1.0";
            x33.Text = "1.0";
            x34.Text = "0.0";
            x35.Text = "0.0";
            x36.Text = "0.0";
            x37.Text = "0.0";

            x41.Text = "0.0";
            x42.Text = "0.0";
            x43.Text = "0.0";
            x44.Text = "1.0";
            x45.Text = "1.0";
            x46.Text = "1.0";
            x47.Text = "0.0";

            r1.Text = "0.0";
            r2.Text = "0.0";
            r3.Text = "150.0";
            r4.Text = "150.0";

            x[0, 0] = 0.0;
            x[0, 1] = -8.0;
            x[0, 2] = 0.0;
            x[0, 3] = -4.0;
            x[0, 4] = -12.0;
            x[0, 5] = 0.0;
            x[0, 6] = -6.0;
            x[0, 7] = 1.0;
            x[0, 8] = 1.0;
            x[0, 9] = 0.0;
            x[0, 10] = 0.0;
            x[0, 11] = 0.0;

            x[1, 0] = 0.0;
            x[1, 1] = 0.0;
            x[1, 2] = -3.0;
            x[1, 3] = -1.0;
            x[1, 4] = 0.0;
            x[1, 5] = -4.0;
            x[1, 6] = -2.0;
            x[1, 7] = 1.0;
            x[1, 8] = 0.0;
            x[1, 9] = 1.0;
            x[1, 10] = 0.0;
            x[1, 11] = 0.0;


            x[2, 0] = 150.0;
            x[2, 1] = 1.0;
            x[2, 2] = 1.0;
            x[2, 3] = 1.0;
            x[2, 4] = 0.0;
            x[2, 5] = 0.0;
            x[2, 6] = 0.0;
            x[2, 7] = 0.0;
            x[2, 8] = 0.0;
            x[2, 9] = 0.0;
            x[2, 10] = 1.0;
            x[2, 11] = 0.0;


            x[3, 0] = 150.0;
            x[3, 1] = 0.0;
            x[3, 2] = 0.0;
            x[3, 3] = 0.0;
            x[3, 4] = 1.0;
            x[3, 5] = 1.0;
            x[3, 6] = 1.0;
            x[3, 7] = 0.0;
            x[3, 8] = 0.0;
            x[3, 9] = 0.0;
            x[3, 10] = 0.0;
            x[3, 11] = 1.0;


            x[4, 0] = 0.0;
            x[4, 1] = 0.0;
            x[4, 2] = 0.0;
            x[4, 3] = 0.0;
            x[4, 4] = 0.0;
            x[4, 5] = 0.0;
            x[4, 6] = 0.0;
            x[4, 7] = -1.0;
            x[4, 8] = 0.0;
            x[4, 9] = 0.0;
            x[4, 10] = 0.0;
            x[4, 11] = 0.0;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            var f = new Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
