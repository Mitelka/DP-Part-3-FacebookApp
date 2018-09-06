namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Threading;
    using FacebookWrapper.ObjectModel;

    public partial class OrederdPhotosForm : Form
    {
        private IEnumerator<Photo> m_Iterator = null;
        private int m_CurrentMostPhotoNumber = 0;

        public OrederdPhotosForm()
        {
            InitializeComponent();
            labelOrederedPhotos.Text = "Loading first photo...";
            new Thread(showNextPhoto).Start();
        }

        private void orederdPhotosForm_Load(object sender, EventArgs e)
        {
        }

        private void nextPhotoButton_Click(object sender, EventArgs e)
        {
            showNextPhoto();
        }

        private void showNextPhoto()
        {
            this.Invoke(new Action(() => this.nextPhotoButton.Enabled = false));
            if (m_Iterator == null)
            {
                m_Iterator = new OrderedPhotosLogic().GetEnumerator();
            }
            if (m_Iterator.MoveNext())
            {
                m_CurrentMostPhotoNumber++;
                this.Invoke(new Action(() => this.labelOrederedPhotos.Text = string.Format("Your #{0} most liked photo:", m_CurrentMostPhotoNumber)));
                string imageLoaction = m_Iterator.Current.PictureNormalURL;
                this.Invoke(new Action(() => this.pictureBox.ImageLocation = imageLoaction));
                this.Invoke(new Action(() => this.nextPhotoButton.Enabled = true));
            }
            else
            {
                MessageBox.Show("You saw all your photos already!");
            }
        }
    }
}
