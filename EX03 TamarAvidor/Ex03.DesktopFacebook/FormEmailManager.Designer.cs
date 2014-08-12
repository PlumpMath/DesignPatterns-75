namespace Ex01.DesktopFacebook
{
    public partial class FormEmailManager
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
            this.labelSenderEmailPassword = new System.Windows.Forms.Label();
            this.labelSenderEmailAddress = new System.Windows.Forms.Label();
            this.labelRecieverEmailAddress = new System.Windows.Forms.Label();
            this.labelEmailSubject = new System.Windows.Forms.Label();
            this.labelEmailBody = new System.Windows.Forms.Label();
            this.textBoxSenderEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxSenderEmailPassword = new System.Windows.Forms.TextBox();
            this.textBoxRecieverEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmailSubect = new System.Windows.Forms.TextBox();
            this.textBoxEmailBody = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelRecieverName = new System.Windows.Forms.Label();
            this.textBoxSenderName = new System.Windows.Forms.TextBox();
            this.textBoxRecieverName = new System.Windows.Forms.TextBox();
            this.comboBoxEmailDomain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSenderEmailPassword
            // 
            this.labelSenderEmailPassword.AutoSize = true;
            this.labelSenderEmailPassword.Location = new System.Drawing.Point(6, 71);
            this.labelSenderEmailPassword.Name = "labelSenderEmailPassword";
            this.labelSenderEmailPassword.Size = new System.Drawing.Size(121, 13);
            this.labelSenderEmailPassword.TabIndex = 0;
            this.labelSenderEmailPassword.Text = "Sender Email Password:";
            // 
            // labelSenderEmailAddress
            // 
            this.labelSenderEmailAddress.AutoSize = true;
            this.labelSenderEmailAddress.Location = new System.Drawing.Point(6, 38);
            this.labelSenderEmailAddress.Name = "labelSenderEmailAddress";
            this.labelSenderEmailAddress.Size = new System.Drawing.Size(123, 13);
            this.labelSenderEmailAddress.TabIndex = 0;
            this.labelSenderEmailAddress.Text = "Sender Email Username:";
            // 
            // labelRecieverEmailAddress
            // 
            this.labelRecieverEmailAddress.AutoSize = true;
            this.labelRecieverEmailAddress.Location = new System.Drawing.Point(6, 134);
            this.labelRecieverEmailAddress.Name = "labelRecieverEmailAddress";
            this.labelRecieverEmailAddress.Size = new System.Drawing.Size(122, 13);
            this.labelRecieverEmailAddress.TabIndex = 0;
            this.labelRecieverEmailAddress.Text = "Reciever Email Address:";
            // 
            // labelEmailSubject
            // 
            this.labelEmailSubject.AutoSize = true;
            this.labelEmailSubject.Location = new System.Drawing.Point(6, 169);
            this.labelEmailSubject.Name = "labelEmailSubject";
            this.labelEmailSubject.Size = new System.Drawing.Size(74, 13);
            this.labelEmailSubject.TabIndex = 0;
            this.labelEmailSubject.Text = "Email Subject:";
            // 
            // labelEmailBody
            // 
            this.labelEmailBody.AutoSize = true;
            this.labelEmailBody.Location = new System.Drawing.Point(6, 202);
            this.labelEmailBody.Name = "labelEmailBody";
            this.labelEmailBody.Size = new System.Drawing.Size(62, 13);
            this.labelEmailBody.TabIndex = 0;
            this.labelEmailBody.Text = "Email Body:";
            // 
            // textBoxSenderEmailAddress
            // 
            this.textBoxSenderEmailAddress.Enabled = false;
            this.textBoxSenderEmailAddress.Location = new System.Drawing.Point(137, 35);
            this.textBoxSenderEmailAddress.Name = "textBoxSenderEmailAddress";
            this.textBoxSenderEmailAddress.Size = new System.Drawing.Size(320, 20);
            this.textBoxSenderEmailAddress.TabIndex = 2;
            this.textBoxSenderEmailAddress.Text = "desig.patter@gmail.com";
            this.textBoxSenderEmailAddress.TextChanged += new System.EventHandler(this.textBoxSenderEmailAddress_TextChanged);
            this.textBoxSenderEmailAddress.Enter += new System.EventHandler(this.textBoxSenderEmailAddress_Enter);
            this.textBoxSenderEmailAddress.Leave += new System.EventHandler(this.textBoxSenderEmailAddress_Leave);
            this.textBoxSenderEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSenderEmailAddress_Validating);
            // 
            // textBoxSenderEmailPassword
            // 
            this.textBoxSenderEmailPassword.Enabled = false;
            this.textBoxSenderEmailPassword.Location = new System.Drawing.Point(137, 68);
            this.textBoxSenderEmailPassword.Name = "textBoxSenderEmailPassword";
            this.textBoxSenderEmailPassword.Size = new System.Drawing.Size(320, 20);
            this.textBoxSenderEmailPassword.TabIndex = 4;
            this.textBoxSenderEmailPassword.Text = "designpatterns";
            this.textBoxSenderEmailPassword.UseSystemPasswordChar = true;
            this.textBoxSenderEmailPassword.TextChanged += new System.EventHandler(this.textBoxSenderEmailPassword_TextChanged);
            this.textBoxSenderEmailPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSenderEmailPassword_Validating);
            // 
            // textBoxRecieverEmailAddress
            // 
            this.textBoxRecieverEmailAddress.Location = new System.Drawing.Point(137, 134);
            this.textBoxRecieverEmailAddress.Name = "textBoxRecieverEmailAddress";
            this.textBoxRecieverEmailAddress.Size = new System.Drawing.Size(320, 20);
            this.textBoxRecieverEmailAddress.TabIndex = 6;
            this.textBoxRecieverEmailAddress.TextChanged += new System.EventHandler(this.textBoxRecieverEmailAddress_TextChanged);
            this.textBoxRecieverEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRecieverEmailAddress_Validating);
            // 
            // textBoxEmailSubect
            // 
            this.textBoxEmailSubect.Enabled = false;
            this.textBoxEmailSubect.Location = new System.Drawing.Point(137, 169);
            this.textBoxEmailSubect.Name = "textBoxEmailSubect";
            this.textBoxEmailSubect.Size = new System.Drawing.Size(320, 20);
            this.textBoxEmailSubect.TabIndex = 7;
            // 
            // textBoxEmailBody
            // 
            this.textBoxEmailBody.Enabled = false;
            this.textBoxEmailBody.Location = new System.Drawing.Point(137, 202);
            this.textBoxEmailBody.Multiline = true;
            this.textBoxEmailBody.Name = "textBoxEmailBody";
            this.textBoxEmailBody.Size = new System.Drawing.Size(320, 241);
            this.textBoxEmailBody.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(530, 419);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(87, 24);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send!";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Location = new System.Drawing.Point(6, 12);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(75, 13);
            this.labelSenderName.TabIndex = 7;
            this.labelSenderName.Text = "Sender Name:";
            // 
            // labelRecieverName
            // 
            this.labelRecieverName.AutoSize = true;
            this.labelRecieverName.Location = new System.Drawing.Point(6, 102);
            this.labelRecieverName.Name = "labelRecieverName";
            this.labelRecieverName.Size = new System.Drawing.Size(84, 13);
            this.labelRecieverName.TabIndex = 8;
            this.labelRecieverName.Text = "Reciever Name:";
            // 
            // textBoxSenderName
            // 
            this.textBoxSenderName.Location = new System.Drawing.Point(137, 5);
            this.textBoxSenderName.Name = "textBoxSenderName";
            this.textBoxSenderName.Size = new System.Drawing.Size(320, 20);
            this.textBoxSenderName.TabIndex = 1;
            // 
            // textBoxRecieverName
            // 
            this.textBoxRecieverName.Location = new System.Drawing.Point(137, 99);
            this.textBoxRecieverName.Name = "textBoxRecieverName";
            this.textBoxRecieverName.Size = new System.Drawing.Size(320, 20);
            this.textBoxRecieverName.TabIndex = 5;
            // 
            // comboBoxEmailDomain
            // 
            this.comboBoxEmailDomain.Enabled = false;
            this.comboBoxEmailDomain.FormattingEnabled = true;
            this.comboBoxEmailDomain.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@hotmail.co.il",
            "@nana.com",
            "@nana.co.il",
            "@yahoo.com"});
            this.comboBoxEmailDomain.Location = new System.Drawing.Point(530, 35);
            this.comboBoxEmailDomain.Name = "comboBoxEmailDomain";
            this.comboBoxEmailDomain.Size = new System.Drawing.Size(116, 21);
            this.comboBoxEmailDomain.TabIndex = 3;
            this.comboBoxEmailDomain.TextChanged += new System.EventHandler(this.comboBoxEmailDomain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(461, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(460, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(460, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // FormEmailManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(687, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmailDomain);
            this.Controls.Add(this.textBoxRecieverName);
            this.Controls.Add(this.textBoxSenderName);
            this.Controls.Add(this.labelRecieverName);
            this.Controls.Add(this.labelSenderName);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxEmailBody);
            this.Controls.Add(this.textBoxEmailSubect);
            this.Controls.Add(this.textBoxRecieverEmailAddress);
            this.Controls.Add(this.textBoxSenderEmailPassword);
            this.Controls.Add(this.textBoxSenderEmailAddress);
            this.Controls.Add(this.labelSenderEmailAddress);
            this.Controls.Add(this.labelEmailBody);
            this.Controls.Add(this.labelEmailSubject);
            this.Controls.Add(this.labelRecieverEmailAddress);
            this.Controls.Add(this.labelSenderEmailPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmailManager";
            this.Text = "FormEmailComposer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenderEmailPassword;
        private System.Windows.Forms.Label labelSenderEmailAddress;
        private System.Windows.Forms.Label labelRecieverEmailAddress;
        private System.Windows.Forms.Label labelEmailSubject;
        private System.Windows.Forms.Label labelEmailBody;
        private System.Windows.Forms.TextBox textBoxSenderEmailAddress;
        private System.Windows.Forms.TextBox textBoxSenderEmailPassword;
        private System.Windows.Forms.TextBox textBoxRecieverEmailAddress;
        private System.Windows.Forms.TextBox textBoxEmailSubect;
        private System.Windows.Forms.TextBox textBoxEmailBody;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelRecieverName;
        private System.Windows.Forms.TextBox textBoxSenderName;
        private System.Windows.Forms.TextBox textBoxRecieverName;
        private System.Windows.Forms.ComboBox comboBoxEmailDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}