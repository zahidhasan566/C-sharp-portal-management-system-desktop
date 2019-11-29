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
    public partial class Available2 : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        int i;
        string s;
        SqlCommand cmd;
        SqlCommand cmd1;
        public Available2()
        {
           
            InitializeComponent();
        }
        public Available2(string id)
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

        private void Available2_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if ((Cse2.Checked && Math2.Checked) || (Math2.Checked && Cse2.Checked))
            {


                con.Open();
                cmd = new SqlCommand("Insert into RequestCourse(reqsid, reqcid) values (@name, @gen)", con);
                cmd1 = new SqlCommand("Insert into RequestCourse(reqsid, reqcid) values (@name, @gen)", con);
                cmd.Parameters.AddWithValue("@name", i);
                cmd.Parameters.AddWithValue("@gen", "CSE102");
                cmd1.Parameters.AddWithValue("@name", i);
                cmd1.Parameters.AddWithValue("@gen", "Maths102");
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                con.Close();
            }
            if (Cse2.Checked && Math2.Checked)
            {
                MessageBox.Show("Confirmed request");
            }


        }
    }
}
