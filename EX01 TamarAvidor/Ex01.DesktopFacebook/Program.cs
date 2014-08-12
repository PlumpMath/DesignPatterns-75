using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
// $G$ THE-001 (-8) your grade on diagrams document
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
