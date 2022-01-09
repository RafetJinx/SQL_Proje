namespace Sql_Project.Officer
{
    partial class FrmOfficerAddingTeacher
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
            this.cmbTeacherGender = new System.Windows.Forms.ComboBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.mskTeacherIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeacherBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeacherIsAdvisor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTeacherGender
            // 
            this.cmbTeacherGender.FormattingEnabled = true;
            this.cmbTeacherGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbTeacherGender.Location = new System.Drawing.Point(213, 205);
            this.cmbTeacherGender.Name = "cmbTeacherGender";
            this.cmbTeacherGender.Size = new System.Drawing.Size(139, 32);
            this.cmbTeacherGender.TabIndex = 31;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(213, 98);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(215, 29);
            this.txtTeacherLastName.TabIndex = 30;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(213, 63);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(215, 29);
            this.txtTeacherName.TabIndex = 29;
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.Location = new System.Drawing.Point(213, 168);
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.Size = new System.Drawing.Size(215, 29);
            this.txtTeacherPassword.TabIndex = 28;
            // 
            // mskTeacherIdentityNumber
            // 
            this.mskTeacherIdentityNumber.Location = new System.Drawing.Point(213, 133);
            this.mskTeacherIdentityNumber.Mask = "00000000000";
            this.mskTeacherIdentityNumber.Name = "mskTeacherIdentityNumber";
            this.mskTeacherIdentityNumber.Size = new System.Drawing.Size(139, 29);
            this.mskTeacherIdentityNumber.TabIndex = 27;
            this.mskTeacherIdentityNumber.ValidatingType = typeof(int);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(213, 321);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(162, 45);
            this.btnAddStudent.TabIndex = 26;
            this.btnAddStudent.Text = "Öğretmen Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cinsiyeti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Şifresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kimlik Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Öğretmen Ekleme Ekranı";
            // 
            // cmbTeacherBranch
            // 
            this.cmbTeacherBranch.FormattingEnabled = true;
            this.cmbTeacherBranch.Location = new System.Drawing.Point(213, 281);
            this.cmbTeacherBranch.Name = "cmbTeacherBranch";
            this.cmbTeacherBranch.Size = new System.Drawing.Size(215, 32);
            this.cmbTeacherBranch.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Alanı:";
            // 
            // cmbTeacherIsAdvisor
            // 
            this.cmbTeacherIsAdvisor.FormattingEnabled = true;
            this.cmbTeacherIsAdvisor.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbTeacherIsAdvisor.Location = new System.Drawing.Point(213, 243);
            this.cmbTeacherIsAdvisor.Name = "cmbTeacherIsAdvisor";
            this.cmbTeacherIsAdvisor.Size = new System.Drawing.Size(139, 32);
            this.cmbTeacherIsAdvisor.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Danışman Mı:";
            // 
            // FrmOfficerAddingTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(475, 409);
            this.Controls.Add(this.cmbTeacherIsAdvisor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTeacherBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTeacherGender);
            this.Controls.Add(this.txtTeacherLastName);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtTeacherPassword);
            this.Controls.Add(this.mskTeacherIdentityNumber);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOfficerAddingTeacher";
            this.Text = "FrmOfficerAddingTeacher";
            this.Load += new System.EventHandler(this.FrmOfficerAddingTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTeacherGender;
        private System.Windows.Forms.TextBox txtTeacherLastName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherPassword;
        private System.Windows.Forms.MaskedTextBox mskTeacherIdentityNumber;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeacherBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeacherIsAdvisor;
        private System.Windows.Forms.Label label8;
    }
}