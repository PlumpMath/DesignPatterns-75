using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Ex01.DesktopFacebook
{
    public sealed class MyLabel : MyControl, IViewableControl
    {
        internal Label Label { get; set; }

        public MyLabel()
        {
            Label = new Label();
        }

        public TimeSpan showFormatedData(TimeSpan i_remainingTime)
        {
            this.Label.Text = string.Format(
@"Days:{0}
Hours:{1}
Minutes:{2}
Seconds:{3}",
i_remainingTime.Days,
i_remainingTime.Hours,
i_remainingTime.Minutes,
i_remainingTime.Seconds);
            return i_remainingTime;
        }

        public void addControl(Form i_form)
        {
            Label.AutoSize = true;
            Label.Location = new Point(0, 0);
            Label.Font = new Font("David", 36);
            Label.Visible = true;
            i_form.Controls.Add(Label);
        }

        public override string ToString()
        {
            return "This is a label for viewing event timer";
        }
    }
}