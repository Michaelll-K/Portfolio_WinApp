using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio_WinApp
{
    public partial class Form1 : Form
    {
        private string text;
        private int len = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text = lblInfo.Text;
            lblInfo.Text = "";
            tInfo.Start();
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
    }
}
