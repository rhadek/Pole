using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole = new int[listBox1.Items.Count];
            int prvkudn = 0;
            bool nn = false;
            for (int i = 0; i < listBox1.Items.Count && !nn; i++)
            {
                pole[i] = Convert.ToInt32(listBox1.Items[i]);
                if (pole[i] != 0)
                {
                    prvkudn = i;
                }
                else
                {
                    nn = true;
                }
                
                
            }
            pole = pole.Take(prvkudn + 1).ToArray();
            int posledni = pole.Last();
            int prvni = pole.First();
            double ar = (double)prvni / posledni;
            MessageBox.Show("podil prvnihoa  posledniho je cisla je " + ar);
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < posledni)
                {
                    listBox2.Items.Add("na poradi " + i + " = " + pole[i]);
                }
                else
                {
                    listBox2.Items.Add("na poradi " + i + " = cislo vetsi nebo se rovna poslednimu cislu pred 0");
                }
                
            }
        }
    }
}
