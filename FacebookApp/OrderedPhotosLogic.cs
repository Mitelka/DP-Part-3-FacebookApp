namespace FacebookApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class OrderedPhotosLogic : IEnumerable<Photo>
    {
        private LinkedList<Photo> m_AllPhotos = new LinkedList<Photo>();

        public OrderedPhotosLogic()
        {
            getAllPhotos();
        }

        public void getAllPhotos()
        {
            foreach (Album album in Singleton<UserFacebookApp>.Instance.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    m_AllPhotos.AddFirst(photo);
                }
            }
        }

        private class OrederedPhotosIterator : IEnumerator<Photo>
        {
            private OrderedPhotosLogic m_OrderedPhotosLogic;
            private Photo m_CurrentPhoto = null;
            private int m_CurrentMaxNumLikes = int.MaxValue;

            public OrederedPhotosIterator(OrderedPhotosLogic i_OrderedPhotosLogic)
            {
                m_OrderedPhotosLogic = i_OrderedPhotosLogic;
            }

            public Photo Current
            {
                get
                {
                    return m_CurrentPhoto;
                }
            }

            object IEnumerator.Current
            {
                get { return this.Current; }
            }

            public bool MoveNext()
            {
                bool result = false;
                LinkedList<Photo> newAllPhotos = new LinkedList<Photo>();
                int maxLikes = int.MinValue;
                Photo maxPhoto = null;
                foreach (Photo photo in m_OrderedPhotosLogic.m_AllPhotos)
                {
                    int numOfLikesPhoto = photo.LikedBy.Count;
                    if (numOfLikesPhoto < m_CurrentMaxNumLikes && maxLikes < numOfLikesPhoto)
                    {
                        maxLikes = numOfLikesPhoto;
                        maxPhoto = photo;
                    }
                }
                m_CurrentPhoto = maxPhoto;
                m_CurrentMaxNumLikes = maxLikes;
                if (maxPhoto != null)
                {
                    result = true;
                }
                return result;
            }

            public void Reset()
            {
                m_CurrentMaxNumLikes = int.MaxValue;
                m_CurrentPhoto = null;
            }

            public void Dispose()
            {
                Reset();
            }
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            return new OrederedPhotosIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
