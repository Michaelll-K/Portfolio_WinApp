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
            this.pbxChat = new System.Windows.Forms.PictureBox();
            this.tInfo = new System.Windows.Forms.Timer(this.components);
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
            // tInfo
            // 
            this.tInfo.Interval = 50;
            this.tInfo.Tick += new System.EventHandler(this.tInfo_Tick);
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
