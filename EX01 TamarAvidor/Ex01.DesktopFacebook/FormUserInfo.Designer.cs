namespace Ex01.DesktopFacebook
{
    public partial class FormUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInfo));
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelRelationshipStatus = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Image = ((System.Drawing.Image)(resources.GetObject("labelUsername.Image")));
            this.labelUsername.Location = new System.Drawing.Point(37, 39);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username: ";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFirstname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.ForeColor = System.Drawing.Color.White;
            this.labelFirstname.Image = ((System.Drawing.Image)(resources.GetObject("labelFirstname.Image")));
            this.labelFirstname.Location = new System.Drawing.Point(37, 75);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(75, 13);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "First Name: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Image = ((System.Drawing.Image)(resources.GetObject("labelGender.Image")));
            this.labelGender.Location = new System.Drawing.Point(37, 159);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 13);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender: ";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLastname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.ForeColor = System.Drawing.Color.White;
            this.labelLastname.Image = ((System.Drawing.Image)(resources.GetObject("labelLastname.Image")));
            this.labelLastname.Location = new System.Drawing.Point(37, 120);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(75, 13);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Last Name: ";
            // 
            // labelReligion
            // 
            this.labelReligion.AutoSize = true;
            this.labelReligion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelReligion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReligion.ForeColor = System.Drawing.Color.White;
            this.labelReligion.Image = ((System.Drawing.Image)(resources.GetObject("labelReligion.Image")));
            this.labelReligion.Location = new System.Drawing.Point(37, 284);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(61, 13);
            this.labelReligion.TabIndex = 6;
            this.labelReligion.Text = "Religion: ";
            // 
            // labelRelationshipStatus
            // 
            this.labelRelationshipStatus.AutoSize = true;
            this.labelRelationshipStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRelationshipStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRelationshipStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelationshipStatus.ForeColor = System.Drawing.Color.White;
            this.labelRelationshipStatus.Image = ((System.Drawing.Image)(resources.GetObject("labelRelationshipStatus.Image")));
            this.labelRelationshipStatus.Location = new System.Drawing.Point(37, 245);
            this.labelRelationshipStatus.Name = "labelRelationshipStatus";
            this.labelRelationshipStatus.Size = new System.Drawing.Size(125, 13);
            this.labelRelationshipStatus.TabIndex = 5;
            this.labelRelationshipStatus.Text = "Relationship Status: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.White;
            this.labelBirthday.Image = ((System.Drawing.Image)(resources.GetObject("labelBirthday.Image")));
            this.labelBirthday.Location = new System.Drawing.Point(37, 200);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(61, 13);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Birthday: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Image = ((System.Drawing.Image)(resources.GetObject("labelEmail.Image")));
            this.labelEmail.Location = new System.Drawing.Point(37, 323);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email: ";
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources.facebookpalette1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 557);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelReligion);
            this.Controls.Add(this.labelRelationshipStatus);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelRelationshipStatus;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEmail;
    }
}