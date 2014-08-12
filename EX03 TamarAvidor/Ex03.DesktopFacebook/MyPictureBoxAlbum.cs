using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public sealed class MyPictureBoxAlbum : MyPictureBoxGeneral
    {
        public MyPictureBoxAlbum()
        {
        }

        public Album Album { get; set; }

        public override MyPictureBoxGeneral HandleRequest(PictureBox i_pictureBoxToSetPhotoTo)
        {
            throw new NotImplementedException();
        }
    }
}
