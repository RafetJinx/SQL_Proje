namespace Sql_Project.Officer
{
    partial class FrmOfficerAppointAdvisor
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeacherFullName = new System.Windows.Forms.ComboBox();
            this.lblTeacherIdentityNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Atama Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // cmbTeacherFullName
            // 
            this.cmbTeacherFullName.FormattingEnabled = true;
            this.cmbTeacherFullName.Location = new System.Drawing.Point(128, 66);
            this.cmbTeacherFullName.Name = "cmbTeacherFullName";
            this.cmbTeacherFullName.Size = new System.Drawing.Size(253, 30);
            this.cmbTeacherFullName.TabIndex = 3;
            this.cmbTeacherFullName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTeacherIdentityNumber
            // 
            this.lblTeacherIdentityNumber.AutoSize = true;
            this.lblTeacherIdentityNumber.Location = new System.Drawing.Point(124, 119);
            this.lblTeacherIdentityNumber.Name = "lblTeacherIdentityNumber";
            this.lblTeacherIdentityNumber.Size = new System.Drawing.Size(120, 22);
            this.lblTeacherIdentityNumber.TabIndex = 4;
            this.lblTeacherIdentityNumber.Text = "___________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Danışman Olarak Ata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOfficerAppointAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(459, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTeacherIdentityNumber);
            this.Controls.Add(this.cmbTeacherFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmOfficerAppointAdvisor";
            this.Text = "FrmOfficerAppointAdvisor";
            this.Load += new System.EventHandler(this.FrmOfficerAppointAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeacherFullName;
        private System.Windows.Forms.Label lblTeacherIdentityNumber;
        private System.Windows.Forms.Button button1;
    }
}