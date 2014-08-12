using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public abstract class MyPictureBoxGeneral : PictureBox
    {
        public enum e_PictureType
        {
            Album = 0,
            Photo = 1
        }

        public MyPictureBoxGeneral()
        {
        }

        public static MyPictureBoxGeneral Create(e_PictureType i_pictureType)
        {
            MyPictureBoxGeneral myPreDefinedPictureBox = null;

            switch (i_pictureType)
            {
                case e_PictureType.Album:
                    myPreDefinedPictureBox = new MyPictureBoxAlbum();
                    break;
                case e_PictureType.Photo:
                    myPreDefinedPictureBox = new MyPictureBoxPhoto();
                    break;
            }

            return myPreDefinedPictureBox;
        }
    }
}
