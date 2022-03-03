using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (1000 - 1) + 1;

            }
            
            for (int i = 0; i < pole.Length; i++)
                listBox1.Items.Add(pole[i].ToString("f2"));

            double min = 10000;
            double max = -20;
            int minp = 0;
            int maxp = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < min)
                {
                    min = pole[i];
                    minp = i;
                }
                if (pole[i] > max)
                {
                    max = pole[i];
                    maxp = i;
                }
            }
            double prohoz = min;
            pole[minp] = max;
            pole[maxp] = prohoz;
            for (int i = 0; i < pole.Length; i++)
            {
                listBox2.Items.Add(pole[i].ToString("f2"));
            }
            double soucet = pole.Sum();
            int pocet = pole.Length;
            double ar = (soucet - (min + max)) / (pocet - 2);
            MessageBox.Show("prumer bez max a min je " + ar.ToString("f2"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
