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

namespace Sql_Project.Teacher
{
    public partial class FrmTeacherLogin : Form
    {
        public FrmTeacherLogin()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Veritabaninda girilen veriler ile uyusan bir ogretmen olup olmadigini kontrol eden sorgumuz.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers WHERE TeacherIdentityNumber=@p1 AND TeacherPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", mskT_IdentityNumber.Text);
            cmd.Parameters.AddWithValue("@p2", txtT_Password.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            // Veritabanımızda okuma gerceklestiriliyor ve girilen veriler ile eslesen bir ogretmen verisi var ise oturum acma islemi gerceklestiriliyor ve Ogretmen detay form'umuza gecis yaptiriyor
            if (sqlDataReader.Read())
            {
                FrmTeacherDetail frmTeacherDetail = new FrmTeacherDetail();
                frmTeacherDetail.Tc_T = mskT_IdentityNumber.Text;
                frmTeacherDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTeacherLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
