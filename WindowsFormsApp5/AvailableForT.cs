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
    public partial class AvailableForT : Form
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
        public AvailableForT()
        {
            InitializeComponent();
        }

        public AvailableForT(string uid)
        {
            InitializeComponent();

            id = uid;
            i = Convert.ToInt32(id);

            try
            {
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT cid from courses where SUBSTRING (cid,1,3) like (Select CASE WHEN " +
                    "Education= 1 THEN 'Mat' WHEN Education= 3 THEN 'Mat' END AS Education " +
                    "from Teacher where tid=(@data))", con1);
                cmd.Parameters.AddWithValue("@data", i);
                con1.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ch1 = 1;
                    }
                }

                if (ch1 != 99)
                {
                    this.Hide();
                    AvailableForT2 a = new AvailableForT2(id);
                    a.Show();
                }

            }
            finally
            {

            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                 "database= Course;" +
                                 "integrated security= SSPI");
            con.Open();
            int a = 0;

            if(checkBox1.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "CSE101");
                cmd.ExecuteNonQuery();
                a = 1;
            }

            if (checkBox2.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "CSE102");
                cmd.ExecuteNonQuery();
                a = 1;
            }
            if (checkBox2.Checked)
            {
                cmd = new SqlCommand("Insert into preference(pretid, precid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "CSE103");
                cmd.ExecuteNonQuery();
                a = 1;
            }
            if (a == 1)
            {
                MessageBox.Show("Submitted!");
                this.Hide();
                AvailableForT add = new AvailableForT(id);
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
