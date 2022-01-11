using Sql_Project.Student;
using Sql_Project.Teacher;
using Sql_Project.Officer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            FrmStudentLogin frm = new FrmStudentLogin();
            frm.Show();
            this.Hide();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            FrmTeacherLogin frm = new FrmTeacherLogin();
            frm.Show();
            this.Hide();
        }

        private void btnOfficerLogin_Click(object sender, EventArgs e)
        {
            FrmOfficerLogin frm = new FrmOfficerLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
