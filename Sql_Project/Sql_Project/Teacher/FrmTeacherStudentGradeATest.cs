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
    public partial class FrmTeacherStudentGradeATest : Form
    {
        public FrmTeacherStudentGradeATest()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string Tc_T;
        private string stl_StudentId;
        private string stl_GivingLessonsByTeacherId;


        private void ShowDetails()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT stl.StudentId, stl.GivingLessonsByTeacherId, s.StudentNumber AS [Öğrenci Numarası], s.StudentName + ' ' + s.StudentLastName AS [Öğrenci Adı], " +
                "stl.StudentLessonVisaPoint AS [Vize Notu], stl.StudentLessonFinalPoint AS [Final Notu], stl.StudentSuccessGrade AS [Başarı Notu] " +
                "FROM StudentsTakingTheLessons AS stl " +
                "INNER JOIN Students AS s " +
                "ON stl.StudentId = s.StudentId " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON stl.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE glt.TeacherId = (SELECT t.TeacherId FROM Teachers AS t WHERE t.TeacherIdentityNumber = " + Tc_T + ") AND l.LessonName = '" + cmbLessons.SelectedItem + "'", conn.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void FrmTeacherStudentGradeATest_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT l.LessonName " +
                "FROM GivingLessonsByTeachers AS glt " +
                "INNER JOIN Lessons AS l " +
                "ON glt.LessonId = l.LessonId " +
                "WHERE glt.TeacherId = (SELECT t.TeacherId FROM Teachers AS t WHERE t.TeacherIdentityNumber =" + Tc_T +")", conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbLessons.Items.Add(sqlDataReader[0]);
            }
            conn.connection().Close();
        }

        private void cmbLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sutun adlarina tiklandigi zaman hata olmamasini sagladik
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                try
                {
                    stl_StudentId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    stl_GivingLessonsByTeacherId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lblStudentNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    lblStudentFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    mskLessonVisaPoint.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    mskLessonFinalPoint.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    lblLessonSuccessGrade.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                } catch (Exception ex)
                {

                }
            }
        }

        private void btnGradeATest_Click(object sender, EventArgs e)
        {
            int successGrade = Convert.ToInt32((Convert.ToDouble(mskLessonVisaPoint.Text) * 0.6 + Convert.ToDouble(mskLessonFinalPoint.Text) * 0.4));

            SqlCommand sqlCommand = new SqlCommand("UPDATE StudentsTakingTheLessons SET StudentLessonVisaPoint = @p1, StudentLessonFinalPoint = @p2, StudentSuccessGrade = @p3 WHERE StudentId = @p4 AND GivingLessonsByTeacherId = @p5", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", mskLessonVisaPoint.Text);
            sqlCommand.Parameters.AddWithValue("@p2", mskLessonFinalPoint.Text);
            sqlCommand.Parameters.AddWithValue("@p3", successGrade.ToString());
            sqlCommand.Parameters.AddWithValue("@p4", stl_StudentId);
            sqlCommand.Parameters.AddWithValue("@p5", stl_GivingLessonsByTeacherId);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Not girişi yapılmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblStudentFullName.Text = "";
            lblStudentNumber.Text = "";
            mskLessonVisaPoint.Text = "";
            mskLessonFinalPoint.Text = "";
            lblLessonSuccessGrade.Text = "";

            ShowDetails();
        }
    }
}
