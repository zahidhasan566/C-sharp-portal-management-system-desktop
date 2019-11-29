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
    public partial class StudentInfo : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        string a;
        
        public StudentInfo()
        {
            InitializeComponent();
        }
        public StudentInfo(string id)
        {
            InitializeComponent();
            a = id;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("select * from student where sid= (Select asid from Assign where atid=1904)", con);

            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();

            BindingSource source1 = new BindingSource();
            source1.DataSource = DR1;

            StudentCourses.DataSource = source1;
            display();
            con.Close();



        }

        private void tBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDashBoard TD = new TeacherDashBoard(a);
            TD.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void StudentCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }
        public void display()
        {
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            StudentCourses.DataSource = dt;
            con.Close();*/

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
