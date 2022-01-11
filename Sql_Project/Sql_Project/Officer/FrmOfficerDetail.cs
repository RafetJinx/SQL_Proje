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
    public partial class FrmOfficerDetail : Form
    {
        public FrmOfficerDetail()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string Tc_O;

        private void FrmOfficerDetail_Load(object sender, EventArgs e)
        {
            // TC No'su verilmis olan memurun bilgilerini getiriyoruz
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Officers WHERE OfficerIdentityNumber = @p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", Tc_O);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            lblOfficerFullName.Text = sqlDataReader[1].ToString() + " " + sqlDataReader[2].ToString();
            lblOfficerIdentityNumber.Text = sqlDataReader[3].ToString();
            conn.connection().Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmOfficerAddingStudent frmOfficerAddingStudent = new FrmOfficerAddingStudent();
            frmOfficerAddingStudent.Show();
        }

        private void btnIncreaseGrade_Click(object sender, EventArgs e)
        {
            // Butun ogrencilerin yariyil'ini bir (1) artttiriyoruz
            if (MessageBox.Show("BÜTÜN ÖĞRENCİLERİN YARIYILI BİR (1) ARTTIRILACAKTIR!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Students SET StudentGrade += 1", conn.connection());
                sqlCommand.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Bütün öğrencilerin yarıyılı bir (1) arttırıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAppointAdvisor_Click(object sender, EventArgs e)
        {
            FrmOfficerAppointAdvisor frmOfficerAppointAdvisor = new FrmOfficerAppointAdvisor();
            frmOfficerAppointAdvisor.Show();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FrmOfficerAddingTeacher frmOfficerAddingTeacher = new FrmOfficerAddingTeacher();
            frmOfficerAddingTeacher.Show();
        }
    }
}
