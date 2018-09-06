namespace FacebookApp
{
    partial class OrderedPhotosForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nextPhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(80, 47);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(270, 102);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // nextPhotoButton
            // 
            this.nextPhotoButton.Location = new System.Drawing.Point(161, 174);
            this.nextPhotoButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextPhotoButton.Name = "nextPhotoButton";
            this.nextPhotoButton.Size = new System.Drawing.Size(111, 33);
            this.nextPhotoButton.TabIndex = 3;
            this.nextPhotoButton.Text = "Next photo";
            this.nextPhotoButton.UseVisualStyleBackColor = true;
            this.nextPhotoButton.Click += new System.EventHandler(this.nextPhotoButton_Click);
            // 
            // OrderedPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 243);
            this.Controls.Add(this.nextPhotoButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "OrderedPhotosForm";
            this.Text = "OrderedPhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button nextPhotoButton;
    }
}