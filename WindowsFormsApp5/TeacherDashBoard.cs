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

namespace WindowsFormsApp5
{
    public partial class TeacherDashBoard : Form
    {
        string uid;
        public TeacherDashBoard()
        {
            InitializeComponent();
        }

        public TeacherDashBoard(string id)
        {
            InitializeComponent();

            uid = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteTeacherAccount B = new DeleteTeacherAccount(uid);
            B.Show();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTeacher UT = new UpdateTeacher(uid);
            UT.Show();
        }

        private void VIEWTEACHERCOURSESBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTeacherCourses VTC = new ViewTeacherCourses(uid);
            VTC.Show();
        }

        private void StudentInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentInfo SI = new StudentInfo(uid);
            SI.Show();
            

        }

        private void UploadGradeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadGrade UG = new UploadGrade(uid);
            UG.Show();
        }

        private void AvailableBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableForT UG = new AvailableForT(uid);
            UG.Show();
        }
    }
}
