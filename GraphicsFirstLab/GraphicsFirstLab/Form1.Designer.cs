namespace GraphicsFirstLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            чБToolStripMenuItem = new ToolStripMenuItem();
            яркостьToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            собеляToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem = new ToolStripMenuItem();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            медианныйToolStripMenuItem = new ToolStripMenuItem();
            щарраToolStripMenuItem = new ToolStripMenuItem();
            горизонтальныйToolStripMenuItem = new ToolStripMenuItem();
            вертикальныйToolStripMenuItem = new ToolStripMenuItem();
            матморфологияToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem = new ToolStripMenuItem();
            erosionToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            openingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1107, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, фильтрToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem, матморфологияToolStripMenuItem });
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(60, 20);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, сепияToolStripMenuItem, чБToolStripMenuItem, яркостьToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(180, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(128, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(128, 22);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // чБToolStripMenuItem
            // 
            чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            чБToolStripMenuItem.Size = new Size(128, 22);
            чБToolStripMenuItem.Text = "ЧБ";
            чБToolStripMenuItem.Click += чБToolStripMenuItem_Click;
            // 
            // яркостьToolStripMenuItem
            // 
            яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            яркостьToolStripMenuItem.Size = new Size(128, 22);
            яркостьToolStripMenuItem.Text = "Яркость";
            яркостьToolStripMenuItem.Click += яркостьToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, собеляToolStripMenuItem, резкостьToolStripMenuItem, тиснениеToolStripMenuItem, медианныйToolStripMenuItem, щарраToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(180, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(140, 22);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // собеляToolStripMenuItem
            // 
            собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            собеляToolStripMenuItem.Size = new Size(140, 22);
            собеляToolStripMenuItem.Text = "Собеля";
            собеляToolStripMenuItem.Click += собеляToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem
            // 
            резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            резкостьToolStripMenuItem.Size = new Size(140, 22);
            резкостьToolStripMenuItem.Text = "Резкость";
            резкостьToolStripMenuItem.Click += резкостьToolStripMenuItem_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(140, 22);
            тиснениеToolStripMenuItem.Text = "Тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // медианныйToolStripMenuItem
            // 
            медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            медианныйToolStripMenuItem.Size = new Size(140, 22);
            медианныйToolStripMenuItem.Text = "Медианный";
            медианныйToolStripMenuItem.Click += медианныйToolStripMenuItem_Click;
            // 
            // щарраToolStripMenuItem
            // 
            щарраToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { горизонтальныйToolStripMenuItem, вертикальныйToolStripMenuItem });
            щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
            щарраToolStripMenuItem.Size = new Size(140, 22);
            щарраToolStripMenuItem.Text = "Щарра";
            щарраToolStripMenuItem.Click += щарраToolStripMenuItem_Click;
            // 
            // горизонтальныйToolStripMenuItem
            // 
            горизонтальныйToolStripMenuItem.Name = "горизонтальныйToolStripMenuItem";
            горизонтальныйToolStripMenuItem.Size = new Size(167, 22);
            горизонтальныйToolStripMenuItem.Text = "Горизонтальный";
            горизонтальныйToolStripMenuItem.Click += горизонтальныйToolStripMenuItem_Click;
            // 
            // вертикальныйToolStripMenuItem
            // 
            вертикальныйToolStripMenuItem.Name = "вертикальныйToolStripMenuItem";
            вертикальныйToolStripMenuItem.Size = new Size(167, 22);
            вертикальныйToolStripMenuItem.Text = "Вертикальный";
            вертикальныйToolStripMenuItem.Click += вертикальныйToolStripMenuItem_Click;
            // 
            // матморфологияToolStripMenuItem
            // 
            матморфологияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem, erosionToolStripMenuItem, openingToolStripMenuItem });
            матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            матморфологияToolStripMenuItem.Size = new Size(180, 22);
            матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // dilationToolStripMenuItem
            // 
            dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            dilationToolStripMenuItem.Size = new Size(180, 22);
            dilationToolStripMenuItem.Text = "Dilation";
            dilationToolStripMenuItem.Click += dilationToolStripMenuItem_Click;
            // 
            // erosionToolStripMenuItem
            // 
            erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            erosionToolStripMenuItem.Size = new Size(180, 22);
            erosionToolStripMenuItem.Text = "Erosion";
            erosionToolStripMenuItem.Click += erosionToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1107, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(191, 524);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(651, 23);
            progressBar1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(848, 524);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openingToolStripMenuItem
            // 
            openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            openingToolStripMenuItem.Size = new Size(180, 22);
            openingToolStripMenuItem.Text = "Opening";
            openingToolStripMenuItem.Click += openingToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 622);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button button1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem чБToolStripMenuItem;
        private ToolStripMenuItem собеляToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem яркостьToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem медианныйToolStripMenuItem;
        private ToolStripMenuItem щарраToolStripMenuItem;
        private ToolStripMenuItem горизонтальныйToolStripMenuItem;
        private ToolStripMenuItem вертикальныйToolStripMenuItem;
        private ToolStripMenuItem матморфологияToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem;
        private ToolStripMenuItem erosionToolStripMenuItem;
        private ToolStripMenuItem openingToolStripMenuItem;
    }
}
