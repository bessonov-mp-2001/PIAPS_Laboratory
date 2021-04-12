using System;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator client = new Calculator();
        int temp1, temp2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label1.Text = client.Sum(temp1, temp2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label1.Text = client.Substract(temp1, temp2).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label1.Text = client.Multiply(temp1, temp2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                if (temp2 == 0)
                {
                    label1.Text = "Error";
                }
                else
                {
                    label1.Text = client.Divide(temp1, temp2).ToString();
                }
            }
        }
    }
}
