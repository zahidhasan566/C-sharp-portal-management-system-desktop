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
    public partial class Available3 : Form
    {
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        int i;
        string s;
        SqlCommand cmd;
        SqlCommand cmd1;
        public Available3()
        {
            InitializeComponent();
        }
        public Available3(string id)
        {
            InitializeComponent();
            i = Convert.ToInt32(id);
            s = id;


        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_1 S = new Student_1(s);
            S.Show();
        }

        private void Available3_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if ((Cse3.Checked && Math3.Checked) || (Math3.Checked && Cse3.Checked))
            {


                con.Open();
                cmd = new SqlCommand("Insert into RequestCourse(reqsid, reqcid) values (@name, @gen)", con);
                cmd1 = new SqlCommand("Insert into RequestCourse(reqsid, reqcid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "CSE103");
                cmd1.Parameters.AddWithValue("@name", i);
                cmd1.Parameters.AddWithValue("@gen", "Maths103");
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                con.Close();
            }



            if (Cse3.Checked && Math3.Checked)
            {
                MessageBox.Show("Confirmed request");
            }
            
        }
    }
}
