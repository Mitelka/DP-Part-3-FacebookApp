namespace FacebookApp
{
    partial class OrederdPhotosForm
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
            this.labelOrederedPhotos = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nextPhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrederedPhotos
            // 
            this.labelOrederedPhotos.AutoSize = true;
            this.labelOrederedPhotos.Location = new System.Drawing.Point(33, 20);
            this.labelOrederedPhotos.Name = "labelOrederedPhotos";
            this.labelOrederedPhotos.Size = new System.Drawing.Size(0, 20);
            this.labelOrederedPhotos.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(37, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(405, 157);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // nextPhotoButton
            // 
            this.nextPhotoButton.Location = new System.Drawing.Point(157, 256);
            this.nextPhotoButton.Name = "nextPhotoButton";
            this.nextPhotoButton.Size = new System.Drawing.Size(166, 51);
            this.nextPhotoButton.TabIndex = 2;
            this.nextPhotoButton.Text = "Next photo";
            this.nextPhotoButton.UseVisualStyleBackColor = true;
            this.nextPhotoButton.Click += new System.EventHandler(this.nextPhotoButton_Click);
            // 
            // OrederdPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 321);
            this.Controls.Add(this.nextPhotoButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelOrederedPhotos);
            this.Name = "OrederdPhotosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your photos";
            this.Load += new System.EventHandler(this.orederdPhotosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrederedPhotos;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button nextPhotoButton;
    }
}