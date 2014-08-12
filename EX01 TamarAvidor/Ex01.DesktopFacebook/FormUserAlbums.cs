using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public partial class FormUserAlbums : Form
    {
        public FormUserAlbums()
        {
            this.InitializeComponent();
        }

        private void FormUserAlbums_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Press On Album Cover To Enter The Album", string.Empty, MessageBoxButtons.OK);
        }
    }
}
