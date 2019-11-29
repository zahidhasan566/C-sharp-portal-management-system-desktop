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
    public partial class Student_1 : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-O59KDQG\\SQLEXPRESS;Initial Catalog=Course;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"data source= rafi\SqlExpress;" +
                                  "database= Course;" +
                                  "integrated security= SSPI");
        string i;

        public Student_1()
        {
            InitializeComponent();
        }
        public Student_1(string id)
        {
          InitializeComponent();
          i = id;

        }
        private void Student_1_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login B = new Login();
            B.Show();
        }

        private void AvailableBtn_Click(object sender, EventArgs e)
        {
            
         

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where SID='" + i + "'"; 
            con.Open();

            //bool flag = false;
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {    
                while (oReader.Read())
                {
                    //string credit = oReader["Credits"].ToString();
                  int credit = Convert.ToInt32(oReader["Credits"]);

                    if (  credit.Equals( DBNull.Value))
                    {
                      
                        this.Hide();
                        Available a = new Available(i);
                        a.Show();


                    }
                    else
                    {
                        if (credit == 6)
                        {
                            this.Hide();
                            Available2 a = new Available2(i);
                            a.Show();
                        }
                        if (credit == 12)
                        {
                            this.Hide();
                            Available3 a = new Available3(i);
                            a.Show();
                        }

                    }

                }

                
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void TeacherInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherInfo T = new TeacherInfo(i);
            T.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentUpdate U = new StudentUpdate(i);
            U.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudentProfil d = new DeleteStudentProfil(i);
            d.Show();
        }

        private void CourseTakenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseTaken C = new CourseTaken(i);
            C.Show();
        }

        private void CompleteCourseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseCompleted CC = new CourseCompleted(i);
            CC.Show();
        }
    }
}
