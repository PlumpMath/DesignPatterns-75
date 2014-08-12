using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public partial class FormUserLogin : Form
    {
        private User m_LoggedInUser = null;

        public FormUserLogin()
        {
            this.InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
            SystemSounds.Exclamation.Play();
        }

        private void loginAndInit()
        {
            LoginResult loginResult = Login.login();

            if (string.IsNullOrEmpty(loginResult.ErrorMessage))
            {
                if (loginResult.LoggedInUser != null)
                {
                    this.m_LoggedInUser = loginResult.LoggedInUser;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage);
            }
        }

        private void FormUserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public User LoggedInUser
        {
            get
            {
                return this.m_LoggedInUser;
            }
        }
    }
}
