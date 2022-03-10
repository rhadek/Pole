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
            int[] pole1 = new int[pozicemax];
            int[] pole2 = new int[pole.Length - pozicemax - 1];
            pole1 = pole.Take(pozicemax).ToArray();
            pole2 = pole.Skip(pozicemax + 1).ToArray();
            int[] poleC = pole1.Concat(pole2).ToArray();
            foreach (int i in poleC)
            {
                listBox3.Items.Add(i.ToString());
            }
        }
    }
}
