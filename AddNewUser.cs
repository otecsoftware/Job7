using Job.SystemUsersNS;
using Job.ProccessingNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Job
{
    public partial class frmAddNewUser : Form
    {
        Proccessing proccessing;
        public frmAddNewUser()
        {
       
      
            InitializeComponent();
          
            proccessing = new Proccessing();
            cboUserType.Items.AddRange(new object[] { "DTA Data Capture", "STE Site Agent / Engineer", "SPU Super User" });
            txtAddNewUserSurname.Focus();
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAddNewUserSurname.Text))
            {
                MessageBox.Show("Please enter your surname");
            }
            else
            {
                string comboBoxValue = cboUserType.SelectedItem.ToString();

                string surname = txtAddNewUserSurname.Text;

                string generatedUserName = comboBoxValue.Substring(0, 3) + surname;

                txtAddNewUser.Text = generatedUserName;
            }






        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {

            SystemUsers systemUsers = new SystemUsers();
            systemUsers.UserName = txtAddNewUser.Text;
            systemUsers.userPassword = txtAddNewUserPassword.Text;

            string ConfirmUserPassword = txtConfirmPassword.Text;

            if (systemUsers.userPassword != ConfirmUserPassword)
            {

                MessageBox.Show("Please make sure Password is the same as above");
            }
            else {

                proccessing.AddSystemUserDatabase(systemUsers);
            }

            
        }
    }
}

