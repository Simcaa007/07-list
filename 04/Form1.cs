using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> znaky = new List<char>();

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            foreach (char ch in retezec)
            {
                znaky.Add(ch);
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'a');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button2.Enabled = false;

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'e');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'i');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'o');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'u');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string vys = "";
            textBox1.Clear();

            znaky.RemoveAll(a => a == 'y');

            foreach (char ch in znaky)
            {
                textBox1.Text += ch;
            }

            button7.Enabled = false;
        }
    }
}
