namespace Sql_Project.Officer
{
    partial class FrmOfficerLogin
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
            this.txtO_Password = new System.Windows.Forms.TextBox();
            this.mskO_IdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtO_Password
            // 
            this.txtO_Password.Location = new System.Drawing.Point(243, 116);
            this.txtO_Password.Name = "txtO_Password";
            this.txtO_Password.Size = new System.Drawing.Size(136, 30);
            this.txtO_Password.TabIndex = 9;
            this.txtO_Password.UseSystemPasswordChar = true;
            // 
            // mskO_IdentityNumber
            // 
            this.mskO_IdentityNumber.Location = new System.Drawing.Point(243, 64);
            this.mskO_IdentityNumber.Mask = "00000000000";
            this.mskO_IdentityNumber.Name = "mskO_IdentityNumber";
            this.mskO_IdentityNumber.Size = new System.Drawing.Size(136, 30);
            this.mskO_IdentityNumber.TabIndex = 8;
            this.mskO_IdentityNumber.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Memur Giriş Ekranı";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(243, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 34);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmOfficerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(407, 215);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtO_Password);
            this.Controls.Add(this.mskO_IdentityNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOfficerLogin";
            this.Text = "FrmOfficerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtO_Password;
        private System.Windows.Forms.MaskedTextBox mskO_IdentityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}