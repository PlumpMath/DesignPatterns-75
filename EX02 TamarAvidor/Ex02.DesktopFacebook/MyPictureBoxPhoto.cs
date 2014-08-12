using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public sealed class MyPictureBoxPhoto : MyPictureBoxGeneral
    {
        public MyPictureBoxPhoto()
        {
        }

        public Photo Photo { get; set; }
    }
}
