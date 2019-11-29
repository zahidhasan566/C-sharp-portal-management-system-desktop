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
    public partial class Assign : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        SqlConnection con2;
        int ch1=99;
        int ch2=99;
        int ch3 = 99;
        public Assign()
        {
            InitializeComponent();

            try
            {
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                        "database= Course;" +
                                        "integrated security= SSPI");
                cmd = new SqlCommand("SELECT pretid  AS TEACHER_ID, PreCid as COURSE_ID from Preference", con1);

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
                cmd = new SqlCommand("SELECT reqsid  AS STUDENT_ID, ReqCid as COURSE_ID from RequestCourse", con2);

                con2.Open();

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ch2 = 2;
                    }
                }


                if (ch2 != 99)
                {
                    SqlDataReader DR2 = cmd.ExecuteReader();

                    BindingSource source2 = new BindingSource();
                    source2.DataSource = DR2;

                    dataGridView2.DataSource = source2;
                }

                ////
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");
                cmd = new SqlCommand("SELECT asid  AS STUDENT_ID, acid as TEACHER_ID, aCid as COURSE_ID from Assign", con);

                con.Open();

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ch3 = 3;
                    }
                }


                if (ch3 != 99)
                {
                    SqlDataReader DR3 = cmd.ExecuteReader();

                    BindingSource source3 = new BindingSource();
                    source3.DataSource = DR3;

                    dataGridView3.DataSource = source3;
                }

            }
            finally
            {

            }
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                string aci = "Null";
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                          "database= Course;" +
                                          "integrated security= SSPI");

                cmd = new SqlCommand("SELECT reqcid  from requestcourse r1 join preference p1 on r1.reqcid = p1.precid" +
                    " where r1.reqsid=(@rs) and p1.pretid=(@ps)", con);
                cmd.Parameters.AddWithValue("@rs", Convert.ToInt32(SidBox.Text));
                cmd.Parameters.AddWithValue("@ps", Convert.ToInt32(TidBox.Text));

                con.Open();

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        flag = 1;
                        //aci = oReader["reqcid"].ToString();
                    }
                }
                if (flag == 0)
                {
                    MessageBox.Show("Error! Mismatched Preference and Selected Courses.");
                    this.Hide();
                    Assign a = new Assign();
                    a.Show();
                }
                else
                {
                    con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                          "database= Course;" +
                                          "integrated security= SSPI");


                    aci = CidBox.Text.ToString();
                    con1.Open();
                    cmd = new SqlCommand("Insert into assign(asid, atid, acid) values (@as, @at, @ac)", con1);
                    cmd.Parameters.AddWithValue("@as", Convert.ToInt32(SidBox.Text));
                    cmd.Parameters.AddWithValue("@at", Convert.ToInt32(TidBox.Text));
                    cmd.Parameters.AddWithValue("@ac", aci);
                    //cmd.Parameters.AddWithValue("@add", AddressText.Text);
                    //cmd.Parameters.AddWithValue("@edu", nat);
                    cmd.ExecuteNonQuery();

                    con2 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");



                    con2.Open();

                    int del = int.Parse(SidBox.Text);

                    cmd = new SqlCommand("Delete from requestcourse where reqsid= (@delete) and reqcid=(@data)", con2);
                    cmd.Parameters.AddWithValue("@delete", del);
                    cmd.Parameters.AddWithValue("@data", aci);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Assigned");
                    this.Hide();
                    Assign form = new Assign();
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid Format.");
                this.Hide();
                Assign form = new Assign();
                form.Show();
            }
            
        }

        private void TidBox_MouseClick(object sender, MouseEventArgs e)
        {
            TidBox.Text = "";
        }

        private void SidBox_MouseClick(object sender, MouseEventArgs e)
        {
            SidBox.Text = "";
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

        private void CidBox_MouseClick(object sender, MouseEventArgs e)
        {
            CidBox.Text = "";
        }
    }
}
