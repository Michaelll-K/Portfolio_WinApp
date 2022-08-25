namespace Portfolio_WinApp.Controls
{
    partial class AccountControl
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
            this.pbx = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnEdu = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.lblMichal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx
            // 
            this.pbx.Image = global::Portfolio_WinApp.Properties.Resources.user;
            this.pbx.Location = new System.Drawing.Point(39, 148);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(240, 240);
            this.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx.TabIndex = 0;
            this.pbx.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelUser.Controls.Add(this.panel2);
            this.panelUser.Controls.Add(this.panel1);
            this.panelUser.Location = new System.Drawing.Point(315, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(786, 542);
            this.panelUser.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblMichal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnLinks);
            this.panel2.Controls.Add(this.btnContact);
            this.panel2.Controls.Add(this.btnRef);
            this.panel2.Controls.Add(this.btnExp);
            this.panel2.Controls.Add(this.btnEdu);
            this.panel2.Controls.Add(this.btnAboutMe);
            this.panel2.Controls.Add(this.btnSkills);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnSkills
            // 
            this.btnSkills.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSkills.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkills.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnSkills.Location = new System.Drawing.Point(125, 0);
            this.btnSkills.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(101, 100);
            this.btnSkills.TabIndex = 0;
            this.btnSkills.Text = "Skills and Abilities";
            this.btnSkills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSkills.UseVisualStyleBackColor = false;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAboutMe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMe.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnAboutMe.Location = new System.Drawing.Point(17, 0);
            this.btnAboutMe.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(101, 100);
            this.btnAboutMe.TabIndex = 1;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAboutMe.UseVisualStyleBackColor = false;
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnExp.Location = new System.Drawing.Point(234, 0);
            this.btnExp.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(101, 100);
            this.btnExp.TabIndex = 3;
            this.btnExp.Text = "Experience";
            this.btnExp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExp.UseVisualStyleBackColor = false;
            // 
            // btnEdu
            // 
            this.btnEdu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEdu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdu.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnEdu.Location = new System.Drawing.Point(343, 0);
            this.btnEdu.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnEdu.Name = "btnEdu";
            this.btnEdu.Size = new System.Drawing.Size(101, 100);
            this.btnEdu.TabIndex = 2;
            this.btnEdu.Text = "Education";
            this.btnEdu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdu.UseVisualStyleBackColor = false;
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLinks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinks.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnLinks.Location = new System.Drawing.Point(670, 0);
            this.btnLinks.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(101, 100);
            this.btnLinks.TabIndex = 7;
            this.btnLinks.Text = "Links";
            this.btnLinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinks.UseVisualStyleBackColor = false;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnContact.Location = new System.Drawing.Point(452, 0);
            this.btnContact.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(101, 100);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContact.UseVisualStyleBackColor = false;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRef.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btnRef.Location = new System.Drawing.Point(561, 0);
            this.btnRef.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(101, 100);
            this.btnRef.TabIndex = 4;
            this.btnRef.Text = "References";
            this.btnRef.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRef.UseVisualStyleBackColor = false;
            // 
            // lblMichal
            // 
            this.lblMichal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMichal.AutoSize = true;
            this.lblMichal.BackColor = System.Drawing.Color.Transparent;
            this.lblMichal.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblMichal.ForeColor = System.Drawing.Color.Black;
            this.lblMichal.Location = new System.Drawing.Point(260, 15);
            this.lblMichal.Name = "lblMichal";
            this.lblMichal.Size = new System.Drawing.Size(249, 74);
            this.lblMichal.TabIndex = 12;
            this.lblMichal.Text = "Michał Kordos\r\nbackend developer";
            this.lblMichal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.pbx);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(1101, 542);
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnEdu;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Label lblMichal;
    }
}
