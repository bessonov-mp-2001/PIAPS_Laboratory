﻿using System;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.WebService1Soap client = new ServiceReference1.WebService1SoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            string pole = textBox1.Text;
            label1.Text = client.CheckReis(pole);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pole = textBox1.Text;
            label1.Text = client.Checkbilet(pole);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pole = textBox2.Text;
            label1.Text = client.Zakazbilet(pole);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = client.ShowMarshrut();
        }
    }
}
