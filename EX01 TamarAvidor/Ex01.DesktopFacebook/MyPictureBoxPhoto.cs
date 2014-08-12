using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public sealed class MyPictureBoxPhoto : PictureBox
    {
        private Photo m_Photo = null;

        public MyPictureBoxPhoto(Photo i_Photo)
        {
            this.m_Photo = i_Photo;
        }

        public Photo Photo
        {
            get
            {
                return this.m_Photo;
            }
        }
    }
}
