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
        int[] A;
        int[] B;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox1.Text);
            A = new int[n];
            B = new int[m];
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(3, 11);
            }
            for (int i = 0; i < m; i++)
            {
                B[i] = rnd.Next(3, 11);
            }
            for (int i = 0; i < A.Length; i++)
            {
                listBox1.Items.Add(A[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < B.Length;i++)
            {
                listBox2.Items.Add(B[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] C = A.Concat(B).ToArray();
            for (int i = 0; i < C.Length; i++)
            {
                listBox3.Items.Add(C[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] D = A.Union(B).ToArray();
            for (int i = 0; i < D.Length; i++)
            {
                listBox4.Items.Add(D[i].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] E = A.Intersect(B).ToArray();
            for (int i = 0; i < E.Length; i++)
            {
                listBox5.Items.Add(E[i].ToString());
            }
        }
    }
}
