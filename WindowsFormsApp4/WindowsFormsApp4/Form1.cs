using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = ColorPanel.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPanel.BackColor = colorDialog.Color;
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.ShowHelp = true;
            fontDialog.Font = FontBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                FontBox.Font = fontDialog.Font;
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Выбор папки";
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = Application.StartupPath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "txt files (*.txt)|*.txt |" + 
                "Мои файлы (*.mojfile)|*.mojfile |" +
                "Сборки (*.exe)|*.exe";
            openFileDialog.FilterIndex = 3;
            openFileDialog.Title = "Выбор файла";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileBox.Text = openFileDialog.FileName;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double U = 1, N, x;
            N = Convert.ToDouble(textBoxN.Text);
            x = Convert.ToDouble(textBoxX.Text);
            for (int i = 2; i < N + 2; i++)
            {
                int dir = (i % 2 == 0) ? -1 : 1;
                U += Math.Pow(Math.Sin(x), i) / i;
            }
            textBoxU.Text = U.ToString();
        }
    }
}
