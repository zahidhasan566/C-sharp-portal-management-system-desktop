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
    public partial class ViewStudentInformation : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        string i;
        public ViewStudentInformation()
        {
            InitializeComponent();
        }
        public ViewStudentInformation(string id)
        {
            InitializeComponent();
            i = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tid,tname,Address from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void tBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_1 S = new Student_1(i);
            S.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
