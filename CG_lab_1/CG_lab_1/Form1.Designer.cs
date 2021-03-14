namespace CG_lab_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вОттенкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПереносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(21, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "открыть ";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.бинарныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.вОттенкахToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.линейноеРастяжениеГистограммыToolStripMenuItem,
            this.ПереносToolStripMenuItem,
            this.волныToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точечныеToolStripMenuItem.Text = "точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.инверсияToolStripMenuItem.Text = "инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.ИнверсияToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матричныеToolStripMenuItem.Text = "матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размытиеToolStripMenuItem.Text = "размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.РазмытиеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(434, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(43, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтрГауссаToolStripMenuItem.Text = "фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.ФильтрГауссаToolStripMenuItem_Click);
            // 
            // вОттенкахToolStripMenuItem
            // 
            this.вОттенкахToolStripMenuItem.Name = "вОттенкахToolStripMenuItem";
            this.вОттенкахToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.вОттенкахToolStripMenuItem.Text = "50 оттенков серого";
            this.вОттенкахToolStripMenuItem.Click += new System.EventHandler(this.ВОттенкахToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.сепияToolStripMenuItem.Text = "сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.СепияToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.яркостьToolStripMenuItem.Text = "яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.ЯркостьToolStripMenuItem_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтрСобеляToolStripMenuItem.Text = "фильтр Собеля";
            this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.ФильтрСобеляToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.резкостьToolStripMenuItem.Text = "резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.РезкостьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.сохранитьToolStripMenuItem.Text = "сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(434, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.идеальныйОтражательToolStripMenuItem.Text = "идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.ИдеальныйОтражательToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеГистограммыToolStripMenuItem
            // 
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Name = "линейноеРастяжениеГистограммыToolStripMenuItem";
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Text = "линейное растяжение гистограммы";
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Click += new System.EventHandler(this.ЛинейноеРастяжениеГистограммыToolStripMenuItem_Click);
            // 
            // ПереносToolStripMenuItem
            // 
            this.ПереносToolStripMenuItem.Name = "ПереносToolStripMenuItem";
            this.ПереносToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.ПереносToolStripMenuItem.Text = "перенос";
            this.ПереносToolStripMenuItem.Click += new System.EventHandler(this.ПереносToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.волныToolStripMenuItem.Text = "волны";
            this.волныToolStripMenuItem.Click += new System.EventHandler(this.ВолныToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тиснениеToolStripMenuItem.Text = "тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.ТиснениеToolStripMenuItem_Click);
            // 
            // бинарныеToolStripMenuItem
            // 
            this.бинарныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сужениеToolStripMenuItem,
            this.расширениеToolStripMenuItem});
            this.бинарныеToolStripMenuItem.Name = "бинарныеToolStripMenuItem";
            this.бинарныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.бинарныеToolStripMenuItem.Text = "бинарные";
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сужениеToolStripMenuItem.Text = "сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.СужениеToolStripMenuItem_Click);
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расширениеToolStripMenuItem.Text = "расширение";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.РасширениеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вОттенкахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПереносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
    }
}

