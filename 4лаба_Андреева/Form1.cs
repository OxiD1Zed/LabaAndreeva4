using System;
using System.Windows.Forms;

namespace _4лаба_Андреева
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button1, textBox1);
            Program.ReplaceTextOfButton(button1, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button2, textBox1);
            Program.ReplaceTextOfButton(button2, textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button3, textBox1);
            Program.ReplaceTextOfButton(button3, textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button4, textBox1);
            Program.ReplaceTextOfButton(button4, textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button5, textBox1);
            Program.ReplaceTextOfButton(button5, textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.RefreshColor(button6, textBox1);
            Program.ReplaceTextOfButton(button6, textBox1);
        }
    }
}
