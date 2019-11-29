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
    public partial class DeleteStudentProfil : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        int i;
        string s;
        SqlCommand cmd;

        public DeleteStudentProfil()
        {
            InitializeComponent();
        }
        public DeleteStudentProfil(string id)
        {
            InitializeComponent();
            i = Convert.ToInt32(id);
            s = id;

        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_1 S = new Student_1(s);
            S.Show();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            con.Open();
          
            cmd = new SqlCommand("Insert into DeleteRequestByStudent(reqsid) values (@name)", con);
            cmd.Parameters.AddWithValue("@name", i);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("requested succesfully");
            con.Close();

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }
    }
}
