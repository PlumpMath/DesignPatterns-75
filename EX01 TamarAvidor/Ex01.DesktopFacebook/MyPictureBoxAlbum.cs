using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public sealed class MyPictureBoxAlbum : PictureBox
    {
        private Album m_Album = null;

        public MyPictureBoxAlbum(Album i_Album)
        {
            this.m_Album = i_Album;
        }

        public Album Album
        {
            get
            {
                return this.m_Album;
            }
        }
    }
}
