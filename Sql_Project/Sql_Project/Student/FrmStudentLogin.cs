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

namespace Sql_Project.Student
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }
        
        SqlConn conn = new SqlConn();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Veritabaninda girilen veriler ile uyusan bir ogrenci olup olmadigini kontrol eden sorgumuz.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE StudentNumber=@p1 AND StudentPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", mskS_StudentNumber.Text);
            cmd.Parameters.AddWithValue("@p2", txtS_Password.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            // Veritabanımızda okuma gerceklestiriliyor ve girilen veriler ile eslesen bir ogrenci verisi var ise oturum acma islemi gerceklestiriliyor ve Ogrenci detay form'umuza gecis yaptiriyor
            if (sqlDataReader.Read()){
                FrmStudentDetail frmStudentDetail = new FrmStudentDetail();
                frmStudentDetail.studentNumber = mskS_StudentNumber.Text;
                frmStudentDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmStudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
