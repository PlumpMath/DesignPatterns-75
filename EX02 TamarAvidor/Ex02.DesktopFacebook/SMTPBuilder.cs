using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.DesktopFacebook
{
    public class SMTPBuilder : IEmailBuilder
    {
        public FormEmailManager FormEmailManager { get; set; }

        public MyEmail Email { get; set; }

        public SMTPBuilder()
        {
            Email = new MyEmail();
        }

        private string getSenderName()
        {
            return FormEmailManager.TextSenderName;
        }

        private string getSenderEmailAddress()
        {
            return FormEmailManager.TextSenderEmailAddress;
        }

        private string getSenderPassword()
        {
            return FormEmailManager.TextSenderPassword;
        }

        private string getRecieverName()
        {
            return FormEmailManager.TextRecieverName;
        }

        private string getRecieverEmailAddress()
        {
            return FormEmailManager.TextRecieverEmailAddress;
        }

        private string getMailSubject()
        {
            return FormEmailManager.TextEmailSubject;
        }

        private string getMailBody()
        {
            return FormEmailManager.TextEmailBody;
        }

        public void BuildSender()
        {
            Email.SenderAddress = new System.Net.Mail.MailAddress(getSenderEmailAddress(), getSenderName());
            Email.SenderPassword = getSenderPassword();
        }

        public void BuildReciever()
        {
            Email.RecieverAddress = new System.Net.Mail.MailAddress(getRecieverEmailAddress(), getRecieverName());
        }

        public void BuildEmailComponents()
        {
            Email.MailSubject = getMailSubject();
            Email.MailBody = getMailBody();
            getHostAndPort();
        }

        private void getHostAndPort()
        {
            ////string textComboBoxChoice = FormEmailManager.TextComboBoxChoice;
            string textEmailDomain = FormEmailManager.TextSenderEmailAddress;
            if (textEmailDomain.Contains("gmail"))
            {
                Email.Host = "smtp.gmail.com";
                Email.Port = 587;
            }
            else if (textEmailDomain.Contains("hotmail") || textEmailDomain.Contains("nana"))
            {
                Email.Host = "smtp.live.com";
                Email.Port = 587;
            }
            else
            {
                Email.Host = "smtp.mail.yahoo.com";
                Email.Port = 995;
            }
        }

        public MyEmail GetComplexProduct()
        {
            return Email;
        }
    }
}
