using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.DesktopFacebook
{
    public interface IEmailBuilder
    {
        void BuildSender();

        void BuildReciever();

        void BuildEmailComponents();

        MyEmail GetComplexProduct();
    }
}
