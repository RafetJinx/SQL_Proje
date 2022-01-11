namespace Sql_Project.Teacher
{
    partial class FrmTeacherApproveLesson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.lblStudentFaculty = new System.Windows.Forms.Label();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.lblLessonName = new System.Windows.Forms.Label();
            this.lblLessonTeacher = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onay Bekleyen Öğrenciler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApproveRequest);
            this.groupBox2.Controls.Add(this.lblStudentNumber);
            this.groupBox2.Controls.Add(this.lblStudentFullName);
            this.groupBox2.Controls.Add(this.lblStudentFaculty);
            this.groupBox2.Controls.Add(this.lblStudentDepartment);
            this.groupBox2.Controls.Add(this.lblLessonName);
            this.groupBox2.Controls.Add(this.lblLessonTeacher);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 209);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Öğrencinin Bilgileri";
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Location = new System.Drawing.Point(725, 150);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(137, 50);
            this.btnApproveRequest.TabIndex = 3;
            this.btnApproveRequest.Text = "Onayla";
            this.btnApproveRequest.UseVisualStyleBackColor = true;
            this.btnApproveRequest.Click += new System.EventHandler(this.btnApproveRequest_Click);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(259, 43);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(70, 22);
            this.lblStudentNumber.TabIndex = 11;
            this.lblStudentNumber.Text = "label8";
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(259, 70);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(70, 22);
            this.lblStudentFullName.TabIndex = 10;
            this.lblStudentFullName.Text = "label9";
            // 
            // lblStudentFaculty
            // 
            this.lblStudentFaculty.AutoSize = true;
            this.lblStudentFaculty.Location = new System.Drawing.Point(259, 97);
            this.lblStudentFaculty.Name = "lblStudentFaculty";
            this.lblStudentFaculty.Size = new System.Drawing.Size(80, 22);
            this.lblStudentFaculty.TabIndex = 9;
            this.lblStudentFaculty.Text = "label10";
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Location = new System.Drawing.Point(259, 124);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(80, 22);
            this.lblStudentDepartment.TabIndex = 8;
            this.lblStudentDepartment.Text = "label11";
            // 
            // lblLessonName
            // 
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Location = new System.Drawing.Point(259, 151);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(80, 22);
            this.lblLessonName.TabIndex = 7;
            this.lblLessonName.Text = "label12";
            // 
            // lblLessonTeacher
            // 
            this.lblLessonTeacher.AutoSize = true;
            this.lblLessonTeacher.Location = new System.Drawing.Point(259, 178);
            this.lblLessonTeacher.Name = "lblLessonTeacher";
            this.lblLessonTeacher.Size = new System.Drawing.Size(80, 22);
            this.lblLessonTeacher.TabIndex = 6;
            this.lblLessonTeacher.Text = "label13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dersi Veren Öğretmen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ders Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bölümü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fakültesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numarası:";
            // 
            // FrmTeacherApproveLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(898, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTeacherApproveLesson";
            this.Text = "Onay Bekleyen Öğrenciler Ekranı";
            this.Load += new System.EventHandler(this.FrmTeacherApproveLesson_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.Label lblStudentFaculty;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.Label lblLessonTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}