namespace FacebookApp
{
    using System.Drawing;

    public class SettingsObject
    {
        public Color BackgroundColor { get; set; }

        public string Title { get; set; }

        public string PicUrl { get; set; }

        public SettingsObject(Color i_BackgroungColor, string i_Title, string i_PicUrl)
        {
            BackgroundColor = i_BackgroungColor;
            Title = i_Title;
            PicUrl = i_PicUrl;
        }
    }
}