namespace Ex01.DesktopFacebook
{
    public partial class FormFriendEvents
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
            this.listBoxFriendEvents = new System.Windows.Forms.ListBox();
            this.buttonRSVP = new System.Windows.Forms.Button();
            this.comboBoxEventsDecisions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxFriendEvents
            // 
            this.listBoxFriendEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxFriendEvents.FormattingEnabled = true;
            this.listBoxFriendEvents.Location = new System.Drawing.Point(0, 0);
            this.listBoxFriendEvents.Name = "listBoxFriendEvents";
            this.listBoxFriendEvents.Size = new System.Drawing.Size(308, 342);
            this.listBoxFriendEvents.TabIndex = 0;
            this.listBoxFriendEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendEvents_SelectedIndexChanged);
            // 
            // buttonRSVP
            // 
            this.buttonRSVP.Enabled = false;
            this.buttonRSVP.Location = new System.Drawing.Point(357, 37);
            this.buttonRSVP.Name = "buttonRSVP";
            this.buttonRSVP.Size = new System.Drawing.Size(102, 26);
            this.buttonRSVP.TabIndex = 1;
            this.buttonRSVP.Text = "Confirm!";
            this.buttonRSVP.UseVisualStyleBackColor = true;
            this.buttonRSVP.Click += new System.EventHandler(this.buttonRSVP_Click);
            // 
            // comboBoxEventsDecisions
            // 
            this.comboBoxEventsDecisions.FormattingEnabled = true;
            this.comboBoxEventsDecisions.Location = new System.Drawing.Point(354, 0);
            this.comboBoxEventsDecisions.Name = "comboBoxEventsDecisions";
            this.comboBoxEventsDecisions.Size = new System.Drawing.Size(105, 21);
            this.comboBoxEventsDecisions.TabIndex = 2;
            this.comboBoxEventsDecisions.Visible = false;
            this.comboBoxEventsDecisions.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventsDecisions_SelectedIndexChanged);
            // 
            // FormFriendEventsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 422);
            this.Controls.Add(this.comboBoxEventsDecisions);
            this.Controls.Add(this.buttonRSVP);
            this.Controls.Add(this.listBoxFriendEvents);
            this.Name = "FormFriendEventsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFriendEventsList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriendEvents;
        private System.Windows.Forms.Button buttonRSVP;
        private System.Windows.Forms.ComboBox comboBoxEventsDecisions;
    }
}