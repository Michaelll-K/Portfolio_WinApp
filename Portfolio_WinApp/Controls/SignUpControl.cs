using Portfolio_WinApp.Models;
using Portfolio_WinApp.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio_WinApp.Controls
{
    public partial class SignUpControl : UserControl
    {
        private AccountManager accountManager = new AccountManager();
        private LoginManager loginManager = new LoginManager();

        private int image = 0;
        public SignUpControl()
        {
            InitializeComponent();
        }

        private string text;
        private int len = 0;

        private void SignUpControl_Load(object sender, EventArgs e)
        {
            //text animation
            text = lblInfo.Text;
            lblInfo.Text = "";
            tInfo.Start();
        }

        private void tInfo_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblInfo.Text = lblInfo.Text + text.ElementAt(len);
                len++;
            }
            else
                tInfo.Stop();
        }

        private void rbtImage1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                image = 0;
        }

        private void rbtImage2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                image = 1;
        }

        private void rbtImage3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                image = 2;
        }

        private void rbtImage4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                image = 3;
        }
        private void btnSaveSignUp_Click(object sender, EventArgs e)
        {
            lblErrorPassword.Text = "";
            lblErrorRepeat.Text = "";
            lblErrorLogin.Text = "";
            lblErrorExist.Text = "";

            if (txtLogin.Text != "" && txtPassword.Text != "" && txtPassword.Text == txtRepeatPassword.Text)
            {
                if (loginManager.CheckIfNotExists(txtLogin.Text, accountManager.Accounts))
                {
                    Account account = new Account()
                    {
                        Login = txtLogin.Text,
                        Password = txtPassword.Text,
                        Image = image,
                        LoginCount = 0
                    };

                    accountManager.AddAccount(account);

                    Hide();
                }
                else
                {
                    lblErrorExist.Text = "User with that login already exist";
                }

            }
            else if (txtLogin.Text != "" && txtPassword.Text != "")
            {
                lblErrorRepeat.Text = "Check your repeted password";
            } 
            else if (txtLogin.Text != "")
            {
                lblErrorPassword.Text = "Password can't be empty";
            } 
            else
            {
                lblErrorLogin.Text = "Login can't be empty";
            }


            
        }
    }
}
