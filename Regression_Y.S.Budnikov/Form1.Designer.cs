namespace Regression_Y.S.Budnikov
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спарвкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Line_b = new System.Windows.Forms.Button();
            this.Indicative_b = new System.Windows.Forms.Button();
            this.Log_b = new System.Windows.Forms.Button();
            this.Hyperbola_b = new System.Windows.Forms.Button();
            this.Degree_b = new System.Windows.Forms.Button();
            this.Cube_b = new System.Windows.Forms.Button();
            this.Square_b = new System.Windows.Forms.Button();
            this.Exp_b = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sol = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Y_tb = new System.Windows.Forms.TextBox();
            this.X_tb = new System.Windows.Forms.TextBox();
            this.Check_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.BackColor = System.Drawing.SystemColors.Control;
            this.Graph.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Location = new System.Drawing.Point(0, 411);
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Navy;
            series1.Name = "Точки";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Name = "График";
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(1209, 387);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "Graph";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.спарвкаToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1209, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // спарвкаToolStripMenuItem
            // 
            this.спарвкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.спарвкаToolStripMenuItem.Name = "спарвкаToolStripMenuItem";
            this.спарвкаToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.спарвкаToolStripMenuItem.Text = "Справка";
            this.спарвкаToolStripMenuItem.Click += new System.EventHandler(this.спарвкаToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // Line_b
            // 
            this.Line_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line_b.Location = new System.Drawing.Point(3, 30);
            this.Line_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Line_b.Name = "Line_b";
            this.Line_b.Size = new System.Drawing.Size(311, 39);
            this.Line_b.TabIndex = 6;
            this.Line_b.Text = "Линейная";
            this.Line_b.UseVisualStyleBackColor = true;
            this.Line_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Indicative_b
            // 
            this.Indicative_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Indicative_b.Location = new System.Drawing.Point(320, 30);
            this.Indicative_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Indicative_b.Name = "Indicative_b";
            this.Indicative_b.Size = new System.Drawing.Size(311, 39);
            this.Indicative_b.TabIndex = 7;
            this.Indicative_b.Text = "Показательная";
            this.Indicative_b.UseVisualStyleBackColor = true;
            this.Indicative_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Log_b
            // 
            this.Log_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_b.Location = new System.Drawing.Point(320, 77);
            this.Log_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Log_b.Name = "Log_b";
            this.Log_b.Size = new System.Drawing.Size(311, 39);
            this.Log_b.TabIndex = 8;
            this.Log_b.Text = "Логарифмическая";
            this.Log_b.UseVisualStyleBackColor = true;
            this.Log_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Hyperbola_b
            // 
            this.Hyperbola_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hyperbola_b.Location = new System.Drawing.Point(320, 124);
            this.Hyperbola_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hyperbola_b.Name = "Hyperbola_b";
            this.Hyperbola_b.Size = new System.Drawing.Size(311, 39);
            this.Hyperbola_b.TabIndex = 9;
            this.Hyperbola_b.Text = "Гиперболическая";
            this.Hyperbola_b.UseVisualStyleBackColor = true;
            this.Hyperbola_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Degree_b
            // 
            this.Degree_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degree_b.Location = new System.Drawing.Point(6, 77);
            this.Degree_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Degree_b.Name = "Degree_b";
            this.Degree_b.Size = new System.Drawing.Size(308, 39);
            this.Degree_b.TabIndex = 10;
            this.Degree_b.Text = "Степенная";
            this.Degree_b.UseVisualStyleBackColor = true;
            this.Degree_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Cube_b
            // 
            this.Cube_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cube_b.Location = new System.Drawing.Point(6, 124);
            this.Cube_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cube_b.Name = "Cube_b";
            this.Cube_b.Size = new System.Drawing.Size(308, 39);
            this.Cube_b.TabIndex = 11;
            this.Cube_b.Text = "Кубическая";
            this.Cube_b.UseVisualStyleBackColor = true;
            this.Cube_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Square_b
            // 
            this.Square_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Square_b.Location = new System.Drawing.Point(6, 171);
            this.Square_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Square_b.Name = "Square_b";
            this.Square_b.Size = new System.Drawing.Size(308, 39);
            this.Square_b.TabIndex = 12;
            this.Square_b.Text = "Квадратичная";
            this.Square_b.UseVisualStyleBackColor = true;
            this.Square_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // Exp_b
            // 
            this.Exp_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exp_b.Location = new System.Drawing.Point(320, 171);
            this.Exp_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exp_b.Name = "Exp_b";
            this.Exp_b.Size = new System.Drawing.Size(311, 39);
            this.Exp_b.TabIndex = 13;
            this.Exp_b.Text = "Экспоненциальное";
            this.Exp_b.UseVisualStyleBackColor = true;
            this.Exp_b.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Значения:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Выбрать значения",
            "Выбрать функцию",
            "Посмотреть результат"});
            this.checkedListBox1.Location = new System.Drawing.Point(458, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(217, 67);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Indicative_b);
            this.groupBox1.Controls.Add(this.Line_b);
            this.groupBox1.Controls.Add(this.Degree_b);
            this.groupBox1.Controls.Add(this.Cube_b);
            this.groupBox1.Controls.Add(this.Log_b);
            this.groupBox1.Controls.Add(this.Hyperbola_b);
            this.groupBox1.Controls.Add(this.Exp_b);
            this.groupBox1.Controls.Add(this.Square_b);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(38, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 232);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции";
            // 
            // sol
            // 
            this.sol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sol.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sol.Location = new System.Drawing.Point(686, 109);
            this.sol.Name = "sol";
            this.sol.ReadOnly = true;
            this.sol.Size = new System.Drawing.Size(482, 286);
            this.sol.TabIndex = 18;
            this.sol.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(681, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Решение:";
            // 
            // Y_tb
            // 
            this.Y_tb.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_tb.Location = new System.Drawing.Point(38, 122);
            this.Y_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y_tb.Name = "Y_tb";
            this.Y_tb.Size = new System.Drawing.Size(414, 29);
            this.Y_tb.TabIndex = 3;
            this.Y_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Y_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_tb_KeyPress);
            // 
            // X_tb
            // 
            this.X_tb.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_tb.Location = new System.Drawing.Point(38, 78);
            this.X_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X_tb.Name = "X_tb";
            this.X_tb.Size = new System.Drawing.Size(414, 29);
            this.X_tb.TabIndex = 2;
            this.X_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_tb_KeyPress);
            // 
            // Check_b
            // 
            this.Check_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Check_b.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Check_b.FlatAppearance.BorderSize = 0;
            this.Check_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_b.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_b.Location = new System.Drawing.Point(971, 74);
            this.Check_b.Name = "Check_b";
            this.Check_b.Size = new System.Drawing.Size(197, 32);
            this.Check_b.TabIndex = 20;
            this.Check_b.Text = "Просмотрено";
            this.Check_b.UseVisualStyleBackColor = true;
            this.Check_b.Click += new System.EventHandler(this.Check_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 798);
            this.Controls.Add(this.Check_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_tb);
            this.Controls.Add(this.X_tb);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ИУиМВС регрессионный анализ";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спарвкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Line_b;
        private System.Windows.Forms.Button Indicative_b;
        private System.Windows.Forms.Button Log_b;
        private System.Windows.Forms.Button Hyperbola_b;
        private System.Windows.Forms.Button Degree_b;
        private System.Windows.Forms.Button Cube_b;
        private System.Windows.Forms.Button Square_b;
        private System.Windows.Forms.Button Exp_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox sol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y_tb;
        private System.Windows.Forms.TextBox X_tb;
        private System.Windows.Forms.Button Check_b;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

