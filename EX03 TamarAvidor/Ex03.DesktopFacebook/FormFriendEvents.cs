using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public partial class FormFriendEvents : Form
    {
        private User m_LoggedInUser = null;
        private bool m_RsvpEventNameReapetFound = false;

        public FormFriendEvents(User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        private void listBoxFriendEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addRsvpDecisionsToComboBox();
            this.checkRepeat();
        }

        private void checkRepeat()
        {
            Event selectedEventToAdd = this.listBoxFriendEvents.SelectedItem as Event;
            this.m_RsvpEventNameReapetFound = this.checkForRSVPrepeat(selectedEventToAdd);
            if (this.m_RsvpEventNameReapetFound == true)
            {
                MessageBox.Show("You have already responed to this event", string.Empty, MessageBoxButtons.OK);
            }
        }

        private void addRsvpDecisionsToComboBox()
        {
            this.comboBoxEventsDecisions.Visible = true;
            this.comboBoxEventsDecisions.Items.Clear();
            this.comboBoxEventsDecisions.Items.Add(Event.eRsvpType.Attending);
            this.comboBoxEventsDecisions.Items.Add(Event.eRsvpType.Declined);
            this.comboBoxEventsDecisions.Items.Add(Event.eRsvpType.Maybe);
        }

        private void comboBoxEventsDecisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonRSVP.Enabled = true;
        }

        private void buttonRSVP_Click(object sender, EventArgs e)
        {
            this.confirmRSVP();
        }

        private void confirmRSVP()
        {
            bool overlapFound = false;
            Event selectedEventToAdd = this.listBoxFriendEvents.SelectedItem as Event;

            switch ((Event.eRsvpType)this.comboBoxEventsDecisions.SelectedItem)
            {
                case Event.eRsvpType.Attending:
                    overlapFound = this.checkOverlapEvents(selectedEventToAdd);
                    break;
                case Event.eRsvpType.Declined:
                    break;
                case Event.eRsvpType.Maybe:
                    overlapFound = this.checkOverlapEvents(selectedEventToAdd);
                    break;
                default:
                    break;
            }

            if (overlapFound == false)
            {
                selectedEventToAdd.Respond((Event.eRsvpType)this.comboBoxEventsDecisions.SelectedItem);
            }

            MessageBox.Show("Confirmed", string.Empty, MessageBoxButtons.OK);
        }

        private bool checkForRSVPrepeat(Event i_SelectedEventToAdd)
        {
            bool rsvpReapetFound = false;
            foreach (Event existingUserEvent in this.m_LoggedInUser.Events)
            {
                if (i_SelectedEventToAdd.Name == existingUserEvent.Name)
                {
                    rsvpReapetFound = true;
                    break;
                }
            }

            return rsvpReapetFound;
        }

        private bool checkOverlapEvents(Event i_SelectedEventToAdd)
        {
            bool overlapFound = false;
            if (i_SelectedEventToAdd.StartTime.HasValue == true)
            {
                DateTime newEventStartTime = i_SelectedEventToAdd.StartTime.Value;
                foreach (Event existingUserEvent in this.m_LoggedInUser.Events)
                {
                    if (newEventStartTime.Year == existingUserEvent.StartTime.Value.Year &&
                        newEventStartTime.Month == existingUserEvent.StartTime.Value.Month &&
                        newEventStartTime.Day == existingUserEvent.StartTime.Value.Day)
                    {
                        if (this.m_RsvpEventNameReapetFound == false)
                        {
                            MessageBox.Show(string.Format(@"You are already have an event at: {0}", existingUserEvent.StartTime.Value.ToString()));
                        }

                        i_SelectedEventToAdd.Respond((Event.eRsvpType)this.comboBoxEventsDecisions.SelectedItem);
                        overlapFound = true;
                        break;
                    }
                }
            }

            return overlapFound;
        }

        public ListBox ListBoxFriendEvents
        {
            get
            {
                return this.listBoxFriendEvents;
            }
        }
    }
}
