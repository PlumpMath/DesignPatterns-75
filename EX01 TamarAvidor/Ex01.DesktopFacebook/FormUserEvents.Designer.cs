﻿namespace Ex01.DesktopFacebook
{
    public partial class FormUserEvents
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
            this.listBoxUserEvents = new System.Windows.Forms.ListBox();
            this.buttonCountDown = new System.Windows.Forms.Button();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.buttonStopCountDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUserEvents
            // 
            this.listBoxUserEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxUserEvents.FormattingEnabled = true;
            this.listBoxUserEvents.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserEvents.Name = "listBoxUserEvents";
            this.listBoxUserEvents.Size = new System.Drawing.Size(273, 303);
            this.listBoxUserEvents.TabIndex = 0;
            this.listBoxUserEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxUserEvents_SelectedIndexChanged);
            // 
            // buttonCountDown
            // 
            this.buttonCountDown.Enabled = false;
            this.buttonCountDown.Location = new System.Drawing.Point(495, 16);
            this.buttonCountDown.Name = "buttonCountDown";
            this.buttonCountDown.Size = new System.Drawing.Size(132, 30);
            this.buttonCountDown.TabIndex = 1;
            this.buttonCountDown.Text = "Start Count Down!";
            this.buttonCountDown.UseVisualStyleBackColor = true;
            this.buttonCountDown.Click += new System.EventHandler(this.buttonCountDown_Click);
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCountDown.ForeColor = System.Drawing.Color.PowderBlue;
            this.labelCountDown.Image = global::Ex01.DesktopFacebook.Properties.Resources.facebookpalette1;
            this.labelCountDown.Location = new System.Drawing.Point(279, 149);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(186, 35);
            this.labelCountDown.TabIndex = 2;
            this.labelCountDown.Text = "Count Down";
            // 
            // buttonStopCountDown
            // 
            this.buttonStopCountDown.Enabled = false;
            this.buttonStopCountDown.Location = new System.Drawing.Point(495, 69);
            this.buttonStopCountDown.Name = "buttonStopCountDown";
            this.buttonStopCountDown.Size = new System.Drawing.Size(132, 27);
            this.buttonStopCountDown.TabIndex = 3;
            this.buttonStopCountDown.Text = "Stop!";
            this.buttonStopCountDown.UseVisualStyleBackColor = true;
            this.buttonStopCountDown.Click += new System.EventHandler(this.buttonStopCountDown_Click);
            // 
            // FormUserEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ex01.DesktopFacebook.Properties.Resources.facebookpalette1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 412);
            this.Controls.Add(this.buttonStopCountDown);
            this.Controls.Add(this.labelCountDown);
            this.Controls.Add(this.buttonCountDown);
            this.Controls.Add(this.listBoxUserEvents);
            this.Name = "FormUserEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUserEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUserEvents;
        private System.Windows.Forms.Button buttonCountDown;
        private System.Windows.Forms.Label labelCountDown;
        private System.Windows.Forms.Button buttonStopCountDown;
    }
}