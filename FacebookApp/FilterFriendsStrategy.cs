namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;

    public class FilterFriendsStrategy
    {
        private Func<User, bool> m_FilterFunc;

        public FilterFriendsStrategy(Func<User, bool> i_FilterFunc)
        {
            m_FilterFunc = i_FilterFunc;
        }

        public LinkedList<User> GetFilterListOfFriends()
        {
            User loggedInUser = Singleton<UserFacebookApp>.Instance.LoggedInUser;
            LinkedList<User> filterFriendsResult = new LinkedList<User>();
            foreach (User friend in loggedInUser.Friends)
            {
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                if (m_FilterFunc.Invoke(friend))
                {
                    filterFriendsResult.AddFirst(friend);
                }
            }

            return filterFriendsResult;
        }
    }
}
