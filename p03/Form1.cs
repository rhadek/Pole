using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p03
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
            int m = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            int[] pole2 = new int[m];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(3, 11);
            }
            for (int i = 0; i < m; i++)
            {
                pole2[i] = rnd.Next(3, 11);
            }
            int[] pole3 = new int[pole.Length + pole2.Length];
            for (int i = 0; i < pole3.Length; i++)
            {
                
            }
        }
    }
}
