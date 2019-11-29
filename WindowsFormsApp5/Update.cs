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
    public partial class Update : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        int useid = 0;
        int ch1 = 99;
        int check = 99;
        int nosearch = 99;
        public Update()
        {
            InitializeComponent();

            string[] arr1 = new string[4] { "BSc.CSE", "BSc.Mathematics", "MSc. CSE", "MSc.Mathematics" };

            EduComboBox.DataSource = arr1;

            string[] arr2 = new string[3] { "Tier-1", "Tier-2", "Tier-3" };

            SalComboBox.DataSource = arr2;

            try
            {
                con1 = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT tid  AS Teacher_ID, tname as Name,CASE WHEN gender= 0 THEN 'Male' ELSE 'Female' END AS Gender, address as Address, CASE WHEN Education= 0 THEN 'BSc.CSE' WHEN Education= 1 THEN 'BSc.Mathematics' WHEN Education= 2 THEN 'MSc.CSE' ELSE 'MSc.Mathematics' END AS Education, " +
                    "Case when Salary=0 then'40000' when Salary=1 then '50000' else '60000' end as Salary from Teacher", con1);

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
            finally
            {

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                
                cmd = new SqlCommand("SELECT * from teacher where tid=(@idid)", con);
                cmd.Parameters.AddWithValue("@idid", IdBox.Text);
                //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
                con.Open();
                int i = 99;
                //bool flag = false;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        NameBox.Text = oReader["tname"].ToString();
                        
                        SalComboBox.SelectedIndex= Convert.ToInt32(oReader["salary"]);
                        EduComboBox.SelectedIndex = Convert.ToInt32(oReader["education"]);
                        i= Convert.ToInt32(oReader["salary"]);
                        check = 1;
                        dateTimePicker1.Text= oReader["dob"].ToString();
                    }
                }
                if(i==99)
                {
                    nosearch = 1;
                    MessageBox.Show("Error! Not Found");
                    this.Hide();
                    Update a = new Update();
                    a.Show();
                }
                useid =Convert.ToInt32(IdBox.Text);
            }
            catch (Exception ex)
            {
                if (nosearch == 99)
                {
                    MessageBox.Show("Error! Invalid Input");
                    this.Hide();
                    Update a = new Update();
                    a.Show();
                }
                
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                try
                {
                    int nat = 99;
                    int sal = 99;


                    nat = EduComboBox.SelectedIndex;
                    sal = SalComboBox.SelectedIndex;

                    con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                          "database= Course;" +
                                          "integrated security= SSPI");

                    con.Open();

                    cmd = new SqlCommand("Update teacher set salary= (@sal), education= (@edu), dob= (@dob1) where tid= (@tid)", con);

                    cmd.Parameters.AddWithValue("@tid", useid);
                    cmd.Parameters.AddWithValue("@sal", sal);
                    cmd.Parameters.AddWithValue("@edu", nat);
                    cmd.Parameters.AddWithValue("@dob1", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                    this.Visible = false;
                    Update form = new Update();
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Invalid or Missing Text");
                    this.Visible = false;
                    Update form = new Update();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Error! Search First");
                this.Hide();
                Update a = new Update();
                a.Show();
            }
        }
    }
}
