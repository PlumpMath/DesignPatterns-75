﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public partial class FormNewsFeed : Form
    {
        public FormNewsFeed()
        {
            this.InitializeComponent();
        }

        public ListBox ListBoxNewsFeed
        {
            get
            {
                return this.listBoxNewsFeed;
            }
        }
    }
}
