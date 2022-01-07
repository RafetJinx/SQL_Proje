namespace Sql_Project.Teacher
{
    partial class FrmTeacherLogin
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
            this.mskT_IdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtT_Password = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskT_IdentityNumber
            // 
            this.mskT_IdentityNumber.Location = new System.Drawing.Point(266, 67);
            this.mskT_IdentityNumber.Mask = "00000000000";
            this.mskT_IdentityNumber.Name = "mskT_IdentityNumber";
            this.mskT_IdentityNumber.Size = new System.Drawing.Size(136, 30);
            this.mskT_IdentityNumber.TabIndex = 3;
            this.mskT_IdentityNumber.ValidatingType = typeof(int);
            // 
            // txtT_Password
            // 
            this.txtT_Password.Location = new System.Drawing.Point(266, 119);
            this.txtT_Password.Name = "txtT_Password";
            this.txtT_Password.Size = new System.Drawing.Size(136, 30);
            this.txtT_Password.TabIndex = 4;
            this.txtT_Password.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(266, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 34);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmTeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(458, 218);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtT_Password);
            this.Controls.Add(this.mskT_IdentityNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTeacherLogin";
            this.Text = "FrmTeacherLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskT_IdentityNumber;
        private System.Windows.Forms.TextBox txtT_Password;
        private System.Windows.Forms.Button btnLogin;
    }
}