namespace FacebookApp
{
    public partial class SettingsFormUI
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.choosePicture = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.SystemColors.Control;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a title for the menu form:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(193, 64);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(68, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // choosePicture
            // 
            this.choosePicture.Location = new System.Drawing.Point(19, 107);
            this.choosePicture.Name = "choosePicture";
            this.choosePicture.Size = new System.Drawing.Size(240, 22);
            this.choosePicture.TabIndex = 17;
            this.choosePicture.Text = "Choose a picture instead your profile pic";
            this.choosePicture.UseVisualStyleBackColor = true;
            this.choosePicture.Click += new System.EventHandler(this.choosePicture_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(91, 159);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(85, 27);
            this.saveChangesButton.TabIndex = 18;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(19, 20);
            this.backgroundColorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(239, 23);
            this.backgroundColorButton.TabIndex = 19;
            this.backgroundColorButton.Text = "Choose a background color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // SettingsFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.choosePicture);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFormUI_FormClosing);
            this.Load += new System.EventHandler(this.SettingsFormUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button choosePicture;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button backgroundColorButton;
    }
}