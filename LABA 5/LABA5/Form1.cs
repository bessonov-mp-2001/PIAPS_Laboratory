//http://www.dneonline.com/calculator.asmx

using System;
using System.Windows.Forms;

namespace LABA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calc.CalculatorSoap client = new Calc.CalculatorSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = client.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = client.Divide(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = client.Multiply(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = client.Subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
