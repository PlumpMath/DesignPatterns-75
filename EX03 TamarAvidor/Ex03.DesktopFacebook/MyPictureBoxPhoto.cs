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

        public override MyPictureBoxGeneral HandleRequest(PictureBox i_pictureBoxToSetPhotoTo)
        {
            MyPictureBoxGeneral pictureBoxToReturn = null;

            if (Photo != null)
            {
                i_pictureBoxToSetPhotoTo.LoadAsync(Photo.URL);
            }

            if (this.m_NextChain != null)
            {
                pictureBoxToReturn = this.m_NextChain;
            }

            return pictureBoxToReturn;
        }
    }
}