namespace FacebookApp
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class FilterFriendsToGreetingUI : Form
    {
        private eFilterBy m_FilterBy;

        public FilterFriendsToGreetingUI()
        {
            InitializeComponent();
        }

        private void checkWhichRadionButtonSelected()
        {
            if (searchByFirstNameRadioButton.Checked)
            {
                m_FilterBy = eFilterBy.FirstName;
            }
            else if (searchByLastNameRadioButton.Checked)
            {
                m_FilterBy = eFilterBy.LastName;
            }
            else
            {
                m_FilterBy = eFilterBy.Birthday;
            }
        }

        private void FilterFriendsToGreetingUI_Load(object sender, EventArgs e)
        {
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            checkWhichRadionButtonSelected();
            FilterFriendsStrategy filterStrategy = null;
            switch (m_FilterBy)
            {
                case eFilterBy.FirstName:
                    {
                        string firstNameText = firstNameTextBox.Text;
                        filterStrategy = new FilterFriendsStrategy(user => user.FirstName.StartsWith(firstNameText));
                        break;
                    }

                case eFilterBy.LastName:
                    {
                        string lastNameText = lastNameTextBox.Text;
                        filterStrategy = new FilterFriendsStrategy(user => user.LastName.StartsWith(lastNameText));
                        break;
                    }

                case eFilterBy.Birthday:
                    {
                        filterStrategy = new FilterFriendsStrategy(filterBirthday);
                        break;
                    }
            }

            new GeneratorGreetingCardFormUI(filterStrategy).Show();
            this.Close();
        }

        private string getTodayDateInString()
        {
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day;
            string monthString = month.ToString();
            string dayString = day.ToString();
            if (month < 10)
            {
                monthString = "0" + monthString;
            }

            if (day < 10)
            {
                dayString = "0" + dayString;
            }

            string resultDate = monthString + "/" + dayString;
            return resultDate;
        }

        private bool filterBirthday(User i_User)
        {
            bool result = false;
            if (i_User.Birthday != null)
            {
                string birthdayToday = getTodayDateInString();
                result = i_User.Birthday.StartsWith(birthdayToday);
            }

            return result;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
