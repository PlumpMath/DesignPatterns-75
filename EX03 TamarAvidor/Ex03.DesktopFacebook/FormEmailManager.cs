using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Ex01.DesktopFacebook
{
    public partial class FormEmailManager : Form
    {
        private string m_username;

        public MyEmail Email { get; set; }

        public FormEmailManager()
        {
            this.InitializeComponent();
            this.Email = new MyEmail();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SMTPComposer composer = new SMTPComposer();
            SMTPBuilder builder = new SMTPBuilder();
            builder.FormEmailManager = this;
            composer.ComposeEmail(builder);
            this.Email = builder.GetComplexProduct();

            try
            {
                var fromAddress = new MailAddress(this.Email.SenderAddress.Address, this.Email.SenderAddress.User);
                var toAddress = new MailAddress(this.Email.RecieverAddress.Address, this.Email.RecieverAddress.User);
                string fromPassword = this.Email.SenderPassword;
                string subject = this.Email.MailSubject;
                string body = this.Email.MailBody;

                var smtp = new SmtpClient
                {
                    Host = this.Email.Host,
                    Port = this.Email.Port,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("Email sent successfully", string.Empty, MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Invalid sender credentials. try again?", string.Empty, MessageBoxButtons.OKCancel);
                if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    dialogResult = MessageBox.Show("Enter again email sender and email password", string.Empty, MessageBoxButtons.OK);
                    this.textBoxSenderEmailAddress.Text = string.Empty;
                    this.textBoxSenderEmailPassword.Text = string.Empty;
                }
            }
        }

        public string TextSenderName
        {
            get
            {
                return this.textBoxSenderName.Text;
            }
        }

        public string TextRecieverName
        {
            get
            {
                return this.textBoxRecieverName.Text;
            }
        }

        public string TextSenderEmailAddress
        {
            get
            {
                return this.textBoxSenderEmailAddress.Text;
            }
        }

        public string TextSenderPassword
        {
            get
            {
                return this.textBoxSenderEmailPassword.Text;
            }
        }

        public string TextRecieverEmailAddress
        {
            get
            {
                return this.textBoxRecieverEmailAddress.Text;
            }
        }

        public string TextEmailSubject
        {
            get
            {
                return this.textBoxEmailSubect.Text;
            }
        }

        public string TextEmailBody
        {
            get
            {
                return this.textBoxEmailBody.Text;
            }
        }

        public string TextComboBoxChoice
        {
            get
            {
                return this.comboBoxEmailDomain.Text;
            }
        }

        private void textBoxSenderEmailAddress_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBoxSenderEmailAddress.Text == string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void comboBoxEmailDomain_TextChanged(object sender, EventArgs e)
        {
            this.textBoxSenderEmailAddress.Text = string.Concat(this.m_username, this.comboBoxEmailDomain.Text);
            this.textBoxSenderEmailPassword.Enabled = true;
        }

        private void textBoxSenderEmailAddress_Enter(object sender, EventArgs e)
        {
            this.textBoxSenderEmailAddress.Text = string.Empty;
            this.textBoxSenderEmailPassword.Enabled = false;
            this.comboBoxEmailDomain.Text = string.Empty;
        }

        private void textBoxSenderEmailAddress_TextChanged(object sender, EventArgs e)
        {
            /*if (textBoxSenderEmailAddress.TextLength > 0)
            {
                comboBoxEmailDomain.Enabled = true;
            }*/
        }

        private void textBoxSenderEmailAddress_Leave(object sender, EventArgs e)
        {
            this.m_username = this.textBoxSenderEmailAddress.Text;
        }

        private void textBoxSenderEmailPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBoxSenderEmailPassword.Text == string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void textBoxSenderEmailPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSenderEmailPassword.TextLength > 0)
            {
                this.textBoxRecieverName.Enabled = true;
                this.textBoxRecieverEmailAddress.Enabled = true;
            }
        }

        private void textBoxRecieverEmailAddress_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBoxRecieverEmailAddress.Text == string.Empty || this.isThereAnAt(this.textBoxRecieverEmailAddress.Text) == false)
            {
                e.Cancel = true;
            }
            else
            {
                this.buttonSend.Enabled = true;
            }
        }

        private bool isThereAnAt(string i_userStringInput)
        {
            bool thereIsAnAt = false;

            if(i_userStringInput.Contains('@'))
            {
                thereIsAnAt = true;
            }

            return thereIsAnAt;
        }

        private void textBoxRecieverEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxRecieverEmailAddress.TextLength > 0)
            {
                this.textBoxEmailSubect.Enabled = true;
                this.textBoxEmailBody.Enabled = true;
            }
            else
            {
                this.textBoxEmailSubect.Enabled = false;
                this.textBoxEmailBody.Enabled = false;
            }
        }
    }
}
