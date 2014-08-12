using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;

namespace Ex01.DesktopFacebook
{
    public partial class FormFriends : Form
    {
        private User m_LoggedInUser = null;

        public FormFriends(User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.displaySelectedFriend();
            this.buttonGetFriendEvents.Visible = true;
            this.linkLabelFriendNameMeaning.Enabled = true;
        }

        private void displaySelectedFriend()
        {
            if (this.listBoxFriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = this.listBoxFriendsList.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    this.pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    this.pictureBoxFriend.Image = this.pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void linkLabelFriendNameMeaning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User selectedFriend = this.listBoxFriendsList.SelectedItem as User;
            string baseUrl = "http://nameberry.com/babyname/";
            string textToConcat = selectedFriend.FirstName;
            FormMain.UrlProvider(baseUrl, textToConcat);
        }

        private void buttonGetFriendEvents_Click(object sender, EventArgs e)
        {
            this.fetchFriendEvents(); 
        }

        private void fetchFriendEvents()
        {
            FormFriendEvents formFriendEventsList = new FormFriendEvents(this.m_LoggedInUser);
            formFriendEventsList.ListBoxFriendEvents.DisplayMember = "Name";

            if (this.listBoxFriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = this.listBoxFriendsList.SelectedItem as User;
                foreach (Event friendEvent in selectedFriend.Events)
                {
                    if (DateTime.Compare(DateTime.Now, friendEvent.StartTime.Value) <= 0)
                    {
                        formFriendEventsList.ListBoxFriendEvents.Items.Add(friendEvent);
                    }
                }
            }

            if (FormMain.checkForEmptyListBox(formFriendEventsList.ListBoxFriendEvents) == true)
            {
                MessageBox.Show("List is empty", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                formFriendEventsList.ShowDialog();
            }
        }

        public ListBox ListBoxFriends
        {
            get
            {
                return this.listBoxFriendsList;
            }
        }
    }
}
