using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            char[] pole = new char[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int ascii = rnd.Next(48, 67);
                pole[i] = (char)ascii;
                listBox1.Items.Add("" + pole[i]);
            }
           
            char posledni = pole.Last();
            int poslednip = Array.IndexOf(pole, posledni);
            
            if (posledni <= 57)
            {
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] <= 57)
                    {
                        pole[i] = 'x';
                    }
                }
            }
            else
            {
                char max = pole.Max();
                int maxp = Array.IndexOf(pole, max);
                pole[poslednip] = max;

                pole[maxp] = posledni;
            }
            for (int i = 0; i < pole.Length; i++)
            {
                listBox2.Items.Add("" + pole[i]);
            }
        }
    }
}
