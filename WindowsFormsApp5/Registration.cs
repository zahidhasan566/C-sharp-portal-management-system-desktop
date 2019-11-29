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
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlCommand cmd1;
        bool flag = false;
        bool flag1 = false;
        public Registration()
        {
            InitializeComponent();
            string[] arr = new string[3] { "HSC", "SSC", "BACHELOR" };

            comboBox1.DataSource = arr;

            string[] arr1 = new string[4] { "BSc.CSE", "BSc.Mathematics", "MSc. CSE", "MSc.Mathematics" };

            comboBox2.DataSource = arr1;

            string[] arr2 = new string[3] { "Tier-1", "Tier-2", "Tier-3" };

            comboBox3.DataSource = arr2;


        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int gen = 0;
                int nat = 99;

                if (MaleRb.Checked == true)
                {
                    gen = 1;
                }
                else if (FemaleRb.Checked == true)
                {
                    gen = 2;
                }

                nat = comboBox1.SelectedIndex;

                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");



                con.Open();
                cmd = new SqlCommand("Insert into student(sname, gender, dob, address, educatiion) values (@name, @gen, @dob1, @add, @edu)", con);
                cmd.Parameters.AddWithValue("@name", NameText.Text);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@dob1", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@add", AddressText.Text);
                cmd.Parameters.AddWithValue("@edu", nat);
                cmd.ExecuteNonQuery();
                flag = true;
                cmd = new SqlCommand("Select top 1 sid from student order by sid desc", con);
                int id = 999;
                int st = 2;
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        id = Convert.ToInt32(oReader["SID"]);
                    }
                }

                if (id != 999)
                {
                    cmd1 = new SqlCommand("Insert into Login(id, Password, Status) values (@id, @pass, @stat)", con);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.Parameters.AddWithValue("@pass", PassBox.Text);
                    cmd1.Parameters.AddWithValue("@stat", st);
                    cmd1.ExecuteNonQuery();
                }

                MessageBox.Show("Registered");
                this.Visible = false;
                Registration form = new Registration();
                form.Show();
            }
            catch (Exception ex)
            {
                

                if (flag == true)
                {
                    con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");



                    con.Open();

                    cmd = new SqlCommand("Select top 1 sid from student order by sid desc", con);
                    int id = 999;
                    //int st = 2;
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            id = Convert.ToInt32(oReader["SID"]);
                        }
                    }
                    if (id != 999)
                    {
                        cmd1 = new SqlCommand("Delete from student where sid= (@id)", con);
                        cmd1.Parameters.AddWithValue("@id", id);
                        //cmd1.Parameters.AddWithValue("@pass", PassBox.Text);
                        //cmd1.Parameters.AddWithValue("@stat", st);
                        cmd1.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Error! Invalid Input.");
                this.Hide();
                Registration a = new Registration();
                a.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void tRegBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int gen = 0;
                int nat = 99;
                int tr = 99;
                if (tMaleRb.Checked == true)
                {
                    gen = 1;
                }
                else if (tFemaleRb.Checked == true)
                {
                    gen = 2;
                }

                nat = comboBox2.SelectedIndex;
                tr = comboBox3.SelectedIndex;

                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");



                con.Open();
                cmd = new SqlCommand("Insert into teacher(tname, gender, dob, address, education, salary) values (@name, @gen, @dob1, @add, @edu, @sal)", con);
                cmd.Parameters.AddWithValue("@name", tNameBox.Text);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@dob1", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@add", tAddressBox.Text);
                cmd.Parameters.AddWithValue("@edu", nat);
                cmd.Parameters.AddWithValue("@sal", tr);
                cmd.ExecuteNonQuery();
                flag1 = true;
                cmd = new SqlCommand("Select top 1 tid from teacher order by tid desc", con);
                int id = 999;
                int st = 3;
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        id = Convert.ToInt32(oReader["TID"]);
                    }
                }

                if (id != 999)
                {
                    cmd1 = new SqlCommand("Insert into Login(id, Password, Status) values (@id, @pass, @stat)", con);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.Parameters.AddWithValue("@pass", tPassBox.Text);
                    cmd1.Parameters.AddWithValue("@stat", st);
                    cmd1.ExecuteNonQuery();
                }

                MessageBox.Show("Registered");
                this.Visible = false;
                Registration form = new Registration();
                form.Show();
            }

            catch (Exception ex)
            {
                if (flag1 == true)
                {
                    con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");



                    con.Open();

                    cmd = new SqlCommand("Select top 1 tid from teacher order by tid desc", con);
                    int id = 999;
                    //int st = 2;
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            id = Convert.ToInt32(oReader["TID"]);
                        }
                    }
                    if (id != 999)
                    {
                        cmd1 = new SqlCommand("Delete from student where sid= (@id)", con);
                        cmd1.Parameters.AddWithValue("@id", id);
                        //cmd1.Parameters.AddWithValue("@pass", PassBox.Text);
                        //cmd1.Parameters.AddWithValue("@stat", st);
                        cmd1.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Error! Invalid Input.");
                this.Hide();
                Registration a = new Registration();
                a.Show();
            }
            
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegView a = new RegView();
            a.Show();
        }
    }
}
