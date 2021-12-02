
namespace Demographic.WinForms
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
            this.total_population = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_bttn = new System.Windows.Forms.Button();
            this.genders_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.male_composition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.female_composition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_year = new System.Windows.Forms.TextBox();
            this.start_population = new System.Windows.Forms.TextBox();
            this.end_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.init_ages_dialog = new System.Windows.Forms.OpenFileDialog();
            this.death_rules_dialog = new System.Windows.Forms.OpenFileDialog();
            this.init_ages_btn = new System.Windows.Forms.Button();
            this.death_rules_btn = new System.Windows.Forms.Button();
            this.initial_ages_label = new System.Windows.Forms.Label();
            this.death_rules_label = new System.Windows.Forms.Label();
            this.initial_age_textbox = new System.Windows.Forms.TextBox();
            this.death_rules_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.total_population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genders_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.male_composition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.female_composition)).BeginInit();
            this.SuspendLayout();
            // 
            // total_population
            // 
            chartArea1.Name = "ChartArea1";
            this.total_population.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.total_population.Legends.Add(legend1);
            this.total_population.Location = new System.Drawing.Point(26, 12);
            this.total_population.Name = "total_population";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.total_population.Series.Add(series1);
            this.total_population.Size = new System.Drawing.Size(707, 231);
            this.total_population.TabIndex = 0;
            this.total_population.Text = "chart1";
            // 
            // start_bttn
            // 
            this.start_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_bttn.Location = new System.Drawing.Point(745, 592);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(247, 121);
            this.start_bttn.TabIndex = 1;
            this.start_bttn.Text = "START";
            this.start_bttn.UseVisualStyleBackColor = true;
            this.start_bttn.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // genders_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.genders_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.genders_chart.Legends.Add(legend2);
            this.genders_chart.Location = new System.Drawing.Point(26, 249);
            this.genders_chart.Name = "genders_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.genders_chart.Series.Add(series2);
            this.genders_chart.Size = new System.Drawing.Size(707, 207);
            this.genders_chart.TabIndex = 2;
            this.genders_chart.Text = "chart1";
            // 
            // male_composition
            // 
            chartArea3.Name = "ChartArea1";
            this.male_composition.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.male_composition.Legends.Add(legend3);
            this.male_composition.Location = new System.Drawing.Point(26, 462);
            this.male_composition.Name = "male_composition";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.male_composition.Series.Add(series3);
            this.male_composition.Size = new System.Drawing.Size(343, 300);
            this.male_composition.TabIndex = 3;
            this.male_composition.Text = "chart1";
            // 
            // female_composition
            // 
            chartArea4.Name = "ChartArea1";
            this.female_composition.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.female_composition.Legends.Add(legend4);
            this.female_composition.Location = new System.Drawing.Point(390, 462);
            this.female_composition.Name = "female_composition";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.female_composition.Series.Add(series4);
            this.female_composition.Size = new System.Drawing.Size(343, 300);
            this.female_composition.TabIndex = 4;
            this.female_composition.Text = "chart1";
            // 
            // start_year
            // 
            this.start_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_year.Location = new System.Drawing.Point(861, 60);
            this.start_year.Name = "start_year";
            this.start_year.Size = new System.Drawing.Size(111, 31);
            this.start_year.TabIndex = 5;
            this.start_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_population
            // 
            this.start_population.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_population.Location = new System.Drawing.Point(751, 224);
            this.start_population.Name = "start_population";
            this.start_population.Size = new System.Drawing.Size(221, 31);
            this.start_population.TabIndex = 7;
            this.start_population.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // end_year
            // 
            this.end_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_year.Location = new System.Drawing.Point(861, 114);
            this.end_year.Name = "end_year";
            this.end_year.Size = new System.Drawing.Size(111, 31);
            this.end_year.TabIndex = 6;
            this.end_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(746, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(776, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Population";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(753, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Year";
            // 
            // init_ages_dialog
            // 
            this.init_ages_dialog.FileName = "openFileDialog1";
            // 
            // death_rules_dialog
            // 
            this.death_rules_dialog.FileName = "openFileDialog1";
            // 
            // init_ages_btn
            // 
            this.init_ages_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.init_ages_btn.Location = new System.Drawing.Point(923, 333);
            this.init_ages_btn.Name = "init_ages_btn";
            this.init_ages_btn.Size = new System.Drawing.Size(75, 31);
            this.init_ages_btn.TabIndex = 9;
            this.init_ages_btn.Text = "Select";
            this.init_ages_btn.UseVisualStyleBackColor = true;
            this.init_ages_btn.Click += new System.EventHandler(this.init_ages_btn_Click);
            // 
            // death_rules_btn
            // 
            this.death_rules_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.death_rules_btn.Location = new System.Drawing.Point(923, 439);
            this.death_rules_btn.Name = "death_rules_btn";
            this.death_rules_btn.Size = new System.Drawing.Size(75, 31);
            this.death_rules_btn.TabIndex = 10;
            this.death_rules_btn.Text = "Select";
            this.death_rules_btn.UseVisualStyleBackColor = true;
            this.death_rules_btn.Click += new System.EventHandler(this.death_rules_btn_Click);
            // 
            // initial_ages_label
            // 
            this.initial_ages_label.AutoSize = true;
            this.initial_ages_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initial_ages_label.Location = new System.Drawing.Point(811, 294);
            this.initial_ages_label.Name = "initial_ages_label";
            this.initial_ages_label.Size = new System.Drawing.Size(106, 25);
            this.initial_ages_label.TabIndex = 12;
            this.initial_ages_label.Text = "Initial Age";
            // 
            // death_rules_label
            // 
            this.death_rules_label.AutoSize = true;
            this.death_rules_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.death_rules_label.Location = new System.Drawing.Point(811, 398);
            this.death_rules_label.Name = "death_rules_label";
            this.death_rules_label.Size = new System.Drawing.Size(130, 25);
            this.death_rules_label.TabIndex = 13;
            this.death_rules_label.Text = "Death Rules";
            // 
            // initial_age_textbox
            // 
            this.initial_age_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initial_age_textbox.Location = new System.Drawing.Point(751, 333);
            this.initial_age_textbox.Name = "initial_age_textbox";
            this.initial_age_textbox.ReadOnly = true;
            this.initial_age_textbox.Size = new System.Drawing.Size(166, 31);
            this.initial_age_textbox.TabIndex = 14;
            // 
            // death_rules_textbox
            // 
            this.death_rules_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.death_rules_textbox.Location = new System.Drawing.Point(751, 439);
            this.death_rules_textbox.Name = "death_rules_textbox";
            this.death_rules_textbox.ReadOnly = true;
            this.death_rules_textbox.Size = new System.Drawing.Size(166, 31);
            this.death_rules_textbox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 778);
            this.Controls.Add(this.death_rules_textbox);
            this.Controls.Add(this.initial_age_textbox);
            this.Controls.Add(this.death_rules_label);
            this.Controls.Add(this.initial_ages_label);
            this.Controls.Add(this.death_rules_btn);
            this.Controls.Add(this.init_ages_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_year);
            this.Controls.Add(this.end_year);
            this.Controls.Add(this.start_population);
            this.Controls.Add(this.female_composition);
            this.Controls.Add(this.male_composition);
            this.Controls.Add(this.genders_chart);
            this.Controls.Add(this.start_bttn);
            this.Controls.Add(this.total_population);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.total_population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genders_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.male_composition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.female_composition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart total_population;
        private System.Windows.Forms.Button start_bttn;
        private System.Windows.Forms.DataVisualization.Charting.Chart genders_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart male_composition;
        private System.Windows.Forms.DataVisualization.Charting.Chart female_composition;
        private System.Windows.Forms.TextBox start_year;
        private System.Windows.Forms.TextBox start_population;
        private System.Windows.Forms.TextBox end_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog init_ages_dialog;
        private System.Windows.Forms.OpenFileDialog death_rules_dialog;
        private System.Windows.Forms.Button init_ages_btn;
        private System.Windows.Forms.Button death_rules_btn;
        private System.Windows.Forms.Label initial_ages_label;
        private System.Windows.Forms.Label death_rules_label;
        private System.Windows.Forms.TextBox initial_age_textbox;
        private System.Windows.Forms.TextBox death_rules_textbox;
    }
}

