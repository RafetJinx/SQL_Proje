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
    public partial class FrmStudentLessonRegistration : Form
    {
        public FrmStudentLessonRegistration()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string studentNumber;

        public void ShowTheLessonsCanTakeTheStudent()
        {
            // Ogrencinin o donem alabilecegi dersleri ve derse ait bilgileri datagrid'te listeliyoruz
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                "SELECT l.LessonName AS [Ders Adı], t.TeacherName + ' ' + t.TeacherLastName AS [Dersi Veren Öğretmen], " +
                "l.LessonCredi AS [Kredi], l.LessonGrade AS [Ders Yarıyılı] " +
                "FROM GivingLessonsByTeachers AS glt " +
                "INNER JOIN Teachers AS t " +
                "ON glt.TeacherId = t.TeacherId " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE l.LessonGrade = " +
                "(SELECT s.StudentGrade FROM Students AS s " +
                "WHERE s.StudentId = " +
                "(SELECT ss.StudentId FROM Students AS ss " +
                "WHERE ss.StudentNumber = " + studentNumber +" )) AND l.LessonName != ALL " +
                "(SELECT l.LessonName AS [Ders Adı] " +
                "FROM StudentsAwaitingLessonsApproval AS sala " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON sala.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE sala.StudentId = " +
                "(SELECT sss.StudentId " +
                "FROM Students AS sss " +
                "WHERE sss.StudentNumber =" + studentNumber + "))", conn.connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void FrmStudentLessonRegistration_Load(object sender, EventArgs e)
        {
            ShowTheLessonsCanTakeTheStudent();
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

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            // Ogrencinin almak istemis oldugu dersi danisman onayına gonderiyoruz
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO StudentsAwaitingLessonsApproval " +
                "VALUES (" +
                "(SELECT s.StudentId FROM Students AS s WHERE s.StudentNumber = @s_StudentNumber), " +
                "(SELECT glt.Id FROM GivingLessonsByTeachers AS glt " +
                "WHERE glt.LessonId = (SELECT l.LessonId FROM Lessons AS l WHERE l.LessonName = (@l_LessonName)) " +
                "AND glt.TeacherId = (SELECT t.TeacherId FROM Teachers AS t WHERE t.TeacherName + ' ' + t.TeacherLastName = (@t_TeacherName))))", conn.connection());
            sqlCommand.Parameters.AddWithValue("@s_StudentNumber", studentNumber);
            sqlCommand.Parameters.AddWithValue("@l_LessonName", lblLessonName.Text);
            sqlCommand.Parameters.AddWithValue("@t_TeacherName", lblTeacherName.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Ders kaydı isteği danışman onayına gönderildi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ShowTheLessonsCanTakeTheStudent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
