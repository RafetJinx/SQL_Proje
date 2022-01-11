namespace Sql_Project.Officer
{
    partial class FrmOfficerDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppointAdvisor = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnIncreaseGrade = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOfficerIdentityNumber = new System.Windows.Forms.Label();
            this.lblOfficerFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppointAdvisor);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.btnIncreaseGrade);
            this.groupBox1.Controls.Add(this.btnAddTeacher);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Denetimler";
            // 
            // btnAppointAdvisor
            // 
            this.btnAppointAdvisor.Location = new System.Drawing.Point(269, 29);
            this.btnAppointAdvisor.Name = "btnAppointAdvisor";
            this.btnAppointAdvisor.Size = new System.Drawing.Size(116, 61);
            this.btnAppointAdvisor.TabIndex = 9;
            this.btnAppointAdvisor.Text = "Danışman Ata";
            this.btnAppointAdvisor.UseVisualStyleBackColor = true;
            this.btnAppointAdvisor.Click += new System.EventHandler(this.btnAppointAdvisor_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(10, 29);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(121, 61);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Öğrenci Kaydı Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnIncreaseGrade
            // 
            this.btnIncreaseGrade.Location = new System.Drawing.Point(142, 29);
            this.btnIncreaseGrade.Name = "btnIncreaseGrade";
            this.btnIncreaseGrade.Size = new System.Drawing.Size(116, 61);
            this.btnIncreaseGrade.TabIndex = 8;
            this.btnIncreaseGrade.Text = "Yarıyıl İlerlet";
            this.btnIncreaseGrade.UseVisualStyleBackColor = true;
            this.btnIncreaseGrade.Click += new System.EventHandler(this.btnIncreaseGrade_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(396, 29);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(121, 61);
            this.btnAddTeacher.TabIndex = 7;
            this.btnAddTeacher.Text = "Öğretmen Kaydı Ekle";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOfficerIdentityNumber);
            this.groupBox2.Controls.Add(this.lblOfficerFullName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // lblOfficerIdentityNumber
            // 
            this.lblOfficerIdentityNumber.AutoSize = true;
            this.lblOfficerIdentityNumber.Location = new System.Drawing.Point(128, 66);
            this.lblOfficerIdentityNumber.Name = "lblOfficerIdentityNumber";
            this.lblOfficerIdentityNumber.Size = new System.Drawing.Size(60, 22);
            this.lblOfficerIdentityNumber.TabIndex = 3;
            this.lblOfficerIdentityNumber.Text = "_____";
            // 
            // lblOfficerFullName
            // 
            this.lblOfficerFullName.AutoSize = true;
            this.lblOfficerFullName.Location = new System.Drawing.Point(128, 39);
            this.lblOfficerFullName.Name = "lblOfficerFullName";
            this.lblOfficerFullName.Size = new System.Drawing.Size(60, 22);
            this.lblOfficerFullName.TabIndex = 2;
            this.lblOfficerFullName.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // FrmOfficerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(563, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOfficerDetail";
            this.Text = "Memur Detay Ekranı";
            this.Load += new System.EventHandler(this.FrmOfficerDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOfficerIdentityNumber;
        private System.Windows.Forms.Label lblOfficerFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppointAdvisor;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnIncreaseGrade;
        private System.Windows.Forms.Button btnAddTeacher;
    }
}