using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double a, b, X, R, N, Z = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: a = 1;
                    break;
                case 1: a = 2;
                    break;
                case 2: a = 3;
                    break;
                case 3: a = 4;
                    break;
                case 4: a = 5;
                    break;
            }

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    b = 0.1;
                    break;
                case 1:
                    b = 0.01;
                    break;
                case 2:
                    b = 0.001;
                    break;
            }

            if (textBox1.Text == "") textBox1.Text = "0";
            if (textBox2.Text == "") textBox2.Text = "0";
            if (textBox3.Text == "") textBox3.Text = "0";

            X = Convert.ToDouble(textBox1.Text);
            R = Convert.ToDouble(textBox2.Text);
            N = Convert.ToDouble(textBox3.Text);

            if (radioButton1.Checked)
            {
                for (int i = 1; i < N; i++)
                {
                    for (int j = 1; j < R; j++)
                    {
                        Z += a * Math.Pow(i, 2) / (Math.Pow(i, 3) + b * Math.Pow(j, 3));
                    }
                }
            }
            if (radioButton3.Checked)
            {
                double temp1 = 1;
                for (int i = 1; i < N; i++)
                {
                    temp1 *= i + 1;
                    double temp2 = (i % 2 == 0) ? 1 : -1;
                    Z += temp2 * Math.Pow(X, i) / temp1;
                }
            }
            textBox4.Text = Convert.ToString(Z);
        }
    }
}
