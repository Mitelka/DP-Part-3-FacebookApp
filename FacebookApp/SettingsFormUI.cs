namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public delegate void NotifyChangeSettings(SettingsObject i_SettingsObject);

    public partial class SettingsFormUI : Form
    {
        public event NotifyChangeSettings m_NotifyChangeSettings;

        public SettingsFormUI()
        {
            InitializeComponent();
        }

        private void SettingsFormUI_Load(object sender, EventArgs e)
        {
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            notifyAll();
        }

        private void notifyAll()
        {
            if (m_NotifyChangeSettings != null)
            {
                SettingsObject settingsObject = new SettingsObject(this.colorDialog.Color, this.titleTextBox.Text, this.openFileDialog.FileName);
                m_NotifyChangeSettings.Invoke(settingsObject);
            }
        }

        private void choosePicture_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.openFileDialog.ShowDialog();
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
        }

        private void SettingsFormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            Hide();
        }
    }
}
