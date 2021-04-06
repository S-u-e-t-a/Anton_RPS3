namespace Lab3
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.RightBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TopBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BottomBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.CUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartCO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.TableButton = new System.Windows.Forms.Button();
            this.CreateChartButton = new System.Windows.Forms.Button();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ScaleUpDown);
            this.groupBox1.Controls.Add(this.RightBorderUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TopBorderUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BottomBorderUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LeftBorderUpDown);
            this.groupBox1.Controls.Add(this.CUpDown);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(601, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Коэффициент a:";
            // 
            // AUpDown
            // 
            this.AUpDown.DecimalPlaces = 1;
            this.AUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.AUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AUpDown.Location = new System.Drawing.Point(193, 226);
            this.AUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AUpDown.Name = "AUpDown";
            this.AUpDown.Size = new System.Drawing.Size(80, 29);
            this.AUpDown.TabIndex = 32;
            this.AUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AUpDown.ValueChanged += new System.EventHandler(this.AUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(96, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Шаг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Левая граница:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Коэффициент c:";
            // 
            // ScaleUpDown
            // 
            this.ScaleUpDown.DecimalPlaces = 2;
            this.ScaleUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.ScaleUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleUpDown.Location = new System.Drawing.Point(193, 261);
            this.ScaleUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScaleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleUpDown.Name = "ScaleUpDown";
            this.ScaleUpDown.Size = new System.Drawing.Size(80, 29);
            this.ScaleUpDown.TabIndex = 25;
            this.ScaleUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleUpDown.ValueChanged += new System.EventHandler(this.ScaleUpDown_ValueChanged);
            // 
            // RightBorderUpDown
            // 
            this.RightBorderUpDown.DecimalPlaces = 1;
            this.RightBorderUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.RightBorderUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RightBorderUpDown.Location = new System.Drawing.Point(194, 76);
            this.RightBorderUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RightBorderUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.RightBorderUpDown.Name = "RightBorderUpDown";
            this.RightBorderUpDown.Size = new System.Drawing.Size(80, 29);
            this.RightBorderUpDown.TabIndex = 20;
            this.RightBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Нижняя граница:";
            // 
            // TopBorderUpDown
            // 
            this.TopBorderUpDown.DecimalPlaces = 1;
            this.TopBorderUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.TopBorderUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TopBorderUpDown.Location = new System.Drawing.Point(194, 115);
            this.TopBorderUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TopBorderUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.TopBorderUpDown.Name = "TopBorderUpDown";
            this.TopBorderUpDown.Size = new System.Drawing.Size(80, 29);
            this.TopBorderUpDown.TabIndex = 21;
            this.TopBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Верхняя граница:";
            // 
            // BottomBorderUpDown
            // 
            this.BottomBorderUpDown.DecimalPlaces = 1;
            this.BottomBorderUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.BottomBorderUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BottomBorderUpDown.Location = new System.Drawing.Point(194, 154);
            this.BottomBorderUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BottomBorderUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.BottomBorderUpDown.Name = "BottomBorderUpDown";
            this.BottomBorderUpDown.Size = new System.Drawing.Size(80, 29);
            this.BottomBorderUpDown.TabIndex = 22;
            this.BottomBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Правая граница:";
            // 
            // LeftBorderUpDown
            // 
            this.LeftBorderUpDown.DecimalPlaces = 1;
            this.LeftBorderUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.LeftBorderUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LeftBorderUpDown.Location = new System.Drawing.Point(193, 37);
            this.LeftBorderUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LeftBorderUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.LeftBorderUpDown.Name = "LeftBorderUpDown";
            this.LeftBorderUpDown.Size = new System.Drawing.Size(80, 29);
            this.LeftBorderUpDown.TabIndex = 23;
            this.LeftBorderUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // CUpDown
            // 
            this.CUpDown.DecimalPlaces = 1;
            this.CUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.CUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CUpDown.Location = new System.Drawing.Point(194, 192);
            this.CUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CUpDown.Name = "CUpDown";
            this.CUpDown.Size = new System.Drawing.Size(80, 29);
            this.CUpDown.TabIndex = 24;
            this.CUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CUpDown.ValueChanged += new System.EventHandler(this.CUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(636, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveDataToolStripMenuItem,
            this.SaveResultToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveDataToolStripMenuItem
            // 
            this.SaveDataToolStripMenuItem.Enabled = false;
            this.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem";
            this.SaveDataToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveDataToolStripMenuItem.Text = "Сохранить исходные данные";
            this.SaveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // SaveResultToolStripMenuItem
            // 
            this.SaveResultToolStripMenuItem.Enabled = false;
            this.SaveResultToolStripMenuItem.Name = "SaveResultToolStripMenuItem";
            this.SaveResultToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveResultToolStripMenuItem.Text = "Сохранить результат";
            this.SaveResultToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SettingsToolStripMenuItem.Text = "Настройка";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.InfoToolStripMenuItem.Text = "Справка";
            // 
            // chartCO
            // 
            this.chartCO.BackColor = System.Drawing.Color.Transparent;
            this.chartCO.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chartCO.ChartAreas.Add(chartArea5);
            this.chartCO.Location = new System.Drawing.Point(12, 39);
            this.chartCO.Name = "chartCO";
            this.chartCO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Red;
            series9.IsVisibleInLegend = false;
            series9.Name = "CassiniOvalPos";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Red;
            series10.IsVisibleInLegend = false;
            series10.Name = "CassiniOvalNeg";
            this.chartCO.Series.Add(series9);
            this.chartCO.Series.Add(series10);
            this.chartCO.Size = new System.Drawing.Size(583, 368);
            this.chartCO.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans Cond", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(118, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 33);
            this.label8.TabIndex = 34;
            this.label8.Text = "Построение овала Кассини";
            // 
            // TableButton
            // 
            this.TableButton.Enabled = false;
            this.TableButton.Font = new System.Drawing.Font("Noto Sans Cond", 11.25F, System.Drawing.FontStyle.Bold);
            this.TableButton.Location = new System.Drawing.Point(601, 413);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(150, 33);
            this.TableButton.TabIndex = 35;
            this.TableButton.Text = "Таблица значений";
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // CreateChartButton
            // 
            this.CreateChartButton.Font = new System.Drawing.Font("Noto Sans Cond", 11.25F, System.Drawing.FontStyle.Bold);
            this.CreateChartButton.Location = new System.Drawing.Point(753, 413);
            this.CreateChartButton.Name = "CreateChartButton";
            this.CreateChartButton.Size = new System.Drawing.Size(150, 33);
            this.CreateChartButton.TabIndex = 36;
            this.CreateChartButton.Text = "Построить график";
            this.CreateChartButton.UseVisualStyleBackColor = true;
            this.CreateChartButton.Click += new System.EventHandler(this.CreateChartButton_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть файл";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 470);
            this.Controls.Add(this.CreateChartButton);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chartCO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Лабораторная работа №3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RightBorderUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TopBorderUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BottomBorderUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LeftBorderUpDown;
        private System.Windows.Forms.NumericUpDown CUpDown;
        private System.Windows.Forms.NumericUpDown ScaleUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button TableButton;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCO;
        private System.Windows.Forms.ToolStripMenuItem SaveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResultToolStripMenuItem;
        private System.Windows.Forms.Button CreateChartButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

