using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
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
            listBox3.Items.Clear();
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {

                pole[i] = rnd.Next(1, 21);
                listBox1.Items.Add(pole[i].ToString());
            }
            pole = pole.Distinct().ToArray();
            for (int i = 0; i < pole.Length; i++)
            {

                
                listBox2.Items.Add(pole[i].ToString());
            }
            int max = pole.Max();
            int pozicemax = Array.IndexOf(pole, max);
            for (int i = 0; i < pole.Length - 1; i++)
            {
                if (pole[i] == max)
                {
                    pole[i] = pole[i + 1];
                    i--;
                }
                else
                {
                    pole[i] = pole[i + 1];
                    listBox3.Items.Add(pole[i].ToString());
                }
            }
        }
    }
}
