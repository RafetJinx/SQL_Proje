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
    public partial class FrmStudentShowNote : Form
    {
        public FrmStudentShowNote()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string s_StudentNumber;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT l.LessonName AS [Ders Adı], " +
                "l.LessonCredi AS [Kredi], stl.StudentLessonVisaPoint AS [Vize Puanı], " +
                "stl.StudentLessonFinalPoint AS [Final Puanı], stl.StudentSuccessGrade AS [Başarı Notu]" +
                "FROM StudentsTakingTheLessons AS stl " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON stl.GivingLessonsByTeacherId = glt.Id  " +
                "INNER JOIN Lessons AS l " +
                "ON glt.Id = l.LessonId " +
                "INNER JOIN Students AS s " +
                "ON stl.StudentId = s.StudentId " +
                "WHERE s.StudentNumber =" + s_StudentNumber + "AND l.LessonGrade = " + cmbGrade.SelectedItem.ToString(), conn.connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmStudentShowNote_Load(object sender, EventArgs e)
        {

        }
    }
}
