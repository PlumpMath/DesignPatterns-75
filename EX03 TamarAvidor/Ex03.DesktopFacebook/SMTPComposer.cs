using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.DesktopFacebook
{
    public class SMTPComposer : IEmailComposer
    {
        public SMTPComposer()
        {
        }

        public void ComposeEmail(IEmailBuilder i_emailBuilder)
        {
            i_emailBuilder.BuildSender();
            i_emailBuilder.BuildReciever();
            i_emailBuilder.BuildEmailComponents();
        }
    }
}
