namespace Обнаружение_гармонического_сигнала_м.а
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_f3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_f2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_f1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_n2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_n1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_energy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_points = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_error = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_n2 = new System.Windows.Forms.TextBox();
            this.textBox_n1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_energy)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_points)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_error)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_f3);
            this.groupBox1.Controls.Add(this.numericUpDown_f2);
            this.groupBox1.Controls.Add(this.numericUpDown_f1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор частот";
            // 
            // numericUpDown_f3
            // 
            this.numericUpDown_f3.DecimalPlaces = 2;
            this.numericUpDown_f3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_f3.Location = new System.Drawing.Point(103, 89);
            this.numericUpDown_f3.Name = "numericUpDown_f3";
            this.numericUpDown_f3.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown_f3.TabIndex = 5;
            this.numericUpDown_f3.ThousandsSeparator = true;
            this.numericUpDown_f3.Value = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            // 
            // numericUpDown_f2
            // 
            this.numericUpDown_f2.DecimalPlaces = 2;
            this.numericUpDown_f2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_f2.Location = new System.Drawing.Point(103, 56);
            this.numericUpDown_f2.Name = "numericUpDown_f2";
            this.numericUpDown_f2.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown_f2.TabIndex = 4;
            this.numericUpDown_f2.ThousandsSeparator = true;
            this.numericUpDown_f2.Value = new decimal(new int[] {
            6,
            0,
            0,
            131072});
            // 
            // numericUpDown_f1
            // 
            this.numericUpDown_f1.DecimalPlaces = 2;
            this.numericUpDown_f1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_f1.Location = new System.Drawing.Point(103, 22);
            this.numericUpDown_f1.Name = "numericUpDown_f1";
            this.numericUpDown_f1.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown_f1.TabIndex = 3;
            this.numericUpDown_f1.ThousandsSeparator = true;
            this.numericUpDown_f1.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "f3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "f2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "f1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_n2);
            this.groupBox2.Controls.Add(this.numericUpDown_n1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Интервал сигнала";
            // 
            // numericUpDown_n2
            // 
            this.numericUpDown_n2.Location = new System.Drawing.Point(103, 55);
            this.numericUpDown_n2.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_n2.Name = "numericUpDown_n2";
            this.numericUpDown_n2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_n2.TabIndex = 5;
            this.numericUpDown_n2.Value = new decimal(new int[] {
            850,
            0,
            0,
            0});
            // 
            // numericUpDown_n1
            // 
            this.numericUpDown_n1.Location = new System.Drawing.Point(103, 21);
            this.numericUpDown_n1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_n1.Name = "numericUpDown_n1";
            this.numericUpDown_n1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_n1.TabIndex = 4;
            this.numericUpDown_n1.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "n2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "n1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_energy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры шума";
            // 
            // numericUpDown_energy
            // 
            this.numericUpDown_energy.DecimalPlaces = 2;
            this.numericUpDown_energy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_energy.Location = new System.Drawing.Point(103, 69);
            this.numericUpDown_energy.Name = "numericUpDown_energy";
            this.numericUpDown_energy.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_energy.TabIndex = 2;
            this.numericUpDown_energy.ThousandsSeparator = true;
            this.numericUpDown_energy.Value = new decimal(new int[] {
            2000,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Энергия(%)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Сгенерировать шум";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown_points);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры сглаживания";
            // 
            // numericUpDown_points
            // 
            this.numericUpDown_points.Location = new System.Drawing.Point(103, 31);
            this.numericUpDown_points.Name = "numericUpDown_points";
            this.numericUpDown_points.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_points.TabIndex = 1;
            this.numericUpDown_points.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Точки";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown_error);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 409);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Допустимый уровень ошибки";
            // 
            // numericUpDown_error
            // 
            this.numericUpDown_error.DecimalPlaces = 5;
            this.numericUpDown_error.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDown_error.Location = new System.Drawing.Point(103, 35);
            this.numericUpDown_error.Name = "numericUpDown_error";
            this.numericUpDown_error.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_error.TabIndex = 1;
            this.numericUpDown_error.ThousandsSeparator = true;
            this.numericUpDown_error.Value = new decimal(new int[] {
            500,
            0,
            0,
            327680});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "E";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_n2);
            this.groupBox6.Controls.Add(this.textBox_n1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(12, 478);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(233, 90);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Найденный интервал";
            // 
            // textBox_n2
            // 
            this.textBox_n2.Enabled = false;
            this.textBox_n2.Location = new System.Drawing.Point(103, 55);
            this.textBox_n2.Name = "textBox_n2";
            this.textBox_n2.Size = new System.Drawing.Size(120, 22);
            this.textBox_n2.TabIndex = 3;
            // 
            // textBox_n1
            // 
            this.textBox_n1.Enabled = false;
            this.textBox_n1.Location = new System.Drawing.Point(103, 21);
            this.textBox_n1.Name = "textBox_n1";
            this.textBox_n1.Size = new System.Drawing.Size(120, 22);
            this.textBox_n1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "n2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "n1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(251, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = " ";
            series1.LegendToolTip = "Исходный сигнал";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1135, 323);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title1.Name = "Сигнал";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(251, 341);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = " ";
            series2.LegendToolTip = "График отклонения";
            series2.Name = "Serise2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = " ";
            series3.LegendToolTip = "Порог ошибки";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = " ";
            series4.LegendToolTip = "Сглаженный график отклонения";
            series4.Name = "Series0";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(1135, 305);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 658);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Обнаружение сигнала с заданной частотой при помощи авторегрессионной модели";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_energy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_points)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_error)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.NumericUpDown numericUpDown_n2;
        private System.Windows.Forms.NumericUpDown numericUpDown_n1;
        private System.Windows.Forms.NumericUpDown numericUpDown_f3;
        private System.Windows.Forms.NumericUpDown numericUpDown_f2;
        private System.Windows.Forms.NumericUpDown numericUpDown_f1;
        private System.Windows.Forms.NumericUpDown numericUpDown_energy;
        private System.Windows.Forms.NumericUpDown numericUpDown_points;
        private System.Windows.Forms.NumericUpDown numericUpDown_error;
        private System.Windows.Forms.TextBox textBox_n1;
        private System.Windows.Forms.TextBox textBox_n2;
    }
}

