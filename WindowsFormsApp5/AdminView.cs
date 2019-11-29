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
    public partial class AdminView : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection con1;
        int useid = 0;
        int ch1 = 99;
        int ch2 = 99;
        public AdminView()
        {
            InitializeComponent();
            
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

                    dataGridView2.DataSource = source1;
                    con1.Close();
                }
                //////////////////////////////////////////////
                ///
                con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
                cmd = new SqlCommand("SELECT sid  AS Student_ID, sname as Name,CASE WHEN gender= 0 THEN 'Male' ELSE 'Female' END AS Gender, address as Address, CASE WHEN Educatiion= 0 THEN 'SSC' WHEN Educatiion= 1 THEN 'HSC' ELSE 'BACHELOR' END AS Education, " +
                    "cgpa As CGPA, Credits as Credits_Completed, DOB as Date_Of_Birth from Student", con);

                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ch2 = 1;
                    }
                }

                if (ch2 != 99)
                {
                    SqlDataReader DR1 = cmd.ExecuteReader();

                    BindingSource source1 = new BindingSource();
                    source1.DataSource = DR1;

                    dataGridView1.DataSource = source1;
                    con.Close();
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
    }
}
