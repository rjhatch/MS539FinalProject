using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539FinalProject
{
    public partial class LoginForm : Form
    {
        private GymSoftwareForm gymSoftwareForm;
        public LoginForm(GymSoftwareForm parentForm)
        {
            InitializeComponent();
            gymSoftwareForm = parentForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Find out if there person's username and password match.
            if (gymSoftwareForm.programManager.LogIn(tbUsername.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gymSoftwareForm.UpdateGUI();
        }
    }
}
