namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.FontButton = new System.Windows.Forms.Button();
            this.FontBox = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileButton = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(27, 25);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(150, 23);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Выбор цвета";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Location = new System.Drawing.Point(206, 25);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(357, 23);
            this.ColorPanel.TabIndex = 1;
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(27, 67);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(150, 23);
            this.FontButton.TabIndex = 2;
            this.FontButton.Text = "Выбор шрифта";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // FontBox
            // 
            this.FontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontBox.Location = new System.Drawing.Point(206, 69);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(357, 30);
            this.FontBox.TabIndex = 3;
            this.FontBox.Text = "Образец шрифта";
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(27, 163);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(150, 23);
            this.FolderButton.TabIndex = 4;
            this.FolderButton.Text = "Выбор папки";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FolderBox
            // 
            this.FolderBox.Location = new System.Drawing.Point(206, 166);
            this.FolderBox.Name = "FolderBox";
            this.FolderBox.Size = new System.Drawing.Size(357, 20);
            this.FolderBox.TabIndex = 5;
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(27, 120);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(150, 23);
            this.FileButton.TabIndex = 6;
            this.FileButton.Text = "Выбор файла";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(206, 123);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(357, 20);
            this.FileBox.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(27, 206);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(150, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(236, 208);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(60, 20);
            this.textBoxN.TabIndex = 9;
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(445, 208);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.ReadOnly = true;
            this.textBoxU.Size = new System.Drawing.Size(118, 20);
            this.textBoxU.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "N =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "U =";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(335, 208);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(64, 20);
            this.textBoxX.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "x =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxU);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.FolderBox);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.ColorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.TextBox FontBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.TextBox FolderBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
    }
}

