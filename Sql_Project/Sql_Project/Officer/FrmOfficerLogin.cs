using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sql_Project.Officer
{
    public partial class FrmOfficerLogin : Form
    {
        public FrmOfficerLogin()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Veritabaninda girilen veriler ile uyusan bir memur olup olmadigini kontrol eden sorgumuz.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Officers WHERE OfficerIdentitynumber=@p1 AND OfficerPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", mskO_IdentityNumber.Text);
            cmd.Parameters.AddWithValue("@p2", txtO_Password.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            // Veritabanımızda okuma gerceklestiriliyor ve girilen veriler ile eslesen bir memur verisi var ise oturum acma islemi gerceklestiriliyor ve Memur detay form'umuza gecis yaptiriyor
            if (dr.Read())
            {
                FrmOfficerDetail frmOfficerDetail = new FrmOfficerDetail();
                frmOfficerDetail.Tc_O = mskO_IdentityNumber.Text;
                frmOfficerDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }

        private void FrmOfficerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
