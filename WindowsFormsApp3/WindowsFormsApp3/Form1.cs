using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public enum DateTimeFormat
    {
        ShowTime,
        ShowDate
    }
    public partial class Form1 : Form
    {
        public DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        public ToolStripMenuItem currentCheckedItem, currentCheckedItem2;
        public Double x, y, z, a, b;

        public Form1()
        {
            InitializeComponent();
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
            currentCheckedItem2 = ToolStripMenuItemZ;
            currentCheckedItem2.Checked = true;
        }

        private void timeDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToShortTimeString();
            else
                info = DateTime.Now.ToShortDateString();
            toolStripStatusLabelClock.Text = info;

            if (toolStripTextBoxX.Text == "") toolStripTextBoxX.Text = "0";
            if (toolStripTextBoxY.Text == "") toolStripTextBoxY.Text = "0";
            if (toolStripTextBoxZ.Text == "") toolStripTextBoxZ.Text = "0";
            if (toolStripComboBoxA.Text == "") toolStripComboBoxA.Text = "1";
            if (toolStripComboBoxB.Text == "") toolStripComboBoxB.Text = "10";

            x = Convert.ToDouble(toolStripTextBoxX.Text);
            y = Convert.ToDouble(toolStripTextBoxY.Text);
            z = Convert.ToDouble(toolStripTextBoxZ.Text);
            a = Convert.ToDouble(toolStripComboBoxA.Text);
            b = Convert.ToDouble(toolStripComboBoxB.Text);

            double ans = (a * x) / (b - y) + (b * y + Math.Sin(z)) / a * x;

            Text = Convert.ToString(ans);

            double ans2 = (x + y) / Math.Abs(y - x);
            
            if (currentCheckedItem2 == ToolStripMenuItemZ) ToolStripStatusLabel.Text = "z = " + Convert.ToString(ans2);
        }

        private void ToolStripMenuItemZ_Click(object sender, EventArgs e)
        {
            currentCheckedItem2.Checked = false;
            currentCheckedItem2 = ToolStripMenuItemZ;
            currentCheckedItem2.Checked = true;
        }

        private void ToolStripMenuItemMouse_Click(object sender, EventArgs e)
        {
            currentCheckedItem2.Checked = false;
            currentCheckedItem2 = ToolStripMenuItemMouse;
            currentCheckedItem2.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = e.Location.ToString();
            toolStripStatusLabelState.Visible = true;

            if (currentCheckedItem2 == ToolStripMenuItemMouse) ToolStripStatusLabel.Text = "Координаты курсора равны: " + e.Location.ToString();
        }
    }
}
