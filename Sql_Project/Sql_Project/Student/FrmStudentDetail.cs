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
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string studentNumber;
        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT s.StudentIdentityNumber,s.StudentNumber,s.StudentName + ' ' + s.StudentLastName," +
                "s.StudentFaculty,s.StudentDepartment,t.TeacherName + ' ' + t.TeacherLastName,s.StudentDateOfRegistiration " +
                "FROM Students AS s " +
                "INNER JOIN Teachers AS t " +
                "ON s.StudentAdvisorId=t.TeacherId " +
                "WHERE s.StudentNumber=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", studentNumber);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblIdentityNumber.Text = sqlDataReader[0].ToString();
                lblStudentNumber.Text = studentNumber;
                lblFullName.Text = sqlDataReader[1] + " " + sqlDataReader[2];
                lblFacultyName.Text = sqlDataReader[3].ToString();
                lblDepartmentName.Text = sqlDataReader[4].ToString();
                lblAdvisorName.Text = sqlDataReader[5].ToString();
                lblDateofRegistiration.Text = sqlDataReader[6].ToString();
            }
            conn.connection().Close();
        }

        private void btnGetTranscript_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT l.LessonName AS [Ders Adı], l.LessonGrade AS [Ders Yarıyılı], " +
                "l.LessonCredi AS [Kredi], stl.StudentLessonVisaPoint AS [Vize Notu], stl.StudentLessonFinalPoint AS [Final Notu], " +
                "stl.StudentSuccessGrade AS [Başarı Notu] FROM StudentsTakingTheLessons as stl " +
                "INNER JOIN GivingLessonsByTeachers as glt " +
                "ON stl.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Lessons as l " +
                "ON glt.Id = l.LessonId " +
                "INNER JOIN Students AS s " +
                "ON stl.StudentId = s.StudentId " +
                "WHERE s.StudentNumber = " + studentNumber + " AND stl.StudentSuccessGrade >= 50", conn.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            FrmStudentShowNote frmStudentShowNote = new FrmStudentShowNote();
            frmStudentShowNote.s_StudentNumber = studentNumber;
            frmStudentShowNote.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisterLesson_Click(object sender, EventArgs e)
        {
            FrmStudentLessonRegistration frmStudentLessonRegistration = new FrmStudentLessonRegistration();
            frmStudentLessonRegistration.studentNumber = studentNumber;
            frmStudentLessonRegistration.Show();
        }

        private void btnListApprovedLessonRegistrations_Click(object sender, EventArgs e)
        {
            FrmStudentApprovedLessons frmStudentApprovedLessons = new FrmStudentApprovedLessons();
            frmStudentApprovedLessons.s_StudentNumber = studentNumber;
            frmStudentApprovedLessons.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentAwatingLessonApproved frmStudentAwatingLessonApproved = new FrmStudentAwatingLessonApproved();
            frmStudentAwatingLessonApproved.s_StudentNumber = studentNumber;
            frmStudentAwatingLessonApproved.Show();
        }
    }
}
