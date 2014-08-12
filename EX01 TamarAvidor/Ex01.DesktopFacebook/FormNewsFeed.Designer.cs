namespace Ex01.DesktopFacebook
{
    public partial class FormNewsFeed
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
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(0, 0);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(726, 303);
            this.listBoxNewsFeed.TabIndex = 0;
            // 
            // FormNewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources.facebookpalette1;
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Name = "FormNewsFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNewsFeed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNewsFeed;
    }
}