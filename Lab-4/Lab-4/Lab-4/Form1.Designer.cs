
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.file_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.sepal_lenght = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_lenght = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_lenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_lenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // file_btn
            // 
            this.file_btn.Location = new System.Drawing.Point(1049, 74);
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
            this.label1.Location = new System.Drawing.Point(1046, 12);
            this.label1.MinimumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sepal_lenght
            // 
            chartArea1.Name = "ChartArea1";
            this.sepal_lenght.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sepal_lenght.Legends.Add(legend1);
            this.sepal_lenght.Location = new System.Drawing.Point(12, 12);
            this.sepal_lenght.Name = "sepal_lenght";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.sepal_lenght.Series.Add(series1);
            this.sepal_lenght.Size = new System.Drawing.Size(315, 266);
            this.sepal_lenght.TabIndex = 2;
            this.sepal_lenght.Text = "chart1";
            // 
            // sepal_width
            // 
            chartArea2.Name = "ChartArea1";
            this.sepal_width.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.sepal_width.Legends.Add(legend2);
            this.sepal_width.Location = new System.Drawing.Point(352, 12);
            this.sepal_width.Name = "sepal_width";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.sepal_width.Series.Add(series2);
            this.sepal_width.Size = new System.Drawing.Size(315, 266);
            this.sepal_width.TabIndex = 3;
            this.sepal_width.Text = "chart1";
            // 
            // petal_lenght
            // 
            chartArea3.Name = "ChartArea1";
            this.petal_lenght.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.petal_lenght.Legends.Add(legend3);
            this.petal_lenght.Location = new System.Drawing.Point(12, 308);
            this.petal_lenght.Name = "petal_lenght";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.petal_lenght.Series.Add(series3);
            this.petal_lenght.Size = new System.Drawing.Size(315, 266);
            this.petal_lenght.TabIndex = 4;
            this.petal_lenght.Text = "chart1";
            // 
            // petal_width
            // 
            chartArea4.Name = "ChartArea1";
            this.petal_width.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.petal_width.Legends.Add(legend4);
            this.petal_width.Location = new System.Drawing.Point(352, 308);
            this.petal_width.Name = "petal_width";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.petal_width.Series.Add(series4);
            this.petal_width.Size = new System.Drawing.Size(315, 266);
            this.petal_width.TabIndex = 5;
            this.petal_width.Text = "chart1";
            // 
            // chart_pie
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_pie.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_pie.Legends.Add(legend5);
            this.chart_pie.Location = new System.Drawing.Point(690, 12);
            this.chart_pie.Name = "chart_pie";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_pie.Series.Add(series5);
            this.chart_pie.Size = new System.Drawing.Size(315, 266);
            this.chart_pie.TabIndex = 6;
            this.chart_pie.Text = "chart1";
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(1049, 181);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(108, 49);
            this.show_btn.TabIndex = 7;
            this.show_btn.Text = "Показать";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 806);
            this.Controls.Add(this.show_btn);
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
        private System.Windows.Forms.Button show_btn;
    }
}

