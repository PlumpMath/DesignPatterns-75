using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
