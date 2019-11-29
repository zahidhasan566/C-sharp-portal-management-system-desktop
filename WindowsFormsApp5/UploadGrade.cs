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
    public partial class UploadGrade : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        //SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-8IMUIAL\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        SqlConnection con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        SqlConnection con2 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        int i;
        string s;
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;

        public UploadGrade()
        {
            InitializeComponent();
        }
        public UploadGrade(string id)
        {
            InitializeComponent();
            i = Convert.ToInt32(id);
            s = id;
            string[] arr = new string[4] { "A", "B", "C", "F" };

            comboBox1.DataSource = arr;

            if (comboBox1.SelectedIndex == 0)
            {
                MarkBox.Text = "80";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MarkBox.Text = "70";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MarkBox.Text = "60";
            }
            else
            {
                MarkBox.Text = "60";
            }
            try
            {
                int ch1 = 99;
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT * from Grade", con1);

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
                    SqlDataReader DR1 = cmd.ExecuteReader();

                    BindingSource source1 = new BindingSource();
                    source1.DataSource = DR1;

                    dataGridView1.DataSource = source1;
                    con1.Close();
                }
            }
            finally { }
        }
       
        private void tBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDashBoard TD = new TeacherDashBoard(s);
            TD.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UploadGrade_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("Insert into Grade(gsid,gcid,grade,marks) values (@s,@c,@g,@m)", con);
           // cmd3 = new SqlCommand("select * from Grade");
            
            cmd.Parameters.AddWithValue("@s", (Convert.ToInt32(IdBox.Text)));
            cmd.Parameters.AddWithValue("@c", SubjBox.Text.ToString());
            cmd.Parameters.AddWithValue("@g", (Convert.ToInt32(comboBox1.SelectedIndex)));
            cmd.Parameters.AddWithValue("@m",(Convert.ToSingle(MarkBox.Text)));
            
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Grade uploaded  succesfully");
            int ass = Convert.ToInt32(comboBox1.SelectedIndex);
            con2.Open();

            cmd3 = new SqlCommand("Select Credits, cgpa from student where sid=(@data)", con2);
            cmd3.Parameters.AddWithValue("@data", (Convert.ToInt32(IdBox.Text)));
            int ?c=null;
            float ?g = null;
            using (SqlDataReader oReader = cmd3.ExecuteReader())
            {
                while (oReader.Read())
                {
                    if (oReader["Credits"].Equals(DBNull.Value))
                    {
                        c = null;
                    }
                    else
                    {
                        c = Convert.ToInt32(oReader["Credits"]);
                    }
                    if (oReader["cgpa"].Equals(DBNull.Value))
                    {
                        g = null;
                    }
                    else
                    {
                        g = Convert.ToSingle(oReader["cgpa"]);
                    }
                    
                }
            }

            if (c.Equals( null))
            {
                c = 0;
                c = c + 3;
            }
            else
            {
                c = c + 3;
            }

            if (g.Equals(null))
            {
                if (ass == 0)
                {
                    g = 4;
                }
                else if (ass == 1)
                {
                    g = Convert.ToSingle(3.8);
                }
                else if (ass == 2)
                {
                    g = Convert.ToSingle(3.6);
                }
                else
                {
                    g = 0;
                }
            }
            else
            {
                if (ass == 0)
                {
                    g = g-0;
                }
                else if (ass == 1)
                {
                    g = Convert.ToSingle(g-.2);
                }
                else if (ass == 2)
                {
                    g = Convert.ToSingle(g - .4);
                }
                else
                {
                    g = Convert.ToSingle(g - .8); ;
                }
            }

            //cmd1.ExecuteNonQuery();



            con.Close();

            con2.Open();

            cmd4 = new SqlCommand("Update student set Credits= (@sal), cgpa= (@edu) where sid= (@tid)", con2);
            cmd4.Parameters.AddWithValue("@tid", (Convert.ToInt32(IdBox.Text)));
            cmd4.Parameters.AddWithValue("@sal", c);
            cmd4.Parameters.AddWithValue("@edu", g);
            //cmd.Parameters.AddWithValue("@edu", nat);
            //cmd.Parameters.AddWithValue("@dob1", dateTimePicker1.Text);

            cmd4.ExecuteNonQuery();

            MessageBox.Show("Uploaded");
            this.Visible = false;
            UploadGrade form = new UploadGrade(s);
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MarkBox.Text = "80";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MarkBox.Text = "70";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MarkBox.Text = "60";
            }
            else
            {
                MarkBox.Text = "60";
            }
        }
    }
}
