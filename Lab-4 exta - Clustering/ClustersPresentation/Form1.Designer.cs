
namespace ClustersPresentation
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
            this.view_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // view_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.view_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.view_chart.Legends.Add(legend1);
            this.view_chart.Location = new System.Drawing.Point(88, 51);
            this.view_chart.Name = "view_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.view_chart.Series.Add(series1);
            this.view_chart.Size = new System.Drawing.Size(781, 502);
            this.view_chart.TabIndex = 0;
            this.view_chart.Text = "chart1";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(794, 578);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 65);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Нажми потом";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Нажми сначала";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.view_chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.view_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart view_chart;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button button1;
    }
}

