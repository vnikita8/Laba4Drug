﻿
namespace Laba4Drug
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UpToDown = new System.Windows.Forms.RadioButton();
            this.DownToUp = new System.Windows.Forms.RadioButton();
            this.shakeTime = new System.Windows.Forms.Label();
            this.insertTime = new System.Windows.Forms.Label();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.GenerateArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogoBox = new System.Windows.Forms.CheckBox();
            this.quickBox = new System.Windows.Forms.CheckBox();
            this.shakeBox = new System.Windows.Forms.CheckBox();
            this.insertBox = new System.Windows.Forms.CheckBox();
            this.bubbleBox = new System.Windows.Forms.CheckBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quickTime = new System.Windows.Forms.Label();
            this.bogoTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpToDown
            // 
            this.UpToDown.AutoSize = true;
            this.UpToDown.Location = new System.Drawing.Point(614, 364);
            this.UpToDown.Name = "UpToDown";
            this.UpToDown.Size = new System.Drawing.Size(93, 17);
            this.UpToDown.TabIndex = 56;
            this.UpToDown.Text = "По убыванию";
            this.UpToDown.UseVisualStyleBackColor = true;
            // 
            // DownToUp
            // 
            this.DownToUp.AutoSize = true;
            this.DownToUp.Checked = true;
            this.DownToUp.Location = new System.Drawing.Point(499, 364);
            this.DownToUp.Name = "DownToUp";
            this.DownToUp.Size = new System.Drawing.Size(109, 17);
            this.DownToUp.TabIndex = 55;
            this.DownToUp.TabStop = true;
            this.DownToUp.Text = "По возрастанию";
            this.DownToUp.UseVisualStyleBackColor = true;
            // 
            // shakeTime
            // 
            this.shakeTime.AutoSize = true;
            this.shakeTime.Location = new System.Drawing.Point(747, 219);
            this.shakeTime.Name = "shakeTime";
            this.shakeTime.Size = new System.Drawing.Size(19, 13);
            this.shakeTime.TabIndex = 54;
            this.shakeTime.Text = "00";
            // 
            // insertTime
            // 
            this.insertTime.AutoSize = true;
            this.insertTime.Location = new System.Drawing.Point(509, 218);
            this.insertTime.Name = "insertTime";
            this.insertTime.Size = new System.Drawing.Size(19, 13);
            this.insertTime.TabIndex = 53;
            this.insertTime.Text = "00";
            // 
            // bubbleTime
            // 
            this.bubbleTime.AutoSize = true;
            this.bubbleTime.Location = new System.Drawing.Point(245, 218);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(19, 13);
            this.bubbleTime.TabIndex = 52;
            this.bubbleTime.Text = "00";
            // 
            // GenerateArray
            // 
            this.GenerateArray.Location = new System.Drawing.Point(50, 84);
            this.GenerateArray.Name = "GenerateArray";
            this.GenerateArray.Size = new System.Drawing.Size(144, 23);
            this.GenerateArray.TabIndex = 51;
            this.GenerateArray.Text = "Сгенерировать";
            this.GenerateArray.UseVisualStyleBackColor = true;
            this.GenerateArray.Click += new System.EventHandler(this.GenerateArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Введите колличество элементов массива";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(50, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(144, 326);
            this.dataGridView1.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Массив";
            this.Column1.Name = "Column1";
            // 
            // bogoBox
            // 
            this.bogoBox.AutoSize = true;
            this.bogoBox.Location = new System.Drawing.Point(805, 266);
            this.bogoBox.Name = "bogoBox";
            this.bogoBox.Size = new System.Drawing.Size(57, 17);
            this.bogoBox.TabIndex = 47;
            this.bogoBox.Text = "BOGO";
            this.bogoBox.UseVisualStyleBackColor = true;
            // 
            // quickBox
            // 
            this.quickBox.AutoSize = true;
            this.quickBox.Location = new System.Drawing.Point(323, 266);
            this.quickBox.Name = "quickBox";
            this.quickBox.Size = new System.Drawing.Size(132, 17);
            this.quickBox.TabIndex = 46;
            this.quickBox.Text = "Быстрая сортировка";
            this.quickBox.UseVisualStyleBackColor = true;
            // 
            // shakeBox
            // 
            this.shakeBox.AutoSize = true;
            this.shakeBox.Location = new System.Drawing.Point(805, 217);
            this.shakeBox.Name = "shakeBox";
            this.shakeBox.Size = new System.Drawing.Size(145, 17);
            this.shakeBox.TabIndex = 45;
            this.shakeBox.Text = "Шейкерная сортировка";
            this.shakeBox.UseVisualStyleBackColor = true;
            // 
            // insertBox
            // 
            this.insertBox.AutoSize = true;
            this.insertBox.Location = new System.Drawing.Point(563, 217);
            this.insertBox.Name = "insertBox";
            this.insertBox.Size = new System.Drawing.Size(144, 17);
            this.insertBox.TabIndex = 44;
            this.insertBox.Text = "Сортировка вставками";
            this.insertBox.UseVisualStyleBackColor = true;
            // 
            // bubbleBox
            // 
            this.bubbleBox.AutoSize = true;
            this.bubbleBox.Location = new System.Drawing.Point(323, 217);
            this.bubbleBox.Name = "bubbleBox";
            this.bubbleBox.Size = new System.Drawing.Size(157, 17);
            this.bubbleBox.TabIndex = 43;
            this.bubbleBox.Text = "Пузырьковая сортировка";
            this.bubbleBox.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(486, 433);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(245, 38);
            this.StopButton.TabIndex = 42;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(486, 387);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(245, 40);
            this.StartButton.TabIndex = 41;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // chart1
            // 
            chartArea21.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chart1.Legends.Add(legend21);
            this.chart1.Location = new System.Drawing.Point(235, 30);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart1.Series.Add(series21);
            this.chart1.Size = new System.Drawing.Size(245, 182);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea22.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.chart2.Legends.Add(legend22);
            this.chart2.Location = new System.Drawing.Point(486, 30);
            this.chart2.Name = "chart2";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Series1";
            this.chart2.Series.Add(series22);
            this.chart2.Size = new System.Drawing.Size(245, 182);
            this.chart2.TabIndex = 58;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea23.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.chart3.Legends.Add(legend23);
            this.chart3.Location = new System.Drawing.Point(737, 30);
            this.chart3.Name = "chart3";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Series1";
            this.chart3.Series.Add(series23);
            this.chart3.Size = new System.Drawing.Size(245, 182);
            this.chart3.TabIndex = 59;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea24.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.chart4.Legends.Add(legend24);
            this.chart4.Location = new System.Drawing.Point(737, 289);
            this.chart4.Name = "chart4";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Series1";
            this.chart4.Series.Add(series24);
            this.chart4.Size = new System.Drawing.Size(245, 182);
            this.chart4.TabIndex = 60;
            this.chart4.Text = "chart4";
            // 
            // chart5
            // 
            chartArea25.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea25);
            legend25.Name = "Legend1";
            this.chart5.Legends.Add(legend25);
            this.chart5.Location = new System.Drawing.Point(235, 289);
            this.chart5.Name = "chart5";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Series1";
            this.chart5.Series.Add(series25);
            this.chart5.Size = new System.Drawing.Size(245, 182);
            this.chart5.TabIndex = 61;
            this.chart5.Text = "chart5";
            // 
            // quickTime
            // 
            this.quickTime.AutoSize = true;
            this.quickTime.Location = new System.Drawing.Point(245, 267);
            this.quickTime.Name = "quickTime";
            this.quickTime.Size = new System.Drawing.Size(19, 13);
            this.quickTime.TabIndex = 62;
            this.quickTime.Text = "00";
            // 
            // bogoTime
            // 
            this.bogoTime.AutoSize = true;
            this.bogoTime.Location = new System.Drawing.Point(747, 270);
            this.bogoTime.Name = "bogoTime";
            this.bogoTime.Size = new System.Drawing.Size(19, 13);
            this.bogoTime.TabIndex = 63;
            this.bogoTime.Text = "00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.googleToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bogoTime);
            this.Controls.Add(this.quickTime);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.UpToDown);
            this.Controls.Add(this.DownToUp);
            this.Controls.Add(this.shakeTime);
            this.Controls.Add(this.insertTime);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.GenerateArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bogoBox);
            this.Controls.Add(this.quickBox);
            this.Controls.Add(this.shakeBox);
            this.Controls.Add(this.insertBox);
            this.Controls.Add(this.bubbleBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton UpToDown;
        private System.Windows.Forms.RadioButton DownToUp;
        private System.Windows.Forms.Label shakeTime;
        private System.Windows.Forms.Label insertTime;
        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.Button GenerateArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox bogoBox;
        private System.Windows.Forms.CheckBox quickBox;
        private System.Windows.Forms.CheckBox shakeBox;
        private System.Windows.Forms.CheckBox insertBox;
        private System.Windows.Forms.CheckBox bubbleBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Label quickTime;
        private System.Windows.Forms.Label bogoTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

