using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Vypis(List<double> c, ListBox lb)
        {
            foreach (double d in c)
            {
                lb.Items.Add(d);
            }
        }

        List<double> cisla = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                cisla.Add(Math.Round(rnd.NextDouble() * (25 +6) - 6, 2));
            }
            Vypis(cisla, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cisla.Reverse();
            Vypis(cisla, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> poradi = new List<int>();
            int p = 1;
            double min = 26;
            foreach (double d in cisla)
            {
                if (d < min)
                {
                    poradi.Clear();
                    min = d;
                    poradi.Add(p);
                }
                else if (d == min)
                {
                    poradi.Add(p);
                }
                p++;
            }

            foreach (int i in poradi)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
