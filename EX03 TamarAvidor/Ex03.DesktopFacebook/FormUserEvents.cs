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

/*System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
message.To.Add("orenl91@gmail.com");
message.Subject = "This is the Subject line";
message.From = new System.Net.Mail.MailAddress("orenl91@gmail.com");
message.Body = "This is the message body";
System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
smtp.Send(message);*/

namespace Ex01.DesktopFacebook
{
    public partial class FormUserEvents : Form
    {
        private Timer m_TimerCountDown = new Timer();

        public IViewableControl ConcreteControl { get; set; }

        public bool isStartPressed { get; set; }

        public event Action m_ReportWhenEventHappening;

        public FormUserEvents()
        {
            this.InitializeComponent();
            this.isStartPressed = false;
        }

        private void buttonCountDown_Click(object sender, EventArgs e)
        {
            if (this.isStartPressed == false)
            {
                FormComboBoxViewableControl formComboBoxViewableControl = new FormComboBoxViewableControl();
                formComboBoxViewableControl.PopulateComboBoxFromListOfControls();
                formComboBoxViewableControl.ShowDialog();

                this.ConcreteControl = formComboBoxViewableControl.SelectedControl;
            }

            if (this.ConcreteControl != null)
            {
                this.buttonStopCountDown.Enabled = true;
                this.buttonCountDown.Enabled = false;
                this.countDownManager();
            }
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

        private void countDownManager()
        {
            if (this.isStartPressed == false)
            {
                this.decideControlType();
                this.m_TimerCountDown.Enabled = true;
                this.m_TimerCountDown.Interval = 1000;
                this.ConcreteControl.addControl(this);
                this.ListBoxUserEvents.Visible = false;
                Event chosenEvent = this.listBoxUserEvents.SelectedItem as Event;
                this.labelChosenEventName.Text = string.Concat("Event name: ", chosenEvent.Name);
                this.labelChosenEventName.Top = this.Bottom - this.labelChosenEventName.Height;
                this.labelChosenEventName.Left = this.ClientRectangle.Left;
                this.labelChosenEventName.Visible = true;
                this.isStartPressed = true;
            }

            this.m_TimerCountDown.Start();
            this.m_TimerCountDown.Tick += (object sender, EventArgs e) =>
            {
                TimeSpan remainingTime = calculateRemainingTime();

                ConcreteControl.showFormatedData(remainingTime);

                remainingTime = this.eventDateArrivedMessage(remainingTime);
            };
        }

        private TimeSpan calculateRemainingTime()
        {
            DateTime nowTime = DateTime.Now;
            Event selectedEvent = this.listBoxUserEvents.SelectedItem as Event;
            DateTime eventStartTime = (DateTime)selectedEvent.StartTime;
            TimeSpan remainingTime = eventStartTime.Subtract(nowTime);
            return remainingTime;
        }

        private void decideControlType()
        {
            if (this.ConcreteControl is MyLabel)
            {
                this.ConcreteControl = new MyLabel(); 
            }
            else if (this.ConcreteControl is MyProgressBar)
            {
                this.ConcreteControl = new MyProgressBar();
            }
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
                this.m_ReportWhenEventHappening.Invoke();
                this.Close();
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