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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            
        }
        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (PassBox.PasswordChar == '✹') PassBox.PasswordChar = '\0';
            else PassBox.PasswordChar = '✹';
        }

        private void ShowBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (PassBox.PasswordChar == '✹') PassBox.PasswordChar = '\0';
            else PassBox.PasswordChar = '✹';

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");

            

            cmd = new SqlCommand("SELECT * from login", con);
            //cmd.Parameters.AddWithValue("@idid", IdBox.Text);
            //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
            con.Open();
            bool flag = false;
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string uid = oReader["ID"].ToString();
                    string pass = oReader["Password"].ToString();
                    int stat = Convert.ToInt32(oReader["Status"]);
                    if (uid.Equals(IdBox.Text) && pass.Equals(PassBox.Text))
                    {
                        flag = true;
                        if (stat == 1)
                        {
                            this.Hide();
                            Admin a = new Admin();
                            a.Show();
                        }
                        else if (stat == 2)
                        {
                            this.Hide();
                            Student_1 a = new Student_1(uid);
                            a.Show();
                        }
                        else
                        {
                            this.Hide();
                            TeacherDashBoard a = new TeacherDashBoard(uid);
                            a.Show();
                        }
                    }
                    
                }
                if (!flag)
                {
                    MessageBox.Show("Error");
                }
            }
            
        }
    }
}
