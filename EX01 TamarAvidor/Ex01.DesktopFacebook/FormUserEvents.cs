using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public partial class FormUserEvents : Form
    {
        private Timer m_TimerCountDown = new Timer();

        public FormUserEvents()
        {
            this.InitializeComponent();
        }

        private void buttonCountDown_Click(object sender, EventArgs e)
        {
            this.m_TimerCountDown = new Timer();
            this.buttonStopCountDown.Enabled = true;
            this.buttonCountDown.Enabled = false;
            this.showCountDown();
        }

        private void buttonStopCountDown_Click(object sender, EventArgs e)
        {
            this.stopCountDown();
        }

        private void stopCountDown()
        {
            this.buttonStopCountDown.Enabled = false;
            this.buttonCountDown.Enabled = true;
            this.m_TimerCountDown.Stop();
        }

        private void showCountDown()
        {
            this.m_TimerCountDown.Enabled = true;
            this.m_TimerCountDown.Interval = 1000;
            this.m_TimerCountDown.Start();

            this.m_TimerCountDown.Tick += (object sender, EventArgs e) => 
            {
                DateTime nowTime = DateTime.Now;
                Event selectedEvent = listBoxUserEvents.SelectedItem as Event;
                DateTime eventStartTime = (DateTime)selectedEvent.StartTime;
                TimeSpan remainingTime = eventStartTime.Subtract(nowTime);

                remainingTime = this.showLabelFormatedData(remainingTime);

                if (this.hasDatePasted(remainingTime) == true)
                {
                    labelCountDown.Text = "Event Already happend";
                }

                remainingTime = this.eventDateArrivedMessage(remainingTime);
            };
        }

        private TimeSpan eventDateArrivedMessage(TimeSpan remainingTime)
        {
            if (remainingTime.Days == 0 &&
                remainingTime.Hours == 0 &&
                remainingTime.Minutes == 0 &&
                remainingTime.Seconds == 0)
            {
                this.m_TimerCountDown.Stop();
                this.m_TimerCountDown.Dispose();
                this.m_TimerCountDown.Enabled = false;
                this.buttonStopCountDown.Enabled = false;
                this.labelCountDown.Text = "Event Happening NOW!!";
                SystemSounds.Hand.Play();
                MessageBox.Show("Event Happening NOW!!", string.Empty, MessageBoxButtons.OK);
            }

            return remainingTime;
        }

        private bool hasDatePasted(TimeSpan remainingTime)
        {
            bool hasDatePast = false;
            if (remainingTime.Seconds < 0)
            {
                hasDatePast = true;
            }

            return hasDatePast;
        }

        private TimeSpan showLabelFormatedData(TimeSpan remainingTime)
        {
            this.labelCountDown.Text = string.Format(
@"Days:{0}
Hours:{1}
Minutes:{2}
Seconds:{3}", 
            remainingTime.Days,
                remainingTime.Hours,
                remainingTime.Minutes,
                remainingTime.Seconds);
            return remainingTime;
        }

        private void listBoxUserEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_TimerCountDown.Enabled == true)
            {
                this.stopCountDown();
            }
            else
            {
                this.buttonCountDown.Enabled = true;
                this.buttonStopCountDown.Enabled = false;
                this.labelCountDown.Visible = true;
            }
        }

        public ListBox ListBoxUserEvents
        {
            get
            {
                return this.listBoxUserEvents;
            }
        }
    }
}
