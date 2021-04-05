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
        int temp1, temp2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label2.Text = client.Add(temp1, temp2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                if (temp2 == 0)
                {
                    label2.Text = "Error";
                }
                else
                {
                    label2.Text = client.Divide(temp1, temp2).ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label2.Text = client.Multiply(temp1, temp2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out temp1) && int.TryParse(textBox2.Text, out temp2))
            {
                label2.Text = client.Subtract(temp1, temp2).ToString();
            }
        }
    }
}
