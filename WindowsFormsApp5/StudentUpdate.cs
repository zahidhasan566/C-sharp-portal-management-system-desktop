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
    public partial class StudentUpdate : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        string i;
        public StudentUpdate()
        {
            InitializeComponent();
        }
        public StudentUpdate(string id)
        {
            InitializeComponent();
            i = id;

        }
        public void disp_data2()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select SID as STUDENT_ID,SName as STUDENT_NAME,Gender as GENDER ,Address as ADRESS,Credits as CREDIT,Educatiion as EDUCATION,cgpa as CGPA  from Student where SID='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            disp_data2();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_1 S = new Student_1(i);
            S.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Student set Address='" + profilTextBox.Text + "' where SID='" + i + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated succesfully");
           
            
            con.Close();
            disp_data2();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void PassChngBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
           
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "update Login set Password='" + PassTextBox.Text + "' where ID='" + i+ "'";
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password Change succesfully");
            con.Close();
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
