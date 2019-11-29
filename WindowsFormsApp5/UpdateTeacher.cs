using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class UpdateTeacher : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");



        int i;
        string a;
        public UpdateTeacher()
        {
            InitializeComponent();
        }
        public UpdateTeacher(string id)
        {
            InitializeComponent();
            i =Convert.ToInt32(id);
            a = id;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd = new SqlCommand("SELECT tid  AS Teacher_ID, tname as Name,CASE WHEN gender= 0 THEN 'Male' ELSE 'Female' END AS Gender, address as Address, CASE WHEN Education= 0 THEN 'BSc.CSE' WHEN Education= 1 THEN 'BSc.Mathematics' WHEN Education= 2 THEN 'MSc.CSE' ELSE 'MSc.Mathematics' END AS Education, " +
                    "Case when Salary=0 then'40000' when Salary=1 then '50000' else '60000' end as Salary from Teacher", con);

            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();

            BindingSource source1 = new BindingSource();
            source1.DataSource = DR1;

            dataGridViewTeacher.DataSource = source1;
            con.Close();


        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDashBoard T = new TeacherDashBoard(a);
            T.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("Update teacher set address= (@add),tname =(@name) where tid = (@data)", con);

            cmd.Parameters.AddWithValue("@data", i);
            cmd.Parameters.AddWithValue("@add", textAddress.Text.ToString());
            cmd.Parameters.AddWithValue("@name", textName.Text.ToString());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Updated!");
            this.Hide();
            UpdateTeacher asa = new UpdateTeacher(a);
            asa.Show();

        }

        public void displayData()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Teacher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewTeacher.DataSource = dt;
            con.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTeacher_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}
