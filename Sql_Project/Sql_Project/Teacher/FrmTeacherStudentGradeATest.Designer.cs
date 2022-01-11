namespace Sql_Project.Teacher
{
    partial class FrmTeacherStudentGradeATest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLessons = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLessonSuccessGrade = new System.Windows.Forms.Label();
            this.mskLessonFinalPoint = new System.Windows.Forms.MaskedTextBox();
            this.mskLessonVisaPoint = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.btnGradeATest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Giriş Ekranı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLessons);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Ders";
            // 
            // cmbLessons
            // 
            this.cmbLessons.FormattingEnabled = true;
            this.cmbLessons.Location = new System.Drawing.Point(366, 29);
            this.cmbLessons.Name = "cmbLessons";
            this.cmbLessons.Size = new System.Drawing.Size(321, 30);
            this.cmbLessons.TabIndex = 3;
            this.cmbLessons.SelectedIndexChanged += new System.EventHandler(this.cmbLessons_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not Girişi Yapılacak Olan Ders:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(8, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 266);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçilen Dersi Alan Öğrenciler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLessonSuccessGrade);
            this.groupBox1.Controls.Add(this.mskLessonFinalPoint);
            this.groupBox1.Controls.Add(this.mskLessonVisaPoint);
            this.groupBox1.Controls.Add(this.lblStudentNumber);
            this.groupBox1.Controls.Add(this.lblStudentFullName);
            this.groupBox1.Controls.Add(this.btnGradeATest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin Bilgileri";
            // 
            // lblLessonSuccessGrade
            // 
            this.lblLessonSuccessGrade.AutoSize = true;
            this.lblLessonSuccessGrade.Location = new System.Drawing.Point(187, 197);
            this.lblLessonSuccessGrade.Name = "lblLessonSuccessGrade";
            this.lblLessonSuccessGrade.Size = new System.Drawing.Size(80, 22);
            this.lblLessonSuccessGrade.TabIndex = 10;
            this.lblLessonSuccessGrade.Text = "label10";
            // 
            // mskLessonFinalPoint
            // 
            this.mskLessonFinalPoint.Location = new System.Drawing.Point(191, 153);
            this.mskLessonFinalPoint.Mask = "000";
            this.mskLessonFinalPoint.Name = "mskLessonFinalPoint";
            this.mskLessonFinalPoint.Size = new System.Drawing.Size(100, 30);
            this.mskLessonFinalPoint.TabIndex = 9;
            this.mskLessonFinalPoint.ValidatingType = typeof(int);
            // 
            // mskLessonVisaPoint
            // 
            this.mskLessonVisaPoint.Location = new System.Drawing.Point(191, 115);
            this.mskLessonVisaPoint.Mask = "000";
            this.mskLessonVisaPoint.Name = "mskLessonVisaPoint";
            this.mskLessonVisaPoint.Size = new System.Drawing.Size(100, 30);
            this.mskLessonVisaPoint.TabIndex = 8;
            this.mskLessonVisaPoint.ValidatingType = typeof(int);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(187, 85);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(70, 22);
            this.lblStudentNumber.TabIndex = 7;
            this.lblStudentNumber.Text = "label9";
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(187, 45);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(70, 22);
            this.lblStudentFullName.TabIndex = 6;
            this.lblStudentFullName.Text = "label8";
            // 
            // btnGradeATest
            // 
            this.btnGradeATest.Location = new System.Drawing.Point(418, 163);
            this.btnGradeATest.Name = "btnGradeATest";
            this.btnGradeATest.Size = new System.Drawing.Size(277, 56);
            this.btnGradeATest.TabIndex = 5;
            this.btnGradeATest.Text = "Not Girişini Gerçekleştir";
            this.btnGradeATest.UseVisualStyleBackColor = true;
            this.btnGradeATest.Click += new System.EventHandler(this.btnGradeATest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Başarı Notu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Final Notu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vize Notu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı:";
            // 
            // FrmTeacherStudentGradeATest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(725, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTeacherStudentGradeATest";
            this.Text = "Not Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmTeacherStudentGradeATest_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLessons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLessonSuccessGrade;
        private System.Windows.Forms.MaskedTextBox mskLessonFinalPoint;
        private System.Windows.Forms.MaskedTextBox mskLessonVisaPoint;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.Button btnGradeATest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}