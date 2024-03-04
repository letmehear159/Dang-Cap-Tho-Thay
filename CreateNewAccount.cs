using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Final_Project
{
    public partial class CreateNewAccount : Form
    {
        //Login _login;
        public CreateNewAccount()
        {
            InitializeComponent();
        }
        //public CreateNewAccount(Login login)
        //{
        //    InitializeComponent();
        //    _db = new LibraryEntities();
        //    _login = login;
        //}


        private void btnSubmit_Click(object sender, EventArgs e)
        {



        }
        private void CreateNewAccount_Load(object sender, EventArgs e)
        {



        }


        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var login = new Login();
            //login.Show();
            //this.Hide();
            ////Hide the current form and open new login form
        }

        private void CreateNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_login.Close();
        }
    }
}
