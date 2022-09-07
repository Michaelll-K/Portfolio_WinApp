namespace Portfolio_WinApp.Controls
{
    partial class SignUpControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMichal = new System.Windows.Forms.Label();
            this.lblPortfolio = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tInfo = new System.Windows.Forms.Timer(this.components);
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.btnSaveSignUp = new System.Windows.Forms.Button();
            this.pbxChat = new System.Windows.Forms.PictureBox();
            this.rbtImage1 = new System.Windows.Forms.RadioButton();
            this.rbtImage2 = new System.Windows.Forms.RadioButton();
            this.rbtImage3 = new System.Windows.Forms.RadioButton();
            this.rbtImage4 = new System.Windows.Forms.RadioButton();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorRepeat = new System.Windows.Forms.Label();
            this.lblErrorExist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMichal
            // 
            this.lblMichal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMichal.AutoSize = true;
            this.lblMichal.BackColor = System.Drawing.Color.Transparent;
            this.lblMichal.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblMichal.ForeColor = System.Drawing.Color.Black;
            this.lblMichal.Location = new System.Drawing.Point(61, 142);
            this.lblMichal.Name = "lblMichal";
            this.lblMichal.Size = new System.Drawing.Size(249, 74);
            this.lblMichal.TabIndex = 15;
            this.lblMichal.Text = "Michał Kordos\r\nbackend developer";
            this.lblMichal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortfolio
            // 
            this.lblPortfolio.AutoSize = true;
            this.lblPortfolio.Font = new System.Drawing.Font("Brush Script Std", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortfolio.Location = new System.Drawing.Point(3, 41);
            this.lblPortfolio.Name = "lblPortfolio";
            this.lblPortfolio.Size = new System.Drawing.Size(366, 101);
            this.lblPortfolio.TabIndex = 14;
            this.lblPortfolio.Text = "Portfolio";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Malgun Gothic", 23F);
            this.lblInfo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblInfo.Location = new System.Drawing.Point(36, 283);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 218);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Sign up!\r\nCreate your own account\r\nthat will be saved in database";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tInfo
            // 
            this.tInfo.Interval = 50;
            this.tInfo.Tick += new System.EventHandler(this.tInfo_Tick);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(419, 142);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(358, 43);
            this.txtLogin.TabIndex = 16;
            this.txtLogin.Tag = "Enter your login";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtPassword.Location = new System.Drawing.Point(419, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 43);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(480, 102);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(230, 37);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Create your login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(459, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(284, 37);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Create your password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtRepeatPassword.Location = new System.Drawing.Point(419, 314);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(358, 43);
            this.txtRepeatPassword.TabIndex = 20;
            this.txtRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRepeat
            // 
            this.lblRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeat.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblRepeat.ForeColor = System.Drawing.Color.Black;
            this.lblRepeat.Location = new System.Drawing.Point(459, 274);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(289, 37);
            this.lblRepeat.TabIndex = 21;
            this.lblRepeat.Text = "Repeat your password";
            this.lblRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveSignUp
            // 
            this.btnSaveSignUp.BackColor = System.Drawing.Color.Coral;
            this.btnSaveSignUp.FlatAppearance.BorderSize = 0;
            this.btnSaveSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSignUp.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.btnSaveSignUp.Image = global::Portfolio_WinApp.Properties.Resources.right_arrows;
            this.btnSaveSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSignUp.Location = new System.Drawing.Point(482, 402);
            this.btnSaveSignUp.Name = "btnSaveSignUp";
            this.btnSaveSignUp.Size = new System.Drawing.Size(261, 71);
            this.btnSaveSignUp.TabIndex = 22;
            this.btnSaveSignUp.Text = "Sign up!";
            this.btnSaveSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSignUp.UseVisualStyleBackColor = false;
            this.btnSaveSignUp.Click += new System.EventHandler(this.btnSaveSignUp_Click);
            // 
            // pbxChat
            // 
            this.pbxChat.BackColor = System.Drawing.Color.Transparent;
            this.pbxChat.Image = global::Portfolio_WinApp.Properties.Resources.box;
            this.pbxChat.Location = new System.Drawing.Point(24, 273);
            this.pbxChat.Name = "pbxChat";
            this.pbxChat.Size = new System.Drawing.Size(326, 236);
            this.pbxChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChat.TabIndex = 12;
            this.pbxChat.TabStop = false;
            // 
            // rbtImage1
            // 
            this.rbtImage1.AutoSize = true;
            this.rbtImage1.Checked = true;
            this.rbtImage1.Location = new System.Drawing.Point(927, 142);
            this.rbtImage1.Name = "rbtImage1";
            this.rbtImage1.Size = new System.Drawing.Size(60, 17);
            this.rbtImage1.TabIndex = 23;
            this.rbtImage1.TabStop = true;
            this.rbtImage1.Text = "Image1";
            this.rbtImage1.UseVisualStyleBackColor = true;
            this.rbtImage1.CheckedChanged += new System.EventHandler(this.rbtImage1_CheckedChanged);
            // 
            // rbtImage2
            // 
            this.rbtImage2.AutoSize = true;
            this.rbtImage2.Location = new System.Drawing.Point(927, 199);
            this.rbtImage2.Name = "rbtImage2";
            this.rbtImage2.Size = new System.Drawing.Size(60, 17);
            this.rbtImage2.TabIndex = 24;
            this.rbtImage2.Text = "Image2";
            this.rbtImage2.UseVisualStyleBackColor = true;
            this.rbtImage2.CheckedChanged += new System.EventHandler(this.rbtImage2_CheckedChanged);
            // 
            // rbtImage3
            // 
            this.rbtImage3.AutoSize = true;
            this.rbtImage3.Location = new System.Drawing.Point(927, 248);
            this.rbtImage3.Name = "rbtImage3";
            this.rbtImage3.Size = new System.Drawing.Size(60, 17);
            this.rbtImage3.TabIndex = 25;
            this.rbtImage3.Text = "Image3";
            this.rbtImage3.UseVisualStyleBackColor = true;
            this.rbtImage3.CheckedChanged += new System.EventHandler(this.rbtImage3_CheckedChanged);
            // 
            // rbtImage4
            // 
            this.rbtImage4.AutoSize = true;
            this.rbtImage4.Location = new System.Drawing.Point(927, 294);
            this.rbtImage4.Name = "rbtImage4";
            this.rbtImage4.Size = new System.Drawing.Size(60, 17);
            this.rbtImage4.TabIndex = 26;
            this.rbtImage4.Text = "Image4";
            this.rbtImage4.UseVisualStyleBackColor = true;
            this.rbtImage4.CheckedChanged += new System.EventHandler(this.rbtImage4_CheckedChanged);
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorLogin.Location = new System.Drawing.Point(783, 142);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(72, 43);
            this.lblErrorLogin.TabIndex = 27;
            this.lblErrorLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorPassword.Location = new System.Drawing.Point(783, 228);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(72, 43);
            this.lblErrorPassword.TabIndex = 28;
            this.lblErrorPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorRepeat
            // 
            this.lblErrorRepeat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorRepeat.Location = new System.Drawing.Point(783, 314);
            this.lblErrorRepeat.Name = "lblErrorRepeat";
            this.lblErrorRepeat.Size = new System.Drawing.Size(72, 43);
            this.lblErrorRepeat.TabIndex = 29;
            this.lblErrorRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorExist
            // 
            this.lblErrorExist.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorExist.Location = new System.Drawing.Point(749, 417);
            this.lblErrorExist.Name = "lblErrorExist";
            this.lblErrorExist.Size = new System.Drawing.Size(72, 43);
            this.lblErrorExist.TabIndex = 30;
            this.lblErrorExist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorExist);
            this.Controls.Add(this.lblErrorRepeat);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.rbtImage4);
            this.Controls.Add(this.rbtImage3);
            this.Controls.Add(this.rbtImage2);
            this.Controls.Add(this.rbtImage1);
            this.Controls.Add(this.btnSaveSignUp);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMichal);
            this.Controls.Add(this.lblPortfolio);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbxChat);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(1101, 542);
            this.Load += new System.EventHandler(this.SignUpControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMichal;
        private System.Windows.Forms.Label lblPortfolio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbxChat;
        private System.Windows.Forms.Timer tInfo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Button btnSaveSignUp;
        private System.Windows.Forms.RadioButton rbtImage1;
        private System.Windows.Forms.RadioButton rbtImage2;
        private System.Windows.Forms.RadioButton rbtImage3;
        private System.Windows.Forms.RadioButton rbtImage4;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorRepeat;
        private System.Windows.Forms.Label lblErrorExist;
    }
}
