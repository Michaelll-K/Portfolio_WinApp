using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portfolio_WinApp.Controls;

namespace Portfolio_WinApp
{
    public partial class Form1 : Form
    {
        private string text;
        private int len = 0;

        private bool drag;
        private int down;
        private int up;
        public Form1()
        {
            InitializeComponent();
        }

        private SignUpControl signUp;

        private void AddControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            control.Visible = false;
            panelMain.Controls.Add(control);
            control.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Info animation
            text = lblInfo.Text;
            lblInfo.Text = "";
            tInfo.Start();

            //Adding hiden views
            signUp = new SignUpControl();
            AddControl(signUp);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblInfo.Text = lblInfo.Text + text.ElementAt(len);
                len++;
            }
            else
                tInfo.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                down = e.X;
                up = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point temp = new Point();
                temp.X = Location.X + (e.X - down);
                temp.Y = Location.Y + (e.Y - up);
                Location = temp;
                temp = Point.Empty;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            signUp.Visible = false;
        }
    }
}
