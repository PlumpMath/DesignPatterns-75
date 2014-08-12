namespace Ex01.DesktopFacebook
{
    public partial class FormMain
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
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonNewsFeed = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonCheckIns = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonReLoggin = new System.Windows.Forms.Button();
            this.textBoxGoogle = new System.Windows.Forms.TextBox();
            this.pictureBoxGoogle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(141, 292);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(419, 20);
            this.textBoxPostStatus.TabIndex = 2;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Location = new System.Drawing.Point(24, 92);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(155, 139);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.Location = new System.Drawing.Point(13, 368);
            this.buttonNewsFeed.Name = "buttonNewsFeed";
            this.buttonNewsFeed.Size = new System.Drawing.Size(120, 20);
            this.buttonNewsFeed.TabIndex = 5;
            this.buttonNewsFeed.Text = "Fetch News Feed";
            this.buttonNewsFeed.UseVisualStyleBackColor = true;
            this.buttonNewsFeed.Click += new System.EventHandler(this.buttonNewsFeed_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(13, 408);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(120, 20);
            this.buttonFriends.TabIndex = 5;
            this.buttonFriends.Text = "Fetch Friends List";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(13, 488);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(120, 20);
            this.buttonEvents.TabIndex = 5;
            this.buttonEvents.Text = "Fetch Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonCheckIns
            // 
            this.buttonCheckIns.Location = new System.Drawing.Point(13, 449);
            this.buttonCheckIns.Name = "buttonCheckIns";
            this.buttonCheckIns.Size = new System.Drawing.Size(120, 20);
            this.buttonCheckIns.TabIndex = 5;
            this.buttonCheckIns.Text = "Fetch Checkins";
            this.buttonCheckIns.UseVisualStyleBackColor = true;
            this.buttonCheckIns.Click += new System.EventHandler(this.buttonCheckIns_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(836, 41);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Location = new System.Drawing.Point(18, 292);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(105, 20);
            this.buttonPostNewStatus.TabIndex = 6;
            this.buttonPostNewStatus.Text = "Post New Status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonPostNewStatus_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCover.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(753, 182);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 7;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelUserName.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserName.Image = global::Ex01.DesktopFacebook.Properties.Resources._251093_facebook_fanartBACK;
            this.labelUserName.Location = new System.Drawing.Point(196, 200);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 29);
            this.labelUserName.TabIndex = 8;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Location = new System.Drawing.Point(12, 529);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(120, 20);
            this.buttonAlbums.TabIndex = 9;
            this.buttonAlbums.Text = "Fetch User Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(13, 567);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(120, 20);
            this.buttonUserInfo.TabIndex = 11;
            this.buttonUserInfo.Text = "Fetch User Info";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUserInfo_Click);
            // 
            // buttonReLoggin
            // 
            this.buttonReLoggin.Location = new System.Drawing.Point(836, 12);
            this.buttonReLoggin.Name = "buttonReLoggin";
            this.buttonReLoggin.Size = new System.Drawing.Size(75, 23);
            this.buttonReLoggin.TabIndex = 12;
            this.buttonReLoggin.Text = "ReLogin";
            this.buttonReLoggin.UseVisualStyleBackColor = true;
            this.buttonReLoggin.Visible = false;
            this.buttonReLoggin.Click += new System.EventHandler(this.buttonReLoggin_Click);
            // 
            // textBoxGoogle
            // 
            this.textBoxGoogle.Location = new System.Drawing.Point(235, 633);
            this.textBoxGoogle.Name = "textBoxGoogle";
            this.textBoxGoogle.Size = new System.Drawing.Size(425, 20);
            this.textBoxGoogle.TabIndex = 13;
            this.textBoxGoogle.Text = "[Enter your text to seach on google\'s search engine, then click the google icon.." +
                ".]";
            this.textBoxGoogle.Click += new System.EventHandler(this.textBoxGoogle_Click);
            // 
            // pictureBoxGoogle
            // 
            this.pictureBoxGoogle.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources.googleicon;
            this.pictureBoxGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGoogle.Enabled = false;
            this.pictureBoxGoogle.Location = new System.Drawing.Point(165, 596);
            this.pictureBoxGoogle.Name = "pictureBoxGoogle";
            this.pictureBoxGoogle.Size = new System.Drawing.Size(64, 57);
            this.pictureBoxGoogle.TabIndex = 14;
            this.pictureBoxGoogle.TabStop = false;
            this.pictureBoxGoogle.Click += new System.EventHandler(this.pictureBoxGoogle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources._251093_facebook_fanart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 665);
            this.Controls.Add(this.pictureBoxGoogle);
            this.Controls.Add(this.textBoxGoogle);
            this.Controls.Add(this.buttonReLoggin);
            this.Controls.Add(this.buttonUserInfo);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.buttonPostNewStatus);
            this.Controls.Add(this.buttonCheckIns);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonNewsFeed);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonLogOut);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonNewsFeed;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonCheckIns;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonReLoggin;
        private System.Windows.Forms.TextBox textBoxGoogle;
        private System.Windows.Forms.PictureBox pictureBoxGoogle;
    }
}
