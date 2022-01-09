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
    public partial class FrmTeacherShowStudentProfile : Form
    {
        public FrmTeacherShowStudentProfile()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void ShowStudentDetail()
        {
            // Öğrenci bilgileri label'a aktarılıyor
            {
                SqlCommand cmd = new SqlCommand("SELECT s.StudentFaculty, s.StudentDepartment, s.StudentDateOfRegistiration, " +
                "s.StudentGrade, t.TeacherName + ' ' + t.TeacherLastName " +
                "FROM Students AS s " +
                "INNER JOIN Teachers AS t " +
                "ON s.StudentAdvisorId=t.TeacherId " +
                "WHERE s.StudentNumber=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", mskStudentNumber.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblStudentFaculty.Text = sqlDataReader[0].ToString();
                    lblStudentDepartment.Text = sqlDataReader[1].ToString();
                    lblStudentDateOfRegistration.Text = sqlDataReader[2].ToString();
                    lblStudentGrade.Text = sqlDataReader[3].ToString();
                    lblStudentAdvisorFullName.Text = sqlDataReader[4].ToString();
                }
                conn.connection().Close();
            }

            // Öğrencinin almış olduğu dersler datagrid'e aktarılıyor
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT l.LessonName AS [Dersin Adı], l.LessonCredi AS [Kredi], " +
                    "l.LessonGrade AS [Dersin Yarıyılı], stl.StudentLessonVisaPoint AS [Vize Notu], " +
                    "stl.StudentLessonFinalPoint AS [Final Notu], stl.StudentSuccessGrade AS [Başarı Notu] " +
                    "FROM StudentsTakingTheLessons AS stl " +
                    "INNER JOIN Students AS s " +
                    "ON stl.StudentId = s.StudentId " +
                    "INNER JOIN GivingLessonsByTeachers AS glt " +
                    "ON stl.GivingLessonsByTeacherId = glt.Id " +
                    "INNER JOIN Teachers AS t " +
                    "ON glt.TeacherId = t.TeacherId " +
                    "INNER JOIN Lessons AS l " +
                    "ON glt.LessonId = l.LessonId " +
                    "WHERE s.StudentNumber =" + mskStudentNumber.Text, conn.connection());
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FrmShowStudentProfile_Load(object sender, EventArgs e)
        {
            cmbStudentFullName.DisplayMember = "Text";
            cmbStudentFullName.ValueMember = "Value";

            SqlCommand sqlCommand = new SqlCommand("SELECT s.StudentName + ' ' + s.StudentLastName, s.StudentNumber FROM Students AS s", conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbStudentFullName.Items.Add(new { Text = sqlDataReader[0], Value = sqlDataReader[1] });
            }
            conn.connection().Close();
        }

        private void cmbStudentFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskStudentNumber.Text = (cmbStudentFullName.SelectedItem as dynamic).Value;
            ShowStudentDetail();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowStudentDetail();
        }
    }
}
