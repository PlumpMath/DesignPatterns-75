namespace Ex01.DesktopFacebook
{
    public partial class FormComboBoxViewableControl
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
            this.comboBoxViewableControls = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxViewableControls
            // 
            this.comboBoxViewableControls.FormattingEnabled = true;
            this.comboBoxViewableControls.Location = new System.Drawing.Point(12, 12);
            this.comboBoxViewableControls.Name = "comboBoxViewableControls";
            this.comboBoxViewableControls.Size = new System.Drawing.Size(121, 21);
            this.comboBoxViewableControls.TabIndex = 0;
            this.comboBoxViewableControls.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewableControls_SelectedIndexChanged);
            // 
            // FormComboBoxViewableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(487, 312);
            this.Controls.Add(this.comboBoxViewableControls);
            this.Name = "FormComboBoxViewableControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormComboBoxViewableControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxViewableControls;
    }
}