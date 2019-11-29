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

    public partial class Delete : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        SqlConnection con2;
        int check1;
        int check2;
        int check3;
        int check4;
        int ch1 = 99;
        int ch2 = 99;

        public Delete()
        {
            InitializeComponent();
            
            try
            {
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT reqsid  AS Student_ID from DeleteRequestByStudent", con1);

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
                

                con2 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");
                cmd = new SqlCommand("SELECT reqtid  AS Teacher_ID from DeleteRequestByTeacher", con2);

                con2.Open();

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ch2 = 1;
                    }
                }

                
                if (ch2 != 99)
                {
                    SqlDataReader DR2 = cmd.ExecuteReader();

                    BindingSource source2 = new BindingSource();
                    source2.DataSource = DR2;

                    dataGridView2.DataSource = source2;
                }
            }
            finally
            {

            }
            //con2.Close();
        }
 
        private void TidtBox_MouseClick(object sender, MouseEventArgs e)
        {
            TidBox.Text = "";
        }

        private void SidBox_MouseClick(object sender, MouseEventArgs e)
        {
            SidBox.Text = "";
        }

        private void SDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");



                con.Open();
                
                int del = int.Parse(SidBox.Text);

                cmd = new SqlCommand("SELECT * from student where sid=(@idid)", con);
                cmd.Parameters.AddWithValue("@idid", del);
                //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
                //con.Open();
                check1 = 99;
                //check2 = 99;
                //bool flag = false;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check1 = Convert.ToInt32(oReader["sid"]);
                    }
                }
                

                cmd = new SqlCommand("SELECT * from login where id=(@idid)", con);
                cmd.Parameters.AddWithValue("@idid", del);
                //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
                //con.Open();
                check2 = 99;
                //bool flag = false;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check2 = Convert.ToInt32(oReader["id"]);
                    }
                }
                if (check1 == 99)
                {
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Delete a = new Delete();
                    a.Show();
                }
                else if (check2 == 99)
                {
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Delete a = new Delete();
                    a.Show();
                }
                if (check1 != 99 && check2 != 99)
                {
                    cmd = new SqlCommand("Delete from student where sid= (@delete)", con);
                    cmd.Parameters.AddWithValue("@delete", del);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Delete from login where id= (@delete)", con);
                    cmd.Parameters.AddWithValue("@delete", del);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted");
                    this.Hide();
                    Delete form = new Delete();
                    form.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid Format");
                this.Hide();
                Delete form = new Delete();
                form.Show();
            }
        }

        private void tBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void TDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");



                con.Open();

                int del = int.Parse(TidBox.Text);

                cmd = new SqlCommand("SELECT * from teacher where tid=(@idid)", con);
                cmd.Parameters.AddWithValue("@idid", del);
                //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
                //con.Open();
                check3 = 99;
                //check2 = 99;
                //bool flag = false;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check3 = Convert.ToInt32(oReader["tid"]);
                    }
                }


                cmd = new SqlCommand("SELECT * from login where id=(@idid)", con);
                cmd.Parameters.AddWithValue("@idid", del);
                //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
                //con.Open();
                check4 = 99;
                //bool flag = false;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check4 = Convert.ToInt32(oReader["id"]);
                    }
                }
                if (check3 == 99)
                {
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Delete a = new Delete();
                    a.Show();
                }
                else if (check4 == 99)
                {
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Delete a = new Delete();
                    a.Show();
                }
                if (check3 != 99 && check4 != 99)
                {
                    cmd = new SqlCommand("Delete from teacher where tid= (@delete)", con);
                    cmd.Parameters.AddWithValue("@delete", del);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Delete from login where id= (@delete)", con);
                    cmd.Parameters.AddWithValue("@delete", del);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted");
                    this.Hide();
                    Delete form = new Delete();
                    form.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid Format");
                this.Hide();
                Delete form = new Delete();
                form.Show();
            }
        }
    }
}
