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
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string Tc_T;
        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TC No'su girilmis olan ogretmen'in bilgilerinin goruntulenmesini sagliyoruz
            SqlCommand sqlCommand = new SqlCommand("SELECT TeacherName + ' ' + TeacherLastName, TeacherIdentityNumber, TeacherAdvisor, TeacherBranch FROM Teachers WHERE TeacherIdentityNumber =" + Tc_T, conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                lblTeacherFullName.Text = sqlDataReader[0].ToString();
                lblTeacherIdentityNumber.Text = sqlDataReader[1].ToString();
                if(sqlDataReader[2].ToString() == "True")
                {
                    lblTeacherIsAdvisor.Text = "Evet";
                }
                else
                {
                    lblTeacherIsAdvisor.Text = "Hayır";
                }
                lblTeacherBranch.Text = sqlDataReader[3].ToString();
            }
            conn.connection().Close();
        }

        private void btnTeacherAdvisorApprove_Click(object sender, EventArgs e)
        {
            // Ogretmen danisman ise danisman onayı sayfasina erisim saglayabiliyor
            if(lblTeacherIsAdvisor.Text == "Evet")
            {
                FrmTeacherApproveLesson frmTeacherApproveLesson = new FrmTeacherApproveLesson();
                frmTeacherApproveLesson.Tc_T = this.Tc_T;
                frmTeacherApproveLesson.Show();
            }
            else
            {
                MessageBox.Show("Danışman olmadığınız için bu sayfayı görüntüleyemezsiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnTeacherShowStudentProfile_Click(object sender, EventArgs e)
        {
            FrmTeacherShowStudentProfile frmShowStudentProfile = new FrmTeacherShowStudentProfile();
            frmShowStudentProfile.Show();
        }

        private void btnTeacherAddNote_Click(object sender, EventArgs e)
        {
            FrmTeacherStudentGradeATest frmTeacherStudentGradeATest = new FrmTeacherStudentGradeATest();
            frmTeacherStudentGradeATest.Tc_T = this.Tc_T;
            frmTeacherStudentGradeATest.Show();
        }
    }
}
