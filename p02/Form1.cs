using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);
                listBox1.Items.Add(pole[i].ToString());

            }
            int max = pole.Max();
            int min = pole.Min();
            int dmin = 100;
            int dmax = -20;
            for (int i = 0; i < n; i++)
            {
                if (pole[i] > dmax)
                {
                    if (pole[i] != max)
                    {
                        dmax = pole[i];
                    }
                }
                if (pole[i] < dmin)
                {
                    if (pole[i] != min)
                    {
                        dmin = pole[i];
                    }
                }
            }
            if (radioButton1.Checked)
            {
                Array.Sort(pole);
                foreach (int s in pole)
                    listBox2.Items.Add(s);
            }
            if (radioButton2.Checked)
            {
                Array.Sort(pole);
                Array.Reverse(pole);
                foreach (int s in pole)
                    listBox2.Items.Add(s);
                
            }
            MessageBox.Show("druhe nejvetsi cislo je " + dmax + " a druhe nejmensi cislo je " + dmin);
        }
    }
}
