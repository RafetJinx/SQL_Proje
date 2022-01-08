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
    public partial class FrmStudentAwatingLessonApproved : Form
    {
        public FrmStudentAwatingLessonApproved()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string s_StudentNumber;

        // ShowTheStudentsAwaitingLessonApproved
        public void ShowTheAwaitingLessonApprovals()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                "SELECT l.LessonName AS [Dersin Adı], t.TeacherName + ' ' + t.TeacherLastName AS [Dersi Veren Öğretmen], " +
                "l.LessonCredi AS [Kredi], l.LessonGrade AS [Dersin Yarıyılı] " +
                "FROM StudentsAwaitingLessonsApproval AS sala " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON sala.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Teachers AS t " +
                "ON glt.TeacherId = t.TeacherId " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE sala.StudentId = (SELECT s.StudentId FROM Students AS s WHERE s.StudentNumber = " + s_StudentNumber + ")", conn.connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sutun adlarina tiklandigi zaman hata olmamasini sagladik
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                lblLessonName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblTeacherName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblLessonCredit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblLessonGrade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void FrmStudentAwatingLessonApproved_Load(object sender, EventArgs e)
        {
            ShowTheAwaitingLessonApprovals();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE StudentsAwaitingLessonsApproval " +
                "WHERE StudentId = (SELECT StudentId FROM Students WHERE StudentNumber = @p1) " +
                "AND StudentsAwaitingLessonsApproval.GivingLessonsByTeacherId = (SELECT gtl.Id FROM GivingLessonsByTeachers AS gtl " +
                "WHERE gtl.LessonId = (SELECT l.LessonId FROM Lessons AS l WHERE l.LessonName = @p2))", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", s_StudentNumber);
            sqlCommand.Parameters.AddWithValue("@p2", lblLessonName.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Seçilen ders danışman onayından kaldırılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowTheAwaitingLessonApprovals();
        }
    }
}
