using System;

namespace FacebookApp
{
    public partial class MainMenuUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helloButton = new System.Windows.Forms.Label();
            this.openFileDialogToPickPicture = new System.Windows.Forms.OpenFileDialog();
            this.userName = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFindMyLove = new System.Windows.Forms.Button();
            this.postsFilterbtn = new System.Windows.Forms.Button();
            this.genereateGreetingCardButton = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.LikestPicButton = new System.Windows.Forms.Button();
            this.MostLikesPic = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPhotoLabel = new System.Windows.Forms.Label();
            this.chooseDestButton = new System.Windows.Forms.Button();
            this.titlePicTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.sortedPicButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikesPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // helloButton
            // 
            this.helloButton.AutoSize = true;
            this.helloButton.Location = new System.Drawing.Point(138, 36);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(0, 13);
            this.helloButton.TabIndex = 14;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.Control;
            this.userName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Maroon;
            this.userName.Location = new System.Drawing.Point(30, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(54, 19);
            this.userName.TabIndex = 17;
            this.userName.Text = "label1";
            this.userName.Visible = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(68, 103);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(124, 94);
            this.userPictureBox.TabIndex = 19;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
            // 
            // buttonFindMyLove
            // 
            this.buttonFindMyLove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFindMyLove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindMyLove.ForeColor = System.Drawing.Color.Red;
            this.buttonFindMyLove.Location = new System.Drawing.Point(34, 250);
            this.buttonFindMyLove.Name = "buttonFindMyLove";
            this.buttonFindMyLove.Size = new System.Drawing.Size(207, 58);
            this.buttonFindMyLove.TabIndex = 20;
            this.buttonFindMyLove.Text = "FindMyLove!";
            this.buttonFindMyLove.UseVisualStyleBackColor = false;
            this.buttonFindMyLove.Click += new System.EventHandler(this.buttonFindMyLove_Click);
            // 
            // postsFilterbtn
            // 
            this.postsFilterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.postsFilterbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsFilterbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.postsFilterbtn.Location = new System.Drawing.Point(34, 314);
            this.postsFilterbtn.Name = "postsFilterbtn";
            this.postsFilterbtn.Size = new System.Drawing.Size(207, 47);
            this.postsFilterbtn.TabIndex = 21;
            this.postsFilterbtn.Text = "Posts Filter";
            this.postsFilterbtn.UseVisualStyleBackColor = false;
            this.postsFilterbtn.Click += new System.EventHandler(this.postsFilterbtn_Click);
            // 
            // genereateGreetingCardButton
            // 
            this.genereateGreetingCardButton.Font = new System.Drawing.Font("Miriam", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.genereateGreetingCardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.genereateGreetingCardButton.Location = new System.Drawing.Point(34, 375);
            this.genereateGreetingCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.genereateGreetingCardButton.Name = "genereateGreetingCardButton";
            this.genereateGreetingCardButton.Size = new System.Drawing.Size(207, 44);
            this.genereateGreetingCardButton.TabIndex = 23;
            this.genereateGreetingCardButton.Text = "Generate a greeting card";
            this.genereateGreetingCardButton.UseVisualStyleBackColor = true;
            this.genereateGreetingCardButton.Click += new System.EventHandler(this.genereateGreetingCardButton_Click_1);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Miriam", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogOut.Location = new System.Drawing.Point(88, 202);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(87, 26);
            this.buttonLogOut.TabIndex = 24;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseCompatibleTextRendering = true;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // LikestPicButton
            // 
            this.LikestPicButton.Location = new System.Drawing.Point(34, 437);
            this.LikestPicButton.Name = "LikestPicButton";
            this.LikestPicButton.Size = new System.Drawing.Size(207, 23);
            this.LikestPicButton.TabIndex = 25;
            this.LikestPicButton.Text = "What\'s my most popular pic?";
            this.LikestPicButton.UseVisualStyleBackColor = true;
            this.LikestPicButton.Click += new System.EventHandler(this.LikestPicButton_Click);
            // 
            // MostLikesPic
            // 
            this.MostLikesPic.Location = new System.Drawing.Point(94, 466);
            this.MostLikesPic.Name = "MostLikesPic";
            this.MostLikesPic.Size = new System.Drawing.Size(98, 67);
            this.MostLikesPic.TabIndex = 26;
            this.MostLikesPic.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(229, 10);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(104, 37);
            this.settingsButton.TabIndex = 27;
            this.settingsButton.Text = "Settings for main form";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click_1);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(362, 103);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(95, 55);
            this.imageNormalPictureBox.TabIndex = 28;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // uploadPhotoLabel
            // 
            this.uploadPhotoLabel.AutoSize = true;
            this.uploadPhotoLabel.Location = new System.Drawing.Point(374, 184);
            this.uploadPhotoLabel.Name = "uploadPhotoLabel";
            this.uploadPhotoLabel.Size = new System.Drawing.Size(83, 13);
            this.uploadPhotoLabel.TabIndex = 29;
            this.uploadPhotoLabel.Text = "Upload a photo:";
            // 
            // chooseDestButton
            // 
            this.chooseDestButton.Location = new System.Drawing.Point(303, 202);
            this.chooseDestButton.Name = "chooseDestButton";
            this.chooseDestButton.Size = new System.Drawing.Size(212, 33);
            this.chooseDestButton.TabIndex = 30;
            this.chooseDestButton.Text = "Choose a destiniation of your photo";
            this.chooseDestButton.UseVisualStyleBackColor = true;
            this.chooseDestButton.Click += new System.EventHandler(this.chooseDestButton_Click);
            // 
            // titlePicTextBox
            // 
            this.titlePicTextBox.Location = new System.Drawing.Point(501, 161);
            this.titlePicTextBox.Name = "titlePicTextBox";
            this.titlePicTextBox.Size = new System.Drawing.Size(114, 20);
            this.titlePicTextBox.TabIndex = 31;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(498, 145);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(123, 13);
            this.titleLabel.TabIndex = 32;
            this.titleLabel.Text = "Title to the pic (optional):";
            // 
            // uploadButton
            // 
            this.uploadButton.Enabled = false;
            this.uploadButton.Location = new System.Drawing.Point(292, 241);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(346, 23);
            this.uploadButton.TabIndex = 33;
            this.uploadButton.Text = "Upload!";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // sortedPicButton
            // 
            this.sortedPicButton.Location = new System.Drawing.Point(291, 269);
            this.sortedPicButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortedPicButton.Name = "sortedPicButton";
            this.sortedPicButton.Size = new System.Drawing.Size(347, 56);
            this.sortedPicButton.TabIndex = 34;
            this.sortedPicButton.Text = "Click to see your photos by popularity order";
            this.sortedPicButton.UseVisualStyleBackColor = true;
            this.sortedPicButton.Click += new System.EventHandler(this.sortedPicButton_Click);
            // 
            // MainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 543);
            this.Controls.Add(this.sortedPicButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePicTextBox);
            this.Controls.Add(this.chooseDestButton);
            this.Controls.Add(this.uploadPhotoLabel);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.MostLikesPic);
            this.Controls.Add(this.LikestPicButton);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.genereateGreetingCardButton);
            this.Controls.Add(this.postsFilterbtn);
            this.Controls.Add(this.buttonFindMyLove);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.helloButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikesPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogToPickPicture;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button buttonFindMyLove;
        private System.Windows.Forms.Button postsFilterbtn;
        private System.Windows.Forms.Button genereateGreetingCardButton;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button LikestPicButton;
        private System.Windows.Forms.PictureBox MostLikesPic;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label uploadPhotoLabel;
        private System.Windows.Forms.Button chooseDestButton;
        private System.Windows.Forms.TextBox titlePicTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button sortedPicButton;
    }
}