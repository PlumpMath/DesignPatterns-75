namespace Ex01.DesktopFacebook
{
    public partial class FormFriends
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
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.linkLabelFriendNameMeaning = new System.Windows.Forms.LinkLabel();
            this.buttonGetFriendEvents = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(0, 0);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(285, 355);
            this.listBoxFriendsList.TabIndex = 0;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // linkLabelFriendNameMeaning
            // 
            this.linkLabelFriendNameMeaning.AutoSize = true;
            this.linkLabelFriendNameMeaning.Enabled = false;
            this.linkLabelFriendNameMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFriendNameMeaning.Location = new System.Drawing.Point(29, 370);
            this.linkLabelFriendNameMeaning.Name = "linkLabelFriendNameMeaning";
            this.linkLabelFriendNameMeaning.Size = new System.Drawing.Size(290, 18);
            this.linkLabelFriendNameMeaning.TabIndex = 2;
            this.linkLabelFriendNameMeaning.TabStop = true;
            this.linkLabelFriendNameMeaning.Text = "Press here for your friend\'s name meaning!";
            this.linkLabelFriendNameMeaning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFriendNameMeaning_LinkClicked);
            // 
            // buttonGetFriendEvents
            // 
            this.buttonGetFriendEvents.Location = new System.Drawing.Point(307, 336);
            this.buttonGetFriendEvents.Name = "buttonGetFriendEvents";
            this.buttonGetFriendEvents.Size = new System.Drawing.Size(215, 19);
            this.buttonGetFriendEvents.TabIndex = 3;
            this.buttonGetFriendEvents.Text = "Get Friend\'s Events";
            this.buttonGetFriendEvents.UseVisualStyleBackColor = true;
            this.buttonGetFriendEvents.Visible = false;
            this.buttonGetFriendEvents.Click += new System.EventHandler(this.buttonGetFriendEvents_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFriend.Location = new System.Drawing.Point(307, 1);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(215, 183);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 1;
            this.pictureBoxFriend.TabStop = false;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources.facebookpalette1;
            this.ClientSize = new System.Drawing.Size(993, 537);
            this.Controls.Add(this.buttonGetFriendEvents);
            this.Controls.Add(this.linkLabelFriendNameMeaning);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.listBoxFriendsList);
            this.Name = "FormFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFriendsList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.LinkLabel linkLabelFriendNameMeaning;
        private System.Windows.Forms.Button buttonGetFriendEvents;
    }
}