using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p09
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
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);
            }
            Array.Sort(pole);
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(pole[i]);
            }
            int pl = pole.Length;
            double ar = 0;
            int pocet = 0;
            if (pl % 2 != 0)
            {
                ar = pole[pl / 2];
            }
            else
            {
                int cislo = pole[pl / 2];
                int cislo1 = pole[pl / 2 - 1];
                ar = (double)(cislo + cislo1) / 2;
            }
            for (int i = 0; i < n; i++)
            {
                if (pole[i] == ar)
                {
                    pocet++;
                }
            }
            MessageBox.Show("Median je " + ar + " a pocet medianuu je " + pocet);
        }
    }
}
