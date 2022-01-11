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
    public partial class FrmOfficerAddingStudent : Form
    {
        public FrmOfficerAddingStudent()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void button1_Click(object sender, EventArgs e)
        {
            // Istenen gerekli bilgileri girilmis olan ogrenci bilgilerini alip veritabanina ekleyen (ogrenci kaydimizi yapan) sql ifademiz
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Students VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", mskStudentNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2", mskStudentIdentityNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtStudentPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtStudentName.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtStudentLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbStudentGender.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbStudentFaculty.Text);
            sqlCommand.Parameters.AddWithValue("@p8", cmbStudentDepartment.Text);
            sqlCommand.Parameters.AddWithValue("@p9", mskStudentDateOfRegistration.Text);
            sqlCommand.Parameters.AddWithValue("@p10", cmbStudentGrade.Text);
            sqlCommand.Parameters.AddWithValue("@p11", (cmbStudentAdvisorFullName.SelectedItem as dynamic).Value);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Öğrenci kaydı gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mskStudentNumber.Text = "";
            mskStudentNumber.Text = "";
            mskStudentIdentityNumber.Text = "";
            txtStudentPassword.Text = "";
            txtStudentName.Text = "";
            txtStudentLastName.Text = "";
            cmbStudentGender.Text = "";
            cmbStudentFaculty.Text = "";
            cmbStudentDepartment.Text = "";
            mskStudentDateOfRegistration.Text = "";
            cmbStudentGrade.Text = "";
            cmbStudentAdvisorFullName.Text = "";
        }

        private void FrmOfficerAddingStudent_Load(object sender, EventArgs e)
        {
            cmbStudentAdvisorFullName.DisplayMember = "Text";
            cmbStudentAdvisorFullName.ValueMember = "Value";

            // Danismani olabilecek ogretmenleri goruntuleyebilmek icin danisman ogretmenleri combobox'imiza ekleyen sql ifademiz
            SqlCommand sqlCommand = new SqlCommand("SELECT t.TeacherName + ' ' + t.TeacherLastName, t.TeacherId FROM Teachers AS t WHERE t.TeacherAdvisor = 1", conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbStudentAdvisorFullName.Items.Add(new { Text = sqlDataReader[0], Value = sqlDataReader[1] });
            }
            conn.connection().Close();
        }
    }
}
