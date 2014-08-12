using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Drawing.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Ex01.DesktopFacebook
{
    public partial class FormMain : Form
    {
        private FormUserLogin m_FormUserLogin = null;
        private User m_LoggedInUser = null;
        private bool m_IsAutoSize = false;

        public FormMain()
        {
            this.InitializeComponent();
            FacebookService.s_CollectionLimit = 1000;
            FacebookService.s_UseForamttedToStrings = true;
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            this.m_FormUserLogin = new FormUserLogin();
            this.login();
        }

        private void login()
        {
            this.m_FormUserLogin.ShowDialog();
            this.m_LoggedInUser = this.m_FormUserLogin.LoggedInUser;
            if (this.m_LoggedInUser != null)
            {
                this.fetchUserBasicInfo();
            }
        }

        private void fetchUserBasicInfo()
        {
            this.pictureBoxProfile.LoadAsync(this.m_LoggedInUser.PictureNormalURL);

            foreach (Album userAlbum in this.m_LoggedInUser.Albums)
            {
                if (userAlbum.Name == "Cover Photos")
                {
                    this.pictureBoxCover.LoadAsync(userAlbum.CoverPhoto.URL);
                    break;
                }
            }

            this.labelUserName.Text = this.m_LoggedInUser.Name;
        }

        private void buttonPostNewStatus_Click(object sender, EventArgs e)
        {
            this.postNewStatus();
        }

        private void postNewStatus()
        {
            if (!string.IsNullOrEmpty(this.textBoxPostStatus.Text))
            {
                this.m_LoggedInUser.PostStatus(this.textBoxPostStatus.Text);
                MessageBox.Show("Status posted successfully", string.Empty, MessageBoxButtons.OK);
                this.textBoxPostStatus.Clear();
            }
        }

        private void buttonNewsFeed_Click(object sender, EventArgs e)
        {
            this.fetchNewsFeed(); 
        }

        private void fetchNewsFeed()
        {
            FormNewsFeed formNewsFeed = new FormNewsFeed();
            formNewsFeed.StartPosition = FormStartPosition.CenterParent;

            foreach (Post post in this.m_LoggedInUser.NewsFeed)
            {
                if (post.Message != null)
                {
                    formNewsFeed.ListBoxNewsFeed.Items.Add(string.Format(@"{0}        Posted By:[{1}]", post.Message, post.From.Name));
                }
                else if (post.Caption != null)
                {
                    formNewsFeed.ListBoxNewsFeed.Items.Add(string.Format(@"{0}        Posted By:[{1}]", post.Caption, post.From.Name));
                }
            }

            if (checkForEmptyListBox(formNewsFeed.ListBoxNewsFeed) == true)
            {
                MessageBox.Show("List is empty", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                formNewsFeed.ShowDialog();
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            this.fetchFriendsList();
        }

        private void fetchFriendsList()
        {
            FormFriends formFriendsList = new FormFriends(this.m_LoggedInUser);
            formFriendsList.StartPosition = FormStartPosition.CenterParent;

            formFriendsList.ListBoxFriends.DisplayMember = "Name";
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                formFriendsList.ListBoxFriends.Items.Add(friend);
            }

            if (checkForEmptyListBox(formFriendsList.ListBoxFriends) == true)
            {
                MessageBox.Show("List is empty", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                formFriendsList.ShowDialog();
            }            
        }

        public static bool checkForEmptyListBox(ListBox i_CurrentListBox)
        {
            bool emptyListBox = false;

            if (i_CurrentListBox.Items.Count == 0)
            {
                emptyListBox = true;
            }

            return emptyListBox;
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            this.fetchEvents();
        }

        private void fetchEvents()
        {
            FormUserEvents formUserEvents = new FormUserEvents();
            formUserEvents.StartPosition = FormStartPosition.CenterParent;

            formUserEvents.ListBoxUserEvents.DisplayMember = "Name";
            foreach (Event fbEvent in this.m_LoggedInUser.Events)
            {
                if (DateTime.Compare(DateTime.Now, fbEvent.StartTime.Value) <= 0)
                {
                    formUserEvents.ListBoxUserEvents.Items.Add(fbEvent);
                }
            }

            if (checkForEmptyListBox(formUserEvents.ListBoxUserEvents) == true)
            {
                MessageBox.Show("List is empty", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                formUserEvents.ShowDialog();
            }    
        }

        private void buttonCheckIns_Click(object sender, EventArgs e)
        {
            this.fetchCheckIns();
        }

        private void fetchCheckIns()
        {
            FormCheckIns formCheckIns = new FormCheckIns();
            formCheckIns.StartPosition = FormStartPosition.CenterParent;

            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                formCheckIns.ListBoxUserCheckIns.Items.Add(checkin);
            }

            if (checkForEmptyListBox(formCheckIns.ListBoxUserCheckIns) == true)
            {
                MessageBox.Show("List is empty", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                formCheckIns.ShowDialog();
            }  
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            this.fetchAlbums();
        }

        private void fetchAlbums()
        {
            FormUserAlbums formUserAlbums = new FormUserAlbums();
            formUserAlbums.StartPosition = FormStartPosition.CenterParent;

            int x = 0;
            int y = 0;
            int xCounter = 5;

            foreach (Album userAlbum in this.m_LoggedInUser.Albums)
            {
                if (userAlbum.CoverPhoto != null)
                {
                    MyPictureBoxAlbum album = new MyPictureBoxAlbum(userAlbum);
                    Label albumNameLabel = new Label();

                    album.Location = new Point(x, y);
                    album.Size = new Size(150, 150);
                    album.SizeMode = PictureBoxSizeMode.StretchImage;
                    album.LoadAsync(userAlbum.CoverPhoto.URL);
                    album.Click += (object sender, EventArgs e) =>
                    {
                        this.fetchPhotosFromSpecificAlbum(sender);
                    };

                    album.BorderStyle = BorderStyle.Fixed3D;
                    albumNameLabel.AutoSize = false;
                    albumNameLabel.Size = new Size(150, 20);
                    albumNameLabel.Text = string.Format(@"Album Name: {0}", album.Album.Name);
                    albumNameLabel.Location = new Point(album.Left, album.Bottom + 2);
                    albumNameLabel.Font = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 7f, FontStyle.Regular);
                    albumNameLabel.MouseEnter += (object sender, EventArgs e) =>
                    {
                        this.m_IsAutoSize = true;
                        this.modifyingAlbumName(sender, new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 9f, FontStyle.Bold), this.m_IsAutoSize);
                    };

                    albumNameLabel.MouseLeave += (object sender, EventArgs e) =>
                    {
                        this.m_IsAutoSize = false;
                        this.modifyingAlbumName(sender, new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 7f, FontStyle.Regular), this.m_IsAutoSize);
                    };

                    formUserAlbums.Controls.Add(album);
                    formUserAlbums.Controls.Add(albumNameLabel);
                    x += 160;
                    xCounter--;
                    if (xCounter == 0)
                    {
                        x = 0;
                        xCounter = 5;
                        y += 184;
                    }
                }
            }

            formUserAlbums.ShowDialog();
        }

        private void modifyingAlbumName(object sender, Font i_Font, bool i_AutoSize)
        {
            Label lableToModify = sender as Label;
            lableToModify.Font = i_Font;
            lableToModify.AutoSize = i_AutoSize;
        }

        ////Once creating an album (or just creating a profile) photos will be automatically added as a default cover of the album. therefore we did not check for empty (null) content.
        private void fetchPhotosFromSpecificAlbum(object sender)
        {
            MyPictureBoxAlbum currentAlbum = sender as MyPictureBoxAlbum;

            int x = 0;
            int y = 0;
            int xCounter = 5;

            FormPhotosFromAlbum formPhotosFromAlbum = new FormPhotosFromAlbum();
            formPhotosFromAlbum.StartPosition = FormStartPosition.CenterParent;

            foreach (Photo photoFromAlbum in currentAlbum.Album.Photos)
            {
                MyPictureBoxPhoto photo = new MyPictureBoxPhoto(photoFromAlbum);
                photo.Location = new Point(x, y);
                photo.Size = new Size(200, 200);
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
                photo.LoadAsync(photoFromAlbum.URL);

                photo.MouseEnter += (object send, EventArgs e) =>
                {
                    this.enlargePhotoSizeOnMouseHover(send);
                };

                photo.MouseLeave += (object send, EventArgs e) =>
                {
                    this.reducePhotoSizeOnMouseLeave(send); 
                };

                formPhotosFromAlbum.Controls.Add(photo);
                x += 220;
                xCounter--;
                if (xCounter == 0)
                {
                    x = 0;
                    xCounter = 5;
                    y += 220;
                }
            }

            formPhotosFromAlbum.ShowDialog();
        }

        private void enlargePhotoSizeOnMouseHover(object sender)
        {
            MyPictureBoxPhoto pictureToEnlarge = sender as MyPictureBoxPhoto;
            pictureToEnlarge.Size = new System.Drawing.Size(400, 400);
        }

        private void reducePhotoSizeOnMouseLeave(object sender)
        {
            MyPictureBoxPhoto pictureToEnlarge = sender as MyPictureBoxPhoto;
            pictureToEnlarge.Size = new System.Drawing.Size(200, 200);
        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            this.fetchUserAdvancedInfo();
        }

        private void fetchUserAdvancedInfo()
        {
            FormUserInfo formUserInfo = new FormUserInfo();
            formUserInfo.LableUsername.Text = string.Concat(formUserInfo.LableUsername.Text, this.userInfoToConcat(this.m_LoggedInUser.UserName));
            formUserInfo.LableFirstname.Text = string.Concat(formUserInfo.LableFirstname.Text, this.userInfoToConcat(this.m_LoggedInUser.FirstName));
            formUserInfo.LableLastname.Text = string.Concat(formUserInfo.LableLastname.Text, this.userInfoToConcat(this.m_LoggedInUser.LastName));
            formUserInfo.LableBirthday.Text = string.Concat(formUserInfo.LableBirthday.Text, this.userInfoToConcat(this.m_LoggedInUser.Birthday));
            formUserInfo.LableReligion.Text = string.Concat(formUserInfo.LableReligion.Text, this.userInfoToConcat(this.m_LoggedInUser.Religion));
            formUserInfo.LableEmail.Text = string.Concat(formUserInfo.LableEmail.Text, this.userInfoToConcat(this.m_LoggedInUser.Email));

            if (this.m_LoggedInUser.Gender.HasValue == true)
            {
                formUserInfo.LableGender.Text = string.Concat(formUserInfo.LableGender.Text, this.m_LoggedInUser.Gender.Value.ToString());
            }
            else
            {
                formUserInfo.LableGender.Text = string.Concat(formUserInfo.LableGender.Text, "No Info To Import");
            }

            if (this.m_LoggedInUser.RelationshipStatus.HasValue == true)
            {
                formUserInfo.LableRelationshipStatus.Text = string.Concat(formUserInfo.LableRelationshipStatus.Text, this.m_LoggedInUser.RelationshipStatus.Value.ToString());
            }
            else
            {
                formUserInfo.LableRelationshipStatus.Text = string.Concat(formUserInfo.LableRelationshipStatus.Text, "No Info To Import");
            }

            formUserInfo.ShowDialog();
        }

        private string userInfoToConcat(string i_UserInfo)
        {
            string stringToReturn = i_UserInfo;
            if (i_UserInfo == null)
            {
                stringToReturn = "No Info To Import";
            }

            return stringToReturn;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.logout();
            this.buttonReLoggin.Visible = true;
        }

        private void logout()
        {
            this.pictureBoxProfile.Image = null;
            this.pictureBoxCover.Image = null;
            this.pictureBoxGoogle.Enabled = false;
            this.textBoxGoogle.Enabled = false;
            this.labelUserName.Text = string.Empty;
        }

        private void buttonReLoggin_Click(object sender, EventArgs e)
        {
            this.reLogin();
        }

        private void reLogin()
        {
            this.login();
            this.buttonReLoggin.Visible = false;
            this.textBoxGoogle.Enabled = true;
        }

        private void textBoxGoogle_Click(object sender, EventArgs e)
        {
            this.textBoxGoogle.Text = string.Empty;
            this.pictureBoxGoogle.Enabled = true;
        }

        private void pictureBoxGoogle_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://google.com/search?q=";
            string textToConcat = this.textBoxGoogle.Text;
            UrlProvider(baseUrl, textToConcat);
        }

        public static void UrlProvider(string i_BaseUrl, string i_StringToConcat)
        {
            string baseUrl = i_BaseUrl;
            if (i_StringToConcat != null)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo();
                sInfo.FileName = string.Concat(baseUrl, i_StringToConcat);
                Process.Start(sInfo);
            }
        }
    }
}
