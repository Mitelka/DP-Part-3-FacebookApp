﻿namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading;
    using FacebookWrapper.ObjectModel;

    public partial class MainMenuUI : Form
    {
        private Photo m_MaxLikesPhoto = null;
        private MainMenuFacade m_Facade;
        private SettingsFormUI m_SettingsFormUI;
        private OpenFileDialog m_OpenFileDialogToPickPicture;

        public MainMenuUI(MainMenuFacade i_Facade)
        {
            m_Facade = i_Facade;
            InitializeComponent();
            showProfilePic();
            userName.Text = "Hello" + " " + m_Facade.GetFirstNameOfUser() + "!";
            m_OpenFileDialogToPickPicture = openFileDialogToPickPicture;
            userName.Visible = true;
        }

        private void showProfilePic()
        {
            userPictureBox.ImageLocation = m_Facade.GetProfilePicUrl();
            userPictureBox.Load();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void LikestPicButton_Click(object sender, EventArgs e)
        {
            new Thread(findAndShowMaxPhoto).Start();
        }

        private void findAndShowMaxPhoto()
        {
            LikestPicButton.Invoke(new Action(() => LikestPicButton.Enabled = false));
            m_MaxLikesPhoto = m_Facade.FindPopularPhoto();
            showMaxPhoto();
        }

        private void showMaxPhoto()
        {
            if (m_MaxLikesPhoto == null)
            {
                MessageBox.Show("You do not have likes in your photos :(");
            }
            else
            {
                MostLikesPic.ImageLocation = m_MaxLikesPhoto.PictureNormalURL;
                MostLikesPic.Load();
                MessageBox.Show("Your most popular photo has reached " + m_MaxLikesPhoto.LikedBy.Count + " likes! Well Done!!!");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.Logout(afterSuccessfullLogout);
        }

        private void afterSuccessfullLogout()
        {
            MessageBox.Show("Logout successfully!");
            Close();
        }

        private void buttonFindMyLove_Click(object sender, EventArgs e)
        {
            new MatchingFormUI(new MatchingFormFacade()).Show();
        }

        private void postsFilterbtn_Click(object sender, EventArgs e)
        {
            new FindPostByPatternUI(m_Facade).Show();
        }

        private void genereateGreetingCardButton_Click_1(object sender, EventArgs e)
        {
            new FilterFriendsToGreetingUI().Show();
        }                   

        private void userPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Close();
            FacebookWrapper.FacebookService.Logout(() => { MessageBox.Show("You successfully logged out!"); });
        }

        private void changeSettings(SettingsObject i_SettingsObject)
        {
            this.BackColor = i_SettingsObject.BackgroundColor;
            this.Text = i_SettingsObject.Title;
            if (!String.IsNullOrEmpty(i_SettingsObject.PicUrl))
            {
                this.userPictureBox.ImageLocation = i_SettingsObject.PicUrl;
            }
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            if (m_SettingsFormUI == null)
            {
                m_SettingsFormUI = new SettingsFormUI();
                m_SettingsFormUI.m_NotifyChangeSettings += changeSettings;
                m_SettingsFormUI.Show();
            }
            else
            {
                m_SettingsFormUI.Visible = true;
            }
        }

        private void chooseDestButton_Click(object sender, EventArgs e)
        {
            m_OpenFileDialogToPickPicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            m_OpenFileDialogToPickPicture.ShowDialog();
            if (!string.IsNullOrEmpty(m_OpenFileDialogToPickPicture.FileName))
            {
                uploadButton.Enabled = true;
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            string titleOfPic;
            if (string.IsNullOrEmpty(titlePicTextBox.Text))
            {
                titleOfPic = string.Empty;
            }
            else
            {
                titleOfPic = titlePicTextBox.Text;
            }

            m_Facade.PostPhoto(m_OpenFileDialogToPickPicture.FileName, titleOfPic);
            MessageBox.Show("Posted!");
        }

        private void sortedPicButton_Click(object sender, EventArgs e)
        {
            new OrederdPhotosForm().Show();
        }
    }
}