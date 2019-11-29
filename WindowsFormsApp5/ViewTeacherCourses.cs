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
    public partial class ViewTeacherCourses : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        string a;
        public ViewTeacherCourses()
        {
            InitializeComponent();
        }
        public ViewTeacherCourses(string id)
        {
            InitializeComponent();
            
            a = id;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd = new SqlCommand("SELECT atid  AS Teacher_ID, asid as STUDENTID,acid as COURSE from Assign", con);

            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();

            BindingSource source1 = new BindingSource();
            source1.DataSource = DR1;

            TeacherCourses.DataSource = source1;
            con.Close();


        }

        
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Assign";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            TeacherCourses.DataSource = dt;

            con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
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
    }
}
