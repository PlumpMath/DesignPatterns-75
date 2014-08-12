using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.DesktopFacebook
{
    public interface IEmailComposer
    {
        void ComposeEmail(IEmailBuilder i_emailBuilder);
    }
}
