using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job.ProccessingNS;
using Job.SystemUsersNS;
using Job.Database;


namespace Job
{
    public partial class frmLogin : Form
    {
        Proccessing proccessing;
        public frmLogin()
        {
            proccessing = new Proccessing();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SystemUsers systemUsers = new SystemUsers();

            //systemUsers.UserName = txtUserName.Text;
            //systemUsers.userPassword = txtPassword.Text;

            systemUsers=proccessing.CheckUserLogin(txtUserName.Text.Trim());




        }

    
    }
}
