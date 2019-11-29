using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Admin : Form
    {
        //int i;
        public Admin()
        {
            InitializeComponent();
        }

        //public Admin(int id)
        //{
          //  InitializeComponent();
          //  i = id;

        //}

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration a = new Registration();
            a.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update a = new Update();
            a.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete a = new Delete();
            a.Show();
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign a = new Assign();
            a.Show();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView a = new AdminView();
            a.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings a = new Settings();
            a.Show();
        }
    }
}
