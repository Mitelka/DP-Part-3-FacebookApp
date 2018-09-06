namespace FacebookApp
{
    using System;
    using System.Windows.Forms;

    // $G$ THE-001 (-45) your grade on diagrams document - 55. please see comments inside the document. (40% of your grade).

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JustLoginToFacebook());
        }
    }
}
