using System;

namespace FacebookApp
{
    partial class FilterFriendsToGreetingUI
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
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchByFirstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByBirthdayRadioButton = new System.Windows.Forms.RadioButton();
            this.filterButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(65, 30);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(217, 13);
            this.searchByLabel.TabIndex = 1;
            this.searchByLabel.Text = "Search the recipient for the greeting card by:";
            this.searchByLabel.Click += new System.EventHandler(this.searchByLabel_Click);
            // 
            // searchByFirstNameRadioButton
            // 
            this.searchByFirstNameRadioButton.AutoSize = true;
            this.searchByFirstNameRadioButton.Location = new System.Drawing.Point(31, 62);
            this.searchByFirstNameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByFirstNameRadioButton.Name = "searchByFirstNameRadioButton";
            this.searchByFirstNameRadioButton.Size = new System.Drawing.Size(135, 17);
            this.searchByFirstNameRadioButton.TabIndex = 2;
            this.searchByFirstNameRadioButton.TabStop = true;
            this.searchByFirstNameRadioButton.Text = "First name starting with:";
            this.searchByFirstNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByLastNameRadioButton
            // 
            this.searchByLastNameRadioButton.AutoSize = true;
            this.searchByLastNameRadioButton.Location = new System.Drawing.Point(31, 101);
            this.searchByLastNameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByLastNameRadioButton.Name = "searchByLastNameRadioButton";
            this.searchByLastNameRadioButton.Size = new System.Drawing.Size(136, 17);
            this.searchByLastNameRadioButton.TabIndex = 4;
            this.searchByLastNameRadioButton.TabStop = true;
            this.searchByLastNameRadioButton.Text = "Last name starting with:";
            this.searchByLastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByBirthdayRadioButton
            // 
            this.searchByBirthdayRadioButton.AutoSize = true;
            this.searchByBirthdayRadioButton.Location = new System.Drawing.Point(31, 136);
            this.searchByBirthdayRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByBirthdayRadioButton.Name = "searchByBirthdayRadioButton";
            this.searchByBirthdayRadioButton.Size = new System.Drawing.Size(98, 17);
            this.searchByBirthdayRadioButton.TabIndex = 6;
            this.searchByBirthdayRadioButton.TabStop = true;
            this.searchByBirthdayRadioButton.Text = "Birthday (today)";
            this.searchByBirthdayRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(127, 178);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(155, 25);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter!";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(228, 62);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(228, 111);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // FilterFriendsToGreetingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 241);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.searchByBirthdayRadioButton);
            this.Controls.Add(this.searchByLastNameRadioButton);
            this.Controls.Add(this.searchByFirstNameRadioButton);
            this.Controls.Add(this.searchByLabel);
            this.Name = "FilterFriendsToGreetingUI";
            this.Text = "Filter Friends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void searchByLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.RadioButton searchByFirstNameRadioButton;
        private System.Windows.Forms.RadioButton searchByLastNameRadioButton;
        private System.Windows.Forms.RadioButton searchByBirthdayRadioButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}