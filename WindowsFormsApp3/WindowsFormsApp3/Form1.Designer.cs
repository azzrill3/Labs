namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelX = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelY = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelZ = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelA = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxB = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemZ = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButton1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(752, 17);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDate,
            this.toolStripMenuItemTime});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemDate
            // 
            this.toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            this.toolStripMenuItemDate.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDate.Text = "Текущая дата";
            this.toolStripMenuItemDate.Click += new System.EventHandler(this.toolStripMenuItemDate_Click);
            // 
            // toolStripMenuItemTime
            // 
            this.toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            this.toolStripMenuItemTime.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTime.Text = "Текущее время";
            this.toolStripMenuItemTime.Click += new System.EventHandler(this.toolStripMenuItemTime_Click);
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timeDateTimeUpdate_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelX,
            this.toolStripTextBoxX,
            this.toolStripLabelY,
            this.toolStripTextBoxY,
            this.toolStripLabelZ,
            this.toolStripTextBoxZ,
            this.toolStripLabelA,
            this.toolStripComboBoxA,
            this.toolStripLabelB,
            this.toolStripComboBoxB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxX
            // 
            this.toolStripTextBoxX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxX.Name = "toolStripTextBoxX";
            this.toolStripTextBoxX.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripTextBoxY
            // 
            this.toolStripTextBoxY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxY.Name = "toolStripTextBoxY";
            this.toolStripTextBoxY.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripTextBoxZ
            // 
            this.toolStripTextBoxZ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxZ.Name = "toolStripTextBoxZ";
            this.toolStripTextBoxZ.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabelX
            // 
            this.toolStripLabelX.Name = "toolStripLabelX";
            this.toolStripLabelX.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabelX.Text = "x";
            // 
            // toolStripLabelY
            // 
            this.toolStripLabelY.Name = "toolStripLabelY";
            this.toolStripLabelY.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabelY.Text = "y";
            // 
            // toolStripLabelZ
            // 
            this.toolStripLabelZ.Name = "toolStripLabelZ";
            this.toolStripLabelZ.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabelZ.Text = "z";
            // 
            // toolStripLabelA
            // 
            this.toolStripLabelA.Name = "toolStripLabelA";
            this.toolStripLabelA.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabelA.Text = "a";
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabelB
            // 
            this.toolStripLabelB.Name = "toolStripLabelB";
            this.toolStripLabelB.Size = new System.Drawing.Size(14, 22);
            this.toolStripLabelB.Text = "b";
            // 
            // toolStripComboBoxB
            // 
            this.toolStripComboBoxB.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.toolStripComboBoxB.Name = "toolStripComboBoxB";
            this.toolStripComboBoxB.Size = new System.Drawing.Size(121, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton,
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.ToolStripStatusLabel.Text = "Ответ";
            // 
            // ToolStripDropDownButton
            // 
            this.ToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemZ,
            this.ToolStripMenuItemMouse});
            this.ToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButton.Image")));
            this.ToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton.Name = "ToolStripDropDownButton";
            this.ToolStripDropDownButton.Size = new System.Drawing.Size(123, 20);
            this.ToolStripDropDownButton.Text = "Выбор выражения";
            // 
            // ToolStripMenuItemZ
            // 
            this.ToolStripMenuItemZ.Name = "ToolStripMenuItemZ";
            this.ToolStripMenuItemZ.Size = new System.Drawing.Size(229, 22);
            this.ToolStripMenuItemZ.Text = "z = (x + y) / |y - x|";
            this.ToolStripMenuItemZ.Click += new System.EventHandler(this.ToolStripMenuItemZ_Click);
            // 
            // ToolStripMenuItemMouse
            // 
            this.ToolStripMenuItemMouse.Name = "ToolStripMenuItemMouse";
            this.ToolStripMenuItemMouse.Size = new System.Drawing.Size(229, 22);
            this.ToolStripMenuItemMouse.Text = "Координаты курсора мыши";
            this.ToolStripMenuItemMouse.Click += new System.EventHandler(this.ToolStripMenuItemMouse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainStatusStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxX;
        private System.Windows.Forms.ToolStripLabel toolStripLabelY;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxY;
        private System.Windows.Forms.ToolStripLabel toolStripLabelZ;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxZ;
        private System.Windows.Forms.ToolStripLabel toolStripLabelA;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripLabel toolStripLabelB;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemZ;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMouse;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
    }
}

