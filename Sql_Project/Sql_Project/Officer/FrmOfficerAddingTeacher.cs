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
    public partial class FrmOfficerAddingTeacher : Form
    {
        public FrmOfficerAddingTeacher()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void FrmOfficerAddingTeacher_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT DISTINCT(TeacherBranch) FROM Teachers", conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbTeacherBranch.Items.Add(sqlDataReader[0]);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Teachers VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtTeacherName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtTeacherLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mskTeacherIdentityNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtTeacherPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p5", cmbTeacherGender.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbTeacherIsAdvisor.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbTeacherBranch.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Öğretmen kaydı gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTeacherName.Text = "";
            txtTeacherLastName.Text = "";
            mskTeacherIdentityNumber.Text = "";
            txtTeacherPassword.Text = "";
            cmbTeacherGender.Text = "";
            cmbTeacherIsAdvisor.Text = "";
            cmbTeacherBranch.Text = "";
        }
    }
}
