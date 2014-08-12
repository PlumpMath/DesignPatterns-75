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
    public partial class FormCheckIns : Form
    {
        public FormCheckIns()
        {
            this.InitializeComponent();
        }

        public ListBox ListBoxUserCheckIns
        {
            get
            {
                return this.listBoxCheckIns;
            }
        }
    }
}
