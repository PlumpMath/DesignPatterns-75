using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Ex01.DesktopFacebook
{
    public class MyEmail
    {
        public MyEmail()
        {
        }

        public MailAddress SenderAddress { get; set; }

        public MailAddress RecieverAddress { get; set; }

        public string SenderPassword { get; set; }

        public string MailSubject { get; set; }

        public string MailBody { get; set; }

        public int Port { get; set; }

        public string Host { get; set; }
    }
}
