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
    public partial class Settings : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        SqlConnection con2;
        int ch1 = 99;
        int check1;
        int check2;
        public Settings()
        {
            InitializeComponent();

            string[] arr1 = new string[2] { "1", "3"};

            CreditsComboBox.DataSource = arr1;

            try
            {
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT cid as ID, cname as Course_Name, credits as Credits, prereq as Prerequisite from courses", con1);

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
                    dataGridView2.DataSource = source1;
                    con1.Close();
                }
  
            }
            finally
            {

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

        private void DeleteBox_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteBox.Text = "";
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string a;
                int check1 = 99;
                int check2 = 99;

                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT cid from courses where cid=(@data)", con1);
                cmd.Parameters.AddWithValue("@data", PrevBox.Text.ToString());
                con1.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check1 = 1;
                    }
                }

                con2 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT cid from courses where cid=(@data)", con2);
                cmd.Parameters.AddWithValue("@data", LatestBox.Text.ToString());
                con2.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check2 = 1;
                    }
                }
                if (LatestBox.Text.ToString().Equals("Null") || LatestBox.Text.ToString().Equals("NULL") || LatestBox.Text.ToString().Equals("null"))
                {
                    check2 = 1;
                }

                //
                if (check1 == 1 && check2 == 1)
                {
                    con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");

                    con.Open();

                    //if (LatestBox.Text.ToString().Equals("Null") || LatestBox.Text.ToString().Equals("NULL") || LatestBox.Text.ToString().Equals("null"))
                    //{
                      //  a = DBNull.Value;
                    //}
                    //else
                    //{
                      //  a = LatestBox.Text.ToString();
                    //}

                    cmd = new SqlCommand("Update courses set prereq = (@pre) where cid= (@course)", con);

                    //cmd.Parameters.AddWithValue("@pre", a);
                    cmd.Parameters.AddWithValue("@course", PrevBox.Text.ToString());
                    if (LatestBox.Text.ToString().Equals("Null") || LatestBox.Text.ToString().Equals("NULL") || LatestBox.Text.ToString().Equals("null"))
                    {
                        cmd.Parameters.AddWithValue("@pre", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pre", LatestBox.Text.ToString());
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Set!");
                    this.Visible = false;
                    Settings form = new Settings();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Missing!");
                    this.Visible = false;
                    Settings form = new Settings();
                    form.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid or Missing Text");
                this.Visible = false;
                Settings form = new Settings();
                form.Show();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int check1 = 99;
                string a;
                int nat = 99;
                int ass;
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                      "database= Course;" +
                                      "integrated security= SSPI");
                cmd = new SqlCommand("SELECT cid from courses where cid=(@data)", con1);
                cmd.Parameters.AddWithValue("@data", PrereqBox.Text.ToString());
                con1.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        check1 = 1;
                    }

                    if (PrereqBox.Text.ToString().Equals("Null") || PrereqBox.Text.ToString().Equals("NULL") || PrereqBox.Text.ToString().Equals("null"))
                    {
                        check1 = 1;
                    }

                    if (check1 == 1)
                    {
                        /*if (PrereqBox.Text.ToString().Equals("Null") || PrereqBox.Text.ToString().Equals("NULL") || PrereqBox.Text.ToString().Equals("null"))
                        {
                            a = "";
                        }
                        else
                        {
                            a = PrereqBox.Text.ToString();
                        }*/

                        nat = CreditsComboBox.SelectedIndex;

                        if (nat == 0)
                        {
                            ass = 1;
                        }
                        else
                        {
                            ass = 3;
                        }

                        con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                          "database= Course;" +
                                          "integrated security= SSPI");



                        con.Open();
                        cmd = new SqlCommand("Insert into courses(cid, cname, credits, prereq) values (@course, @name, @cre, @pre)", con);
                        cmd.Parameters.AddWithValue("@course", CidBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@name", NameBox.Text.ToString());
                        cmd.Parameters.AddWithValue("@cre", ass);
                        if (PrereqBox.Text.ToString().Equals("Null") || PrereqBox.Text.ToString().Equals("NULL") || PrereqBox.Text.ToString().Equals("null"))
                        {
                            cmd.Parameters.AddWithValue("@pre", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@pre", PrereqBox.Text.ToString());
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Added!");
                        this.Visible = false;
                        Settings form = new Settings();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Missing!");
                        this.Visible = false;
                        Settings form = new Settings();
                        form.Show();
                    }
                }
            }
            
           
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Missing! Invalid Input");
                this.Visible = false;
                Settings form = new Settings();
                form.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Added!2");
                this.Visible = false;
                Settings form = new Settings();
                form.Show();
            }

        }

        private void SDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");



                con.Open();

                string del = DeleteBox.Text.ToString();

                cmd = new SqlCommand("SELECT cid from courses where cid=(@idid)", con);
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
                        check1 = 1;
                    }
                }

                
                if (check1 == 99)
                {
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Settings a = new Settings();
                    a.Show();
                }
                
                if (check1 != 99)
                {
                    cmd = new SqlCommand("Delete from courses where cid= (@delete)", con);
                    cmd.Parameters.AddWithValue("@delete", del);

                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Deleted");
                    this.Hide();
                    Settings form = new Settings();
                    form.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid Format");
                this.Hide();
                Settings form = new Settings();
                form.Show();
            }
        }
    }
}
