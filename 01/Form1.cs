using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int DruheMax(List<int> cisla)
        {
            int max = cisla.Max();
            cisla.RemoveAll(a => a == max);
            return cisla.Max();
        }

        public int DruheMin(List<int> cisla)
        {
            int min = cisla.Min();
            cisla.RemoveAll(a => a == min);
            return cisla.Min();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> cisla = new List<int>();
            foreach (string s in textBox1.Lines)
            {
                int c = int.Parse(s);
                cisla.Add(c);
            }
            MessageBox.Show($"Druhe max je: {DruheMax(cisla).ToString()} a druhe min je: {DruheMin().ToString()}");
        }
    }
}
