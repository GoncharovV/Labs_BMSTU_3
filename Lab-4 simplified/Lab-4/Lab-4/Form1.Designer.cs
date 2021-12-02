
namespace Lab_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.file_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.sepal_lenght = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_lenght = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_lenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_lenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // file_btn
            // 
            this.file_btn.Location = new System.Drawing.Point(856, 372);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(108, 64);
            this.file_btn.TabIndex = 0;
            this.file_btn.Text = "Показать";
            this.file_btn.UseVisualStyleBackColor = true;
            this.file_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 398);
            this.label1.MinimumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sepal_lenght
            // 
            chartArea11.Name = "ChartArea1";
            this.sepal_lenght.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.sepal_lenght.Legends.Add(legend11);
            this.sepal_lenght.Location = new System.Drawing.Point(39, 12);
            this.sepal_lenght.Name = "sepal_lenght";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.sepal_lenght.Series.Add(series11);
            this.sepal_lenght.Size = new System.Drawing.Size(291, 218);
            this.sepal_lenght.TabIndex = 2;
            this.sepal_lenght.Text = "chart1";
            // 
            // sepal_width
            // 
            chartArea12.Name = "ChartArea1";
            this.sepal_width.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.sepal_width.Legends.Add(legend12);
            this.sepal_width.Location = new System.Drawing.Point(375, 12);
            this.sepal_width.Name = "sepal_width";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.sepal_width.Series.Add(series12);
            this.sepal_width.Size = new System.Drawing.Size(324, 274);
            this.sepal_width.TabIndex = 3;
            this.sepal_width.Text = "chart1";
            this.sepal_width.Click += new System.EventHandler(this.sepal_width_Click);
            // 
            // petal_lenght
            // 
            chartArea13.Name = "ChartArea1";
            this.petal_lenght.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.petal_lenght.Legends.Add(legend13);
            this.petal_lenght.Location = new System.Drawing.Point(104, 412);
            this.petal_lenght.Name = "petal_lenght";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.petal_lenght.Series.Add(series13);
            this.petal_lenght.Size = new System.Drawing.Size(287, 260);
            this.petal_lenght.TabIndex = 4;
            this.petal_lenght.Text = "chart1";
            // 
            // petal_width
            // 
            chartArea14.Name = "ChartArea1";
            this.petal_width.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.petal_width.Legends.Add(legend14);
            this.petal_width.Location = new System.Drawing.Point(593, 451);
            this.petal_width.Name = "petal_width";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.petal_width.Series.Add(series14);
            this.petal_width.Size = new System.Drawing.Size(259, 296);
            this.petal_width.TabIndex = 5;
            this.petal_width.Text = "chart1";
            // 
            // chart_pie
            // 
            chartArea15.Name = "ChartArea1";
            this.chart_pie.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart_pie.Legends.Add(legend15);
            this.chart_pie.Location = new System.Drawing.Point(797, 40);
            this.chart_pie.Name = "chart_pie";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart_pie.Series.Add(series15);
            this.chart_pie.Size = new System.Drawing.Size(256, 225);
            this.chart_pie.TabIndex = 6;
            this.chart_pie.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 806);
            this.Controls.Add(this.chart_pie);
            this.Controls.Add(this.petal_width);
            this.Controls.Add(this.petal_lenght);
            this.Controls.Add(this.sepal_width);
            this.Controls.Add(this.sepal_lenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sepal_lenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_lenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepal_lenght;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart petal_lenght;
        private System.Windows.Forms.DataVisualization.Charting.Chart petal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pie;
    }
}

