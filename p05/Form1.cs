using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
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
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(0, 21);
            }
            Array.Sort(pole);
            foreach (int i in pole)
            {
                listBox1.Items.Add(i.ToString());
            }
            int b = Convert.ToInt32(textBox2.Text);
            int poziceb = Array.IndexOf(pole, b);
            int[] pole1 = pole.Take(poziceb + 1).ToArray();
            foreach (int i in pole1)
            {
                listBox2.Items.Add(i.ToString());
            }
            int[] pole2 = pole.Skip(pole.Length - poziceb).ToArray();
            foreach (int i in pole2)
            {
                listBox3.Items.Add(i.ToString());
            }
        }
    }
}
