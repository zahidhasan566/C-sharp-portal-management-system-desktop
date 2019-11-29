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
    public partial class DeleteTeacherAccount : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        int i;
        string s;
        SqlCommand cmd;
        public DeleteTeacherAccount()
        {
            //InitializeComponent();
        }
        public  DeleteTeacherAccount(string id)
        {
            InitializeComponent();
            i = Convert.ToInt32(id);
            s = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("Insert into DeleteRequestByTeacher(reqtid) values (@name)", con);
            cmd.Parameters.AddWithValue("@name", i);

            cmd.ExecuteNonQuery();
            MessageBox.Show("requested succesfully");
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDashBoard B =new TeacherDashBoard(s);
            B.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}
