
namespace Doctors
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
            this.doctorsGrid = new System.Windows.Forms.DataGridView();
            this.certificatesGrid = new System.Windows.Forms.DataGridView();
            this.specializationGrid = new System.Windows.Forms.DataGridView();
            this.loadDoctors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCertificates = new System.Windows.Forms.Button();
            this.specializationLoad = new System.Windows.Forms.Button();
            this.doctorIdTb = new System.Windows.Forms.TextBox();
            this.doctorNameTb = new System.Windows.Forms.TextBox();
            this.doctorSpecId = new System.Windows.Forms.TextBox();
            this.cerIdTb = new System.Windows.Forms.TextBox();
            this.cerDoctorTb = new System.Windows.Forms.TextBox();
            this.specIdTb = new System.Windows.Forms.TextBox();
            this.specNameTb = new System.Windows.Forms.TextBox();
            this.cerDescTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createDoctorBtn = new System.Windows.Forms.Button();
            this.changeDoctor = new System.Windows.Forms.Button();
            this.deleteDoctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createSpes = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.createCer = new System.Windows.Forms.Button();
            this.changeCer = new System.Windows.Forms.Button();
            this.deleteCer = new System.Windows.Forms.Button();
            this.changeSpec = new System.Windows.Forms.Button();
            this.deleteSpec = new System.Windows.Forms.Button();
            this.countDoctorsTb = new System.Windows.Forms.TextBox();
            this.countDoctors = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.doctorsCountLabel = new System.Windows.Forms.Label();
            this.findSpecTb = new System.Windows.Forms.TextBox();
            this.findSpec = new System.Windows.Forms.Button();
            this.findSpecLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cerDateTb = new System.Windows.Forms.TextBox();
            this.cerDate = new System.Windows.Forms.Button();
            this.cerDateLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorsGrid
            // 
            this.doctorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsGrid.Location = new System.Drawing.Point(14, 49);
            this.doctorsGrid.Name = "doctorsGrid";
            this.doctorsGrid.RowTemplate.Height = 25;
            this.doctorsGrid.Size = new System.Drawing.Size(374, 207);
            this.doctorsGrid.TabIndex = 0;
            // 
            // certificatesGrid
            // 
            this.certificatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certificatesGrid.Location = new System.Drawing.Point(394, 49);
            this.certificatesGrid.Name = "certificatesGrid";
            this.certificatesGrid.RowTemplate.Height = 25;
            this.certificatesGrid.Size = new System.Drawing.Size(374, 207);
            this.certificatesGrid.TabIndex = 1;
            // 
            // specializationGrid
            // 
            this.specializationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specializationGrid.Location = new System.Drawing.Point(774, 49);
            this.specializationGrid.Name = "specializationGrid";
            this.specializationGrid.RowTemplate.Height = 25;
            this.specializationGrid.Size = new System.Drawing.Size(374, 207);
            this.specializationGrid.TabIndex = 2;
            // 
            // loadDoctors
            // 
            this.loadDoctors.Location = new System.Drawing.Point(14, 262);
            this.loadDoctors.Name = "loadDoctors";
            this.loadDoctors.Size = new System.Drawing.Size(374, 23);
            this.loadDoctors.TabIndex = 3;
            this.loadDoctors.Text = "Загрузить";
            this.loadDoctors.UseVisualStyleBackColor = true;
            this.loadDoctors.Click += new System.EventHandler(this.loadDoctors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Доктора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сертификаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Специальности";
            // 
            // loadCertificates
            // 
            this.loadCertificates.Location = new System.Drawing.Point(394, 262);
            this.loadCertificates.Name = "loadCertificates";
            this.loadCertificates.Size = new System.Drawing.Size(374, 23);
            this.loadCertificates.TabIndex = 7;
            this.loadCertificates.Text = "Загрузить";
            this.loadCertificates.UseVisualStyleBackColor = true;
            this.loadCertificates.Click += new System.EventHandler(this.loadCertificates_Click);
            // 
            // specializationLoad
            // 
            this.specializationLoad.Location = new System.Drawing.Point(774, 262);
            this.specializationLoad.Name = "specializationLoad";
            this.specializationLoad.Size = new System.Drawing.Size(374, 23);
            this.specializationLoad.TabIndex = 8;
            this.specializationLoad.Text = "Загрузить";
            this.specializationLoad.UseVisualStyleBackColor = true;
            this.specializationLoad.Click += new System.EventHandler(this.specializationLoad_Click);
            // 
            // doctorIdTb
            // 
            this.doctorIdTb.Location = new System.Drawing.Point(42, 331);
            this.doctorIdTb.Name = "doctorIdTb";
            this.doctorIdTb.Size = new System.Drawing.Size(94, 23);
            this.doctorIdTb.TabIndex = 9;
            // 
            // doctorNameTb
            // 
            this.doctorNameTb.Location = new System.Drawing.Point(142, 331);
            this.doctorNameTb.Name = "doctorNameTb";
            this.doctorNameTb.Size = new System.Drawing.Size(94, 23);
            this.doctorNameTb.TabIndex = 10;
            // 
            // doctorSpecId
            // 
            this.doctorSpecId.Location = new System.Drawing.Point(245, 331);
            this.doctorSpecId.Name = "doctorSpecId";
            this.doctorSpecId.Size = new System.Drawing.Size(94, 23);
            this.doctorSpecId.TabIndex = 11;
            // 
            // cerIdTb
            // 
            this.cerIdTb.Location = new System.Drawing.Point(440, 331);
            this.cerIdTb.Name = "cerIdTb";
            this.cerIdTb.Size = new System.Drawing.Size(94, 23);
            this.cerIdTb.TabIndex = 12;
            // 
            // cerDoctorTb
            // 
            this.cerDoctorTb.Location = new System.Drawing.Point(540, 331);
            this.cerDoctorTb.Name = "cerDoctorTb";
            this.cerDoctorTb.Size = new System.Drawing.Size(94, 23);
            this.cerDoctorTb.TabIndex = 13;
            // 
            // specIdTb
            // 
            this.specIdTb.Location = new System.Drawing.Point(812, 331);
            this.specIdTb.Name = "specIdTb";
            this.specIdTb.Size = new System.Drawing.Size(94, 23);
            this.specIdTb.TabIndex = 14;
            // 
            // specNameTb
            // 
            this.specNameTb.Location = new System.Drawing.Point(923, 331);
            this.specNameTb.Name = "specNameTb";
            this.specNameTb.Size = new System.Drawing.Size(183, 23);
            this.specNameTb.TabIndex = 15;
            // 
            // cerDescTb
            // 
            this.cerDescTb.Location = new System.Drawing.Point(640, 331);
            this.cerDescTb.Name = "cerDescTb";
            this.cerDescTb.Size = new System.Drawing.Size(94, 23);
            this.cerDescTb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Специализация";
            // 
            // createDoctorBtn
            // 
            this.createDoctorBtn.Location = new System.Drawing.Point(41, 372);
            this.createDoctorBtn.Name = "createDoctorBtn";
            this.createDoctorBtn.Size = new System.Drawing.Size(297, 23);
            this.createDoctorBtn.TabIndex = 21;
            this.createDoctorBtn.Text = "Добавить";
            this.createDoctorBtn.UseVisualStyleBackColor = true;
            this.createDoctorBtn.Click += new System.EventHandler(this.createDoctorBtn_Click);
            // 
            // changeDoctor
            // 
            this.changeDoctor.Location = new System.Drawing.Point(41, 401);
            this.changeDoctor.Name = "changeDoctor";
            this.changeDoctor.Size = new System.Drawing.Size(297, 23);
            this.changeDoctor.TabIndex = 22;
            this.changeDoctor.Text = "Изменить";
            this.changeDoctor.UseVisualStyleBackColor = true;
            this.changeDoctor.Click += new System.EventHandler(this.changeDoctor_Click);
            // 
            // deleteDoctor
            // 
            this.deleteDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteDoctor.Location = new System.Drawing.Point(42, 430);
            this.deleteDoctor.Name = "deleteDoctor";
            this.deleteDoctor.Size = new System.Drawing.Size(297, 23);
            this.deleteDoctor.TabIndex = 23;
            this.deleteDoctor.Text = "Удалить";
            this.deleteDoctor.UseVisualStyleBackColor = true;
            this.deleteDoctor.Click += new System.EventHandler(this.deleteDoctor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(850, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(980, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Название";
            // 
            // createSpes
            // 
            this.createSpes.Location = new System.Drawing.Point(812, 372);
            this.createSpes.Name = "createSpes";
            this.createSpes.Size = new System.Drawing.Size(294, 23);
            this.createSpes.TabIndex = 26;
            this.createSpes.Text = "Добавить";
            this.createSpes.UseVisualStyleBackColor = true;
            this.createSpes.Click += new System.EventHandler(this.createSpes_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Доктор";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Описание";
            // 
            // createCer
            // 
            this.createCer.Location = new System.Drawing.Point(437, 372);
            this.createCer.Name = "createCer";
            this.createCer.Size = new System.Drawing.Size(297, 23);
            this.createCer.TabIndex = 30;
            this.createCer.Text = "Добавить";
            this.createCer.UseVisualStyleBackColor = true;
            this.createCer.Click += new System.EventHandler(this.createCer_Click);
            // 
            // changeCer
            // 
            this.changeCer.Location = new System.Drawing.Point(437, 401);
            this.changeCer.Name = "changeCer";
            this.changeCer.Size = new System.Drawing.Size(297, 23);
            this.changeCer.TabIndex = 31;
            this.changeCer.Text = "Изменить";
            this.changeCer.UseVisualStyleBackColor = true;
            this.changeCer.Click += new System.EventHandler(this.changeCer_Click);
            // 
            // deleteCer
            // 
            this.deleteCer.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteCer.Location = new System.Drawing.Point(437, 430);
            this.deleteCer.Name = "deleteCer";
            this.deleteCer.Size = new System.Drawing.Size(297, 23);
            this.deleteCer.TabIndex = 32;
            this.deleteCer.Text = "Удалить";
            this.deleteCer.UseVisualStyleBackColor = true;
            this.deleteCer.Click += new System.EventHandler(this.deleteCer_Click);
            // 
            // changeSpec
            // 
            this.changeSpec.Location = new System.Drawing.Point(812, 401);
            this.changeSpec.Name = "changeSpec";
            this.changeSpec.Size = new System.Drawing.Size(297, 23);
            this.changeSpec.TabIndex = 33;
            this.changeSpec.Text = "Изменить";
            this.changeSpec.UseVisualStyleBackColor = true;
            this.changeSpec.Click += new System.EventHandler(this.changeSpec_Click);
            // 
            // deleteSpec
            // 
            this.deleteSpec.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteSpec.Location = new System.Drawing.Point(812, 430);
            this.deleteSpec.Name = "deleteSpec";
            this.deleteSpec.Size = new System.Drawing.Size(297, 23);
            this.deleteSpec.TabIndex = 34;
            this.deleteSpec.Text = "Удалить";
            this.deleteSpec.UseVisualStyleBackColor = true;
            this.deleteSpec.Click += new System.EventHandler(this.deleteSpec_Click);
            // 
            // countDoctorsTb
            // 
            this.countDoctorsTb.Location = new System.Drawing.Point(42, 524);
            this.countDoctorsTb.Name = "countDoctorsTb";
            this.countDoctorsTb.Size = new System.Drawing.Size(107, 23);
            this.countDoctorsTb.TabIndex = 35;
            // 
            // countDoctors
            // 
            this.countDoctors.Location = new System.Drawing.Point(158, 524);
            this.countDoctors.Name = "countDoctors";
            this.countDoctors.Size = new System.Drawing.Size(230, 23);
            this.countDoctors.TabIndex = 36;
            this.countDoctors.Text = "Найти количество врачей";
            this.countDoctors.UseVisualStyleBackColor = true;
            this.countDoctors.Click += new System.EventHandler(this.countDoctors_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID Специализации";
            // 
            // doctorsCountLabel
            // 
            this.doctorsCountLabel.AutoSize = true;
            this.doctorsCountLabel.Location = new System.Drawing.Point(405, 527);
            this.doctorsCountLabel.Name = "doctorsCountLabel";
            this.doctorsCountLabel.Size = new System.Drawing.Size(12, 15);
            this.doctorsCountLabel.TabIndex = 38;
            this.doctorsCountLabel.Text = "-";
            // 
            // findSpecTb
            // 
            this.findSpecTb.Location = new System.Drawing.Point(42, 582);
            this.findSpecTb.Name = "findSpecTb";
            this.findSpecTb.Size = new System.Drawing.Size(107, 23);
            this.findSpecTb.TabIndex = 39;
            // 
            // findSpec
            // 
            this.findSpec.Location = new System.Drawing.Point(158, 582);
            this.findSpec.Name = "findSpec";
            this.findSpec.Size = new System.Drawing.Size(230, 23);
            this.findSpec.TabIndex = 40;
            this.findSpec.Text = "Найти название специализации";
            this.findSpec.UseVisualStyleBackColor = true;
            this.findSpec.Click += new System.EventHandler(this.findSpec_Click);
            // 
            // findSpecLabel
            // 
            this.findSpecLabel.AutoSize = true;
            this.findSpecLabel.Location = new System.Drawing.Point(405, 585);
            this.findSpecLabel.Name = "findSpecLabel";
            this.findSpecLabel.Size = new System.Drawing.Size(12, 15);
            this.findSpecLabel.TabIndex = 41;
            this.findSpecLabel.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 564);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "ID Сертификата";
            // 
            // cerDateTb
            // 
            this.cerDateTb.Location = new System.Drawing.Point(43, 642);
            this.cerDateTb.Name = "cerDateTb";
            this.cerDateTb.Size = new System.Drawing.Size(107, 23);
            this.cerDateTb.TabIndex = 43;
            // 
            // cerDate
            // 
            this.cerDate.Location = new System.Drawing.Point(158, 641);
            this.cerDate.Name = "cerDate";
            this.cerDate.Size = new System.Drawing.Size(230, 23);
            this.cerDate.TabIndex = 44;
            this.cerDate.Text = "Найти дату последнего сертификата";
            this.cerDate.UseVisualStyleBackColor = true;
            this.cerDate.Click += new System.EventHandler(this.cerDate_Click);
            // 
            // cerDateLabel
            // 
            this.cerDateLabel.AutoSize = true;
            this.cerDateLabel.Location = new System.Drawing.Point(405, 642);
            this.cerDateLabel.Name = "cerDateLabel";
            this.cerDateLabel.Size = new System.Drawing.Size(12, 15);
            this.cerDateLabel.TabIndex = 45;
            this.cerDateLabel.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 624);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 46;
            this.label15.Text = "ID Врача";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 715);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cerDateLabel);
            this.Controls.Add(this.cerDate);
            this.Controls.Add(this.cerDateTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.findSpecLabel);
            this.Controls.Add(this.findSpec);
            this.Controls.Add(this.findSpecTb);
            this.Controls.Add(this.doctorsCountLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.countDoctors);
            this.Controls.Add(this.countDoctorsTb);
            this.Controls.Add(this.deleteSpec);
            this.Controls.Add(this.changeSpec);
            this.Controls.Add(this.deleteCer);
            this.Controls.Add(this.changeCer);
            this.Controls.Add(this.createCer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.createSpes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteDoctor);
            this.Controls.Add(this.changeDoctor);
            this.Controls.Add(this.createDoctorBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cerDescTb);
            this.Controls.Add(this.specNameTb);
            this.Controls.Add(this.specIdTb);
            this.Controls.Add(this.cerDoctorTb);
            this.Controls.Add(this.cerIdTb);
            this.Controls.Add(this.doctorSpecId);
            this.Controls.Add(this.doctorNameTb);
            this.Controls.Add(this.doctorIdTb);
            this.Controls.Add(this.specializationLoad);
            this.Controls.Add(this.loadCertificates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadDoctors);
            this.Controls.Add(this.specializationGrid);
            this.Controls.Add(this.certificatesGrid);
            this.Controls.Add(this.doctorsGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorsGrid;
        private System.Windows.Forms.DataGridView certificatesGrid;
        private System.Windows.Forms.DataGridView specializationGrid;
        private System.Windows.Forms.Button loadDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadCertificates;
        private System.Windows.Forms.Button specializationLoad;
        private System.Windows.Forms.TextBox doctorIdTb;
        private System.Windows.Forms.TextBox doctorNameTb;
        private System.Windows.Forms.TextBox doctorSpecId;
        private System.Windows.Forms.TextBox cerIdTb;
        private System.Windows.Forms.TextBox cerDoctorTb;
        private System.Windows.Forms.TextBox specIdTb;
        private System.Windows.Forms.TextBox specNameTb;
        private System.Windows.Forms.TextBox cerDescTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createDoctorBtn;
        private System.Windows.Forms.Button changeDoctor;
        private System.Windows.Forms.Button deleteDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createSpes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createCer;
        private System.Windows.Forms.Button changeCer;
        private System.Windows.Forms.Button deleteCer;
        private System.Windows.Forms.Button changeSpec;
        private System.Windows.Forms.Button deleteSpec;
        private System.Windows.Forms.TextBox countDoctorsTb;
        private System.Windows.Forms.Button countDoctors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label doctorsCountLabel;
        private System.Windows.Forms.TextBox findSpecTb;
        private System.Windows.Forms.Button findSpec;
        private System.Windows.Forms.Label findSpecLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cerDateTb;
        private System.Windows.Forms.Button cerDate;
        private System.Windows.Forms.Label cerDateLabel;
        private System.Windows.Forms.Label label15;
    }
}

