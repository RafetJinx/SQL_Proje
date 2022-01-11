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
    public partial class FrmOfficerAppointAdvisor : Form
    {
        public FrmOfficerAppointAdvisor()
        {
            InitializeComponent();
        }
        
        SqlConn conn = new SqlConn();

        private void button1_Click(object sender, EventArgs e)
        {
            // Secilen ogretmeni danisman olarak atayan sql ifademiz
            SqlCommand sqlCommand = new SqlCommand("UPDATE Teachers SET TeacherAdvisor = 1 WHERE TeacherIdentityNumber = " + lblTeacherIdentityNumber.Text, conn.connection());
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Seçilen öğretmen danışman olarak atandı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTeacherIdentityNumber.Text = (cmbTeacherFullName.SelectedItem as dynamic).Value;
        }

        private void FrmOfficerAppointAdvisor_Load(object sender, EventArgs e)
        {
            cmbTeacherFullName.DisplayMember = "Text";
            cmbTeacherFullName.ValueMember = "Value";

            // Kayıtlı olan ve danisman olmayan ogretmenleri combobox'a ekliyoruz
            SqlCommand sqlCommand = new SqlCommand("SELECT t.TeacherName + ' ' + t.TeacherLastName, t.TeacherIdentityNumber FROM Teachers AS t WHERE TeacherAdvisor = 0", conn.connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbTeacherFullName.Items.Add(new { Text = sqlDataReader[0], Value = sqlDataReader[1] });
            }
            conn.connection().Close();
        }
    }
}
