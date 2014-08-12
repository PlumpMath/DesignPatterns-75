using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Ex01.DesktopFacebook
{
    public sealed class MyProgressBar : MyControl, IViewableControl
    {
        internal ProgressBar ProgressBar { get; set; }

        public MyProgressBar()
        {
            ProgressBar = new ProgressBar();
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Value = 0;
            this.ProgressBar.Step = 1;
            this.ProgressBar.Size = new Size(350, 50);
        }

        public TimeSpan showFormatedData(TimeSpan i_remainingTime)
        {
            this.ProgressBar.Maximum = (int)i_remainingTime.TotalSeconds;
            this.ProgressBar.PerformStep();
            return i_remainingTime;
        }

        public void addControl(Form i_form)
        {
            ProgressBar.AutoSize = true;
            ProgressBar.Location = new Point(0, 0);
            ProgressBar.Visible = true;
            i_form.Controls.Add(ProgressBar);
        }

        public override string ToString()
        {
            return "This is a Progress bar for viewing event timer";
        }
    }
}
