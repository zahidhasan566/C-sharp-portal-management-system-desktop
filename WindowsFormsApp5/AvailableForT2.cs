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
    public partial class AvailableForT2 : Form
    {
        string id;
        int i;
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        int useid = 0;
        int ch1 = 99;
        int check = 99;
        int nosearch = 99;
        public AvailableForT2(string uid)
        {
            InitializeComponent();

            id = uid;
            i = Convert.ToInt32(id);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                 "database= Course;" +
                                 "integrated security= SSPI");
            con.Open();
            int a = 0;

            if (checkBox1.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "Maths101");
                cmd.ExecuteNonQuery();
                a = 1;
            }

            if (checkBox2.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "Maths102");
                cmd.ExecuteNonQuery();
                a = 1;
            }
            if (checkBox2.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "Maths103");
                cmd.ExecuteNonQuery();
                a = 1;
            }
            if (a == 1)
            {
                MessageBox.Show("Submitted!");
                this.Hide();
                AvailableForT2 add = new AvailableForT2(id);
                add.Show();
            }
        }

        private void tBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDashBoard a = new TeacherDashBoard(id);
            a.Show();

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}
