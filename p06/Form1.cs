using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
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
            Random rnd = new Random();
            double[] pole = new double[n];
            double soucet = 0;
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (1000 + 1000) - 1000;
                listBox1.Items.Add(pole[i].ToString());
                soucet += pole[i];

            }
            int max = -1001;
            double ar = soucet / n;
            foreach (int i in pole)
            {
                if (i <= ar)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
            }
                MessageBox.Show("max ktere je mensi nez " + ar +" je " + max);
        }
    }
}
