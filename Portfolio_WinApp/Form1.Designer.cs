namespace Portfolio_WinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tInfo = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPortfolio = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxMichal = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbxChat = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMichal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).BeginInit();
            this.SuspendLayout();
            // 
            // tInfo
            // 
            this.tInfo.Interval = 75;
            this.tInfo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Portfolio_WinApp.Properties.Resources.cross;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1057, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = global::Portfolio_WinApp.Properties.Resources._3175;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.lblPortfolio);
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Controls.Add(this.lblInfo);
            this.panelMain.Controls.Add(this.pbxChat);
            this.panelMain.Location = new System.Drawing.Point(0, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1101, 542);
            this.panelMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 74);
            this.label1.TabIndex = 11;
            this.label1.Text = "Michał Kordos\r\nbackend developer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortfolio
            // 
            this.lblPortfolio.AutoSize = true;
            this.lblPortfolio.Font = new System.Drawing.Font("Brush Script Std", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortfolio.Location = new System.Drawing.Point(3, 41);
            this.lblPortfolio.Name = "lblPortfolio";
            this.lblPortfolio.Size = new System.Drawing.Size(366, 101);
            this.lblPortfolio.TabIndex = 10;
            this.lblPortfolio.Text = "Portfolio";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelInfo.Location = new System.Drawing.Point(936, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(165, 542);
            this.panelInfo.TabIndex = 9;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLogin.Controls.Add(this.txtLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.pbxMichal);
            this.panelLogin.Location = new System.Drawing.Point(370, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(570, 542);
            this.panelLogin.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(67, 290);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(429, 43);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Tag = "Enter your login";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtPassword.Location = new System.Drawing.Point(67, 376);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(429, 43);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(177, 250);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(215, 37);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Enter your login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(156, 336);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(269, 37);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Enter your password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxMichal
            // 
            this.pbxMichal.BackColor = System.Drawing.Color.Transparent;
            this.pbxMichal.Image = global::Portfolio_WinApp.Properties.Resources.user;
            this.pbxMichal.Location = new System.Drawing.Point(163, 53);
            this.pbxMichal.Name = "pbxMichal";
            this.pbxMichal.Size = new System.Drawing.Size(257, 194);
            this.pbxMichal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMichal.TabIndex = 4;
            this.pbxMichal.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Malgun Gothic", 30F);
            this.lblInfo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblInfo.Location = new System.Drawing.Point(36, 290);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 206);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Sign in \r\nto see \r\nmy portfolio!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxChat
            // 
            this.pbxChat.BackColor = System.Drawing.Color.Transparent;
            this.pbxChat.Image = global::Portfolio_WinApp.Properties.Resources.box;
            this.pbxChat.Location = new System.Drawing.Point(24, 273);
            this.pbxChat.Name = "pbxChat";
            this.pbxChat.Size = new System.Drawing.Size(326, 236);
            this.pbxChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChat.TabIndex = 6;
            this.pbxChat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Michał Kordos - Portfolio_WinApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMichal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbxMichal;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbxChat;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer tInfo;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPortfolio;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelLogin;
    }
}

