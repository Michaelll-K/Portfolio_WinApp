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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxChat = new System.Windows.Forms.PictureBox();
            this.pbxMichal = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMichal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.lblInfo);
            this.panelMain.Controls.Add(this.pbxChat);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.pbxMichal);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.lblLogin);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.txtLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1101, 573);
            this.panelMain.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Orator Std", 20F);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(415, 336);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(271, 36);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Enter your login";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtPassword.Location = new System.Drawing.Point(336, 488);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(429, 43);
            this.txtPassword.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(336, 376);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(429, 43);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Tag = "Enter your login";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Orator Std", 20F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(391, 449);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(319, 36);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Enter your password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Orator Std", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(321, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(459, 142);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Michał Kordos\r\nPortfolio";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxChat
            // 
            this.pbxChat.BackColor = System.Drawing.Color.Transparent;
            this.pbxChat.Image = global::Portfolio_WinApp.Properties.Resources.chat;
            this.pbxChat.Location = new System.Drawing.Point(198, 90);
            this.pbxChat.Name = "pbxChat";
            this.pbxChat.Size = new System.Drawing.Size(184, 136);
            this.pbxChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChat.TabIndex = 6;
            this.pbxChat.TabStop = false;
            // 
            // pbxMichal
            // 
            this.pbxMichal.BackColor = System.Drawing.Color.Transparent;
            this.pbxMichal.Image = global::Portfolio_WinApp.Properties.Resources.Michał;
            this.pbxMichal.Location = new System.Drawing.Point(425, 139);
            this.pbxMichal.Name = "pbxMichal";
            this.pbxMichal.Size = new System.Drawing.Size(257, 194);
            this.pbxMichal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMichal.TabIndex = 4;
            this.pbxMichal.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Orator Std", 15F);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Image = global::Portfolio_WinApp.Properties.Resources.chat;
            this.lblInfo.Location = new System.Drawing.Point(205, 101);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(168, 81);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Sing in \r\nto see \r\nmy portfolio!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Michał Kordos - Portfolio_WinApp";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMichal)).EndInit();
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
    }
}

