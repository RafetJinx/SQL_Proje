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
    public partial class FrmTeacherApproveLesson : Form
    {
        public FrmTeacherApproveLesson()
        {
            InitializeComponent();
        }

        public string Tc_T;
        SqlConn conn = new SqlConn();

        private void ShowAwaitingLessons()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("" +
                "SELECT s.StudentNumber AS [Öğrenci Numarası], " +
                "s.StudentName + ' ' + s.StudentLastName AS [Öğrenci Adı], s.StudentFaculty AS [Fakültesi], " +
                "s.StudentDepartment AS [Bölümü], l.LessonName AS [Ders Adı], " +
                "t.TeacherName + ' ' + t.TeacherLastName AS [Dersi Veren Öğretmen] " +
                "FROM StudentsAwaitingLessonsApproval AS sala " +
                "INNER JOIN Students AS s " +
                "ON sala.StudentId = s.StudentId " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON sala.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Teachers AS t " +
                "ON glt.TeacherId = t.TeacherId " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE s.StudentAdvisorId = (SELECT tt.TeacherId FROM Teachers AS tt WHERE tt.TeacherIdentityNumber =" + Tc_T + ") " +
                "OR glt.TeacherId = (SELECT tt.TeacherId FROM Teachers AS tt WHERE tt.TeacherIdentityNumber = " + Tc_T + ")", conn.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmTeacherApproveLesson_Load(object sender, EventArgs e)
        {
            ShowAwaitingLessons();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                lblStudentNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblStudentFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblStudentFaculty.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblStudentDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblLessonName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblLessonTeacher.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            string student_id = "";
            string glt_id = "";

            // Gerekli verilerin getirilmesini (student_id, glt_id) saglayan kisim
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT StudentId, GivingLessonsByTeacherId FROM StudentsAwaitingLessonsApproval  " +
                    "WHERE StudentId = (SELECT StudentId FROM Students AS s WHERE s.StudentNumber = " + lblStudentNumber.Text + ")", conn.connection());
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    student_id = sqlDataReader[0].ToString();
                    glt_id = sqlDataReader[1].ToString();
                }
                conn.connection().Close();
            }
            
            // Öğrencinin onay bekleyen derslerinden bir tanesini öğrencinin aldığı derslere ekliyoruz
            {
                SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO StudentsTakingTheLessons " +
                "(StudentId, GivingLessonsByTeacherId)" +
                "VALUES" +
                "(@p1,@p2)", conn.connection());
                sqlCommand1.Parameters.AddWithValue("@p1", student_id);
                sqlCommand1.Parameters.AddWithValue("@p2", glt_id);
                sqlCommand1.ExecuteNonQuery();
                conn.connection().Close();
            }

            // Öğrencinin onay bekleyen dersler listesinden seçilen ders siliniyor
            {
                SqlCommand sqlCommand2 = new SqlCommand("DELETE FROM StudentsAwaitingLessonsApproval WHERE StudentId=@p1 AND GivingLessonsByTeacherId=@p2", conn.connection());
                sqlCommand2.Parameters.AddWithValue("@p1", student_id);
                sqlCommand2.Parameters.AddWithValue("@p2", glt_id);
                sqlCommand2.ExecuteNonQuery();
                conn.connection().Close();
            }
            MessageBox.Show("Onaylama işlemi gerçekleştirildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAwaitingLessons();
        }
    }
}
