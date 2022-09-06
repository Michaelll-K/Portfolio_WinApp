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

        private void btnSaveSignUp_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Login = txtLogin.Text,
                Password = txtPassword.Text,
            };

            AccountManager am = new AccountManager();
            
        }
    }
}
