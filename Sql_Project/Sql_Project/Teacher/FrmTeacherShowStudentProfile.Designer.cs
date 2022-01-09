namespace Sql_Project.Teacher
{
    partial class FrmTeacherShowStudentProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.mskStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbStudentFullName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStudentFaculty = new System.Windows.Forms.Label();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.lblStudentDateOfRegistration = new System.Windows.Forms.Label();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.lblStudentAdvisorFullName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Profili Görüntüleme Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Numarası:";
            // 
            // mskStudentNumber
            // 
            this.mskStudentNumber.Location = new System.Drawing.Point(192, 30);
            this.mskStudentNumber.Mask = "00000000000";
            this.mskStudentNumber.Name = "mskStudentNumber";
            this.mskStudentNumber.Size = new System.Drawing.Size(134, 30);
            this.mskStudentNumber.TabIndex = 2;
            this.mskStudentNumber.ValidatingType = typeof(int);
            // 
            // cmbStudentFullName
            // 
            this.cmbStudentFullName.FormattingEnabled = true;
            this.cmbStudentFullName.Location = new System.Drawing.Point(154, 30);
            this.cmbStudentFullName.Name = "cmbStudentFullName";
            this.cmbStudentFullName.Size = new System.Drawing.Size(223, 30);
            this.cmbStudentFullName.TabIndex = 3;
            this.cmbStudentFullName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentFullName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 440);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin Aldığı Ders Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(348, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.mskStudentNumber);
            this.groupBox2.Location = new System.Drawing.Point(15, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numaraya Göre Arama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbStudentFullName);
            this.groupBox3.Location = new System.Drawing.Point(510, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Seçerek Arama";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStudentAdvisorFullName);
            this.groupBox4.Controls.Add(this.lblStudentGrade);
            this.groupBox4.Controls.Add(this.lblStudentDateOfRegistration);
            this.groupBox4.Controls.Add(this.lblStudentDepartment);
            this.groupBox4.Controls.Add(this.lblStudentFaculty);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(15, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(932, 180);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrencinin Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fakültesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bölümü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kayıt Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bulunduğu Yarıyıl:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Danışmanı:";
            // 
            // lblStudentFaculty
            // 
            this.lblStudentFaculty.AutoSize = true;
            this.lblStudentFaculty.Location = new System.Drawing.Point(233, 35);
            this.lblStudentFaculty.Name = "lblStudentFaculty";
            this.lblStudentFaculty.Size = new System.Drawing.Size(70, 22);
            this.lblStudentFaculty.TabIndex = 5;
            this.lblStudentFaculty.Text = "label9";
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Location = new System.Drawing.Point(233, 62);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(80, 22);
            this.lblStudentDepartment.TabIndex = 6;
            this.lblStudentDepartment.Text = "label10";
            // 
            // lblStudentDateOfRegistration
            // 
            this.lblStudentDateOfRegistration.AutoSize = true;
            this.lblStudentDateOfRegistration.Location = new System.Drawing.Point(233, 89);
            this.lblStudentDateOfRegistration.Name = "lblStudentDateOfRegistration";
            this.lblStudentDateOfRegistration.Size = new System.Drawing.Size(80, 22);
            this.lblStudentDateOfRegistration.TabIndex = 7;
            this.lblStudentDateOfRegistration.Text = "label11";
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(233, 116);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(80, 22);
            this.lblStudentGrade.TabIndex = 8;
            this.lblStudentGrade.Text = "label12";
            // 
            // lblStudentAdvisorFullName
            // 
            this.lblStudentAdvisorFullName.AutoSize = true;
            this.lblStudentAdvisorFullName.Location = new System.Drawing.Point(233, 143);
            this.lblStudentAdvisorFullName.Name = "lblStudentAdvisorFullName";
            this.lblStudentAdvisorFullName.Size = new System.Drawing.Size(80, 22);
            this.lblStudentAdvisorFullName.TabIndex = 9;
            this.lblStudentAdvisorFullName.Text = "label13";
            // 
            // FrmShowStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(962, 790);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmShowStudentProfile";
            this.Text = "FrmShowStudentProfile";
            this.Load += new System.EventHandler(this.FrmShowStudentProfile_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskStudentNumber;
        private System.Windows.Forms.ComboBox cmbStudentFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStudentAdvisorFullName;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblStudentDateOfRegistration;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label lblStudentFaculty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}