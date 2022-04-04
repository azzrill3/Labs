using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            float ans, h, o1, f;
            label1.Text = "o1";
            label2.Text = "h";
            label3.Text = "f";
            if (textBox1.Text == "") textBox1.Text = "0";
            if (textBox2.Text == "") textBox2.Text = "0";
            if (textBox3.Text == "") textBox3.Text = "0";
            h = Convert.ToSingle(textBox1.Text);
            o1 = Convert.ToSingle(textBox2.Text);
            f = Convert.ToSingle(textBox3.Text);
            ans = (float)Math.Sin(h + e.X / Math.Pow(Math.E, (double)o1)) - o1 + Math.Abs((float)Math.Sin(f) + (float)Math.Sqrt(Math.Abs((float)Math.Sin(e.Y))));
            Text = string.Format("Ответ: {0}", ans);
        }
    }
}
