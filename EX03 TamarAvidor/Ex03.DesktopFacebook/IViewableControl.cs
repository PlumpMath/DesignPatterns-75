// -----------------------------------------------------------------------
// <copyright file="IViewableControl.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ex01.DesktopFacebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IViewableControl
    {
        TimeSpan showFormatedData(TimeSpan i_remainingTime);

        void addControl(Form i_form);
    }
}
