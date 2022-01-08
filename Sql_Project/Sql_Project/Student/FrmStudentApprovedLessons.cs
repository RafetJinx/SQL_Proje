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
    public partial class FrmStudentApprovedLessons : Form
    {
        public FrmStudentApprovedLessons()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string s_StudentNumber;

        private void FrmStudentApprovedLessons_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                "SELECT l.LessonName AS [Ders Adı], t.TeacherName + ' ' + t.TeacherLastName AS [Dersi Veren Öğretmen], " +
                "l.LessonCredi AS [Kredi] " +
                "FROM StudentsTakingTheLessons AS stl " +
                "INNER JOIN GivingLessonsByTeachers AS glt " +
                "ON stl.GivingLessonsByTeacherId = glt.Id " +
                "INNER JOIN Lessons AS l " +
                "ON glt.Id = l.LessonId " +
                "INNER JOIN Teachers AS t " +
                "ON glt.TeacherId = t.TeacherId " +
                "INNER JOIN Students AS s " +
                "ON stl.StudentId = s.StudentId " +
                "WHERE s.StudentNumber = " + s_StudentNumber +" " +
                "AND l.LessonGrade = (SELECT ss.StudentGrade FROM Students AS ss WHERE ss.StudentNumber = "+ s_StudentNumber +")", conn.connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;        
        }
    }
}
